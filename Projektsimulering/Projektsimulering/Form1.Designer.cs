namespace Projektsimulering
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
            this.FireButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AngleTextBox = new System.Windows.Forms.TextBox();
            this.VelocityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TargetPosX = new System.Windows.Forms.Label();
            this.TargetPosY = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ProjPosX = new System.Windows.Forms.Label();
            this.ProjPosY = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FireButton
            // 
            this.FireButton.Location = new System.Drawing.Point(173, 301);
            this.FireButton.Name = "FireButton";
            this.FireButton.Size = new System.Drawing.Size(234, 94);
            this.FireButton.TabIndex = 0;
            this.FireButton.Text = "Fire";
            this.FireButton.UseVisualStyleBackColor = true;
            this.FireButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(173, 436);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(234, 98);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Angle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Velocity";
            // 
            // AngleTextBox
            // 
            this.AngleTextBox.Location = new System.Drawing.Point(173, 109);
            this.AngleTextBox.Name = "AngleTextBox";
            this.AngleTextBox.Size = new System.Drawing.Size(145, 38);
            this.AngleTextBox.TabIndex = 4;
            // 
            // VelocityTextBox
            // 
            this.VelocityTextBox.Location = new System.Drawing.Point(173, 179);
            this.VelocityTextBox.Name = "VelocityTextBox";
            this.VelocityTextBox.Size = new System.Drawing.Size(145, 38);
            this.VelocityTextBox.TabIndex = 5;
            this.VelocityTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Target position:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Y:";
            // 
            // TargetPosX
            // 
            this.TargetPosX.AutoSize = true;
            this.TargetPosX.Location = new System.Drawing.Point(697, 410);
            this.TargetPosX.Name = "TargetPosX";
            this.TargetPosX.Size = new System.Drawing.Size(93, 32);
            this.TargetPosX.TabIndex = 9;
            this.TargetPosX.Text = "label6";
            // 
            // TargetPosY
            // 
            this.TargetPosY.AutoSize = true;
            this.TargetPosY.Location = new System.Drawing.Point(697, 470);
            this.TargetPosY.Name = "TargetPosY";
            this.TargetPosY.Size = new System.Drawing.Size(93, 32);
            this.TargetPosY.TabIndex = 10;
            this.TargetPosY.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(630, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = "Projectile postition:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(630, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 32);
            this.label9.TabIndex = 12;
            this.label9.Text = "X:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(630, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 32);
            this.label10.TabIndex = 13;
            this.label10.Text = "Y:";
            // 
            // ProjPosX
            // 
            this.ProjPosX.AutoSize = true;
            this.ProjPosX.Location = new System.Drawing.Point(703, 154);
            this.ProjPosX.Name = "ProjPosX";
            this.ProjPosX.Size = new System.Drawing.Size(109, 32);
            this.ProjPosX.TabIndex = 14;
            this.ProjPosX.Text = "label11";
            // 
            // ProjPosY
            // 
            this.ProjPosY.AutoSize = true;
            this.ProjPosY.Location = new System.Drawing.Point(703, 206);
            this.ProjPosY.Name = "ProjPosY";
            this.ProjPosY.Size = new System.Drawing.Size(109, 32);
            this.ProjPosY.TabIndex = 15;
            this.ProjPosY.Text = "label12";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(445, 647);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(96, 32);
            this.StatusLabel.TabIndex = 16;
            this.StatusLabel.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 750);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ProjPosY);
            this.Controls.Add(this.ProjPosX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TargetPosY);
            this.Controls.Add(this.TargetPosX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VelocityTextBox);
            this.Controls.Add(this.AngleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.FireButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FireButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AngleTextBox;
        private System.Windows.Forms.TextBox VelocityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TargetPosX;
        private System.Windows.Forms.Label TargetPosY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ProjPosX;
        private System.Windows.Forms.Label ProjPosY;
        private System.Windows.Forms.Label StatusLabel;
    }
}

