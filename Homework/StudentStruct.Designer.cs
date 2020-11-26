namespace Homework
{
    partial class StudentStruct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butSave = new System.Windows.Forms.Button();
            this.butShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCompare = new System.Windows.Forms.TextBox();
            this.txtgrade = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(67, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(138, 69);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 35);
            this.txtName.TabIndex = 1;
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChi.Location = new System.Drawing.Point(138, 128);
            this.txtChi.Multiline = true;
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(123, 35);
            this.txtChi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(67, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "國文:";
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEng.Location = new System.Drawing.Point(138, 189);
            this.txtEng.Multiline = true;
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(123, 35);
            this.txtEng.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(67, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "英文:";
            // 
            // txtMat
            // 
            this.txtMat.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMat.Location = new System.Drawing.Point(138, 261);
            this.txtMat.Multiline = true;
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(123, 35);
            this.txtMat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(67, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "數學:";
            // 
            // butSave
            // 
            this.butSave.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butSave.Location = new System.Drawing.Point(71, 338);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(117, 47);
            this.butSave.TabIndex = 8;
            this.butSave.Text = "儲存";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butShow
            // 
            this.butShow.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butShow.Location = new System.Drawing.Point(214, 338);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(150, 47);
            this.butShow.TabIndex = 9;
            this.butShow.Text = "顯示儲存資料";
            this.butShow.UseVisualStyleBackColor = true;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCompare);
            this.groupBox1.Controls.Add(this.txtgrade);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(385, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 260);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // txtCompare
            // 
            this.txtCompare.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCompare.Location = new System.Drawing.Point(19, 142);
            this.txtCompare.Multiline = true;
            this.txtCompare.Name = "txtCompare";
            this.txtCompare.Size = new System.Drawing.Size(305, 101);
            this.txtCompare.TabIndex = 1;
            // 
            // txtgrade
            // 
            this.txtgrade.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtgrade.Location = new System.Drawing.Point(19, 32);
            this.txtgrade.Multiline = true;
            this.txtgrade.Name = "txtgrade";
            this.txtgrade.Size = new System.Drawing.Size(305, 101);
            this.txtgrade.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(527, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 49);
            this.button3.TabIndex = 11;
            this.button3.Text = "最高分/最低分";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "StudentGrade";
            this.Text = "StudentGrade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCompare;
        private System.Windows.Forms.TextBox txtgrade;
        private System.Windows.Forms.Button button3;
    }
}