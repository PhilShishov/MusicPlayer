namespace MusicPlayer_WinForms.MusicPlayer
{
    using System;
    using System.Windows.Forms;

    static class MusicPlayerApp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MusicPlayer());
        }
    }
}
