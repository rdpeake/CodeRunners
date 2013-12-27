using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.IO;

namespace LanguageEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to reset the language window?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
                textBox1.Text = resources.GetString("textBox1.Text");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show savefiledialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Dynamic Link Libraries (*.dll)|*.dll";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;


            Microsoft.CSharp.CSharpCodeProvider provider = new CSharpCodeProvider();
            ICodeCompiler compiler = provider.CreateCompiler();
            CompilerParameters compilerparams = new CompilerParameters();
            compilerparams.GenerateExecutable = false;
            compilerparams.GenerateInMemory = false;
            compilerparams.OutputAssembly = sfd.FileName;
            compilerparams.ReferencedAssemblies.Add("Language.dll");

            CompilerResults results =
               compiler.CompileAssemblyFromSource(compilerparams, textBox1.Text);
            if (results.Errors.HasErrors)
            {
                StringBuilder errors = new StringBuilder("Compiler Errors :\r\n");
                foreach (CompilerError error in results.Errors)
                {
                    errors.AppendFormat("Line {0},{1}\t: {2}\n",
                           error.Line, error.Column, error.ErrorText);
                }
                MessageBox.Show(errors.ToString());
            }
            else
            {
                //do i need to save?
                MessageBox.Show("Success");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //show savefiledialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            FileStream fs = File.Create(sfd.FileName);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(textBox1.Text);
            sw.Flush();
            sw.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "txt files (*.txt)|*.txt";
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            FileStream fs = File.OpenRead(ofd.FileName);
            StreamReader sr = new StreamReader(fs);
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }


    }
}
