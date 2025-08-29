using System.Reflection;
using System.IO;
using System.Linq;

namespace Sonic_Editor.source.GUI
{
    public static class TogglePrimaryGUI
    {
        // Barra Izquierda
        public static void AddFileExplorer(Form targetForm)
        {
            TreeView fileTree = new TreeView();
            fileTree.Dock = DockStyle.Left;
            fileTree.Width = 250;
            //fileTree.BorderStyle = BorderStyle.None;

            var dir = new DirectoryInfo(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
            );
            while (dir != null && !dir.GetFiles("*.csproj").Any())
                dir = dir.Parent;
            string rootPath = dir?.FullName 
                ?? Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            TreeNode rootNode = new TreeNode(Path.GetFileName(rootPath));
            LoadDirectory(rootPath, rootNode);

            fileTree.Nodes.Add(rootNode);
            rootNode.Expand();
            targetForm.Controls.Add(fileTree);
            fileTree.BringToFront();
        }

        private static void LoadDirectory(string dir, TreeNode node)
        {
            foreach (string d in Directory.GetDirectories(dir))
            {
                TreeNode dirNode = new TreeNode(Path.GetFileName(d));
                LoadDirectory(d, dirNode);
                node.Nodes.Add(dirNode);
            }
            foreach (string f in Directory.GetFiles(dir))
            {
                node.Nodes.Add(new TreeNode(Path.GetFileName(f)));
            }
        }
    }
}