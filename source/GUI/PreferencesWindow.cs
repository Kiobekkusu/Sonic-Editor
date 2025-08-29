namespace Sonic_Editor.source.GUI
{
    public class PreferencesWindow : Form
    {
        public PreferencesWindow()
        {
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new System.Drawing.Size(600, 400);

            var ComingSoonText = new Label
            {
                Text = "Coming Soon...",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
            };
            Controls.Add(ComingSoonText);
        }
    }
}
