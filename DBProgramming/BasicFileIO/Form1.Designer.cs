﻿namespace BasicFileIO
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
            this.buttonFilestreamWrite = new System.Windows.Forms.Button();
            this.buttonFilestreamRead = new System.Windows.Forms.Button();
            this.buttonBinaryWriter = new System.Windows.Forms.Button();
            this.buttonBinaryReader = new System.Windows.Forms.Button();
            this.buttonStreamReader = new System.Windows.Forms.Button();
            this.buttonStreamWriter = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonFilestreamWrite
            // 
            this.buttonFilestreamWrite.Location = new System.Drawing.Point(156, 63);
            this.buttonFilestreamWrite.Name = "buttonFilestreamWrite";
            this.buttonFilestreamWrite.Size = new System.Drawing.Size(168, 48);
            this.buttonFilestreamWrite.TabIndex = 0;
            this.buttonFilestreamWrite.Text = "FileStream - Write";
            this.buttonFilestreamWrite.UseVisualStyleBackColor = true;
            this.buttonFilestreamWrite.Click += new System.EventHandler(this.buttonFilestreamWrite_Click);
            // 
            // buttonFilestreamRead
            // 
            this.buttonFilestreamRead.Location = new System.Drawing.Point(440, 63);
            this.buttonFilestreamRead.Name = "buttonFilestreamRead";
            this.buttonFilestreamRead.Size = new System.Drawing.Size(168, 48);
            this.buttonFilestreamRead.TabIndex = 1;
            this.buttonFilestreamRead.Text = "FileStream - Read";
            this.buttonFilestreamRead.UseVisualStyleBackColor = true;
            this.buttonFilestreamRead.Click += new System.EventHandler(this.buttonFilestreamRead_Click);
            // 
            // buttonBinaryWriter
            // 
            this.buttonBinaryWriter.Location = new System.Drawing.Point(156, 132);
            this.buttonBinaryWriter.Name = "buttonBinaryWriter";
            this.buttonBinaryWriter.Size = new System.Drawing.Size(168, 48);
            this.buttonBinaryWriter.TabIndex = 2;
            this.buttonBinaryWriter.Text = "BinaryWriter";
            this.buttonBinaryWriter.UseVisualStyleBackColor = true;
            this.buttonBinaryWriter.Click += new System.EventHandler(this.buttonBinaryWriter_Click);
            // 
            // buttonBinaryReader
            // 
            this.buttonBinaryReader.Location = new System.Drawing.Point(440, 132);
            this.buttonBinaryReader.Name = "buttonBinaryReader";
            this.buttonBinaryReader.Size = new System.Drawing.Size(168, 48);
            this.buttonBinaryReader.TabIndex = 3;
            this.buttonBinaryReader.Text = "BinaryReader";
            this.buttonBinaryReader.UseVisualStyleBackColor = true;
            this.buttonBinaryReader.Click += new System.EventHandler(this.buttonBinaryReader_Click);
            // 
            // buttonStreamReader
            // 
            this.buttonStreamReader.Location = new System.Drawing.Point(440, 202);
            this.buttonStreamReader.Name = "buttonStreamReader";
            this.buttonStreamReader.Size = new System.Drawing.Size(168, 48);
            this.buttonStreamReader.TabIndex = 4;
            this.buttonStreamReader.Text = "StreamReader";
            this.buttonStreamReader.UseVisualStyleBackColor = true;
            this.buttonStreamReader.Click += new System.EventHandler(this.buttonStreamReader_Click);
            // 
            // buttonStreamWriter
            // 
            this.buttonStreamWriter.Location = new System.Drawing.Point(156, 202);
            this.buttonStreamWriter.Name = "buttonStreamWriter";
            this.buttonStreamWriter.Size = new System.Drawing.Size(168, 48);
            this.buttonStreamWriter.TabIndex = 5;
            this.buttonStreamWriter.Text = "StreamWriter";
            this.buttonStreamWriter.UseVisualStyleBackColor = true;
            this.buttonStreamWriter.Click += new System.EventHandler(this.buttonStreamWriter_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(156, 290);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(452, 109);
            this.textBoxDisplay.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.buttonStreamWriter);
            this.Controls.Add(this.buttonStreamReader);
            this.Controls.Add(this.buttonBinaryReader);
            this.Controls.Add(this.buttonBinaryWriter);
            this.Controls.Add(this.buttonFilestreamRead);
            this.Controls.Add(this.buttonFilestreamWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFilestreamWrite;
        private System.Windows.Forms.Button buttonFilestreamRead;
        private System.Windows.Forms.Button buttonBinaryWriter;
        private System.Windows.Forms.Button buttonBinaryReader;
        private System.Windows.Forms.Button buttonStreamReader;
        private System.Windows.Forms.Button buttonStreamWriter;
        private System.Windows.Forms.TextBox textBoxDisplay;
    }
}

