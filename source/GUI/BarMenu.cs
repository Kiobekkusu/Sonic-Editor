using System.Media;
using System.Reflection;

namespace Sonic_Editor.source.GUI
{
    public static class BarMenuGUI
    {
        public static void BarMenu(Form targetForm){
            //No se me ocurre muchas cosas XD
            MenuStrip menuStrip = new MenuStrip();

            var ArchiveMenu = new ToolStripMenuItem("Archive");
            ArchiveMenu.DropDownItems.Add("New");
            ArchiveMenu.DropDownItems.Add("Save");
            ArchiveMenu.DropDownItems.Add(new ToolStripSeparator());
            ArchiveMenu.DropDownItems.Add("Exit", null, (sender, e) =>
            {
                Application.Exit();
            });

            var EditionMenu = new ToolStripMenuItem("Edition");
            EditionMenu.DropDownItems.Add("Copy");
            EditionMenu.DropDownItems.Add("Paste");
            EditionMenu.DropDownItems.Add(new ToolStripSeparator());
            EditionMenu.DropDownItems.Add("Preferences", null, (sender, e) =>
            {
                var preferences = new PreferencesWindow();
                preferences.ShowDialog();
            });

            var GameMenu = new ToolStripMenuItem("Game");
            GameMenu.DropDownItems.Add("Run");
            GameMenu.DropDownItems.Add("Debug", null, (sender, e) =>
            {
                System.Diagnostics.Process.Start("main.exe");
            });

            var HelpMenu = new ToolStripMenuItem("Help");
            HelpMenu.DropDownItems.Add("About", null, (sender, e) => 
            {
                var assembly = System.Reflection.Assembly.GetExecutingAssembly();
                using (var stream = assembly.GetManifestResourceStream("Sonic_Editor.assets.sounds.yey.wav"))
                {
                    if (stream != null)
                    {
                        var player = new System.Media.SoundPlayer(stream);
                        player.Play();
                    }
                }

                var about = new AboutWindow();
                about.ShowDialog();
            });
           

            HelpMenu.DropDownItems.Add(new ToolStripSeparator());
            HelpMenu.DropDownItems.Add("Documentation"); // En terminos de documentación, no hay documentacion al respecto.

            menuStrip.Items.Add(ArchiveMenu);
            menuStrip.Items.Add(EditionMenu);
            menuStrip.Items.Add(GameMenu);
            menuStrip.Items.Add(HelpMenu);

            targetForm.MainMenuStrip = menuStrip;
            targetForm.Controls.Add(menuStrip);
        }
    }
}