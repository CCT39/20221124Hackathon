namespace Hackathon4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGetAns = new System.Windows.Forms.Button();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btnCheckAns = new System.Windows.Forms.Button();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(444, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(344, 422);
            this.listBox1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(62, 105);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 45);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "開始遊戲";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGetAns
            // 
            this.btnGetAns.Enabled = false;
            this.btnGetAns.Location = new System.Drawing.Point(62, 156);
            this.btnGetAns.Name = "btnGetAns";
            this.btnGetAns.Size = new System.Drawing.Size(132, 45);
            this.btnGetAns.TabIndex = 2;
            this.btnGetAns.Text = "看答案";
            this.btnGetAns.UseVisualStyleBackColor = true;
            this.btnGetAns.Click += new System.EventHandler(this.btnGetAns_Click);
            // 
            // tbxInput
            // 
            this.tbxInput.Enabled = false;
            this.tbxInput.Location = new System.Drawing.Point(34, 289);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(365, 25);
            this.tbxInput.TabIndex = 3;
            // 
            // btnCheckAns
            // 
            this.btnCheckAns.Enabled = false;
            this.btnCheckAns.Location = new System.Drawing.Point(88, 333);
            this.btnCheckAns.Name = "btnCheckAns";
            this.btnCheckAns.Size = new System.Drawing.Size(134, 38);
            this.btnCheckAns.TabIndex = 4;
            this.btnCheckAns.Text = "檢查答案";
            this.btnCheckAns.UseVisualStyleBackColor = true;
            this.btnCheckAns.Click += new System.EventHandler(this.btnCheckAns_Click);
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Enabled = false;
            this.btnGiveUp.Location = new System.Drawing.Point(228, 333);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(134, 38);
            this.btnGiveUp.TabIndex = 5;
            this.btnGiveUp.Text = "放棄重來";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(42, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "輸入";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.btnCheckAns);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.btnGetAns);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGetAns;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Button btnCheckAns;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.Label label1;
    }
}

