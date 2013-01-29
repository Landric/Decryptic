using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Decryptic
{
    public partial class MainForm : Form
    {
        OpenFileDialog openDialog = new OpenFileDialog();

        String cipherText;

        public MainForm()
        {
            InitializeComponent();
        }

        private void openFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog.Filter = "Text Document (*.txt)|*.txt|All files (*.*)|*.*";
            openDialog.Title = "Open";

            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/My Documents/";
            openDialog.RestoreDirectory = false;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                String file = openDialog.FileName;
                cipherText = File.ReadAllText(file);
                cipherTextBox.Text = cipherText;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutDecrypticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }
    }
}
