namespace MouseClickTool
{
    partial class main
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delayVal = new System.Windows.Forms.TextBox();
            this.clickType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Label();
     
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
    
           
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delayVal);
            this.groupBox3.Controls.Add(this.clickType);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Location = new System.Drawing.Point(20, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 79);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "";
            // 
            // delayVal
            // 
            this.delayVal.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.delayVal.Location = new System.Drawing.Point(135, 36);
            this.delayVal.MaxLength = 10;
            this.delayVal.Name = "delayVal";
            this.delayVal.Size = new System.Drawing.Size(90, 25);
            this.delayVal.TabIndex = 1;
            this.delayVal.Text = "1000";
            // 
            // clickType
            // 
            this.clickType.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.clickType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clickType.FormattingEnabled = true;
            this.clickType.Items.AddRange(new object[] {
            "左键",
            "右键"});
            this.clickType.Location = new System.Drawing.Point(258, 36);
            this.clickType.Name = "clickType";
            this.clickType.Size = new System.Drawing.Size(90, 25);
            this.clickType.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(13, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "间隔(毫秒):";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("微软雅黑",8F);
            this.btnStart.Location = new System.Drawing.Point(380, 33);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 31);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(452, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "×";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Enabled = false;
            this.title.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Desktop;
            this.title.Location = new System.Drawing.Point(20, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(207, 34);
            this.title.TabIndex = 4;
            this.title.Text = "Latucc";
            // 
            // btnMin
            // 
            this.btnMin.AutoSize = true;
            this.btnMin.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMin.Location = new System.Drawing.Point(409, 19);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(37, 40);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "-";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(509, 200);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Latucc";
       
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox delayVal;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox clickType;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label btnMin;
    }
}

