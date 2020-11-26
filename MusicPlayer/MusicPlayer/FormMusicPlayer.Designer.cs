namespace MusicPlayer_WinForms.MusicPlayer
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    using AxWMPLib;

    partial class FormMusicPlayer
    {
        private IContainer components = null;

        private MenuStrip menuStripMain;
        private ToolStripMenuItem mediaToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem playlistToolStripMenuItem;
        private ToolStripMenuItem playlistToolStripMenuItemAdd;
        private ToolStripMenuItem playlistToolStripMenuItemSave;
        private ToolStripMenuItem inToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Label label1;
        private Button Play;
        private ListBox Playlist;
        private ListBox listBox2;
        private Button Pause;
        private Button Previous;
        private Button Next;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormMusicPlayer));
            this.menuStripMain = new MenuStrip();
            this.mediaToolStripMenuItem = new ToolStripMenuItem();
            this.openFileToolStripMenuItem = new ToolStripMenuItem();
            this.quitToolStripMenuItem = new ToolStripMenuItem();
            this.playlistToolStripMenuItem = new ToolStripMenuItem();
            this.playlistToolStripMenuItemAdd = new ToolStripMenuItem();
            this.playlistToolStripMenuItemSave = new ToolStripMenuItem();
            this.inToolStripMenuItem = new ToolStripMenuItem();
            this.aboutToolStripMenuItem = new ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWindowsMediaPlayer();
            this.label1 = new Label();
            this.Play = new Button();
            this.Playlist = new ListBox();
            this.listBox2 = new ListBox();
            this.Pause = new Button();
            this.Previous = new Button();
            this.Next = new Button();
            this.menuStripMain.SuspendLayout();
            ((ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new ToolStripItem[] {
            this.mediaToolStripMenuItem,
            this.playlistToolStripMenuItem,
            this.inToolStripMenuItem});
            this.menuStripMain.Location = new Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new Size(744, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new Size(52, 20);
            this.mediaToolStripMenuItem.Text = "Media";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Control | Keys.O)));
            this.openFileToolStripMenuItem.Size = new Size(180, 22);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Alt | Keys.F4)));
            this.quitToolStripMenuItem.Size = new Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.playlistToolStripMenuItemAdd,
            this.playlistToolStripMenuItemSave});
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new Size(56, 20);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // playlistToolStripMenuItemAdd
            // 
            this.playlistToolStripMenuItemAdd.Name = "playlistToolStripMenuItemAdd";
            this.playlistToolStripMenuItemAdd.ShortcutKeys = ((Keys)((Keys.Control | Keys.D)));
            this.playlistToolStripMenuItemAdd.Size = new Size(192, 22);
            this.playlistToolStripMenuItemAdd.Text = "Add to Playlist";
            this.playlistToolStripMenuItemAdd.Click += new EventHandler(this.playlistToolStripMenuItemAdd_Click);
            // 
            // playlistToolStripMenuItemSave
            // 
            this.playlistToolStripMenuItemSave.Name = "playlistToolStripMenuItemSave";
            this.playlistToolStripMenuItemSave.ShortcutKeys = ((Keys)((Keys.Control | Keys.S)));
            this.playlistToolStripMenuItemSave.Size = new Size(192, 22);
            this.playlistToolStripMenuItemSave.Text = "Save Playlist";
            this.playlistToolStripMenuItemSave.Click += new EventHandler(this.playlistToolStripMenuItemSave_Click);
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new Size(82, 20);
            this.inToolStripMenuItem.Text = "Information";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Control | Keys.A)));
            this.aboutToolStripMenuItem.Size = new Size(149, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new Point(0, 24);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new Size(343, 298);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = Color.Red;
            this.label1.Location = new Point(480, 3);
            this.label1.Name = "label1";
            this.label1.Size = new Size(59, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "PlayList";
            // 
            // Play
            // 
            this.Play.Location = new Point(364, 282);
            this.Play.Name = "Play";
            this.Play.Size = new Size(58, 40);
            this.Play.TabIndex = 5;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new EventHandler(this.Play_Click);
            // 
            // Playlist
            // 
            this.Playlist.FormattingEnabled = true;
            this.Playlist.Location = new Point(349, 24);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new Size(395, 238);
            this.Playlist.TabIndex = 6;
            this.Playlist.SelectedIndexChanged += new EventHandler(this.Playlist_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new Point(84, 50);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new Size(8, 4);
            this.listBox2.TabIndex = 7;
            // 
            // Pause
            // 
            this.Pause.Location = new Point(428, 282);
            this.Pause.Name = "Pause";
            this.Pause.Size = new Size(58, 40);
            this.Pause.TabIndex = 8;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new EventHandler(this.Pause_Click);
            // 
            // Previous
            // 
            this.Previous.Location = new Point(491, 282);
            this.Previous.Name = "Previous";
            this.Previous.Size = new Size(58, 40);
            this.Previous.TabIndex = 9;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Location = new Point(555, 282);
            this.Next.Name = "Next";
            this.Next.Size = new Size(58, 40);
            this.Next.TabIndex = 10;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new EventHandler(this.Next_Click);
            // 
            // MusicPlayer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(744, 322);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Playlist);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMusicPlayer";
            this.Text = "Music Player";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}