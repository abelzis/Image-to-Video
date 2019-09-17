using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Processing__AI__Machine_Learning
{
    public partial class Form1 : Form
    {
        private OpenFileDialog ofd;
        public List<String> videoFileNameList;

        public Form1()
        {
            InitializeComponent();
            videoFileNameList = new List<string>();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // add image to image list vector
        private void addImageFileNameToList(String filePath) { videoFileNameList.Add(filePath); }
        
        // add image to listbox
        private void addImageFileNameToListBox(String filePath) { videoListBox.Items.Add(filePath.Substring(filePath.LastIndexOf('\\') + 1)); }

        // adds image file names to the app
        private void addImageFileName(String filePath)
        {
            addImageFileNameToList(filePath);
            addImageFileNameToListBox(filePath);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd1 = new OpenFileDialog();
                ofd1.Filter = "Video Files(*.AVI;*.WMV;*.MOV)|*.AVI;*.WMV;*.MOV|All files (*.*)|*.*";
                ofd1.Multiselect = true;

                if (ofd1.ShowDialog() == DialogResult.OK)    //show the dialog, and if result is ok, upload the video
                    foreach (String filePath in ofd1.FileNames) ;
                        //addImageFileName(filePath);
                ofd1.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
