namespace Page19_Experiment2
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPart = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPart = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(22, 31);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "学号";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "姓名";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(22, 92);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(37, 15);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "性别";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(22, 127);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 15);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "年龄";
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.Location = new System.Drawing.Point(25, 164);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(37, 15);
            this.lblPart.TabIndex = 4;
            this.lblPart.Text = "专业";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(83, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 25);
            this.txtID.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 25);
            this.txtName.TabIndex = 6;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(84, 94);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 25);
            this.txtSex.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(83, 126);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 25);
            this.txtAge.TabIndex = 8;
            // 
            // txtPart
            // 
            this.txtPart.Location = new System.Drawing.Point(83, 161);
            this.txtPart.Name = "txtPart";
            this.txtPart.Size = new System.Drawing.Size(100, 25);
            this.txtPart.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(183, 215);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(107, 265);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(31, 15);
            this.lblShow.TabIndex = 11;
            this.lblShow.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 387);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPart);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPart);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPart;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblShow;
    }
}

