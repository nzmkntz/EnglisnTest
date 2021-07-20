namespace EnglishTest
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.StartQuestions = new System.Windows.Forms.Button();
            this.RegisterQuestions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartQuestions
            // 
            this.StartQuestions.Location = new System.Drawing.Point(60, 59);
            this.StartQuestions.Name = "StartQuestions";
            this.StartQuestions.Size = new System.Drawing.Size(228, 65);
            this.StartQuestions.TabIndex = 0;
            this.StartQuestions.Text = "問題開始";
            this.StartQuestions.UseVisualStyleBackColor = true;
            this.StartQuestions.Click += new System.EventHandler(this.StartQuestions_Click);
            // 
            // RegisterQuestions
            // 
            this.RegisterQuestions.Location = new System.Drawing.Point(60, 166);
            this.RegisterQuestions.Name = "RegisterQuestions";
            this.RegisterQuestions.Size = new System.Drawing.Size(228, 65);
            this.RegisterQuestions.TabIndex = 1;
            this.RegisterQuestions.Text = "問題登録";
            this.RegisterQuestions.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterQuestions);
            this.Controls.Add(this.StartQuestions);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartQuestions;
        private System.Windows.Forms.Button RegisterQuestions;
    }
}

