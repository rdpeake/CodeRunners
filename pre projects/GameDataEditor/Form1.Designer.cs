namespace GameDataEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Initial Level point");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("More Level Information");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("SubLevel #", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("SubLevel #");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Level #", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ShowPreview1 = new System.Windows.Forms.Button();
            this.Split_Dialog = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Edit2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_FinalType = new System.Windows.Forms.ComboBox();
            this.btn_Rem4 = new System.Windows.Forms.Button();
            this.btn_Add4 = new System.Windows.Forms.Button();
            this.dialog_isPlayer = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Edit1 = new System.Windows.Forms.Button();
            this.btn_Rem5 = new System.Windows.Forms.Button();
            this.btn_Add5 = new System.Windows.Forms.Button();
            this.list_Lines = new System.Windows.Forms.ListBox();
            this.btn_FindImage1 = new System.Windows.Forms.Button();
            this.cmb_Image1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.list_Interactions = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDialogName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Rem3 = new System.Windows.Forms.Button();
            this.btn_Add3 = new System.Windows.Forms.Button();
            this.list_dialog = new System.Windows.Forms.ListBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.preview_Image = new System.Windows.Forms.PictureBox();
            this.btn_Rem1 = new System.Windows.Forms.Button();
            this.btn_Add1 = new System.Windows.Forms.Button();
            this.list_Image = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_Rem2 = new System.Windows.Forms.Button();
            this.btn_add2 = new System.Windows.Forms.Button();
            this.list_Video = new System.Windows.Forms.ListBox();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialog1 = new WorldControls.Dialog();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.preview_Video = new GameDataEditor.MediaEmbed();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Split_Dialog)).BeginInit();
            this.Split_Dialog.Panel1.SuspendLayout();
            this.Split_Dialog.Panel2.SuspendLayout();
            this.Split_Dialog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview_Image)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Puzzles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_ShowPreview1);
            this.tabPage2.Controls.Add(this.Split_Dialog);
            this.tabPage2.Controls.Add(this.txtDialogName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_Rem3);
            this.tabPage2.Controls.Add(this.btn_Add3);
            this.tabPage2.Controls.Add(this.list_dialog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(861, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dialog";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_ShowPreview1
            // 
            this.btn_ShowPreview1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ShowPreview1.Location = new System.Drawing.Point(320, 331);
            this.btn_ShowPreview1.Name = "btn_ShowPreview1";
            this.btn_ShowPreview1.Size = new System.Drawing.Size(127, 23);
            this.btn_ShowPreview1.TabIndex = 7;
            this.btn_ShowPreview1.Tag = "Dialog";
            this.btn_ShowPreview1.Text = "Show/Hide Preview";
            this.btn_ShowPreview1.UseVisualStyleBackColor = true;
            this.btn_ShowPreview1.Click += new System.EventHandler(this.btn_ShowPreview_Click);
            // 
            // Split_Dialog
            // 
            this.Split_Dialog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Split_Dialog.Location = new System.Drawing.Point(162, 32);
            this.Split_Dialog.MinimumSize = new System.Drawing.Size(557, 295);
            this.Split_Dialog.Name = "Split_Dialog";
            // 
            // Split_Dialog.Panel1
            // 
            this.Split_Dialog.Panel1.Controls.Add(this.groupBox1);
            this.Split_Dialog.Panel1MinSize = 389;
            // 
            // Split_Dialog.Panel2
            // 
            this.Split_Dialog.Panel2.Controls.Add(this.groupBox3);
            this.Split_Dialog.Panel2MinSize = 300;
            this.Split_Dialog.Size = new System.Drawing.Size(693, 295);
            this.Split_Dialog.SplitterDistance = 389;
            this.Split_Dialog.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_Edit2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_FinalType);
            this.groupBox1.Controls.Add(this.btn_Rem4);
            this.groupBox1.Controls.Add(this.btn_Add4);
            this.groupBox1.Controls.Add(this.dialog_isPlayer);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_FindImage1);
            this.groupBox1.Controls.Add(this.cmb_Image1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.list_Interactions);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(389, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 295);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interactions";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Final Options";
            // 
            // btn_Edit2
            // 
            this.btn_Edit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Edit2.Enabled = false;
            this.btn_Edit2.Location = new System.Drawing.Point(220, 234);
            this.btn_Edit2.Name = "btn_Edit2";
            this.btn_Edit2.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit2.TabIndex = 0;
            this.btn_Edit2.Text = "Edit Final Options";
            this.btn_Edit2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Final Interaction";
            // 
            // cmb_FinalType
            // 
            this.cmb_FinalType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_FinalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FinalType.FormattingEnabled = true;
            this.cmb_FinalType.Items.AddRange(new object[] {
            "AnyKey",
            "OptionsList",
            "TextInput"});
            this.cmb_FinalType.Location = new System.Drawing.Point(220, 207);
            this.cmb_FinalType.Name = "cmb_FinalType";
            this.cmb_FinalType.Size = new System.Drawing.Size(163, 21);
            this.cmb_FinalType.TabIndex = 11;
            // 
            // btn_Rem4
            // 
            this.btn_Rem4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Rem4.Location = new System.Drawing.Point(210, 266);
            this.btn_Rem4.Name = "btn_Rem4";
            this.btn_Rem4.Size = new System.Drawing.Size(75, 23);
            this.btn_Rem4.TabIndex = 8;
            this.btn_Rem4.Tag = "Interaction";
            this.btn_Rem4.Text = "Remove";
            this.btn_Rem4.UseVisualStyleBackColor = true;
            this.btn_Rem4.Click += new System.EventHandler(this.Remove_Click);
            // 
            // btn_Add4
            // 
            this.btn_Add4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Add4.Location = new System.Drawing.Point(129, 266);
            this.btn_Add4.Name = "btn_Add4";
            this.btn_Add4.Size = new System.Drawing.Size(75, 23);
            this.btn_Add4.TabIndex = 7;
            this.btn_Add4.Tag = "Interaction";
            this.btn_Add4.Text = "Add";
            this.btn_Add4.UseVisualStyleBackColor = true;
            this.btn_Add4.Click += new System.EventHandler(this.Add_Click);
            // 
            // dialog_isPlayer
            // 
            this.dialog_isPlayer.AutoSize = true;
            this.dialog_isPlayer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dialog_isPlayer.Location = new System.Drawing.Point(168, 48);
            this.dialog_isPlayer.Name = "dialog_isPlayer";
            this.dialog_isPlayer.Size = new System.Drawing.Size(66, 17);
            this.dialog_isPlayer.TabIndex = 0;
            this.dialog_isPlayer.Text = "Is Player";
            this.dialog_isPlayer.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_Edit1);
            this.groupBox2.Controls.Add(this.btn_Rem5);
            this.groupBox2.Controls.Add(this.btn_Add5);
            this.groupBox2.Controls.Add(this.list_Lines);
            this.groupBox2.Location = new System.Drawing.Point(132, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 130);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lines";
            // 
            // btn_Edit1
            // 
            this.btn_Edit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit1.Location = new System.Drawing.Point(159, 77);
            this.btn_Edit1.Name = "btn_Edit1";
            this.btn_Edit1.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit1.TabIndex = 11;
            this.btn_Edit1.Tag = "Lines";
            this.btn_Edit1.Text = "Edit";
            this.btn_Edit1.UseVisualStyleBackColor = true;
            this.btn_Edit1.Click += new System.EventHandler(this.btn_Edit1_Click);
            // 
            // btn_Rem5
            // 
            this.btn_Rem5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Rem5.Location = new System.Drawing.Point(159, 47);
            this.btn_Rem5.Name = "btn_Rem5";
            this.btn_Rem5.Size = new System.Drawing.Size(75, 23);
            this.btn_Rem5.TabIndex = 10;
            this.btn_Rem5.Tag = "Lines";
            this.btn_Rem5.Text = "Remove";
            this.btn_Rem5.UseVisualStyleBackColor = true;
            this.btn_Rem5.Click += new System.EventHandler(this.Remove_Click);
            // 
            // btn_Add5
            // 
            this.btn_Add5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add5.Location = new System.Drawing.Point(159, 18);
            this.btn_Add5.Name = "btn_Add5";
            this.btn_Add5.Size = new System.Drawing.Size(75, 23);
            this.btn_Add5.TabIndex = 9;
            this.btn_Add5.Tag = "Lines";
            this.btn_Add5.Text = "Add";
            this.btn_Add5.UseVisualStyleBackColor = true;
            this.btn_Add5.Click += new System.EventHandler(this.Add_Click);
            // 
            // list_Lines
            // 
            this.list_Lines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_Lines.FormattingEnabled = true;
            this.list_Lines.Location = new System.Drawing.Point(3, 16);
            this.list_Lines.Name = "list_Lines";
            this.list_Lines.Size = new System.Drawing.Size(150, 108);
            this.list_Lines.TabIndex = 0;
            // 
            // btn_FindImage1
            // 
            this.btn_FindImage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FindImage1.Location = new System.Drawing.Point(308, 19);
            this.btn_FindImage1.Name = "btn_FindImage1";
            this.btn_FindImage1.Size = new System.Drawing.Size(75, 23);
            this.btn_FindImage1.TabIndex = 5;
            this.btn_FindImage1.Tag = "Dialog";
            this.btn_FindImage1.Text = "Browse";
            this.btn_FindImage1.UseVisualStyleBackColor = true;
            // 
            // cmb_Image1
            // 
            this.cmb_Image1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Image1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Image1.FormattingEnabled = true;
            this.cmb_Image1.Location = new System.Drawing.Point(220, 21);
            this.cmb_Image1.Name = "cmb_Image1";
            this.cmb_Image1.Size = new System.Drawing.Size(82, 21);
            this.cmb_Image1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Character Image";
            // 
            // list_Interactions
            // 
            this.list_Interactions.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_Interactions.FormattingEnabled = true;
            this.list_Interactions.Location = new System.Drawing.Point(3, 16);
            this.list_Interactions.Name = "list_Interactions";
            this.list_Interactions.Size = new System.Drawing.Size(120, 276);
            this.list_Interactions.TabIndex = 2;
            this.list_Interactions.SelectedIndexChanged += new System.EventHandler(this.Interaction_index_Change);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dialog1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.MinimumSize = new System.Drawing.Size(300, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 295);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // txtDialogName
            // 
            this.txtDialogName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDialogName.Location = new System.Drawing.Point(202, 6);
            this.txtDialogName.Name = "txtDialogName";
            this.txtDialogName.Size = new System.Drawing.Size(653, 20);
            this.txtDialogName.TabIndex = 4;
            this.txtDialogName.TextChanged += new System.EventHandler(this.Dialog_Name_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // btn_Rem3
            // 
            this.btn_Rem3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Rem3.Location = new System.Drawing.Point(239, 331);
            this.btn_Rem3.Name = "btn_Rem3";
            this.btn_Rem3.Size = new System.Drawing.Size(75, 23);
            this.btn_Rem3.TabIndex = 2;
            this.btn_Rem3.Tag = "Dialog";
            this.btn_Rem3.Text = "Remove";
            this.btn_Rem3.UseVisualStyleBackColor = true;
            this.btn_Rem3.Click += new System.EventHandler(this.Remove_Click);
            // 
            // btn_Add3
            // 
            this.btn_Add3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Add3.Location = new System.Drawing.Point(158, 331);
            this.btn_Add3.Name = "btn_Add3";
            this.btn_Add3.Size = new System.Drawing.Size(75, 23);
            this.btn_Add3.TabIndex = 1;
            this.btn_Add3.Tag = "Dialog";
            this.btn_Add3.Text = "Add";
            this.btn_Add3.UseVisualStyleBackColor = true;
            this.btn_Add3.Click += new System.EventHandler(this.Add_Click);
            // 
            // list_dialog
            // 
            this.list_dialog.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_dialog.FormattingEnabled = true;
            this.list_dialog.Location = new System.Drawing.Point(3, 3);
            this.list_dialog.Name = "list_dialog";
            this.list_dialog.Size = new System.Drawing.Size(149, 356);
            this.list_dialog.TabIndex = 0;
            this.list_dialog.SelectedIndexChanged += new System.EventHandler(this.list_Dialog_SelectedIndex_Change);
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(861, 362);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Cut Sceens";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.preview_Image);
            this.tabPage4.Controls.Add(this.btn_Rem1);
            this.tabPage4.Controls.Add(this.btn_Add1);
            this.tabPage4.Controls.Add(this.list_Image);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(861, 362);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Images";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // preview_Image
            // 
            this.preview_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preview_Image.Location = new System.Drawing.Point(142, 3);
            this.preview_Image.Name = "preview_Image";
            this.preview_Image.Size = new System.Drawing.Size(711, 327);
            this.preview_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.preview_Image.TabIndex = 3;
            this.preview_Image.TabStop = false;
            // 
            // btn_Rem1
            // 
            this.btn_Rem1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Rem1.Location = new System.Drawing.Point(223, 336);
            this.btn_Rem1.Name = "btn_Rem1";
            this.btn_Rem1.Size = new System.Drawing.Size(75, 23);
            this.btn_Rem1.TabIndex = 2;
            this.btn_Rem1.Tag = "Image";
            this.btn_Rem1.Text = "Remove";
            this.btn_Rem1.UseVisualStyleBackColor = true;
            this.btn_Rem1.Click += new System.EventHandler(this.Remove_Click);
            // 
            // btn_Add1
            // 
            this.btn_Add1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Add1.Location = new System.Drawing.Point(142, 336);
            this.btn_Add1.Name = "btn_Add1";
            this.btn_Add1.Size = new System.Drawing.Size(75, 23);
            this.btn_Add1.TabIndex = 1;
            this.btn_Add1.Tag = "Image";
            this.btn_Add1.Text = "Add";
            this.btn_Add1.UseVisualStyleBackColor = true;
            this.btn_Add1.Click += new System.EventHandler(this.Add_Click);
            // 
            // list_Image
            // 
            this.list_Image.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_Image.FormattingEnabled = true;
            this.list_Image.Location = new System.Drawing.Point(3, 3);
            this.list_Image.Name = "list_Image";
            this.list_Image.Size = new System.Drawing.Size(133, 356);
            this.list_Image.TabIndex = 0;
            this.list_Image.Tag = "Image";
            this.list_Image.SelectedIndexChanged += new System.EventHandler(this.Preview_List_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_Rem2);
            this.tabPage5.Controls.Add(this.btn_add2);
            this.tabPage5.Controls.Add(this.list_Video);
            this.tabPage5.Controls.Add(this.btn_Stop);
            this.tabPage5.Controls.Add(this.btn_pause);
            this.tabPage5.Controls.Add(this.btn_play);
            this.tabPage5.Controls.Add(this.elementHost1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(861, 362);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Video";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_Rem2
            // 
            this.btn_Rem2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Rem2.Location = new System.Drawing.Point(210, 336);
            this.btn_Rem2.Name = "btn_Rem2";
            this.btn_Rem2.Size = new System.Drawing.Size(75, 23);
            this.btn_Rem2.TabIndex = 6;
            this.btn_Rem2.Tag = "Video";
            this.btn_Rem2.Text = "Remove";
            this.btn_Rem2.UseVisualStyleBackColor = true;
            this.btn_Rem2.Click += new System.EventHandler(this.Remove_Click);
            // 
            // btn_add2
            // 
            this.btn_add2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add2.Location = new System.Drawing.Point(129, 336);
            this.btn_add2.Name = "btn_add2";
            this.btn_add2.Size = new System.Drawing.Size(75, 23);
            this.btn_add2.TabIndex = 5;
            this.btn_add2.Tag = "Video";
            this.btn_add2.Text = "Add";
            this.btn_add2.UseVisualStyleBackColor = true;
            this.btn_add2.Click += new System.EventHandler(this.Add_Click);
            // 
            // list_Video
            // 
            this.list_Video.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_Video.FormattingEnabled = true;
            this.list_Video.Location = new System.Drawing.Point(3, 3);
            this.list_Video.Name = "list_Video";
            this.list_Video.Size = new System.Drawing.Size(120, 356);
            this.list_Video.TabIndex = 4;
            this.list_Video.Tag = "Video";
            this.list_Video.SelectedIndexChanged += new System.EventHandler(this.Preview_List_SelectedIndexChanged);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Location = new System.Drawing.Point(780, 336);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 3;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pause.Enabled = false;
            this.btn_pause.Location = new System.Drawing.Point(699, 336);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_play
            // 
            this.btn_play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_play.Enabled = false;
            this.btn_play.Location = new System.Drawing.Point(618, 336);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.treeView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(861, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Levels";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Initial Level point";
            treeNode2.Name = "Node5";
            treeNode2.Text = "More Level Information";
            treeNode3.Name = "Node1";
            treeNode3.Text = "SubLevel #";
            treeNode4.Name = "Node2";
            treeNode4.Text = "SubLevel #";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Level #";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(181, 356);
            this.treeView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // dialog1
            // 
            this.dialog1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dialog1.BackColor = System.Drawing.Color.Transparent;
            this.dialog1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.dialog1.Location = new System.Drawing.Point(3, 16);
            this.dialog1.MinimumSize = new System.Drawing.Size(240, 130);
            this.dialog1.Name = "dialog1";
            this.dialog1.Size = new System.Drawing.Size(297, 155);
            this.dialog1.TabIndex = 0;
            // 
            // elementHost1
            // 
            this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost1.Location = new System.Drawing.Point(129, 3);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(726, 332);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.preview_Video;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 412);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(885, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Split_Dialog.Panel1.ResumeLayout(false);
            this.Split_Dialog.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Split_Dialog)).EndInit();
            this.Split_Dialog.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preview_Image)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private MediaEmbed preview_Video;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_Rem2;
        private System.Windows.Forms.Button btn_add2;
        private System.Windows.Forms.ListBox list_Video;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox preview_Image;
        private System.Windows.Forms.Button btn_Rem1;
        private System.Windows.Forms.Button btn_Add1;
        private System.Windows.Forms.ListBox list_Image;
        private System.Windows.Forms.Button btn_Rem3;
        private System.Windows.Forms.Button btn_Add3;
        private System.Windows.Forms.ListBox list_dialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox list_Interactions;
        private System.Windows.Forms.TextBox txtDialogName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_FindImage1;
        private System.Windows.Forms.ComboBox cmb_Image1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Rem4;
        private System.Windows.Forms.Button btn_Add4;
        private System.Windows.Forms.CheckBox dialog_isPlayer;
        private System.Windows.Forms.ListBox list_Lines;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Edit1;
        private System.Windows.Forms.Button btn_Rem5;
        private System.Windows.Forms.Button btn_Add5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Edit2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_FinalType;
        private System.Windows.Forms.SplitContainer Split_Dialog;
        private System.Windows.Forms.Button btn_ShowPreview1;
        private WorldControls.Dialog dialog1;
    }
}

