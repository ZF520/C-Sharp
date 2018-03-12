namespace Page42_Experiment3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtPrior = new System.Windows.Forms.TextBox();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "数组空间为5，请依次输入5个数字：";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(60, 86);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(105, 15);
            this.lblNo.TabIndex = 1;
            this.lblNo.Text = "输入第1个元素";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "排序前数组序列：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "排序后数组序列:";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(182, 81);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(75, 25);
            this.txtAdd.TabIndex = 4;
            // 
            // txtPrior
            // 
            this.txtPrior.Location = new System.Drawing.Point(112, 147);
            this.txtPrior.Name = "txtPrior";
            this.txtPrior.Size = new System.Drawing.Size(100, 25);
            this.txtPrior.TabIndex = 5;
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point(112, 219);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(100, 25);
            this.txtSort.TabIndex = 6;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(306, 82);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 7;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(306, 177);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(75, 23);
            this.sort.TabIndex = 8;
            this.sort.Text = "排序";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 403);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.txtPrior);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtPrior;
        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sort;
    }
}

