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

namespace Folder_Analyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PathInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichBox_TextChanged(object sender, EventArgs e)
        {

        }
        int count = 0;
        private async void AnalyzeButton_Click(object sender, EventArgs e)
        {
            if (this.PathInput.Text == "")
            {
                this.RichBox.Clear();
                this.RichBox.ForeColor = Color.Red;
                this.RichBox.Text = "Path field is empty!";

                await Task.Delay(2000);
                this.RichBox.Clear();
                this.RichBox.ForeColor = Color.White;
            }
            else
            {
                string[] Videos = { ".mp4", ".avi", ".mov", ".wmv", ".flv", ".mkv" };
                string[] Docs = { ".pdf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".txt" };
                string[] Pictures = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff" };
                List<string> videoFiles = new List<string>();
                List<string> docFiles = new List<string>();
                List<string> pictureFiles = new List<string>();
                string[] files = Directory.GetFiles(PathInput.Text);
                int picturesTotal = 0;
                int docsTotal = 0;
                int videosTotal = 0;

                for (int i = 0; i < Videos.Length; i++)
                {
                    string[] vids = Directory.GetFiles(this.PathInput.Text, $"*{Videos[i]}");
                    videoFiles.AddRange(vids);
                    videosTotal++;
                }
                string[] allVideos = videoFiles.ToArray();
                int videosCount = allVideos.Length;


                for (int i = 0; i < Docs.Length; i++)
                {
                    string[] docs = Directory.GetFiles(this.PathInput.Text, $"*{Docs[i]}");
                    docFiles.AddRange(docs);
                    docsTotal++;
                }
                string[] allDocs = docFiles.ToArray();
                int docsCount = allDocs.Length;


                for (int i = 0; i < Pictures.Length; i++)
                {
                    string[] pics = Directory.GetFiles(this.PathInput.Text, $"*{Pictures[i]}");
                    pictureFiles.AddRange(pics);
                    picturesTotal++;
                }
                string[] allPictures = pictureFiles.ToArray();
                int picturesCount = allPictures.Length;

                this.RichBox.AppendText($"Total Files: {files.Length}" +
                    $"\nDocs: {docsCount}" +
                    $"\nPictures: {picturesCount}" +
                    $"\nVideos: {videosCount} \n");
                this.RichBox.AppendText(new string('-', 50));

                this.RichBox.AppendText("\n DOCS  | Copy Path: C:\\Users\\User\\Desktop\\Docs \n");
                this.RichBox.AppendText(new string('-', 50));
                for (int i = 0; i < allDocs.Length; i++)
                {
                    this.RichBox.AppendText("\n" + Path.GetFileName(allDocs[i]));
                }

                this.RichBox.AppendText("\n" + new string('-', 50));

                this.RichBox.AppendText("\n PICTURES |Copy Path: C:\\Users\\User\\Desktop\\Pictures \n");
                this.RichBox.AppendText(new string('-', 50));

                for (int i = 0; i < allPictures.Length; i++)
                {
                    this.RichBox.AppendText("\n" + Path.GetFileName(allPictures[i]));
                }

                this.RichBox.AppendText("\n" + new string('-', 50));

                this.RichBox.AppendText("\n VIDEOS |Copy Path: C:\\Users\\User\\Desktop\\Videos \n");

                this.RichBox.AppendText(new string('-', 50));

                for (int i = 0; i < allVideos.Length; i++)
                {
                    this.RichBox.AppendText($"\n {Path.GetFileName(allVideos[i])}");
                }

                string destDocs = "C:\\Users\\User\\Desktop\\Docs";
                string destPics = "C:\\Users\\User\\Desktop\\Pictures";
                string destVids = "C:\\Users\\User\\Desktop\\Videos";

                string from = this.PathInput.Text;

                for(int i = 0; i < allDocs.Length; i++)
                {
                    string DocsPath = allDocs[i];
                    string DocsNames = Path.GetFileName(DocsPath);
                    string dest = Path.Combine(destDocs, DocsNames);
                    File.Copy(DocsPath, dest, true);
                }
                for (int i = 0; i < allPictures.Length; i++)
                {
                    string picsPath = allPictures[i];
                    string picsNames = Path.GetFileName(picsPath);
                    string dest = Path.Combine(destPics, picsNames);
                    File.Copy(picsPath, dest, true);
                }
                for (int i = 0; i < allVideos.Length; i++)
                {
                    string vidPath = allVideos[i];
                    string vidNames = Path.GetFileName(vidPath);
                    string dest = Path.Combine(destVids, vidNames);
                    File.Copy(vidPath, dest, true);
                }
            }          
        }
        }
    }
