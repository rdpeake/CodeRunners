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
    public partial class Form1 : Form
    {
        //TODO Update these Filters
        private static string ImageFilter = "all files (*.*)|*.*";
        private static string VideoFilter = "all files (*.*)|*.*";

        #region Binding Lists
        private BindingList<System.IO.FileInfo> VideoList;
        private BindingList<System.IO.FileInfo> ImageList;
        private BindingList<GameData.Dialog> DialogList;
        #endregion

        public Form1()
        {
            VideoList = new BindingList<System.IO.FileInfo>();
            ImageList = new BindingList<System.IO.FileInfo>();
            DialogList = new BindingList<GameData.Dialog>();
            InteractionLines = new BindingList<string>();
            Interactions = new BindingList<GameData.Dialog.Interaction>();
            InitializeComponent();
            list_Video.DataSource = VideoList;
            list_Video.DisplayMember = "Name";
            list_Video.ValueMember = "FullName";

            list_Image.DataSource = ImageList;
            list_Image.DisplayMember = "Name";
            list_Image.ValueMember = "FullName";

            //Dialog
            list_dialog.DataSource = DialogList;
            list_dialog.DisplayMember = "Name";
            list_dialog.ValueMember = "";
            DialogList.ListChanged += DialogList_ListChanged;
            
            list_Lines.DataSource = InteractionLines;
            list_Interactions.DataSource = Interactions;
            InteractionLines.ListChanged += InteractionLines_ListChanged;
            Interactions.ListChanged += Interactions_ListChanged;


            preview_Video.LoadedBehavior = System.Windows.Controls.MediaState.Manual;
        }

        #region DeleteButton
        void Remove_Click(object sender, EventArgs e)
        {
            Button source = sender as Button;
            switch (source.Tag.ToString())
            {
                case "Image":
                    if (list_Image.SelectedIndex > -1)
                    {
                        if (ConfirmDelete())
                        {
                            ImageList.RemoveAt(list_Image.SelectedIndex);
                        }
                    }
                    break;
                case "Video":
                    if (list_Video.SelectedIndex > -1)
                    {
                        if (ConfirmDelete())
                        {
                            VideoList.RemoveAt(list_Video.SelectedIndex);
                        }
                    }
                    break;
                case "Dialog":
                    if (list_dialog.SelectedIndex > -1)
                    {
                        if (ConfirmDelete())
                        {
                            DialogList.RemoveAt(list_dialog.SelectedIndex);
                        }
                    }
                    break;
                case "Interaction":
                    if (list_Interactions.SelectedIndex > -1)
                    {
                        if (ConfirmDelete())
                        {
                            Interactions.RemoveAt(list_Interactions.SelectedIndex);
                        }
                    }
                    break;
                case "Lines":
                    if (list_Lines.SelectedIndex > -1)
                    {
                        if (ConfirmDelete())
                        {
                            InteractionLines.RemoveAt(list_Lines.SelectedIndex);
                        }
                    }
                    break;
            }
        }

        public bool ConfirmDelete()
        {
            return MessageBox.Show("Are you sure you wish to delete the selected Item?", "Confirm Delete", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) 
                == System.Windows.Forms.DialogResult.Yes;
        }
        #endregion

        #region add Button
        void Add_Click(object sender, EventArgs e)
        {
            Control source = sender as Control;
            string filename;
            switch (source.Tag.ToString())
            {
                case "Image":
                    filename = getNewFile(ImageFilter);
                    if (filename != null)
                    {
                        ImageList.Add(new System.IO.FileInfo(filename));
                        if (ImageList.Count == 1)
                        {
                            list_Image.SelectedIndex = -1;
                            list_Image.SelectedIndex = 0;
                        }
                    }
                    break;
                case "Video":
                    filename = getNewFile(VideoFilter);
                    if (filename != null)
                    {
                        VideoList.Add(new System.IO.FileInfo(filename));
                        if (VideoList.Count == 1)
                        {
                            list_Video.SelectedIndex = -1;
                            list_Video.SelectedIndex = 0;
                        }
                    }
                    break;
                case "Dialog":
                    DialogList.AddNew();
                    if (DialogList.Count == 1)
                    {
                        list_dialog.SelectedIndex = -1;
                        list_dialog.SelectedIndex = 0;
                    }
                    break;
                case "Interaction":
                    Interactions.AddNew();
                    if (Interactions.Count == 1)
                    {
                        list_Interactions.SelectedIndex = -1;
                        list_Interactions.SelectedIndex = 0;
                    }
                    break;
                case "Lines":
                    using (Edit_Line d = new Edit_Line())
                    {
                        if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            InteractionLines.Add(d.NewValue);
                            if (InteractionLines.Count == 1)
                            {
                                list_Lines.SelectedIndex = -1;
                                list_Lines.SelectedIndex = 0;
                            }
                        }
                    }
                    break;
            }
        }

        public string getNewFile(string Filter)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = Filter;
            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return ofd.FileName;
            }
            return null;
        }
        #endregion

        #region Preview List Box handler (Video/Image)
        void Preview_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox source = sender as ListBox;
            switch (source.Tag.ToString())
            {
                case "Image":
                    if (source.SelectedValue != null)
                    {
                        preview_Image.Image = Bitmap.FromFile(source.SelectedValue.ToString());
                    }
                    else
                        preview_Image.Image = null;
                    break;
                case "Video":
                    if (source.SelectedValue != null)
                    {
                        preview_Video.Source = new System.Uri(source.SelectedValue.ToString());
                        btn_play.Enabled = true;
                        btn_pause.Enabled = false;
                        btn_Stop.Enabled = false;
                    }
                    else
                    {
                        preview_Video.Source = null;
                        btn_play.Enabled = false;
                        btn_pause.Enabled = false;
                        btn_Stop.Enabled = false;
                    }
                    break;
            }
        }
        #endregion

        #region Preview Cutsceen / Dialog toggle
        private void btn_ShowPreview_Click(object sender, EventArgs e)
        {
            Control source = sender as Control;
            switch (source.Tag.ToString())
            {
                case "Dialog":
                    Split_Dialog.Panel2Collapsed = !Split_Dialog.Panel2Collapsed;
                    break;
            }
        }
        #endregion

        #region Dialog Section
        private GameData.Dialog currentDialog;
        private BindingList<string> InteractionLines;
        private BindingList<GameData.Dialog.Interaction> Interactions;
        private bool dialogUpdating = false;

        private void btn_Edit1_Click(object sender, EventArgs e)
        {
            string oldval = InteractionLines[list_Lines.SelectedIndex];
            using (Edit_Line d = new Edit_Line(oldval))
            {
                if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    InteractionLines[list_Lines.SelectedIndex] = d.NewValue;
                }
            }
        }

        void InteractionLines_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (!dialogUpdating)
            {
                //update currentDialog;
                currentDialog.Interactions[list_Interactions.SelectedIndex].Lines = InteractionLines.ToList();
                int selindex = list_Interactions.SelectedIndex;
                DialogList[list_dialog.SelectedIndex] = currentDialog;
                list_Interactions.SelectedIndex = -1;
                list_Interactions.SelectedIndex = selindex;
            }
            btn_Edit1.Enabled = InteractionLines.Count > 0;
            //Console.WriteLine("InteractionLines");
        }

        void Interactions_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (!dialogUpdating)
            {
                currentDialog.Interactions = Interactions.ToList();
                DialogList[list_dialog.SelectedIndex] = currentDialog;
            }
            //Console.WriteLine("Interactions");
        }

        void DialogList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (list_dialog.SelectedIndex > -1)
            {
                dialog1.setDialog(DialogList[list_dialog.SelectedIndex]);
                Console.WriteLine("UpdateDialog");
            }
        }

        private void list_Dialog_SelectedIndex_Change(object sender, EventArgs e)
        {
            dialogUpdating = true;
            if (list_dialog.SelectedIndex > -1 && DialogList.Count > 0 && list_dialog.SelectedIndex < DialogList.Count)
                currentDialog = DialogList[list_dialog.SelectedIndex];
            else
                currentDialog = null;

            if (currentDialog != null)
            {
                txtDialogName.Text = currentDialog.Name;
                Interactions.Clear();
                foreach (GameData.Dialog.Interaction interaction in currentDialog.Interactions)
                {
                    Interactions.Add(interaction);
                }
            }
            dialogUpdating = false;
        }

        private void Interaction_index_Change(object sender, EventArgs e)
        {
            dialogUpdating = true;
            if (list_Interactions.SelectedIndex == -1 || Interactions.Count == 0)
            {
                cmb_Image1.SelectedIndex = -1;
                cmb_FinalType.SelectedIndex = -1;
                InteractionLines.Clear();
                dialog_isPlayer.Checked = false;
                return;
            }
            //update interaction details
            cmb_Image1.SelectedIndex = Interactions[list_Interactions.SelectedIndex].CharacterImage;
            cmb_FinalType.SelectedIndex = (int)Interactions[list_Interactions.SelectedIndex].FinalTransitionType;
            dialog_isPlayer.Checked = Interactions[list_Interactions.SelectedIndex].isPlayer;
            InteractionLines.Clear();
            foreach (string line in Interactions[list_Interactions.SelectedIndex].Lines)
            {
                InteractionLines.Add(line);
            }
            dialogUpdating = false;
        }

        private void Dialog_Name_Changed(object sender, EventArgs e)
        {
            if (currentDialog.Name != (sender as Control).Text)
            {
                currentDialog.Name = (sender as Control).Text;
                DialogList[list_dialog.SelectedIndex] = currentDialog;
            }
        }       

        private void Dialog_Details_Change(object sender, EventArgs e)
        {

        }

        #endregion

        #region Video_Handle
        private void button1_Click(object sender, EventArgs e)
        {
            this.preview_Video.Play();
            btn_play.Enabled = false;
            btn_pause.Enabled = true;
            btn_Stop.Enabled = true;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            this.preview_Video.Pause();
            btn_play.Enabled = true;
            btn_pause.Enabled = false;
            btn_Stop.Enabled = true;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            this.preview_Video.Stop();
            btn_play.Enabled = true;
            btn_pause.Enabled = false;
            btn_Stop.Enabled = false;
        }
        #endregion



    }
}
