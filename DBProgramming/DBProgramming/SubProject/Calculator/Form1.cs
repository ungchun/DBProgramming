using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitVariables();
        }

        public void InitVariables()
        {
            comboBoxComboCak_Operator.Items.Add("+");
            comboBoxComboCak_Operator.Items.Add("-");
            comboBoxComboCak_Operator.Items.Add("*");
            comboBoxComboCak_Operator.Items.Add("/");

            comboBoxComboCak_Operator.SelectedIndex = 0;
        }


        private void buttonComboBoxCak_Click(object sender, EventArgs e)
        {
            String oper1_conflict_test = textBoxComboCak_Oper1.Text;
            String oper2_conflict_test = textBoxComboCak_Oper2.Text;

            int result = 0;
            String oper = "";

            // comboBox index로 사칙연산 판단해서 계산하는데 왜 conflict가 안뜨지??ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ
            switch (comboBoxComboCak_Operator.SelectedIndex)
            {
                case 0:
                    oper = "+";
                    // Convert : String -> Int
                    result = Convert.ToInt32(oper1_conflict_test) + Convert.ToInt32(oper2_conflict_test);
                    break;
                case 1:
                    oper = "-";
                    result = Convert.ToInt32(oper1_conflict_test) - Convert.ToInt32(oper2_conflict_test);
                    break;
                case 2:
                    oper = "*";
                    result = Convert.ToInt32(oper1_conflict_test) * Convert.ToInt32(oper2_conflict_test);



                    break;
                case 3:
                    oper = "/";
                    result = Convert.ToInt32(oper1_conflict_test) / Convert.ToInt32(oper2_conflict_test);



                    break;
            }

            // Int -> String 으로 변환후 Text에 set
            String stResult = Convert.ToString(result);
            textBoxComboCak_Result.Text = stResult;
        }

        private void buttonRB_Calculate_Click(object sender, EventArgs e)
        {
            String oper1_conflict = textBoxRB_Oper1.Text;
            String oper2_conflict = textBoxRB_Oper2.Text;

            double result = 0;

            // 제곱연산을 위한 변수
            int binomial = 0;
            bool binCheck = false;

            // radioBtn이 무엇인지 checked 판단해서 사칙연산 계산 ( 소수점 계산을 위해 double )
            if (radioButtonAdd.Checked)
            {
                result = Convert.ToDouble(oper1_conflict) + Convert.ToDouble(oper2_conflict);
            }
            else if(radioButtonSub.Checked)
            {
                result = Convert.ToDouble(oper1_conflict) - Convert.ToDouble(oper2_conflict);
            }
            else if (radioButtonMul.Checked)
            {
                result = Convert.ToDouble(oper1_conflict) * Convert.ToDouble(oper2_conflict);
            }
            else if(radioButtonDivi.Checked)
            {
                result = Convert.ToDouble(oper1_conflict) / Convert.ToDouble(oper2_conflict);
            }
            // 제곱연산
            else
            {
                // 2^3 이면 2를 제곱해줘야해서 따로 변수로 저장
                int num1 = Convert.ToInt32(oper1_conflict);
                binomial = num1;
                // 2^3 이면 3제곱을 해야해서 for문 사용해서 제곱계산
                for(int i = 1; i < Convert.ToInt32(oper2_conflict); i++)
                {
                    binomial *= num1;
                }
                // 제곱연산인지 사칙연산인지 판단하기위해 제곱연산이면 binCheck true 로
                binCheck = true;
            }

            // binCheck가 true 면 제곱연산 false면 사칙연산
            if (binCheck)
            {
                String binStResult = Convert.ToString(binomial);
                textBoxRB_Result.Text = binStResult;
                binCheck = false;
            }
            else
            {
                String stResult = Convert.ToString(result);
                textBoxRB_Result.Text = stResult;
            }

        }
    }
}
