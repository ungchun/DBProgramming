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

        private List<List<string>> MakeColumnarDataStructure()
        {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open), Encoding.Default);

            string str = "";

            var line = sr.ReadLine();
            var headers = line.Split(',');

            List<List<string>> data = new List<List<string>>();
            foreach(string header in headers)
            {
                List<string> list = new List<string>();
                list.Add(header);

                data.Add(list);
        
            }

            int row = 0;
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                var values = line.Split(',');

                for (int i =0; i<values.Length; i++)
                {
                    data[i].Add(values[i]);
                }
                if (row++ == 10)
                    break;
            }

            // textBoxCSVViewer.Text = str;

            sr.Close();
            return data;
        }

        private void printColumnData_columnbased(List<List<string>> data, int columnIdx)
        {
            string str = "";
            foreach (string value in data[1])
            {
                str += value + "\r\n";
            }
            textBoxCSVViewer.Text = str;
        }

        private void printRowData_columnbased(List<List<string>> data)
        {
            string str = "";
            for (int row = 0; row <data[0].Count; row++)
            {
                foreach(List<string> list in data)
                {
                    str += list[row] + "\t";
                }
                str += "\r\n";
            }
            textBoxCSVViewer.Text = str;
        }

        private string [] parseCSVLine (string line)
        {
            string[] str = new string[11];
            string value = "";
            int index = 0;
            bool flag = false;

            foreach (char word in line)
            {
                if (word == ',' && flag == false)
                {
                    str[index] = value;
                    index++;
                    value = "";
                }
                else if (word == '"' && flag == false)
                {
                    flag = true;
                }
                else if (word == '"')
                {
                    flag = false;
                }
                else
                {
                    value += word;
                }
               
            }
            return str;
            //return line.Split(',');
        }

        Dictionary<string, int> headerIndexDict = new Dictionary<string, int>();

        private void SetHeaderList(string header)
        {
            var values = parseCSVLine(header);
            listBoxHeaders.Items.Clear();
            for(int i = 0; i < values.Length; i++)
            {
                string column = values[i];
                listBoxHeaders.Items.Add(column);
                headerIndexDict[column] = i;
            }
            //listBoxHeaders.Items.AddRange(values);
        }

        private List<List<string>> MakeRowbasedDataStructure(string filename)
        {
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open), Encoding.Default);

            var line = sr.ReadLine();
            SetHeaderList(line);

            //var headers = line.Split(',');

            List<List<string>> data = new List<List<string>>();
            
            //int row = 0;
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                //textBoxCSVViewer.Text += line;
                var values = parseCSVLine(line);

                data.Add(values.ToList());

              //  if (row++ == 10)
                //    break;
            }

            sr.Close();
            return data;
        }

        private void printRowData_rowbased(List<List<string>> data, TextBox textbox)
        {
            string str = "";
            foreach(List<string> rowlist in data)
            {
                foreach(string value in rowlist)
                {
                    str += value + "\t";
                }
                str += "\r\n";
            }
            textbox.Text = str;
        }

        private void printColumnData_rowbased(List<List<string>> data, int colIdx)
        {
            string str = "";
            foreach(List<string> rowlist in data)
            {
                str += rowlist[colIdx] + "\r\n";
            }
            textBoxCSVViewer.Text = str;
        }

        List<List<string>> data;

        private void buttonOpenCSV_Click(object sender, EventArgs e)
        {
            var FD = new OpenFileDialog();
            DialogResult dResult = FD.ShowDialog();

            if(dResult == DialogResult.OK)
            {
                string filename = FD.FileName;
                data = MakeRowbasedDataStructure(filename);
                printRowData_rowbased(data, textBoxCSVViewer);
            }

            //List<List<string>> data = MakeRowbasedDataStructure();
            //printRowData_rowbased(data);
            //printColumnData_rowbased(data, 1);

            //List<List<string>> data = MakeColumnarDataStructure();
            //printColumnData_columnbased(data, 1);
            //printRowData_columnbased(data);
        }

        private void buttonSeach_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearchKeyword.Text;
            if (keyword == "")
            {
                MessageBox.Show("검색 키워드를 입력하세요.", "확인");
                return;
            }
            
            if(listBoxHeaders.SelectedItems == null)
            {
                MessageBox.Show("검색대상 컬럼을 선택하세요.", "확인");
                return;
            }

            string column = listBoxHeaders.SelectedItem.ToString();
            if(column == "")
            {
                MessageBox.Show("검색대상 컬럼을 선택하세요.", "확인");
                return;
            }

            MessageBox.Show("키워드 = " + keyword + " 컬럼 = " + column, "확인");

            DoSearch(keyword, column);
        }

        private void DoSearch(string keyword, string column)
        {
            // 1. 대상 컬럼확인
            if(headerIndexDict.ContainsKey(column) == false)
            {
                MessageBox.Show("검색대상 컬럼을 선택하세요.", "확인");
                return;
            }
            int targetColumnIndex = headerIndexDict[column];

            // 2. 대상 컬럼에서 키워드를 포함하는지 확인
            List<List<string>> resultData = new List<List<string>>();
            foreach(List<string> row in data)
            {
                string value = row[targetColumnIndex];
                if (value.Contains(keyword))
                {
                    resultData.Add(row);
                }
            }

            printRowData_rowbased(resultData, textBoxSearchResult);
        }
    }
}
