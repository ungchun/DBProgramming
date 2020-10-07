using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;

namespace BasicFileIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitVariables();
        }

        private void buttonFilestreamWrite_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create));
            bw.Write(1234);
            bw.Close();
            //long someValue = 0x123456789ABCDEF0;
            //Stream outStream = new FileStream("a.dat", FileMode.Create);

            //byte[] wBytes = BitConverter.GetBytes(someValue);

            //outStream.Write(wBytes, 0, wBytes.Length);

            //outStream.Close();

        }

        private void buttonFilestreamRead_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));
            int num1 = br.ReadInt32();
            Console.WriteLine("read int result = " + num1);
            br.Close();
            //byte[] rBytes = new byte[8];

            //Stream inStream = new FileStream("a.dat", FileMode.Open);

            //inStream.Read(rBytes, 0, rBytes.Length);

            //long readValue = BitConverter.ToInt64(rBytes, 0);

            //Console.WriteLine("Read Date = " + readValue);

            //inStream.Close();
        }
        private void InitVariables()
        {
            textBoxDisplay.Text = "asdasdasdasdasd";
        }

        private void buttonBinaryWriter_Click(object sender, EventArgs e)
        {

        }

        private void buttonBinaryReader_Click(object sender, EventArgs e)
        {

        }

        private void buttonStreamWriter_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create));
            sw.WriteLine(int.MaxValue);
            sw.WriteLine("kimsunghun");
            sw.WriteLine(uint.MaxValue);
            sw.WriteLine("반갑습니다");
            sw.WriteLine(double.MaxValue);
            sw.Close();

        }

        private void buttonStreamReader_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open));
            textBoxDisplay.Text = "";
            while(sr.EndOfStream == false)
            {
                textBoxDisplay.Text += sr.ReadLine();
                textBoxDisplay.Text += "\r\n";
            }
            sr.Close();
        }
    }
}
