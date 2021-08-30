using Gecko;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Reader1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
           geckoWebBrowser1.Navigate("www.google.com");
        }

        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файлы pdf|*.pdf";
            openFileDialog1.ShowDialog();
            geckoWebBrowser1.Navigate( openFileDialog1.FileName);
          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
