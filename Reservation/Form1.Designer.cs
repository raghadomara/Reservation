namespace Reservation
{
    partial class Form1
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
            this.numberOfPepoleTB = new System.Windows.Forms.TextBox();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.timeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.finishBtn = new System.Windows.Forms.Button();
            this.existBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberOfPepoleTB
            // 
            this.numberOfPepoleTB.Location = new System.Drawing.Point(188, 72);
            this.numberOfPepoleTB.Name = "numberOfPepoleTB";
            this.numberOfPepoleTB.Size = new System.Drawing.Size(100, 22);
            this.numberOfPepoleTB.TabIndex = 0;
            // 
            // dateTB
            // 
            this.dateTB.Location = new System.Drawing.Point(188, 121);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(100, 22);
            this.dateTB.TabIndex = 1;
            // 
            // timeTB
            // 
            this.timeTB.Location = new System.Drawing.Point(188, 180);
            this.timeTB.Name = "timeTB";
            this.timeTB.Size = new System.Drawing.Size(100, 22);
            this.timeTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "number of people";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "time";
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(154, 248);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(75, 23);
            this.finishBtn.TabIndex = 7;
            this.finishBtn.Text = "finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // existBtn
            // 
            this.existBtn.Location = new System.Drawing.Point(283, 248);
            this.existBtn.Name = "existBtn";
            this.existBtn.Size = new System.Drawing.Size(75, 23);
            this.existBtn.TabIndex = 8;
            this.existBtn.Text = "exit";
            this.existBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.existBtn);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeTB);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.numberOfPepoleTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberOfPepoleTB;
        private System.Windows.Forms.TextBox dateTB;
        private System.Windows.Forms.TextBox timeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.Button existBtn;
    }
}

