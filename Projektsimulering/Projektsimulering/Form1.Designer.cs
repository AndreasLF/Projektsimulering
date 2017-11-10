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
            this.components = new System.ComponentModel.Container();
            this.fireButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.angleTextBox = new System.Windows.Forms.TextBox();
            this.velocityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.targetPosX = new System.Windows.Forms.Label();
            this.targetPosY = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.projPosX = new System.Windows.Forms.Label();
            this.projPosY = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // fireButton
            // 
            this.fireButton.Location = new System.Drawing.Point(65, 126);
            this.fireButton.Margin = new System.Windows.Forms.Padding(1);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(88, 39);
            this.fireButton.TabIndex = 0;
            this.fireButton.Text = "Fire";
            this.fireButton.UseVisualStyleBackColor = true;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(65, 183);
            this.restartButton.Margin = new System.Windows.Forms.Padding(1);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(88, 41);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Angle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Velocity";
            // 
            // angleTextBox
            // 
            this.angleTextBox.Location = new System.Drawing.Point(65, 46);
            this.angleTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.Size = new System.Drawing.Size(57, 20);
            this.angleTextBox.TabIndex = 4;
            // 
            // velocityTextBox
            // 
            this.velocityTextBox.Location = new System.Drawing.Point(65, 75);
            this.velocityTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.velocityTextBox.Name = "velocityTextBox";
            this.velocityTextBox.Size = new System.Drawing.Size(57, 20);
            this.velocityTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Target position:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Y:";
            // 
            // targetPosX
            // 
            this.targetPosX.AutoSize = true;
            this.targetPosX.Location = new System.Drawing.Point(261, 172);
            this.targetPosX.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.targetPosX.Name = "targetPosX";
            this.targetPosX.Size = new System.Drawing.Size(35, 13);
            this.targetPosX.TabIndex = 9;
            this.targetPosX.Text = "label6";
            // 
            // targetPosY
            // 
            this.targetPosY.AutoSize = true;
            this.targetPosY.Location = new System.Drawing.Point(261, 197);
            this.targetPosY.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.targetPosY.Name = "targetPosY";
            this.targetPosY.Size = new System.Drawing.Size(35, 13);
            this.targetPosY.TabIndex = 10;
            this.targetPosY.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Projectile postition:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "X:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 86);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Y:";
            // 
            // projPosX
            // 
            this.projPosX.AutoSize = true;
            this.projPosX.Location = new System.Drawing.Point(264, 65);
            this.projPosX.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.projPosX.Name = "projPosX";
            this.projPosX.Size = new System.Drawing.Size(41, 13);
            this.projPosX.TabIndex = 14;
            this.projPosX.Text = "label11";
            // 
            // projPosY
            // 
            this.projPosY.AutoSize = true;
            this.projPosY.Location = new System.Drawing.Point(264, 86);
            this.projPosY.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.projPosY.Name = "projPosY";
            this.projPosY.Size = new System.Drawing.Size(41, 13);
            this.projPosY.TabIndex = 15;
            this.projPosY.Text = "label12";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(167, 271);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "Status";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 315);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.projPosY);
            this.Controls.Add(this.projPosX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.targetPosY);
            this.Controls.Add(this.targetPosX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.velocityTextBox);
            this.Controls.Add(this.angleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.fireButton);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fireButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.TextBox velocityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label targetPosX;
        private System.Windows.Forms.Label targetPosY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label projPosX;
        private System.Windows.Forms.Label projPosY;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}

