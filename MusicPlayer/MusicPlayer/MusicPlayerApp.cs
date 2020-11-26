namespace MusicPlayer_WinForms.MusicPlayer
{
    using System;
    using System.Windows.Forms;

    public static class MusicPlayerApp
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMusicPlayer());
        }
    }
}
