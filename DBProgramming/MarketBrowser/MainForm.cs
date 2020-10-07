using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MarketBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOpenCSV_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open),Encoding.Default);

            string str = "";
            while(sr.EndOfStream == false)
            {
                var line = sr.ReadLine();
                var values = line.Split(',');
                str += values [0] + "\r\n";
            }
            textBoxCSVViewer.Text = str;

            sr.Close();

        }
    }
}
