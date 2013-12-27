using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDataEditor
{
    public partial class Edit_Line : Form
    {
        public string NewValue
        {
            get
            {
                return textBox1.Text;
            }
        }

        public Edit_Line()
            : this("")
        {

        }

        public Edit_Line(string oldVal)
        {
            InitializeComponent();
            this.textBox1.Text = oldVal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
