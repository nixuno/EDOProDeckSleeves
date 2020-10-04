using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace EDOProDeckSleeves
{
    public partial class Form1 : Form
    {
        List<Sleeve> sleeves;
        readonly string sleevesFolderPath = $@"{AppDomain.CurrentDomain.BaseDirectory}\sleeves";
        readonly string conversionFolderPath = $@"{AppDomain.CurrentDomain.BaseDirectory}\convert";
        readonly string projectIgnisFolderPath = @"C:\ProjectIgnis\textures";
        public Form1() {
            InitializeComponent();
            //If we can't find the EDOPro textures folder, it probably isn't installed.
            listBox_playerSleeve.KeyUp += ListBox_playerSleeve_KeyUp;
            listBox_opponentSleeve.KeyUp += ListBox_opponentSleeve_KeyUp;
            if(!System.IO.Directory.Exists(projectIgnisFolderPath)) {
                DialogResult goToDiscord = MessageBox.Show("Looks like EDOPro isn't installed. Would you like to open the EDOPro Discord to download it?", "EDOPro Missing", MessageBoxButtons.YesNo);
                if(goToDiscord == DialogResult.Yes) {
                    System.Diagnostics.Process.Start(@"https://discord.gg/ygopro-percy");
                }
                Environment.Exit(0);
            } else {
                PopulateSleeveLists();
            }
        }

        private void PopulateSleeveLists() {
            System.IO.Directory.CreateDirectory(sleevesFolderPath);
            DirectoryInfo sleevesDirectory = new DirectoryInfo(sleevesFolderPath);
            sleeves = new List<Sleeve>();
            FileInfo[] sleeveFileInfos = sleevesDirectory.GetFiles("*.png");
            foreach(FileInfo sleeveFileInfo in sleeveFileInfos) {
                sleeves.Add(new Sleeve(sleeveFileInfo));
            }
            listBox_playerSleeve.ClearSelected();
            listBox_playerSleeve.Items.Clear();
            listBox_playerSleeve.Items.AddRange(sleeves.ToArray());
            listBox_playerSleeve.DisplayMember = "BaseName";

            listBox_opponentSleeve.ClearSelected();
            listBox_opponentSleeve.Items.Clear();
            listBox_opponentSleeve.Items.AddRange(sleeves.ToArray());
            listBox_opponentSleeve.DisplayMember = "BaseName";
        }

        private void ListBox_playerSleeve_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox_playerSleeve.SelectedIndex > -1) {
                Sleeve selectedSleeve = (Sleeve)listBox_playerSleeve.Items[listBox_playerSleeve.SelectedIndex];
                using (Bitmap selectedSleeveBitmap = new Bitmap(selectedSleeve.FullName)) {
                    pictureBox_player.Image = new Bitmap(selectedSleeveBitmap);
                }
                System.IO.File.Copy($@"{projectIgnisFolderPath}\cover.png", $@"{projectIgnisFolderPath}\cover.bak.png", true);
                System.IO.File.Copy(selectedSleeve.FullName, $@"{projectIgnisFolderPath}\cover.png", true);
            }
        }

        private void ListBox_playerSleeve_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete && listBox_playerSleeve.SelectedIndex > -1) {
                Sleeve selectedSleeve = (Sleeve)listBox_playerSleeve.Items[listBox_playerSleeve.SelectedIndex];
                System.IO.File.Delete(selectedSleeve.FullName);
                PopulateSleeveLists();
            }
        }

        private void ListBox_opponentSleeve_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox_opponentSleeve.SelectedIndex > -1) {
                Sleeve selectedSleeve = (Sleeve)listBox_opponentSleeve.Items[listBox_opponentSleeve.SelectedIndex];
                using (Bitmap selectedSleeveBitmap = new Bitmap(selectedSleeve.FullName)) {
                    pictureBox_opponent.Image = new Bitmap(selectedSleeveBitmap);
                }
                System.IO.File.Copy($@"{projectIgnisFolderPath}\cover2.png", $@"{projectIgnisFolderPath}\cover2.bak.png", true);
                System.IO.File.Copy(selectedSleeve.FullName, $@"{projectIgnisFolderPath}\cover2.png", true);
            }
        }

        private void ListBox_opponentSleeve_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete && listBox_opponentSleeve.SelectedIndex > -1) {
                Sleeve selectedSleeve = (Sleeve)listBox_opponentSleeve.Items[listBox_opponentSleeve.SelectedIndex];
                System.IO.File.Delete(selectedSleeve.FullName);
                PopulateSleeveLists();
            }
        }

        private void Button_AddSleeve_Click(object sender, EventArgs e) {
            OpenFileDialog sleeveFileDialog = new OpenFileDialog {
                Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.tif;*.tiff;*.png",
                Multiselect = true
            };
            sleeveFileDialog.ShowDialog();
            string[] selectedFiles = sleeveFileDialog.FileNames;
            if (selectedFiles.Length > 0) {
                foreach (string selectedFile in selectedFiles) {
                    FileInfo selectedFileInfo = new FileInfo(selectedFile);
                    string fileName = Path.GetFileName(selectedFile);
                    string fileBaseName = Path.GetFileNameWithoutExtension(selectedFile);
                    string fileExtension = Path.GetExtension(selectedFile);

                    //The path to copy from.
                    string sourceCopyPath = selectedFile;

                    //Where to copy to.
                    string targetCopyPath = $@"{sleevesFolderPath}\{fileName}";

                    //Convert to .png if it isn't one.
                    if (!fileExtension.Equals(".png")) {
                        //FileStream stream = new FileStream(selectedFile, FileMode.Open);
                        string convertedImagePath = $@"{conversionFolderPath}\{fileBaseName}.png";
                        System.IO.Directory.CreateDirectory(conversionFolderPath);
                        using (MemoryStream memoryStream = new MemoryStream()) {
                            Bitmap originalImage = new Bitmap(selectedFile);     
                            originalImage.Save(memoryStream, ImageFormat.Png);
                            using (FileStream fileStream = new FileStream(convertedImagePath, FileMode.Create, FileAccess.ReadWrite)) {
                                byte[] bytes = memoryStream.ToArray();
                                fileStream.Write(bytes, 0, bytes.Length);
                            }
                            sourceCopyPath = convertedImagePath;
                            targetCopyPath = $@"{sleevesFolderPath}\{fileBaseName}.png";
                        }
                    }
                    
                    if (System.IO.File.Exists(targetCopyPath)) {
                        DialogResult overwriteDecision = MessageBox.Show($"A sleeve named \"{fileBaseName}\" already exists. Do you want to overwrite?", "Existing Sleeve Found", MessageBoxButtons.YesNo);
                        if (overwriteDecision == DialogResult.Yes) {
                            System.IO.File.Copy(sourceCopyPath, targetCopyPath, true);
                        }
                    } else {
                        System.IO.File.Copy(sourceCopyPath, targetCopyPath, false);
                    }
                }
                PopulateSleeveLists();
            }
        }

        private void Button_resetToDefaultSleeve_Click(object sender, EventArgs e) {
            Bitmap defaultPlayer = EDOProDeckSleeves.Properties.Resources.starterPlayer;
            defaultPlayer.Save($@"{projectIgnisFolderPath}\cover.png");
            pictureBox_player.Image = defaultPlayer;

            Bitmap defaultOpponent = EDOProDeckSleeves.Properties.Resources.starterOpponent;            
            defaultOpponent.Save($@"{projectIgnisFolderPath}\cover2.png");
            pictureBox_opponent.Image = defaultOpponent;
        }

        private void Button_duel_Click(object sender, EventArgs e) {
            Stream str = EDOProDeckSleeves.Properties.Resources.its_time_to_duel;
            SoundPlayer sp = new SoundPlayer(str);
            sp.Play();
        }

        public class Sleeve {
            public string FullName { get; set; }
            public string BaseName { get; set; }
            public string Name { get; set; }
            public Sleeve(FileInfo sleeveFileInfo) {
                FullName = sleeveFileInfo.FullName;
                BaseName = Path.GetFileNameWithoutExtension(sleeveFileInfo.FullName);
                Name = sleeveFileInfo.Name;
            }
        }
    }
}
