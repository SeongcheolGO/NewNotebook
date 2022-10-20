namespace NewNotebook
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
            this.trans = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trans
            // 
            this.trans.Location = new System.Drawing.Point(419, 123);
            this.trans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trans.Name = "trans";
            this.trans.Size = new System.Drawing.Size(132, 89);
            this.trans.TabIndex = 0;
            this.trans.Text = "전송";
            this.trans.UseVisualStyleBackColor = true;
            this.trans.Click += new System.EventHandler(this.trans_Click);
            // 
            // Error
            // 
            this.Error.Location = new System.Drawing.Point(440, 216);
            this.Error.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(111, 76);
            this.Error.TabIndex = 1;
            this.Error.Text = "오류창";
            this.Error.UseVisualStyleBackColor = true;
            this.Error.Click += new System.EventHandler(this.Error_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 300);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.trans);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button trans;
        private System.Windows.Forms.Button Error;
    }
}

