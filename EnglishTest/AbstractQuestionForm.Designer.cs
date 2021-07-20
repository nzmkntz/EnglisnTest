namespace EnglishTest
{
    partial class AbstractQuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblQuestionTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAnswerTitle = new System.Windows.Forms.Label();
            this.LblTimeLimitTitle = new System.Windows.Forms.Label();
            this.LblScoreTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSubmitAnswer = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblQuestionTitle
            // 
            this.LblQuestionTitle.AutoSize = true;
            this.LblQuestionTitle.Location = new System.Drawing.Point(27, 29);
            this.LblQuestionTitle.Name = "LblQuestionTitle";
            this.LblQuestionTitle.Size = new System.Drawing.Size(44, 18);
            this.LblQuestionTitle.TabIndex = 0;
            this.LblQuestionTitle.Text = "問題";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "XXXXXXXX";
            // 
            // LblAnswerTitle
            // 
            this.LblAnswerTitle.AutoSize = true;
            this.LblAnswerTitle.Location = new System.Drawing.Point(27, 132);
            this.LblAnswerTitle.Name = "LblAnswerTitle";
            this.LblAnswerTitle.Size = new System.Drawing.Size(44, 18);
            this.LblAnswerTitle.TabIndex = 2;
            this.LblAnswerTitle.Text = "回答";
            // 
            // LblTimeLimitTitle
            // 
            this.LblTimeLimitTitle.AutoSize = true;
            this.LblTimeLimitTitle.Location = new System.Drawing.Point(618, 29);
            this.LblTimeLimitTitle.Name = "LblTimeLimitTitle";
            this.LblTimeLimitTitle.Size = new System.Drawing.Size(80, 18);
            this.LblTimeLimitTitle.TabIndex = 3;
            this.LblTimeLimitTitle.Text = "制限時間";
            // 
            // LblScoreTitle
            // 
            this.LblScoreTitle.AutoSize = true;
            this.LblScoreTitle.Location = new System.Drawing.Point(618, 78);
            this.LblScoreTitle.Name = "LblScoreTitle";
            this.LblScoreTitle.Size = new System.Drawing.Size(44, 18);
            this.LblScoreTitle.TabIndex = 4;
            this.LblScoreTitle.Text = "点数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "XXXXXXXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "XXXXXXXX";
            // 
            // BtnSubmitAnswer
            // 
            this.BtnSubmitAnswer.Location = new System.Drawing.Point(571, 300);
            this.BtnSubmitAnswer.Name = "BtnSubmitAnswer";
            this.BtnSubmitAnswer.Size = new System.Drawing.Size(189, 72);
            this.BtnSubmitAnswer.TabIndex = 7;
            this.BtnSubmitAnswer.Text = "回答する";
            this.BtnSubmitAnswer.UseVisualStyleBackColor = true;
            this.BtnSubmitAnswer.Click += new System.EventHandler(this.BtnSubmitAnswer_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(30, 404);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(189, 34);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "やめる";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // AbstractQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSubmitAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblScoreTitle);
            this.Controls.Add(this.LblTimeLimitTitle);
            this.Controls.Add(this.LblAnswerTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblQuestionTitle);
            this.Name = "AbstractQuestionForm";
            this.Text = "AbstractQuestions";
            this.Load += new System.EventHandler(this.AbstractQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblQuestionTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAnswerTitle;
        private System.Windows.Forms.Label LblTimeLimitTitle;
        private System.Windows.Forms.Label LblScoreTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSubmitAnswer;
        private System.Windows.Forms.Button BtnCancel;
    }
}