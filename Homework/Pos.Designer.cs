namespace Homework
{
    partial class Pos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.butSta = new System.Windows.Forms.Button();
            this.butCon = new System.Windows.Forms.Button();
            this.butMol = new System.Windows.Forms.Button();
            this.butMika = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butcard = new System.Windows.Forms.Button();
            this.butcash = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtlist = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "菜單 Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "總金額 Total Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "付款方式";
            // 
            // labPrice
            // 
            this.labPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPrice.Location = new System.Drawing.Point(74, 76);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(183, 39);
            this.labPrice.TabIndex = 7;
            // 
            // butSta
            // 
            this.butSta.BackgroundImage = global::Homework.Properties.Resources.star;
            this.butSta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSta.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSta.Location = new System.Drawing.Point(133, 247);
            this.butSta.Name = "butSta";
            this.butSta.Size = new System.Drawing.Size(119, 130);
            this.butSta.TabIndex = 3;
            this.butSta.Text = "Star\r\n100元";
            this.butSta.UseVisualStyleBackColor = true;
            this.butSta.Click += new System.EventHandler(this.butSta_Click);
            // 
            // butCon
            // 
            this.butCon.BackgroundImage = global::Homework.Properties.Resources.conti;
            this.butCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butCon.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCon.Location = new System.Drawing.Point(10, 247);
            this.butCon.Name = "butCon";
            this.butCon.Size = new System.Drawing.Size(117, 130);
            this.butCon.TabIndex = 2;
            this.butCon.Text = "Conti\r\n280元";
            this.butCon.UseVisualStyleBackColor = true;
            this.butCon.Click += new System.EventHandler(this.butCon_Click);
            // 
            // butMol
            // 
            this.butMol.BackgroundImage = global::Homework.Properties.Resources.molten;
            this.butMol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butMol.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMol.Location = new System.Drawing.Point(133, 117);
            this.butMol.Name = "butMol";
            this.butMol.Size = new System.Drawing.Size(119, 124);
            this.butMol.TabIndex = 1;
            this.butMol.Text = "Molten\r\n350元";
            this.butMol.UseVisualStyleBackColor = true;
            this.butMol.Click += new System.EventHandler(this.butMol_Click);
            // 
            // butMika
            // 
            this.butMika.BackColor = System.Drawing.Color.Transparent;
            this.butMika.BackgroundImage = global::Homework.Properties.Resources.mikasa;
            this.butMika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butMika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMika.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMika.Location = new System.Drawing.Point(10, 117);
            this.butMika.Name = "butMika";
            this.butMika.Size = new System.Drawing.Size(117, 124);
            this.butMika.TabIndex = 0;
            this.butMika.Text = "MiKaSa\r\n400元";
            this.butMika.UseVisualStyleBackColor = false;
            this.butMika.Click += new System.EventHandler(this.butMika_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.butcard);
            this.groupBox1.Controls.Add(this.butcash);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(258, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 158);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "信用卡享9折!!";
            // 
            // butcard
            // 
            this.butcard.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butcard.Location = new System.Drawing.Point(138, 82);
            this.butcard.Name = "butcard";
            this.butcard.Size = new System.Drawing.Size(100, 43);
            this.butcard.TabIndex = 8;
            this.butcard.Text = "信用卡";
            this.butcard.UseVisualStyleBackColor = true;
            this.butcard.Click += new System.EventHandler(this.butcard_Click);
            // 
            // butcash
            // 
            this.butcash.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butcash.Location = new System.Drawing.Point(14, 82);
            this.butcash.Name = "butcash";
            this.butcash.Size = new System.Drawing.Size(100, 43);
            this.butcash.TabIndex = 7;
            this.butcash.Text = "現金";
            this.butcash.UseVisualStyleBackColor = true;
            this.butcash.Click += new System.EventHandler(this.butcash_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labPrice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(258, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 143);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtlist);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(528, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 307);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(78, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "清除清單";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtlist
            // 
            this.txtlist.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtlist.Location = new System.Drawing.Point(11, 48);
            this.txtlist.Multiline = true;
            this.txtlist.Name = "txtlist";
            this.txtlist.Size = new System.Drawing.Size(214, 207);
            this.txtlist.TabIndex = 1;
            this.txtlist.Text = "尚未購買";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "購物清單";
            // 
            // Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butSta);
            this.Controls.Add(this.butCon);
            this.Controls.Add(this.butMol);
            this.Controls.Add(this.butMika);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Pos";
            this.Text = "Pos";
            this.Load += new System.EventHandler(this.Pos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butMika;
        private System.Windows.Forms.Button butMol;
        private System.Windows.Forms.Button butCon;
        private System.Windows.Forms.Button butSta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butcard;
        private System.Windows.Forms.Button butcash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtlist;
        private System.Windows.Forms.Label label5;
    }
}