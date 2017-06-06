using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program
{
    public partial class Form1 : Form
    {
        string file; //file to classify
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog cFile = new OpenFileDialog();//open file windows
            cFile.Filter = "classify customer file|*.txt";//filter only open .txt file

            cFile.ShowDialog();

            file = cFile.FileName;
            this.txtFile.Text = cFile.FileName;//get path file

        }
    }
}
