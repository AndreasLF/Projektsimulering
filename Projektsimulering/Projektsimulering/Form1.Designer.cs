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
            this.textLabelAngle = new System.Windows.Forms.Label();
            this.textLabelVelocity = new System.Windows.Forms.Label();
            this.angleTextBox = new System.Windows.Forms.TextBox();
            this.velocityTextBox = new System.Windows.Forms.TextBox();
            this.textLabelTPos = new System.Windows.Forms.Label();
            this.textLabelTPosX = new System.Windows.Forms.Label();
            this.textLabelTPosY = new System.Windows.Forms.Label();
            this.targetPosX = new System.Windows.Forms.Label();
            this.targetPosY = new System.Windows.Forms.Label();
            this.textLabelPPos = new System.Windows.Forms.Label();
            this.textLabelPPosX = new System.Windows.Forms.Label();
            this.textLabelPPosY = new System.Windows.Forms.Label();
            this.projPosX = new System.Windows.Forms.Label();
            this.projPosY = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // fireButton
            // 
            this.fireButton.Location = new System.Drawing.Point(173, 300);
            this.fireButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(235, 93);
            this.fireButton.TabIndex = 0;
            this.fireButton.Text = "Fire";
            this.fireButton.UseVisualStyleBackColor = true;
            this.fireButton.Click += new System.EventHandler(this.fireButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(173, 436);
            this.restartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(235, 98);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            // 
            // textLabelAngle
            // 
            this.textLabelAngle.AutoSize = true;
            this.textLabelAngle.Location = new System.Drawing.Point(344, 112);
            this.textLabelAngle.Name = "textLabelAngle";
            this.textLabelAngle.Size = new System.Drawing.Size(89, 32);
            this.textLabelAngle.TabIndex = 2;
            this.textLabelAngle.Text = "Angle";
            // 
            // textLabelVelocity
            // 
            this.textLabelVelocity.AutoSize = true;
            this.textLabelVelocity.Location = new System.Drawing.Point(344, 179);
            this.textLabelVelocity.Name = "textLabelVelocity";
            this.textLabelVelocity.Size = new System.Drawing.Size(116, 32);
            this.textLabelVelocity.TabIndex = 3;
            this.textLabelVelocity.Text = "Velocity";
            // 
            // angleTextBox
            // 
            this.angleTextBox.Location = new System.Drawing.Point(173, 110);
            this.angleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.Size = new System.Drawing.Size(145, 38);
            this.angleTextBox.TabIndex = 4;
            // 
            // velocityTextBox
            // 
            this.velocityTextBox.Location = new System.Drawing.Point(173, 179);
            this.velocityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.velocityTextBox.Name = "velocityTextBox";
            this.velocityTextBox.Size = new System.Drawing.Size(145, 38);
            this.velocityTextBox.TabIndex = 5;
            // 
            // textLabelTPos
            // 
            this.textLabelTPos.AutoSize = true;
            this.textLabelTPos.Location = new System.Drawing.Point(624, 358);
            this.textLabelTPos.Name = "textLabelTPos";
            this.textLabelTPos.Size = new System.Drawing.Size(212, 32);
            this.textLabelTPos.TabIndex = 6;
            this.textLabelTPos.Text = "Target position:";
            // 
            // textLabelTPosX
            // 
            this.textLabelTPosX.AutoSize = true;
            this.textLabelTPosX.Location = new System.Drawing.Point(629, 410);
            this.textLabelTPosX.Name = "textLabelTPosX";
            this.textLabelTPosX.Size = new System.Drawing.Size(42, 32);
            this.textLabelTPosX.TabIndex = 7;
            this.textLabelTPosX.Text = "X:";
            // 
            // textLabelTPosY
            // 
            this.textLabelTPosY.AutoSize = true;
            this.textLabelTPosY.Location = new System.Drawing.Point(629, 470);
            this.textLabelTPosY.Name = "textLabelTPosY";
            this.textLabelTPosY.Size = new System.Drawing.Size(42, 32);
            this.textLabelTPosY.TabIndex = 8;
            this.textLabelTPosY.Text = "Y:";
            // 
            // targetPosX
            // 
            this.targetPosX.AutoSize = true;
            this.targetPosX.Location = new System.Drawing.Point(696, 410);
            this.targetPosX.Name = "targetPosX";
            this.targetPosX.Size = new System.Drawing.Size(93, 32);
            this.targetPosX.TabIndex = 9;
            this.targetPosX.Text = "label6";
            // 
            // targetPosY
            // 
            this.targetPosY.AutoSize = true;
            this.targetPosY.Location = new System.Drawing.Point(696, 470);
            this.targetPosY.Name = "targetPosY";
            this.targetPosY.Size = new System.Drawing.Size(93, 32);
            this.targetPosY.TabIndex = 10;
            this.targetPosY.Text = "label7";
            // 
            // textLabelPPos
            // 
            this.textLabelPPos.AutoSize = true;
            this.textLabelPPos.Location = new System.Drawing.Point(629, 105);
            this.textLabelPPos.Name = "textLabelPPos";
            this.textLabelPPos.Size = new System.Drawing.Size(257, 32);
            this.textLabelPPos.TabIndex = 11;
            this.textLabelPPos.Text = "Projectile postition:";
            // 
            // textLabelPPosX
            // 
            this.textLabelPPosX.AutoSize = true;
            this.textLabelPPosX.Location = new System.Drawing.Point(629, 155);
            this.textLabelPPosX.Name = "textLabelPPosX";
            this.textLabelPPosX.Size = new System.Drawing.Size(42, 32);
            this.textLabelPPosX.TabIndex = 12;
            this.textLabelPPosX.Text = "X:";
            // 
            // textLabelPPosY
            // 
            this.textLabelPPosY.AutoSize = true;
            this.textLabelPPosY.Location = new System.Drawing.Point(629, 205);
            this.textLabelPPosY.Name = "textLabelPPosY";
            this.textLabelPPosY.Size = new System.Drawing.Size(42, 32);
            this.textLabelPPosY.TabIndex = 13;
            this.textLabelPPosY.Text = "Y:";
            // 
            // projPosX
            // 
            this.projPosX.AutoSize = true;
            this.projPosX.Location = new System.Drawing.Point(704, 155);
            this.projPosX.Name = "projPosX";
            this.projPosX.Size = new System.Drawing.Size(109, 32);
            this.projPosX.TabIndex = 14;
            this.projPosX.Text = "label11";
            // 
            // projPosY
            // 
            this.projPosY.AutoSize = true;
            this.projPosY.Location = new System.Drawing.Point(704, 205);
            this.projPosY.Name = "projPosY";
            this.projPosY.Size = new System.Drawing.Size(109, 32);
            this.projPosY.TabIndex = 15;
            this.projPosY.Text = "label12";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(445, 646);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(96, 32);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "Status";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 751);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.projPosY);
            this.Controls.Add(this.projPosX);
            this.Controls.Add(this.textLabelPPosY);
            this.Controls.Add(this.textLabelPPosX);
            this.Controls.Add(this.textLabelPPos);
            this.Controls.Add(this.targetPosY);
            this.Controls.Add(this.targetPosX);
            this.Controls.Add(this.textLabelTPosY);
            this.Controls.Add(this.textLabelTPosX);
            this.Controls.Add(this.textLabelTPos);
            this.Controls.Add(this.velocityTextBox);
            this.Controls.Add(this.angleTextBox);
            this.Controls.Add(this.textLabelVelocity);
            this.Controls.Add(this.textLabelAngle);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.fireButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fireButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label textLabelAngle;
        private System.Windows.Forms.Label textLabelVelocity;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.TextBox velocityTextBox;
        private System.Windows.Forms.Label textLabelTPos;
        private System.Windows.Forms.Label textLabelTPosX;
        private System.Windows.Forms.Label textLabelTPosY;
        private System.Windows.Forms.Label targetPosX;
        private System.Windows.Forms.Label targetPosY;
        private System.Windows.Forms.Label textLabelPPos;
        private System.Windows.Forms.Label textLabelPPosX;
        private System.Windows.Forms.Label textLabelPPosY;
        private System.Windows.Forms.Label projPosX;
        private System.Windows.Forms.Label projPosY;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}

