﻿namespace TRG_File_Merge
{
    partial class frmFileMerge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileMerge));
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnMergeExport = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.gbxMergeOptions = new System.Windows.Forms.GroupBox();
            this.txtCommentText = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbtCommentDelimiter = new System.Windows.Forms.RadioButton();
            this.rbtSpaceDelimiter = new System.Windows.Forms.RadioButton();
            this.lblFilesListed = new System.Windows.Forms.Label();
            this.lblActiveFiles = new System.Windows.Forms.Label();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.lbxFileList = new System.Windows.Forms.CheckedListBox();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.gbxSaveLocation = new System.Windows.Forms.GroupBox();
            this.btnSetPath = new System.Windows.Forms.Button();
            this.lblSaveFileLocation = new System.Windows.Forms.Label();
            this.gbxListCount = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbxMergeOptions.SuspendLayout();
            this.gbxSaveLocation.SuspendLayout();
            this.gbxListCount.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(13, 17);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(122, 24);
            this.btnAddFile.TabIndex = 0;
            this.btnAddFile.Text = "&Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnMergeExport
            // 
            this.btnMergeExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMergeExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMergeExport.BackgroundImage")));
            this.btnMergeExport.Location = new System.Drawing.Point(896, 16);
            this.btnMergeExport.Name = "btnMergeExport";
            this.btnMergeExport.Size = new System.Drawing.Size(124, 110);
            this.btnMergeExport.TabIndex = 15;
            this.btnMergeExport.Text = "&Export ";
            this.btnMergeExport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMergeExport.UseVisualStyleBackColor = true;
            this.btnMergeExport.Click += new System.EventHandler(this.btnMergeExport_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(141, 17);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(118, 24);
            this.btnAddFolder.TabIndex = 1;
            this.btnAddFolder.Text = "Add &Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // gbxMergeOptions
            // 
            this.gbxMergeOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxMergeOptions.Controls.Add(this.txtCommentText);
            this.gbxMergeOptions.Controls.Add(this.radioButton1);
            this.gbxMergeOptions.Controls.Add(this.rbtCommentDelimiter);
            this.gbxMergeOptions.Controls.Add(this.rbtSpaceDelimiter);
            this.gbxMergeOptions.Location = new System.Drawing.Point(6, 64);
            this.gbxMergeOptions.Name = "gbxMergeOptions";
            this.gbxMergeOptions.Size = new System.Drawing.Size(862, 65);
            this.gbxMergeOptions.TabIndex = 18;
            this.gbxMergeOptions.TabStop = false;
            this.gbxMergeOptions.Text = "File Merge Options:  ";
            // 
            // txtCommentText
            // 
            this.txtCommentText.Location = new System.Drawing.Point(412, 26);
            this.txtCommentText.Name = "txtCommentText";
            this.txtCommentText.Size = new System.Drawing.Size(218, 20);
            this.txtCommentText.TabIndex = 13;
            this.txtCommentText.TextChanged += new System.EventHandler(this.txtCommentText_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(697, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(118, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Do not use delimiter";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbtCommentDelimiter
            // 
            this.rbtCommentDelimiter.AutoSize = true;
            this.rbtCommentDelimiter.Location = new System.Drawing.Point(191, 27);
            this.rbtCommentDelimiter.Name = "rbtCommentDelimiter";
            this.rbtCommentDelimiter.Size = new System.Drawing.Size(220, 17);
            this.rbtCommentDelimiter.TabIndex = 12;
            this.rbtCommentDelimiter.Text = "Insert text as comment tag between files: ";
            this.rbtCommentDelimiter.UseVisualStyleBackColor = true;
            // 
            // rbtSpaceDelimiter
            // 
            this.rbtSpaceDelimiter.AutoSize = true;
            this.rbtSpaceDelimiter.Location = new System.Drawing.Point(20, 27);
            this.rbtSpaceDelimiter.Name = "rbtSpaceDelimiter";
            this.rbtSpaceDelimiter.Size = new System.Drawing.Size(148, 17);
            this.rbtSpaceDelimiter.TabIndex = 11;
            this.rbtSpaceDelimiter.Text = "Insert space between files";
            this.rbtSpaceDelimiter.UseVisualStyleBackColor = true;
            // 
            // lblFilesListed
            // 
            this.lblFilesListed.AutoSize = true;
            this.lblFilesListed.Location = new System.Drawing.Point(12, 25);
            this.lblFilesListed.Name = "lblFilesListed";
            this.lblFilesListed.Size = new System.Drawing.Size(77, 13);
            this.lblFilesListed.TabIndex = 16;
            this.lblFilesListed.Text = "Files Listed:     ";
            // 
            // lblActiveFiles
            // 
            this.lblActiveFiles.AutoSize = true;
            this.lblActiveFiles.Location = new System.Drawing.Point(10, 52);
            this.lblActiveFiles.Name = "lblActiveFiles";
            this.lblActiveFiles.Size = new System.Drawing.Size(79, 13);
            this.lblActiveFiles.TabIndex = 17;
            this.lblActiveFiles.Text = "Active Files:     ";
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearList.Location = new System.Drawing.Point(667, 16);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(96, 44);
            this.btnClearList.TabIndex = 2;
            this.btnClearList.Text = "&Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(6, 16);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(108, 44);
            this.btnMoveUp.TabIndex = 8;
            this.btnMoveUp.Text = "Move &Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFile.Location = new System.Drawing.Point(769, 16);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(98, 44);
            this.btnRemoveFile.TabIndex = 9;
            this.btnRemoveFile.Text = "&Remove File";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(120, 16);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(108, 44);
            this.btnMoveDown.TabIndex = 10;
            this.btnMoveDown.Text = "Move &Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // lbxFileList
            // 
            this.lbxFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxFileList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxFileList.FormattingEnabled = true;
            this.lbxFileList.Location = new System.Drawing.Point(6, 102);
            this.lbxFileList.Name = "lbxFileList";
            this.lbxFileList.ScrollAlwaysVisible = true;
            this.lbxFileList.Size = new System.Drawing.Size(1014, 499);
            this.lbxFileList.TabIndex = 7;
            this.lbxFileList.SelectedIndexChanged += new System.EventHandler(this.lbxFileList_SelectedIndexChanged);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveClose.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSaveClose.Location = new System.Drawing.Point(453, 13);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(105, 25);
            this.btnSaveClose.TabIndex = 3;
            this.btnSaveClose.Text = "&Save && Close";
            this.btnSaveClose.UseVisualStyleBackColor = false;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(13, 47);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(122, 24);
            this.btnCheckAll.TabIndex = 4;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Location = new System.Drawing.Point(141, 47);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(118, 24);
            this.btnUncheckAll.TabIndex = 5;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(234, 16);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(108, 44);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Sort &List";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // gbxSaveLocation
            // 
            this.gbxSaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSaveLocation.Controls.Add(this.btnSetPath);
            this.gbxSaveLocation.Controls.Add(this.lblSaveFileLocation);
            this.gbxSaveLocation.Controls.Add(this.btnSaveClose);
            this.gbxSaveLocation.Location = new System.Drawing.Point(445, 15);
            this.gbxSaveLocation.Name = "gbxSaveLocation";
            this.gbxSaveLocation.Size = new System.Drawing.Size(575, 78);
            this.gbxSaveLocation.TabIndex = 19;
            this.gbxSaveLocation.TabStop = false;
            this.gbxSaveLocation.Text = "Save file location:  ";
            // 
            // btnSetPath
            // 
            this.btnSetPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetPath.Location = new System.Drawing.Point(453, 47);
            this.btnSetPath.Name = "btnSetPath";
            this.btnSetPath.Size = new System.Drawing.Size(105, 25);
            this.btnSetPath.TabIndex = 21;
            this.btnSetPath.Text = "Set Save Path";
            this.btnSetPath.UseVisualStyleBackColor = true;
            this.btnSetPath.Click += new System.EventHandler(this.btnSetPath_Click);
            // 
            // lblSaveFileLocation
            // 
            this.lblSaveFileLocation.AutoSize = true;
            this.lblSaveFileLocation.Location = new System.Drawing.Point(17, 47);
            this.lblSaveFileLocation.Name = "lblSaveFileLocation";
            this.lblSaveFileLocation.Size = new System.Drawing.Size(16, 13);
            this.lblSaveFileLocation.TabIndex = 20;
            this.lblSaveFileLocation.Text = "...";
            // 
            // gbxListCount
            // 
            this.gbxListCount.Controls.Add(this.lblFilesListed);
            this.gbxListCount.Controls.Add(this.lblActiveFiles);
            this.gbxListCount.Location = new System.Drawing.Point(284, 16);
            this.gbxListCount.Name = "gbxListCount";
            this.gbxListCount.Size = new System.Drawing.Size(155, 77);
            this.gbxListCount.TabIndex = 20;
            this.gbxListCount.TabStop = false;
            this.gbxListCount.Text = "List item Count:  ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMergeExport);
            this.groupBox1.Controls.Add(this.btnRemoveFile);
            this.groupBox1.Controls.Add(this.btnClearList);
            this.groupBox1.Controls.Add(this.btnSort);
            this.groupBox1.Controls.Add(this.gbxMergeOptions);
            this.groupBox1.Controls.Add(this.btnMoveDown);
            this.groupBox1.Controls.Add(this.btnMoveUp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 614);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 135);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.lbxFileList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1028, 614);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddFolder);
            this.groupBox3.Controls.Add(this.btnUncheckAll);
            this.groupBox3.Controls.Add(this.btnAddFile);
            this.groupBox3.Controls.Add(this.btnCheckAll);
            this.groupBox3.Location = new System.Drawing.Point(6, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 85);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gbxSaveLocation);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.gbxListCount);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1028, 96);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // frmFileMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFileMerge";
            this.Text = "TRG File Merge";
            this.Load += new System.EventHandler(this.frmFileMerge_Load);
            this.gbxMergeOptions.ResumeLayout(false);
            this.gbxMergeOptions.PerformLayout();
            this.gbxSaveLocation.ResumeLayout(false);
            this.gbxSaveLocation.PerformLayout();
            this.gbxListCount.ResumeLayout(false);
            this.gbxListCount.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnMergeExport;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.GroupBox gbxMergeOptions;
        private System.Windows.Forms.Label lblFilesListed;
        private System.Windows.Forms.Label lblActiveFiles;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.CheckedListBox lbxFileList;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbtCommentDelimiter;
        private System.Windows.Forms.RadioButton rbtSpaceDelimiter;
        private System.Windows.Forms.TextBox txtCommentText;
        private System.Windows.Forms.GroupBox gbxSaveLocation;
        private System.Windows.Forms.Label lblSaveFileLocation;
        private System.Windows.Forms.GroupBox gbxListCount;
        private System.Windows.Forms.Button btnSetPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

