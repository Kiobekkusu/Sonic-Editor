using System.Reflection;
//using System.IO;
//using System.Drawing;

namespace Sonic_Editor.source.GUI
{
    public class AboutWindow : Form
    {
        public AboutWindow()
        {
            StartPosition = FormStartPosition.CenterScreen;

            Text = "Sonic Editor";
            Size = new Size(350, 220);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            var info = new Label
            {
                Text = "Fuck you :p",
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Height = 40
            };
            Controls.Add(info);

            var pic = new PictureBox
            {
                Size = new Size(100, 100),
                Location = new Point((ClientSize.Width - 100) / 2, info.Bottom),
                SizeMode = PictureBoxSizeMode.Zoom,
            };

            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream("Sonic_Editor.assets.happy.jpg"))
            {
                if (stream != null)
                    pic.Image = Image.FromStream(stream);
            }
            Controls.Add(pic);

            var kero = new Label
            {
                Text = "Te kiero mucho\nI love you much",
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Height = 40
            };
            Controls.Add(kero);
        }
    }
} 




