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
        // 학생수 3명 count할 변수
        int studentCount;
        // 어디부분에서 save 버튼 눌렀는지 확인하는 token
        int saveStudentToken;
        // reset할 부분
        int textFlag;
        // strcoon
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
            // init comboBox
            comboBoxStudent1Gender.Items.Clear();
            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent3Gender.Items.Clear();
            string[] genderData = { "남자", "여자" };
            comboBoxStudent1Gender.Items.AddRange(genderData);
            comboBoxStudent2Gender.Items.AddRange(genderData);
            comboBoxStudent3Gender.Items.AddRange(genderData);
            //

            // autoLoad Check 확인
            if (checkBoxAutoLoad.Checked)
            {
                LoadStudent();
            }
        }

        private int checkStudentCount()
        {
            if (studentCount == 3)
            {
                MessageBox.Show("학생수가 3명입니다.");
                return 0;
            }
            return 1;
        }


        private void InitStudentNumber()
        {
            studentCount = 0;
            
            // using 메서드 만들기 전부다
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

        private void resetText(int textFlag)
        {
            switch (textFlag)
            {
                case 1:
                    textBoxStudent1Name.Text = "학생정보 없음";
                    textBoxStudent1Id.Text = "";
                    comboBoxStudent1Gender.Text = "";
                    textBoxStudent1Memo.Text = "";
                    break;
                case 2:
                    textBoxStudent2Name.Text = "학생정보 없음";
                    textBoxStudent2Id.Text = "";
                    comboBoxStudent2Gender.Text = "";
                    textBoxStudent2Memo.Text = "";
                    break;
                case 3:
                    textBoxStudent3Name.Text = "학생정보 없음";
                    textBoxStudent3Id.Text = "";
                    comboBoxStudent3Gender.Text = "";
                    textBoxStudent3Memo.Text = "";
                    break;
                case 4:
                    textBoxStudent1Name.Text = "학생정보 없음";
                    textBoxStudent1Id.Text = "";
                    comboBoxStudent1Gender.Text = "";
                    textBoxStudent1Memo.Text = "";

                    textBoxStudent2Name.Text = "학생정보 없음";
                    textBoxStudent2Id.Text = "";
                    comboBoxStudent2Gender.Text = "";
                    textBoxStudent2Memo.Text = "";

                    textBoxStudent3Name.Text = "학생정보 없음";
                    textBoxStudent3Id.Text = "";
                    comboBoxStudent3Gender.Text = "";
                    textBoxStudent3Memo.Text = "";
                    break;
                default:
                    break;
            }
        }

        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            if (checkStudentCount() == 0)
            {
                return;
            }
            saveStudentToken = 1;
            SaveStudent();
        }

        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            if (checkStudentCount() == 0)
            {
                return;
            }
            saveStudentToken = 2;
            SaveStudent();
        }

        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            if (checkStudentCount() == 0)
            {
                return;
            }
            saveStudentToken = 3;
            SaveStudent();
        }

        private void LoadStudent()
        {
            // 전부다 reset -> 4
            textFlag = 4;
            resetText(textFlag);

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
                        string a = rdr["stu_name"].ToString();
                        string b = rdr["stu_number"].ToString();
                        string c = rdr["stu_gender"].ToString();
                        string d = rdr["stu_memo"].ToString();
                        textBoxStudent1Name.Text = a;
                        textBoxStudent1Id.Text = b;
                        comboBoxStudent1Gender.Text = c;
                        textBoxStudent1Memo.Text = d;
                        temp++;
                    }
                    else if (temp == 2)
                    {
                        string a = rdr["stu_name"].ToString();
                        string b = rdr["stu_number"].ToString();
                        string c = rdr["stu_gender"].ToString();
                        string d = rdr["stu_memo"].ToString();
                        textBoxStudent2Name.Text = a;
                        textBoxStudent2Id.Text = b;
                        comboBoxStudent2Gender.Text = c;
                        textBoxStudent2Memo.Text = d;
                        temp++;
                    }
                    else
                    {
                        string a = rdr["stu_name"].ToString();
                        string b = rdr["stu_number"].ToString();
                        string c = rdr["stu_gender"].ToString();
                        string d = rdr["stu_memo"].ToString();
                        textBoxStudent3Name.Text = a;
                        textBoxStudent3Id.Text = b;
                        comboBoxStudent3Gender.Text = c;
                        textBoxStudent3Memo.Text = d;
                    }
                }
                rdr.Close();
            }
        }

        // 저장할때 학번 비교해서 같은거 있으면 저장 x 예외처리
        // 저장할때 공백이면 저장 x
        private void SaveStudent()
        {
            string name;
            string number;
            string gender;
            string memo;

            switch (saveStudentToken) {
                case 1:
                    name = textBoxStudent1Name.Text;   // 이름
                    number = textBoxStudent1Id.Text; // 학번
                    gender = comboBoxStudent1Gender.Text; // 성별
                    memo = textBoxStudent1Memo.Text;   // 메모
                    if(name=="" || number ==""|| gender == "")
                    {
                        MessageBox.Show("공백을 채워주세요");
                        return;
                    }
                    using (MySqlConnection conn = new MySqlConnection(strcoon))
                    {
                        conn.Open();
                        string query = "INSERT INTO student(stu_name,stu_number,stu_gender,stu_memo) " +
                            "values(" + "'" + name + "'" + "," + "'" + number + "'" + "," + "'" + gender + "'" + "," + "'" + memo + "'" + ")";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                    }
                    break;
                case 2:
                    name = textBoxStudent2Name.Text;   // 이름
                    number = textBoxStudent2Id.Text; // 학번
                    gender = comboBoxStudent2Gender.Text; // 성별
                    memo = textBoxStudent2Memo.Text;   // 메모
                    if (name == "" || number == "" || gender == "")
                    {
                        MessageBox.Show("공백을 채워주세요");
                        return;
                    }
                    using (MySqlConnection conn = new MySqlConnection(strcoon))
                    {
                        conn.Open();
                        string query = "INSERT INTO student(stu_name,stu_number,stu_gender,stu_memo) " +
                            "values(" + "'" + name + "'" + "," + "'" + number + "'" + "," + "'" + gender + "'" + "," + "'" + memo + "'" + ")";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                    }
                    break;
                case 3:
                    name = textBoxStudent3Name.Text;   // 이름
                    number = textBoxStudent3Id.Text; // 학번
                    gender = comboBoxStudent3Gender.Text; // 성별
                    memo = textBoxStudent3Memo.Text;   // 메모
                    if (name == "" || number == "" || gender == "")
                    {
                        MessageBox.Show("공백을 채워주세요");
                        return;
                    }
                    using (MySqlConnection conn = new MySqlConnection(strcoon))
                    {
                        conn.Open();
                        string query = "INSERT INTO student(stu_name,stu_number,stu_gender,stu_memo) " +
                            "values(" + "'" + name + "'" + "," + "'" + number + "'" + "," + "'" + gender + "'" + "," + "'" + memo + "'" + ")";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                    }
                    break;
                default:
                    break;
            }
            InitStudentNumber();
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
            // 학생 1 delete 후 reset
            textFlag = 1;
            resetText(textFlag);
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
            // 학생 2 delete 후 reset
            textFlag = 2;
            resetText(textFlag);
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
            // 학생 3 delete 후 reset
            textFlag = 3;
            resetText(textFlag);
            InitStudentNumber();
        }
    }
}
