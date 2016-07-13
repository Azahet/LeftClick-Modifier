using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace LeftClick_Modifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string t = "";
        public static string chemin = @"";
        private void thirteenButton3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            var OurKey = Registry.ClassesRoot;
            OurKey = OurKey.OpenSubKey(@"*\shell", true);
            GetSubKeys(OurKey);
        }

        private void thirteenButton1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                chemin = openFileDialog1.FileName;
            }
        }

        private void thirteenButton2_Click(object sender, EventArgs e)
        {
            var filenameNoExtension = Path.GetFileNameWithoutExtension(chemin);
            var key = Registry.ClassesRoot.OpenSubKey("*\\shell", true);
            key.CreateSubKey(filenameNoExtension);
            key = key.OpenSubKey(filenameNoExtension, true);
            key.CreateSubKey("command");
            key.SetValue("", "Ouvrir avec " + filenameNoExtension, RegistryValueKind.String);
            key.SetValue("Icon", chemin, RegistryValueKind.String);
            key = key.OpenSubKey("command", true);
            key.SetValue("", "\"" + chemin + "\" \"%1\"", RegistryValueKind.String);
            var prcChecker = Process.GetProcessesByName("explorer");
            prcChecker[0].Kill();
        }
        private void GetSubKeys(RegistryKey SubKey)
        {
            foreach (var sub in SubKey.GetSubKeyNames())
            {
                if (t != "")
                {
                    treeView1.Nodes[t].Nodes.Add(sub);
                }
                else
                {
                    treeView1.Nodes.Add(sub, sub);
                }
                var local = Registry.Users;
                local = SubKey.OpenSubKey(sub, true);
                t = sub;
                GetSubKeys(local);
                t = "";
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registry.ClassesRoot.OpenSubKey("*\\shell", true).DeleteSubKeyTree(treeView1.SelectedNode.Name);
            treeView1.Nodes.Clear();
            var OurKey = Registry.ClassesRoot;
            OurKey = OurKey.OpenSubKey(@"*\shell", true);
            GetSubKeys(OurKey);
        }
    }
}
