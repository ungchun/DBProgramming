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
using MySql.Data.MySqlClient;

namespace StudentManagerment
{
    public partial class Form1 : Form
    {
        string strcoon = "Server=49.50.174.201;Database=s5414030;Uid=s5414030;Pwd=s5414030;Charset=utf8";

        public Form1()
        {
            InitializeComponent();
            InitVariables();
            InitStudentNumber();
            InitNowStudentNumber();
        }

        private void InitVariables()
        {
            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent2Gender.Items.Add("남자");
            comboBoxStudent2Gender.Items.Add("여자");

            comboBoxStudent3Gender.Items.Clear();
            string[] genderData = { "남자", "여자" };
            comboBoxStudent3Gender.Items.AddRange(genderData);

            if (checkBoxAutoLoad.Checked)
            {
                LoadStudent();
            }
        }


        int studentCount;
        private void InitStudentNumber()
        {
            studentCount = 0;
            using (MySqlConnection conn = new MySqlConnection(strcoon))
            {
                conn.Open();
                string query = "select * from student";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    studentCount++;
                }
                rdr.Close();
            }
            studentNumber.Text = Convert.ToString(studentCount);
        }


        // 프로그램 실행되고있는 중에 save, delete 하면 studentNumber text 변경
        private void InitNowStudentNumber()
        {
            //studentNumber.Text = Convert.ToString(nowStudentCount);
        }

        // 학생 정보 불러오기
        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            if(studentCount == 3)
            {
                MessageBox.Show("학생수가 3명입니다.");
                return;
            }

            string name = textBoxStudent1Name.Text;   // 이름
            string number = textBoxStudent1Id.Text; // 학번
            string gender = comboBoxStudent1Gender.Text; // 성별
            string memo = textBoxStudent1Memo.Text;   // 메모
            using (MySqlConnection conn = new MySqlConnection(strcoon))
            {
                conn.Open();
                string query = "INSERT INTO student(stu_name,stu_number,stu_gender,stu_memo) " +
                    "values(" + "'" + name + "'" + "," + "'" + number + "'" + "," + "'" + gender + "'" + "," + "'" + memo + "'" + ")";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            InitStudentNumber();
            //saveStudentToken = 1;
            //SaveStudent();
        }

        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            if (studentCount == 3)
            {
                MessageBox.Show("학생수가 3명입니다.");
                return;
            }
            string name = textBoxStudent2Name.Text;   // 이름
            string number = textBoxStudent2Id.Text; // 학번
            string gender = comboBoxStudent2Gender.Text; // 성별
            string memo = textBoxStudent2Memo.Text;   // 메모
            using (MySqlConnection conn = new MySqlConnection(strcoon))
            {
                conn.Open();
                string query = "INSERT INTO student(stu_name,stu_number,stu_gender,stu_memo) " +
                    "values(" + "'" + name + "'" + "," + "'" + number + "'" + "," + "'" + gender + "'" + "," + "'" + memo + "'" + ")";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            InitStudentNumber();
            //saveStudentToken = 2;
            //SaveStudent();
        }

        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            if (studentCount == 3)
            {
                MessageBox.Show("학생수가 3명입니다.");
                return;
            }
            string name = textBoxStudent3Name.Text;   // 이름
            string number = textBoxStudent3Id.Text; // 학번
            string gender = comboBoxStudent3Gender.Text; // 성별
            string memo = textBoxStudent3Memo.Text;   // 메모
            using (MySqlConnection conn = new MySqlConnection(strcoon))
            {
                conn.Open();
                string query = "INSERT INTO student(stu_name,stu_number,stu_gender,stu_memo) " +
                    "values(" + "'" + name + "'" + "," + "'" + number + "'" + "," + "'" + gender + "'" + "," + "'" + memo + "'" + ")";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            InitStudentNumber();
            //saveStudentToken = 3;
            //SaveStudent();
        }

        private void LoadStudent()
        {
            using (MySqlConnection conn = new MySqlConnection(strcoon))
            {
                // 학생수 count 위한 temp 변수
                int temp = 1;

                conn.Open();
                string query = "select * from student";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (temp == 1)
                    {
                        var a = rdr["stu_name"];
                        var b = rdr["stu_number"];
                        var c = rdr["stu_gender"];
                        var d = rdr["stu_memo"];
                        textBoxStudent1Name.Text = Convert.ToString(a);
                        textBoxStudent1Id.Text = Convert.ToString(b);
                        comboBoxStudent1Gender.Text = Convert.ToString(c);
                        textBoxStudent1Memo.Text = Convert.ToString(d);
                        temp++;
                    }
                    else if (temp == 2)
                    {
                        var a = rdr["stu_name"];
                        var b = rdr["stu_number"];
                        var c = rdr["stu_gender"];
                        var d = rdr["stu_memo"];
                        textBoxStudent2Name.Text = Convert.ToString(a);
                        textBoxStudent2Id.Text = Convert.ToString(b);
                        comboBoxStudent2Gender.Text = Convert.ToString(c);
                        textBoxStudent2Memo.Text = Convert.ToString(d);
                        temp++;
                    }
                    else
                    {
                        var a = rdr["stu_name"];
                        var b = rdr["stu_number"];
                        var c = rdr["stu_gender"];
                        var d = rdr["stu_memo"];
                        textBoxStudent3Name.Text = Convert.ToString(a);
                        textBoxStudent3Id.Text = Convert.ToString(b);
                        comboBoxStudent3Gender.Text = Convert.ToString(c);
                        textBoxStudent3Memo.Text = Convert.ToString(d);
                    }
                }
                rdr.Close();
            }
        }


        private void SaveStudent()
        {

        }

        // delete는 file delete 후에 count-- 해주고 기본 세팅 및 count 표시
        private void buttonStudent1Delete_Click(object sender, EventArgs e)
        {
            string number = textBoxStudent1Id.Text; // 학번
            using (MySqlConnection conn = new MySqlConnection(strcoon))
            {
                conn.Open();
                string query = "delete from student where stu_number=" + "'" + number + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            textBoxStudent1Name.Text = "학생정보 없음";
            textBoxStudent1Id.Text = "";
            comboBoxStudent1Gender.Text = "";
            textBoxStudent1Memo.Text = "";
            InitStudentNumber();
        }

        private void buttonStudent2Delete_Click(object sender, EventArgs e)
        {
            string number = textBoxStudent2Id.Text; // 학번
            using (MySqlConnection conn = new MySqlConnection(strcoon))
            {
                conn.Open();
                string query = "delete from student where stu_number=" + "'" + number + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            textBoxStudent2Name.Text = "학생정보 없음";
            textBoxStudent2Id.Text = "";
            comboBoxStudent2Gender.Text = "";
            textBoxStudent2Memo.Text = "";
            InitStudentNumber();
        }

        private void buttonStudent3Delete_Click(object sender, EventArgs e)
        {
            string number = textBoxStudent3Id.Text; // 학번
            using (MySqlConnection conn = new MySqlConnection(strcoon))
            {
                conn.Open();
                string query = "delete from student where stu_number=" + "'" + number + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            textBoxStudent3Name.Text = "학생정보 없음";
            textBoxStudent3Id.Text = "";
            comboBoxStudent3Gender.Text = "";
            textBoxStudent3Memo.Text = "";
            InitStudentNumber();
        }
    }
}
