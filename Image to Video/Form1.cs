using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;


namespace Image_to_Video
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd;
        List<String> imageFileNameList;

        public Form1()
        {
            InitializeComponent();
            imageFileNameList = new List<String>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // add image to image list vector
        private void addImageFileNameToList(String filePath) { imageFileNameList.Add(filePath); }

        // add image to listbox
        private void addImageFileNameToListBox(String filePath) { imgListBox.Items.Add(filePath.Substring(filePath.LastIndexOf('\\') + 1)); }

        // adds image file names to the app
        private void addImageFileName(String filePath)
        {
            addImageFileNameToList(filePath);
            addImageFileNameToListBox(filePath);
        }

        //insert images
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd1 = new OpenFileDialog();
                ofd1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                ofd1.Multiselect = true;

                if (ofd1.ShowDialog() == DialogResult.OK)    //show the dialog, and if result is ok, upload the image
                    foreach (String filePath in ofd1.FileNames)
                        addImageFileName(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //browse button
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //on click, open file dialog
                ofd = new OpenFileDialog();
                ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)    //show the dialog, and if result is ok, upload the image
                {
                    //if a single file is selected
                    if (ofd.FileNames.GetLength(0) == 1)
                        uploadText.Text = ofd.FileNames[0]; //set text in textbox
                    //if multiple files are selected
                    if (ofd.FileNames.GetLength(0) > 1)
                    {
                        // set text in textbox
                        int last_index = ofd.FileNames.GetLength(0) - 1;
                        String path = ofd.FileNames[0].Substring(0, ofd.FileNames[0].LastIndexOf('\\') + 1);
                        String first_file = ofd.FileNames[0].Substring(ofd.FileNames[0].LastIndexOf('\\') + 1);
                        String last_file = ofd.FileNames[last_index].Substring(ofd.FileNames[last_index].LastIndexOf('\\') + 1);
                        uploadText.Text = path + "\"" + first_file + "\"...\"" + last_file + "\"";
                    }

                    //update textbox of the file path
                    //uploadText.Text = ofd1.FileName;

                    //uploadText.Text = uploadText.Text.Remove(uploadText.Text.LastIndexOf('\\'));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Upload button
        private void Button2_Click(object sender, EventArgs e)
        {
            if (uploadText.Text != String.Empty)
            {
                try
                {
                    foreach (String filePath in ofd.FileNames)
                        addImageFileName(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}