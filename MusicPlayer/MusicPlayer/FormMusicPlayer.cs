namespace MusicPlayer_WinForms.MusicPlayer
{
    using System;
    using System.Windows.Forms;
    using System.IO;

    public partial class FormMusicPlayer : Form
    {
        int Startindex = 0;
        string[] FileName, FilePath;

        public FormMusicPlayer()
        {
            InitializeComponent();
        }

        public void playfile(int playlistindex)
        {

            if (Playlist.Items.Count <= 0)
            {
                return;
            }
            if (playlistindex < 0)
            {
                return;
            }
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.URL = FilePath[playlistindex];
            axWindowsMediaPlayer1.Ctlcontrols.next();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream streamOpen = null;
            OpenFileDialog openFileDialogPlayer = new OpenFileDialog();
            openFileDialogPlayer.InitialDirectory = "C:\\";
            openFileDialogPlayer.Filter = "MP3 Audio File (*.mp3)|*.mp3| Windows Media File (*.wma)|*.wma|WAV Audio File  (*.wav)|*.wav|M3U(*.m3u) | *.m3u|All FILES (*.*)|*.*";
            openFileDialogPlayer.FilterIndex = 1;
            DialogResult result = openFileDialogPlayer.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    if ((streamOpen = openFileDialogPlayer.OpenFile()) != null)
                    {
                        using (StreamReader reader = new StreamReader(streamOpen))
                        {
                            axWindowsMediaPlayer1.URL = openFileDialogPlayer.FileName;
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void playlistToolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            Stream streamOpen = null;
            OpenFileDialog openFileDialogAdd = new OpenFileDialog();
            openFileDialogAdd.InitialDirectory = "c:\\";
            openFileDialogAdd.Filter = "MP3 Audio File (*.mp3)|*.mp3| Windows Media File (*.wma)|*.wma|WAV Audio File  (*.wav)|*.wav|M3U(*.m3u)|*.m3u|All FILES (*.*)|*.*";
            openFileDialogAdd.Multiselect = true;

            if (openFileDialogAdd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((streamOpen = openFileDialogAdd.OpenFile()) != null)
                    {
                        using (StreamReader reader = new StreamReader(streamOpen))
                        {
                            FilePath = openFileDialogAdd.FileNames;
                            FileName = openFileDialogAdd.SafeFileNames;

                            for (int i = 0; i <= FileName.Length - 1; i++)
                            {
                                Playlist.Items.Add(FileName[i]);
                            }
                            playfile(0);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }

            }
        }

        private void playlistToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() != DialogResult.Cancel)
            {
                bool isSuccess = true;
                StreamWriter sr = null;
                try
                {
                    string url = "";
                    sr = new StreamWriter(folderDialog.SelectedPath + "//" + Microsoft.VisualBasic.Interaction.InputBox("Enter the name for the playlist", "Playlist Name", "Playlist") + ".m3u");
                    foreach (Object song in Playlist.Items)
                    {
                        url = song.ToString();
                        try
                        {
                            sr.WriteLine(url);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error - " + ex.Message);
                            isSuccess = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error - " + ex.Message);
                    isSuccess = false;
                }
                finally
                {
                    if (sr != null)
                        sr.Close();
                }
                if (isSuccess)
                    MessageBox.Show("Playlist saved successfully!");
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (Startindex > 0)
            {
                Startindex = Startindex - 1;
            }

            playfile(Startindex);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (Startindex == Playlist.Items.Count - 1)
            {
                Startindex = Playlist.Items.Count - 1;
            }
            else if (Startindex < Playlist.Items.Count)
            {
                Startindex = Startindex + 1;

            }

            playfile(Startindex);
        }

        private void Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Startindex = Playlist.SelectedIndex;
            playfile(Startindex);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a music player\r\nAuthor: Philip Shishov\r\nPU FMI");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


