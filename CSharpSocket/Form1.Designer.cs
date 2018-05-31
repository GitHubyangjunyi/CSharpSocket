namespace CSharpSocket
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.RichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Btn_Start);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(750, 100);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "服务器状态";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(20, 50);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(152, 18);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "无客户机请求连接";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(623, 48);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 1;
            this.Btn_Start.Text = "启动";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(12, 150);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(750, 150);
            this.RichTextBox1.TabIndex = 1;
            this.RichTextBox1.Text = "";
            // 
            // RichTextBox2
            // 
            this.RichTextBox2.Location = new System.Drawing.Point(12, 350);
            this.RichTextBox2.Name = "RichTextBox2";
            this.RichTextBox2.Size = new System.Drawing.Size(750, 150);
            this.RichTextBox2.TabIndex = 2;
            this.RichTextBox2.Text = "";
            this.RichTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RichTextBox2_KeyPress);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 129);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(89, 18);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "聊天记录:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 329);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(62, 18);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "输入框";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.RichTextBox2);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Form1";
            this.Text = "服务器端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.RichTextBox RichTextBox1;
        private System.Windows.Forms.RichTextBox RichTextBox2;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
    }
}

