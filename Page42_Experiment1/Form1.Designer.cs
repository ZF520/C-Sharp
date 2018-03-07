namespace Page42_Experiment1
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
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(32, 46);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 25);
            this.txtCelsius.TabIndex = 0;
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(138, 49);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(52, 15);
            this.lblFahrenheit.TabIndex = 1;
            this.lblFahrenheit.Text = "摄氏度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "<==>";
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(371, 49);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(52, 15);
            this.lblCelsius.TabIndex = 3;
            this.lblCelsius.Text = "华氏度";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(254, 46);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 25);
            this.txtFahrenheit.TabIndex = 4;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(190, 101);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "转换";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 419);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.txtCelsius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnChange;
    }
}

