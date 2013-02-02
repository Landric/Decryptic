using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Decryptic
{
    public partial class MainForm : Form
    {
        OpenFileDialog openDialog = new OpenFileDialog();

        public MainForm()
        {
            InitializeComponent();

            //Initialise the frequency analysis tab
            freqChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            languageComboBox.SelectedIndex = 0;
            updateComparisonGraph();
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
                cipherTextBox.Text = File.ReadAllText(file);
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

        private void analyseButton_Click(object sender, EventArgs e)
        {
            String cipherText = cipherTextBox.Text.ToLower();

            //Perform and display frequency analysis
            SortedDictionary<Char, double> frequencyAnalysis = Analyser.frequencyAnalysis(cipherText);
            updateCipherGraph(frequencyAnalysis);

            //Calculate and display index of coincidence
                        
            //Detect and decrypt simple Caesar shift
            
            //Detect and decrypt monoalphabetic substitution
            
            //Detect and decrypt Vigenère cipher
            
            //Detect and decrypt polyalphabetic cipher
        }

        private void updateComparisonGraph()
        {
            Series series = freqChart.Series["Standard Alphabet"];
            SortedDictionary<Char, double> alphabet;

            switch (languageComboBox.SelectedIndex)
            {
                case 0: alphabet = Analyser.EnglishFreq; break;
                default: alphabet = Analyser.EnglishFreq; break;
            }

            series.Points.Clear();
            foreach (Char c in alphabet.Keys)
            {
                series.Points.AddXY(c.ToString(), alphabet[c]);
            }
        }
        private void updateCipherGraph(SortedDictionary<Char, double> frequencyAnalysis)
        {
            Series series = freqChart.Series["Cipher Text"];

            series.Points.Clear();
            foreach (Char c in frequencyAnalysis.Keys)
            {
                series.Points.AddXY(c.ToString(), frequencyAnalysis[c]);
            }
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateComparisonGraph();
        }

    }
}
