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

namespace StudentManagerment
{
    public partial class Form1 : Form
    {
        // save 한 학생이 1인지 2인지 3인지 알기위한 토큰
        private int saveStudentToken = 0;
        // 처음 실행했을 때 학생 몇명인지 표현하기 위한 변수
        private int studentCount = 0;
        // 프로그램 실행하고 있는 중에서 저장, 삭제 했을 때 몇명인지 표현하기 위한 변수
        private int nowStudentCount = 0;

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

            if (checkBoxAutoLoad.Checked) {
                LoadStudent();
            }
        }

        // 처음 실행했을 때 파일 있는지 없는지 파악해서 count 셈
        private void InitStudentNumber()
        {
            string student_1 = @"C:\Users\leedo\source\repos\DBProgramming\StudentManagerment\bin\Debug\student.dat1";
            FileInfo fi_1 = new FileInfo(student_1);
            string student_2 = @"C:\Users\leedo\source\repos\DBProgramming\StudentManagerment\bin\Debug\student.dat2";
            FileInfo fi_2 = new FileInfo(student_2);
            string student_3 = @"C:\Users\leedo\source\repos\DBProgramming\StudentManagerment\bin\Debug\student.dat3";
            FileInfo fi_3 = new FileInfo(student_3);
            if (fi_1.Exists)
            {
                studentCount++;
            }
            if (fi_2.Exists)
            {
                studentCount++;
            }
            if (fi_3.Exists)
            {
                studentCount++;
            }
            studentNumber.Text = Convert.ToString(studentCount);
            nowStudentCount = studentCount;
        }

        // 프로그램 실행되고있는 중에 save, delete 하면 studentNumber text 변경
        private void InitNowStudentNumber()
        {
            studentNumber.Text = Convert.ToString(nowStudentCount);
        }

        // 학생 정보 불러오기
        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            saveStudentToken = 1;
            SaveStudent();
        }

        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            saveStudentToken = 2;
            SaveStudent();
        }

        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            saveStudentToken = 3;
            SaveStudent();
        }

        private void LoadStudent()
        {
            // 불러오기전에 파일이 있는지 없는지 확인해야해서 변수 세팅
            string student_1 = @"C:\Users\leedo\source\repos\DBProgramming\StudentManagerment\bin\Debug\student.dat1";
            FileInfo fi_1 = new FileInfo(student_1);
            string student_2 = @"C:\Users\leedo\source\repos\DBProgramming\StudentManagerment\bin\Debug\student.dat2";
            FileInfo fi_2 = new FileInfo(student_2);
            string student_3 = @"C:\Users\leedo\source\repos\DBProgramming\StudentManagerment\bin\Debug\student.dat3";
            FileInfo fi_3 = new FileInfo(student_3);

            // 학생1 있는지 확인 있으면 출력
            if (fi_1.Exists)
            {
                BinaryReader br1 = new BinaryReader(new FileStream("student.dat1", FileMode.Open));
                textBoxStudent1Name.Text = br1.ReadString();
                textBoxStudent1Id.Text = br1.ReadString();
                comboBoxStudent1Gender.Text = br1.ReadString();
                textBoxStudent1Memo.Text = br1.ReadString();
                br1.Close();
            }

            // 학생2 있는지 확인 있으면 출력
            if (fi_2.Exists)
            {
                BinaryReader br2 = new BinaryReader(new FileStream("student.dat2", FileMode.Open));
                textBoxStudent2Name.Text = br2.ReadString();
                textBoxStudent2Id.Text = br2.ReadString();
                comboBoxStudent2Gender.Text = br2.ReadString();
                textBoxStudent2Memo.Text = br2.ReadString();
                br2.Close();
            }
            
            // 학생3 있는지 확인 있으면 출력
            if (fi_3.Exists)
            {
                BinaryReader br3 = new BinaryReader(new FileStream("student.dat3", FileMode.Open));
                textBoxStudent3Name.Text = br3.ReadString();
                textBoxStudent3Id.Text = br3.ReadString();
                comboBoxStudent3Gender.Text = br3.ReadString();
                textBoxStudent3Memo.Text = br3.ReadString();
                br3.Close();
            }
        }


        private void SaveStudent()
        {
            // save를 어디서 했는지 token 값으로 확인해서 저장
            switch (saveStudentToken)
            {
                case 1:
                    BinaryWriter bw1 = new BinaryWriter(new FileStream("student.dat1", FileMode.Create));
                    bw1.Write(textBoxStudent1Name.Text);
                    bw1.Write(textBoxStudent1Id.Text);
                    bw1.Write(comboBoxStudent1Gender.Text);
                    bw1.Write(textBoxStudent1Memo.Text);
                    bw1.Close();
                    // 저장했으니 count++ 해주고 표시
                    nowStudentCount++;
                    InitNowStudentNumber();
                    break;
                case 2:
                    BinaryWriter bw2 = new BinaryWriter(new FileStream("student.dat2", FileMode.Create));
                    bw2.Write(textBoxStudent2Name.Text);
                    bw2.Write(textBoxStudent2Id.Text);
                    bw2.Write(comboBoxStudent2Gender.Text);
                    bw2.Write(textBoxStudent2Memo.Text);
                    bw2.Close();
                    nowStudentCount++;
                    InitNowStudentNumber();
                    break;
                case 3:
                    BinaryWriter bw3 = new BinaryWriter(new FileStream("student.dat3", FileMode.Create));
                    bw3.Write(textBoxStudent3Name.Text);
                    bw3.Write(textBoxStudent3Id.Text);
                    bw3.Write(comboBoxStudent3Gender.Text);
                    bw3.Write(textBoxStudent3Memo.Text);
                    bw3.Close();
                    nowStudentCount++;
                    InitNowStudentNumber();
                    break;
                default:
                    break;
            }

        }

        // delete는 file delete 후에 count-- 해주고 기본 세팅 및 count 표시
        private void buttonStudent1Delete_Click(object sender, EventArgs e)
        {
            File.Delete("student.dat1");
            nowStudentCount--;
            InitNowStudentNumber();
            textBoxStudent1Name.Text = "학생정보 없음";
            textBoxStudent1Id.Text = "";
            comboBoxStudent1Gender.Text = "";
            textBoxStudent1Memo.Text = "";
        }

        private void buttonStudent2Delete_Click(object sender, EventArgs e)
        {
            File.Delete("student.dat2");
            nowStudentCount--;
            InitNowStudentNumber();
            textBoxStudent2Name.Text = "학생정보 없음";
            textBoxStudent2Id.Text = "";
            comboBoxStudent2Gender.Text = "";
            textBoxStudent2Memo.Text = "";
        }

        private void buttonStudent3Delete_Click(object sender, EventArgs e)
        {
            File.Delete("student.dat3");
            nowStudentCount--;
            InitNowStudentNumber();
            textBoxStudent3Name.Text = "학생정보 없음";
            textBoxStudent3Id.Text = "";
            comboBoxStudent3Gender.Text = "";
            textBoxStudent3Memo.Text = "";
        }
    }
}
