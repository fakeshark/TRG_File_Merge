using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TRG_File_Merge.Properties;

namespace TRG_File_Merge
{
    public partial class frmFileMerge : Form
    {
        string destinationFolderPath = "";
        int itemCount = 0;
        string filesFolderPath = "";
        string fileFolderPath = "";
        string text = "";
        string saveText = "";
        string listText = "testing";
        string delimiter = "";
        string savePath = "";
        //string savePath = "";

        public frmFileMerge()
        {
            InitializeComponent();
            //look for and apply ini file
            UpdateLists();
            lbxFileList.HorizontalScrollbar = true;
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            //user browses to folder and selects file
            OpenFileDialog fileSelected = new OpenFileDialog();
            fileSelected.Filter = "Text Files (*.txt)|*.txt|XML Files (*.xml)|*.xml|SGML Files (*.sgml)|*.sgml|All Files (*.*)|*.*";
            fileSelected.Multiselect = false;

            if (fileSelected.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = fileSelected.FileName;
                //file gets added to listbox
                lbxFileList.Items.Add(selectedFileName, true);
            }
            UpdateLists();
        }

        private void WriteToSaveFile ()
        {
            //create a save file with the current listbox items in it
            var saveFile = new SaveFileDialog();

            saveFile.Filter = "sav files (*.sav)|*.sav|All files (*.*)|*.*";
            saveFile.FilterIndex = 2;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, listText);
                MessageBox.Show("Your list has been save to an external file.\n\nFile Location:\t" + saveFile.FileName);
                Settings.Default["SaveFilePath"] = saveFile.FileName;
            }
        }

        private void LoadSaveFile()
        {
            if (File.Exists(savePath))
            {
                string[] lines = System.IO.File.ReadAllLines(savePath);

                foreach (string listItem in lines)
                {
                    lbxFileList.Items.Add(listItem, true);
                }
            }
            else
            {
                MessageBox.Show("Save file not found", "Warning");
                lblSaveFileLocation.Text = "";
            }

        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            //user browses to folder
            FolderBrowserDialog filesPath = new System.Windows.Forms.FolderBrowserDialog();
            if (DialogResult.OK == filesPath.ShowDialog())
            {
                filesFolderPath = Convert.ToString(filesPath.SelectedPath);
                string[] filesSelected = Directory.GetFiles(filesFolderPath);

                foreach (string fileName in filesSelected)
                {
                    //all files from folder are added to listbox
                    lbxFileList.Items.Add(fileName, true);
                }
            }

            //file path from each file is added to mergelist
            UpdateLists();
        }

        private void btnMergeExport_Click(object sender, EventArgs e)
        {
            if (rbtSpaceDelimiter.Checked == true)
            {
                delimiter = "\n\n\n\n\n";
            }
            else if (rbtCommentDelimiter.Checked == true)
            {
                delimiter = "\n\n<!-- " + txtCommentText.Text + " -->\n\n";
            }
            else
            {
                delimiter = "";
            }

            foreach (string Item in lbxFileList.CheckedItems)
            {
                //don't use delimiter if it's the last iteration of the foreach loop
                if (lbxFileList.CheckedItems.IndexOf(Item) == lbxFileList.CheckedItems.Count - 1)
                {
                    delimiter = "";
                }
                
                //all files from folder are added to listbox
                text += System.IO.File.ReadAllText(Item);
                text += delimiter;
            }

            var sfd = new SaveFileDialog();

            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 2;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, text);
                MessageBox.Show("Your file has been exported.\n\nFile Location:\t" + sfd.FileName);
                text = "";
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            if (lbxFileList.Items.Count == 0)
            {
                MessageBox.Show("List is already empty.");
            }
            else
            {
                //message box asks user to confirm the clearing of the list
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear the entire list?", "Clear List?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lbxFileList.Items.Clear();
                }
            }
            //after user confirmation, filenames are cleared from listbox
            UpdateLists();
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            //check if anything is selected
            if (lbxFileList.SelectedIndex == -1)
            {
                MessageBox.Show("Select an Item first!");
            }
            else
            {
                MoveItem(-1);
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            //check if anything is selected
            if (lbxFileList.SelectedIndex == -1)
            {
                MessageBox.Show("Select an Item first!");
            }
            else
            {
                MoveItem(1);
            }
        }

        private void MoveItem(int direction)
        {
            // Checking selected item
            if (lbxFileList.SelectedItem == null || lbxFileList.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = lbxFileList.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= lbxFileList.Items.Count)
                return; // Index out of range - nothing to do

            object selected = lbxFileList.SelectedItem;

            // Removing selected item
            lbxFileList.Items.Remove(selected);
            // Insert selected item in new position
            lbxFileList.Items.Insert(newIndex, selected);
            // keep selected item selected (re-select)
            lbxFileList.SetSelected(newIndex, true);

            UpdateLists();
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            //message box asks user to confirm the remove
            if (lbxFileList.SelectedIndex == -1)
            {
                MessageBox.Show("Select an Item first!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Remove this item from the list?", "Remove Item?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //remove file from listbox
                    lbxFileList.Items.Remove(lbxFileList.SelectedItem);
                    UpdateLists();
                }
            }
        }

        private void UpdateLists()
        {
            lblFilesListed.Text = "Files Listed:     " + Convert.ToString(lbxFileList.Items.Count);
            lblActiveFiles.Text = "Active Files:     " + Convert.ToString(lbxFileList.CheckedItems.Count);
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            // check to see if there is a path set

            if (File.Exists(savePath))
            {
                foreach (string Item in lbxFileList.CheckedItems)
                {
                    //don't use delimiter if it's the last iteration of the foreach loop
                    if (lbxFileList.CheckedItems.IndexOf(Item) == lbxFileList.CheckedItems.Count - 1)
                    {
                        delimiter = "";
                    }

                    //all files from folder are added to listbox
                    saveText += (Item + "\n");
                }

                File.WriteAllText(savePath, saveText);
                MessageBox.Show("Your settings have been saved.\n\nThank you!");
                saveText = "";
                

                Settings.Default["CommentText"] = txtCommentText.Text;
                Settings.Default["SaveFilePath"] = lblSaveFileLocation.Text;
                Settings.Default.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Save file location must be set first!");
                SetSavePath();
            }
             
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbxFileList.Items.Count; i++)
            {
                lbxFileList.SetItemChecked(i, true);
            }
            UpdateLists();
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbxFileList.Items.Count; i++)
            {
                lbxFileList.SetItemChecked(i, false);
            }
            UpdateLists();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lbxFileList.Sorted = true;
        }

        private void txtCommentText_TextChanged(object sender, EventArgs e)
        {
            rbtCommentDelimiter.Checked = true;
        }

        private void lbxFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLists();
        }

        private void frmFileMerge_Load(object sender, EventArgs e)
        {
            txtCommentText.Text = Settings.Default["CommentText"].ToString();
            lblSaveFileLocation.Text = Settings.Default["SaveFilePath"].ToString();
            savePath = Settings.Default["SaveFilePath"].ToString();
            LoadSaveFile();
        }

        private void btnSetPath_Click(object sender, EventArgs e)
        {
            SetSavePath();
        }

        private void SetSavePath()
        {
            SaveFileDialog saveFilePath = new SaveFileDialog();
            saveFilePath.Filter = "Save Files (*.sav)|*.sav";
            
            if (saveFilePath.ShowDialog() == DialogResult.OK)
            {
                string saveFileName = saveFilePath.FileName;
                lblSaveFileLocation.Text = saveFileName;
                savePath = saveFileName;
                File.WriteAllText(saveFilePath.FileName, "");
            }
        }
    }
}