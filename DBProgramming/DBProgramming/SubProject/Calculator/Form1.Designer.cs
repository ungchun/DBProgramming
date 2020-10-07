namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxComboCak = new System.Windows.Forms.GroupBox();
            this.buttonComboBoxCak = new System.Windows.Forms.Button();
            this.comboBoxComboCak_Operator = new System.Windows.Forms.ComboBox();
            this.textBoxComboCak_Result = new System.Windows.Forms.TextBox();
            this.textBoxComboCak_Oper2 = new System.Windows.Forms.TextBox();
            this.textBoxComboCak_Oper1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSub = new System.Windows.Forms.RadioButton();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.buttonRB_Calculate = new System.Windows.Forms.Button();
            this.textBoxRB_Result = new System.Windows.Forms.TextBox();
            this.textBoxRB_Oper2 = new System.Windows.Forms.TextBox();
            this.textBoxRB_Oper1 = new System.Windows.Forms.TextBox();
            this.radioButtonMul = new System.Windows.Forms.RadioButton();
            this.radioButtonDivi = new System.Windows.Forms.RadioButton();
            this.radioButtonBin = new System.Windows.Forms.RadioButton();
            this.groupBoxComboCak.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxComboCak
            // 
            this.groupBoxComboCak.Controls.Add(this.buttonComboBoxCak);
            this.groupBoxComboCak.Controls.Add(this.comboBoxComboCak_Operator);
            this.groupBoxComboCak.Controls.Add(this.textBoxComboCak_Result);
            this.groupBoxComboCak.Controls.Add(this.textBoxComboCak_Oper2);
            this.groupBoxComboCak.Controls.Add(this.textBoxComboCak_Oper1);
            this.groupBoxComboCak.Controls.Add(this.label1);
            this.groupBoxComboCak.Controls.Add(this.label2);
            this.groupBoxComboCak.Controls.Add(this.label4);
            this.groupBoxComboCak.Controls.Add(this.label3);
            this.groupBoxComboCak.Location = new System.Drawing.Point(44, 46);
            this.groupBoxComboCak.Name = "groupBoxComboCak";
            this.groupBoxComboCak.Size = new System.Drawing.Size(600, 115);
            this.groupBoxComboCak.TabIndex = 0;
            this.groupBoxComboCak.TabStop = false;
            this.groupBoxComboCak.Text = "Combobox based Calculator";
            // 
            // buttonComboBoxCak
            // 
            this.buttonComboBoxCak.Location = new System.Drawing.Point(359, 66);
            this.buttonComboBoxCak.Name = "buttonComboBoxCak";
            this.buttonComboBoxCak.Size = new System.Drawing.Size(75, 23);
            this.buttonComboBoxCak.TabIndex = 1;
            this.buttonComboBoxCak.Text = "Calculate";
            this.buttonComboBoxCak.UseVisualStyleBackColor = true;
            this.buttonComboBoxCak.Click += new System.EventHandler(this.buttonComboBoxCak_Click);
            // 
            // comboBoxComboCak_Operator
            // 
            this.comboBoxComboCak_Operator.FormattingEnabled = true;
            this.comboBoxComboCak_Operator.Location = new System.Drawing.Point(122, 67);
            this.comboBoxComboCak_Operator.Name = "comboBoxComboCak_Operator";
            this.comboBoxComboCak_Operator.Size = new System.Drawing.Size(121, 20);
            this.comboBoxComboCak_Operator.TabIndex = 1;
            // 
            // textBoxComboCak_Result
            // 
            this.textBoxComboCak_Result.Location = new System.Drawing.Point(440, 66);
            this.textBoxComboCak_Result.Name = "textBoxComboCak_Result";
            this.textBoxComboCak_Result.Size = new System.Drawing.Size(100, 21);
            this.textBoxComboCak_Result.TabIndex = 6;
            // 
            // textBoxComboCak_Oper2
            // 
            this.textBoxComboCak_Oper2.Location = new System.Drawing.Point(249, 66);
            this.textBoxComboCak_Oper2.Name = "textBoxComboCak_Oper2";
            this.textBoxComboCak_Oper2.Size = new System.Drawing.Size(100, 21);
            this.textBoxComboCak_Oper2.TabIndex = 5;
            // 
            // textBoxComboCak_Oper1
            // 
            this.textBoxComboCak_Oper1.Location = new System.Drawing.Point(6, 66);
            this.textBoxComboCak_Oper1.Name = "textBoxComboCak_Oper1";
            this.textBoxComboCak_Oper1.Size = new System.Drawing.Size(100, 21);
            this.textBoxComboCak_Oper1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operand 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Operand 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonBin);
            this.groupBox1.Controls.Add(this.radioButtonDivi);
            this.groupBox1.Controls.Add(this.radioButtonMul);
            this.groupBox1.Controls.Add(this.radioButtonSub);
            this.groupBox1.Controls.Add(this.radioButtonAdd);
            this.groupBox1.Controls.Add(this.buttonRB_Calculate);
            this.groupBox1.Controls.Add(this.textBoxRB_Result);
            this.groupBox1.Controls.Add(this.textBoxRB_Oper2);
            this.groupBox1.Controls.Add(this.textBoxRB_Oper1);
            this.groupBox1.Location = new System.Drawing.Point(44, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radio button Calculator";
            // 
            // radioButtonSub
            // 
            this.radioButtonSub.AutoSize = true;
            this.radioButtonSub.Location = new System.Drawing.Point(132, 70);
            this.radioButtonSub.Name = "radioButtonSub";
            this.radioButtonSub.Size = new System.Drawing.Size(29, 16);
            this.radioButtonSub.TabIndex = 9;
            this.radioButtonSub.TabStop = true;
            this.radioButtonSub.Text = "-";
            this.radioButtonSub.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(132, 48);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(29, 16);
            this.radioButtonAdd.TabIndex = 8;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "+";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRB_Calculate
            // 
            this.buttonRB_Calculate.Location = new System.Drawing.Point(359, 48);
            this.buttonRB_Calculate.Name = "buttonRB_Calculate";
            this.buttonRB_Calculate.Size = new System.Drawing.Size(75, 23);
            this.buttonRB_Calculate.TabIndex = 7;
            this.buttonRB_Calculate.Text = "Calculate";
            this.buttonRB_Calculate.UseVisualStyleBackColor = true;
            this.buttonRB_Calculate.Click += new System.EventHandler(this.buttonRB_Calculate_Click);
            // 
            // textBoxRB_Result
            // 
            this.textBoxRB_Result.Location = new System.Drawing.Point(440, 50);
            this.textBoxRB_Result.Name = "textBoxRB_Result";
            this.textBoxRB_Result.Size = new System.Drawing.Size(100, 21);
            this.textBoxRB_Result.TabIndex = 2;
            // 
            // textBoxRB_Oper2
            // 
            this.textBoxRB_Oper2.Location = new System.Drawing.Point(249, 48);
            this.textBoxRB_Oper2.Name = "textBoxRB_Oper2";
            this.textBoxRB_Oper2.Size = new System.Drawing.Size(100, 21);
            this.textBoxRB_Oper2.TabIndex = 1;
            // 
            // textBoxRB_Oper1
            // 
            this.textBoxRB_Oper1.Location = new System.Drawing.Point(6, 48);
            this.textBoxRB_Oper1.Name = "textBoxRB_Oper1";
            this.textBoxRB_Oper1.Size = new System.Drawing.Size(100, 21);
            this.textBoxRB_Oper1.TabIndex = 0;
            // 
            // radioButtonMul
            // 
            this.radioButtonMul.AutoSize = true;
            this.radioButtonMul.Location = new System.Drawing.Point(168, 47);
            this.radioButtonMul.Name = "radioButtonMul";
            this.radioButtonMul.Size = new System.Drawing.Size(29, 16);
            this.radioButtonMul.TabIndex = 10;
            this.radioButtonMul.TabStop = true;
            this.radioButtonMul.Text = "*";
            this.radioButtonMul.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivi
            // 
            this.radioButtonDivi.AutoSize = true;
            this.radioButtonDivi.Location = new System.Drawing.Point(167, 70);
            this.radioButtonDivi.Name = "radioButtonDivi";
            this.radioButtonDivi.Size = new System.Drawing.Size(29, 16);
            this.radioButtonDivi.TabIndex = 11;
            this.radioButtonDivi.TabStop = true;
            this.radioButtonDivi.Text = "/";
            this.radioButtonDivi.UseVisualStyleBackColor = true;
            // 
            // radioButtonBin
            // 
            this.radioButtonBin.AutoSize = true;
            this.radioButtonBin.Location = new System.Drawing.Point(203, 47);
            this.radioButtonBin.Name = "radioButtonBin";
            this.radioButtonBin.Size = new System.Drawing.Size(29, 16);
            this.radioButtonBin.TabIndex = 12;
            this.radioButtonBin.TabStop = true;
            this.radioButtonBin.Text = "^";
            this.radioButtonBin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxComboCak);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.groupBoxComboCak.ResumeLayout(false);
            this.groupBoxComboCak.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxComboCak;
        private System.Windows.Forms.Button buttonComboBoxCak;
        private System.Windows.Forms.ComboBox comboBoxComboCak_Operator;
        private System.Windows.Forms.TextBox textBoxComboCak_Result;
        private System.Windows.Forms.TextBox textBoxComboCak_Oper2;
        private System.Windows.Forms.TextBox textBoxComboCak_Oper1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSub;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.Button buttonRB_Calculate;
        private System.Windows.Forms.TextBox textBoxRB_Result;
        private System.Windows.Forms.TextBox textBoxRB_Oper2;
        private System.Windows.Forms.TextBox textBoxRB_Oper1;
        private System.Windows.Forms.RadioButton radioButtonMul;
        private System.Windows.Forms.RadioButton radioButtonDivi;
        private System.Windows.Forms.RadioButton radioButtonBin;
    }
}

