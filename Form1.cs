namespace Sonic_Editor;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
        Sonic_Editor.source.GUI.TogglePrimaryGUI.AddFileExplorer(this);
        Sonic_Editor.source.GUI.BarMenuGUI.BarMenu(this);
    }
}
