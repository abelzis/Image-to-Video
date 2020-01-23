using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FFMediaToolkit.Decoding;
using FFMediaToolkit.Graphics;  // ImageData class
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;



namespace Video_Processing__AI__Machine_Learning
{
    public partial class Form1 : Form
    {
        //private OpenFileDialog ofd;
        public List<String> videoFileNameList;

        public Form1()
        {
            InitializeComponent();
            videoFileNameList = new List<string>();

            analizationPanel.Visible = false;
        }

        // Exit click
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // add image to image list vector
        private void addVideoFileNameToList(String filePath) { try
            {
                videoFileNameList.Add(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trying to add video. Error message: " + ex.Message,
                "Video add error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
        }
        
        // add image to listbox
        private void addVideoFileNameToListBox(String filePath) { videoListBox.Items.Add(filePath.Substring(filePath.LastIndexOf('\\') + 1)); }

        // adds image file names to the app
        private void addVideoFileName(String filePath)
        {
            addVideoFileNameToList(filePath);
            addVideoFileNameToListBox(filePath);
        }

        // Opens new window to add video files
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd1 = new OpenFileDialog();
                ofd1.Filter = "Video Files(*.AVI;*.WMV;*.MOV; *.MP4)|*.AVI;*.WMV;*.MOV; *.MP4|All files (*.*)|*.*";
                ofd1.Multiselect = true;

                if (ofd1.ShowDialog() == DialogResult.OK)    //show the dialog, and if result is ok, upload the video
                    foreach (String filePath in ofd1.FileNames)
                        addVideoFileName(filePath);
                ofd1.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // change information in panels when a file is selected
        private void videoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            analizationPanel.Visible = true;        // show panel
            analizationProgressBar.Visible = false; // hide progress bar

            // Display filename
            string fileName = videoListBox.SelectedItem.ToString();
            filename.Text = "Filename: " + fileName;

            // Display format
            format.Text = "Format: " + fileName.Substring(fileName.LastIndexOf('.') + 1);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Analyze button clicked => start processing video
        private void button1_Click(object sender, EventArgs e)
        {
            analizationProgressBar.Visible = true;

            try
            {
                var file = MediaFile.Open(videoFileNameList[videoListBox.SelectedIndex]);   // Open video file

                // Read file frame by frame
                for (int i = 0; i < file.Video.Info.FrameCount; i++)
                {
                    Image<Bgr24> bitmap = BitmapHelper.ToBitmap(file.Video.ReadFrame(i));    // Get frame as bitmap
                    
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error trying to open video. Error message: " + ex.Message,
                "Video open error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
        }
    }
}

