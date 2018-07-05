using archive_all_images.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archive_all_images
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            textbox_filepath.AutoSize = false;
            textbox_filepath.Height = 20;
        }

        private void textbox_filepath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textbox_filepath.Text)) return;

            var folderDialog = new FolderBrowserDialog
            {
                Description = "please select the folder"
            };
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                textbox_filepath.Text = folderDialog.SelectedPath;
                folderDialog.Reset();
            }
            else label1.Focus();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbox_filepath.Text))
            {
                MessageBox.Show("please select input first");
                return;
            }

            var archivePath = textbox_filepath.Text + "_archive";
            if (!Directory.Exists(archivePath)) Directory.CreateDirectory(archivePath);
            progress_.Maximum = 0;
            label_status.Text = "let's find all images...";
            button_start.Enabled = false;
            button_reset.Enabled = false;

            var task = Task.Run(() =>
            {
                var foundFiles = new List<string>();
                ArchiveImage(textbox_filepath.Text, foundFiles);
                return foundFiles;
            });
            var awaiter = task.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                var foundFiles = awaiter.GetResult();
                label_status.Text = foundFiles.Count + " images has been archived!!!";
                progress_.Maximum = foundFiles.Count;
                progress_.Step = 1;

                foreach (var file in foundFiles)
                {
                    using (var fileStream = File.OpenRead(file))
                    {
                        var fileName = Path.GetFileName(file);
                        var originType = Path.GetExtension(file);
                        var result = checker.GetFileType(fileStream);
                        if (string.IsNullOrEmpty(result.Extension)) continue;

                        if (string.IsNullOrEmpty(originType)) fileName += result.Extension;
                        else fileName = fileName.Replace(originType, result.Extension);

                        var copyPath = Path.Combine(archivePath, fileName);
                        if (File.Exists(copyPath))
                        {
                            var insertIndex = fileName.IndexOf(result.Extension);
                            copyPath = Path.Combine(archivePath, fileName.Insert(insertIndex, "_" + Guid.NewGuid()));
                        }
                        File.Copy(file, copyPath);
                    }
                    progress_.PerformStep();
                }

                MessageBox.Show("complete!");
                button_start.Enabled = true;
                button_reset.Enabled = true;
            });
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textbox_filepath.Text = "";
        }

        FileTypeChecker checker = new FileTypeChecker();
        void ArchiveImage(string folderPath, List<string> foundFiles)
        {
            if (Directory.Exists(folderPath))
            {
                var files = Directory.GetFiles(folderPath);
                var folders = Directory.GetDirectories(folderPath);

                foreach (var file in files)
                {
                    using (var fileStream = File.OpenRead(file))
                    {
                        var fileName = Path.GetFileName(file);
                        var originType = Path.GetExtension(file);
                        var result = checker.GetFileType(fileStream);
                        if (string.IsNullOrEmpty(result.Extension)) continue;

                        foundFiles.Add(file);
                    }
                }

                foreach (var folder in folders)
                {
                    ArchiveImage(folder, foundFiles);
                }
            }
        }
    }
}
