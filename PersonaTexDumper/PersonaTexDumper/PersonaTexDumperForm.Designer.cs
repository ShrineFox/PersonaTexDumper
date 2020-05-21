namespace PersonaTexDumper
{
    partial class Form_PersonaTextDumper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PersonaTextDumper));
            this.btn_Dump = new System.Windows.Forms.Button();
            this.btn_BrowseSearch = new System.Windows.Forms.Button();
            this.txtBox_SearchDir = new System.Windows.Forms.TextBox();
            this.lbl_SearchDir = new System.Windows.Forms.Label();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBox_KeepFolderStructure = new System.Windows.Forms.CheckBox();
            this.chkBox_NameAfterContainers = new System.Windows.Forms.CheckBox();
            this.lbl_OutputDir = new System.Windows.Forms.Label();
            this.txtBox_OutputDir = new System.Windows.Forms.TextBox();
            this.btn_BrowseOutput = new System.Windows.Forms.Button();
            this.txtBox_Log = new System.Windows.Forms.RichTextBox();
            this.chkBox_ExtractPAC = new System.Windows.Forms.CheckBox();
            this.chkBox_SearchSubfolders = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_Dump
            // 
            this.btn_Dump.Location = new System.Drawing.Point(310, 239);
            this.btn_Dump.Name = "btn_Dump";
            this.btn_Dump.Size = new System.Drawing.Size(75, 107);
            this.btn_Dump.TabIndex = 11;
            this.btn_Dump.Text = "Dump";
            this.btn_Dump.UseVisualStyleBackColor = true;
            this.btn_Dump.Click += new System.EventHandler(this.btn_Dump_Click);
            // 
            // btn_BrowseSearch
            // 
            this.btn_BrowseSearch.Location = new System.Drawing.Point(310, 55);
            this.btn_BrowseSearch.Name = "btn_BrowseSearch";
            this.btn_BrowseSearch.Size = new System.Drawing.Size(75, 30);
            this.btn_BrowseSearch.TabIndex = 3;
            this.btn_BrowseSearch.Text = "Browse...";
            this.btn_BrowseSearch.UseVisualStyleBackColor = true;
            this.btn_BrowseSearch.Click += new System.EventHandler(this.btn_BrowseSearch_Click);
            // 
            // txtBox_SearchDir
            // 
            this.txtBox_SearchDir.Location = new System.Drawing.Point(12, 59);
            this.txtBox_SearchDir.Name = "txtBox_SearchDir";
            this.txtBox_SearchDir.Size = new System.Drawing.Size(292, 22);
            this.txtBox_SearchDir.TabIndex = 2;
            // 
            // lbl_SearchDir
            // 
            this.lbl_SearchDir.AutoSize = true;
            this.lbl_SearchDir.Location = new System.Drawing.Point(12, 39);
            this.lbl_SearchDir.Name = "lbl_SearchDir";
            this.lbl_SearchDir.Size = new System.Drawing.Size(118, 17);
            this.lbl_SearchDir.TabIndex = 0;
            this.lbl_SearchDir.Text = "Search Directory:";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "Any",
            "RMD",
            "GMD",
            "EPL",
            "SPR",
            "SPD",
            "TMX"});
            this.comboBox_Type.Location = new System.Drawing.Point(127, 12);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(258, 24);
            this.comboBox_Type.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Container Type:";
            // 
            // chkBox_KeepFolderStructure
            // 
            this.chkBox_KeepFolderStructure.AutoSize = true;
            this.chkBox_KeepFolderStructure.Checked = true;
            this.chkBox_KeepFolderStructure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_KeepFolderStructure.Location = new System.Drawing.Point(14, 186);
            this.chkBox_KeepFolderStructure.Name = "chkBox_KeepFolderStructure";
            this.chkBox_KeepFolderStructure.Size = new System.Drawing.Size(222, 21);
            this.chkBox_KeepFolderStructure.TabIndex = 8;
            this.chkBox_KeepFolderStructure.Text = "Keep Original Folder Structure";
            this.chkBox_KeepFolderStructure.UseVisualStyleBackColor = true;
            // 
            // chkBox_NameAfterContainers
            // 
            this.chkBox_NameAfterContainers.AutoSize = true;
            this.chkBox_NameAfterContainers.Checked = true;
            this.chkBox_NameAfterContainers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_NameAfterContainers.Location = new System.Drawing.Point(14, 213);
            this.chkBox_NameAfterContainers.Name = "chkBox_NameAfterContainers";
            this.chkBox_NameAfterContainers.Size = new System.Drawing.Size(323, 21);
            this.chkBox_NameAfterContainers.TabIndex = 9;
            this.chkBox_NameAfterContainers.Text = "Make Folders Named After Original Containers";
            this.chkBox_NameAfterContainers.UseVisualStyleBackColor = true;
            // 
            // lbl_OutputDir
            // 
            this.lbl_OutputDir.AutoSize = true;
            this.lbl_OutputDir.Location = new System.Drawing.Point(12, 84);
            this.lbl_OutputDir.Name = "lbl_OutputDir";
            this.lbl_OutputDir.Size = new System.Drawing.Size(116, 17);
            this.lbl_OutputDir.TabIndex = 0;
            this.lbl_OutputDir.Text = "Output Directory:";
            // 
            // txtBox_OutputDir
            // 
            this.txtBox_OutputDir.Location = new System.Drawing.Point(12, 104);
            this.txtBox_OutputDir.Name = "txtBox_OutputDir";
            this.txtBox_OutputDir.Size = new System.Drawing.Size(292, 22);
            this.txtBox_OutputDir.TabIndex = 4;
            // 
            // btn_BrowseOutput
            // 
            this.btn_BrowseOutput.Location = new System.Drawing.Point(310, 100);
            this.btn_BrowseOutput.Name = "btn_BrowseOutput";
            this.btn_BrowseOutput.Size = new System.Drawing.Size(75, 30);
            this.btn_BrowseOutput.TabIndex = 5;
            this.btn_BrowseOutput.Text = "Browse...";
            this.btn_BrowseOutput.UseVisualStyleBackColor = true;
            this.btn_BrowseOutput.Click += new System.EventHandler(this.btn_BrowseOutput_Click);
            // 
            // txtBox_Log
            // 
            this.txtBox_Log.Location = new System.Drawing.Point(12, 240);
            this.txtBox_Log.Name = "txtBox_Log";
            this.txtBox_Log.ReadOnly = true;
            this.txtBox_Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtBox_Log.Size = new System.Drawing.Size(292, 106);
            this.txtBox_Log.TabIndex = 10;
            this.txtBox_Log.Text = "";
            // 
            // chkBox_ExtractPAC
            // 
            this.chkBox_ExtractPAC.AutoSize = true;
            this.chkBox_ExtractPAC.Checked = true;
            this.chkBox_ExtractPAC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_ExtractPAC.Location = new System.Drawing.Point(12, 132);
            this.chkBox_ExtractPAC.Name = "chkBox_ExtractPAC";
            this.chkBox_ExtractPAC.Size = new System.Drawing.Size(194, 21);
            this.chkBox_ExtractPAC.TabIndex = 6;
            this.chkBox_ExtractPAC.Text = "Extract from PAC Archives";
            this.chkBox_ExtractPAC.UseVisualStyleBackColor = true;
            // 
            // chkBox_SearchSubfolders
            // 
            this.chkBox_SearchSubfolders.AutoSize = true;
            this.chkBox_SearchSubfolders.Checked = true;
            this.chkBox_SearchSubfolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_SearchSubfolders.Location = new System.Drawing.Point(12, 159);
            this.chkBox_SearchSubfolders.Name = "chkBox_SearchSubfolders";
            this.chkBox_SearchSubfolders.Size = new System.Drawing.Size(224, 21);
            this.chkBox_SearchSubfolders.TabIndex = 7;
            this.chkBox_SearchSubfolders.Text = "Recursively Search Subfolders";
            this.chkBox_SearchSubfolders.UseVisualStyleBackColor = true;
            // 
            // Form_PersonaTextDumper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 355);
            this.Controls.Add(this.chkBox_SearchSubfolders);
            this.Controls.Add(this.chkBox_ExtractPAC);
            this.Controls.Add(this.txtBox_Log);
            this.Controls.Add(this.lbl_OutputDir);
            this.Controls.Add(this.txtBox_OutputDir);
            this.Controls.Add(this.btn_BrowseOutput);
            this.Controls.Add(this.chkBox_NameAfterContainers);
            this.Controls.Add(this.chkBox_KeepFolderStructure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.lbl_SearchDir);
            this.Controls.Add(this.txtBox_SearchDir);
            this.Controls.Add(this.btn_BrowseSearch);
            this.Controls.Add(this.btn_Dump);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_PersonaTextDumper";
            this.Text = "Persona Texture Dumper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Dump;
        private System.Windows.Forms.Button btn_BrowseSearch;
        private System.Windows.Forms.TextBox txtBox_SearchDir;
        private System.Windows.Forms.Label lbl_SearchDir;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBox_KeepFolderStructure;
        private System.Windows.Forms.CheckBox chkBox_NameAfterContainers;
        private System.Windows.Forms.Label lbl_OutputDir;
        private System.Windows.Forms.TextBox txtBox_OutputDir;
        private System.Windows.Forms.Button btn_BrowseOutput;
        private System.Windows.Forms.RichTextBox txtBox_Log;
        private System.Windows.Forms.CheckBox chkBox_ExtractPAC;
        private System.Windows.Forms.CheckBox chkBox_SearchSubfolders;
    }
}

