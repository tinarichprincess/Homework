namespace Homework
{
    partial class Guess_Number
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
            this.butGuess = new System.Windows.Forms.Button();
            this.butShow = new System.Windows.Forms.Button();
            this.txtEnterNumber = new System.Windows.Forms.TextBox();
            this.butStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(131, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select A Number Betweent 1 to 100";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butGuess
            // 
            this.butGuess.Enabled = false;
            this.butGuess.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butGuess.Location = new System.Drawing.Point(159, 332);
            this.butGuess.Name = "butGuess";
            this.butGuess.Size = new System.Drawing.Size(187, 74);
            this.butGuess.TabIndex = 1;
            this.butGuess.Text = "Guess";
            this.butGuess.UseVisualStyleBackColor = true;
            this.butGuess.Click += new System.EventHandler(this.butGuess_Click);
            // 
            // butShow
            // 
            this.butShow.Enabled = false;
            this.butShow.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butShow.Location = new System.Drawing.Point(392, 332);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(187, 74);
            this.butShow.TabIndex = 2;
            this.butShow.Text = "Show Answer";
            this.butShow.UseVisualStyleBackColor = true;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // txtEnterNumber
            // 
            this.txtEnterNumber.AcceptsTab = true;
            this.txtEnterNumber.Enabled = false;
            this.txtEnterNumber.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnterNumber.Location = new System.Drawing.Point(298, 243);
            this.txtEnterNumber.Multiline = true;
            this.txtEnterNumber.Name = "txtEnterNumber";
            this.txtEnterNumber.Size = new System.Drawing.Size(160, 59);
            this.txtEnterNumber.TabIndex = 3;
            // 
            // butStart
            // 
            this.butStart.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butStart.Location = new System.Drawing.Point(281, 154);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(194, 63);
            this.butStart.TabIndex = 4;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.button3_Click);
            // 
            // Guess_Number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.txtEnterNumber);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.butGuess);
            this.Controls.Add(this.label1);
            this.Name = "Guess_Number";
            this.Text = "Guess_Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butGuess;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.TextBox txtEnterNumber;
        private System.Windows.Forms.Button butStart;
    }
}