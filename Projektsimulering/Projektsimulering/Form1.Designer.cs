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
            this.targetPosXLabel = new System.Windows.Forms.Label();
            this.targetPosYLabel = new System.Windows.Forms.Label();
            this.textLabelPPos = new System.Windows.Forms.Label();
            this.textLabelPPosX = new System.Windows.Forms.Label();
            this.textLabelPPosY = new System.Windows.Forms.Label();
            this.projPosX = new System.Windows.Forms.Label();
            this.projPosY = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.textLabelTime = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.textLabelStatus = new System.Windows.Forms.Label();
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
            this.fireButton.Click += new System.EventHandler(this.fireButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Enabled = false;
            this.restartButton.Location = new System.Drawing.Point(65, 183);
            this.restartButton.Margin = new System.Windows.Forms.Padding(1);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(88, 41);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // textLabelAngle
            // 
            this.textLabelAngle.AutoSize = true;
            this.textLabelAngle.Location = new System.Drawing.Point(129, 47);
            this.textLabelAngle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.textLabelAngle.Name = "textLabelAngle";
            this.textLabelAngle.Size = new System.Drawing.Size(34, 13);
            this.textLabelAngle.TabIndex = 2;
            this.textLabelAngle.Text = "Angle";
            // 
            // textLabelVelocity
            // 
            this.textLabelVelocity.AutoSize = true;
            this.textLabelVelocity.Location = new System.Drawing.Point(129, 75);
            this.textLabelVelocity.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.textLabelVelocity.Name = "textLabelVelocity";
            this.textLabelVelocity.Size = new System.Drawing.Size(44, 13);
            this.textLabelVelocity.TabIndex = 3;
            this.textLabelVelocity.Text = "Velocity";
            // 
            // angleTextBox
            // 
            this.angleTextBox.Location = new System.Drawing.Point(65, 46);
            this.angleTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.Size = new System.Drawing.Size(57, 20);
            this.angleTextBox.TabIndex = 4;
            this.angleTextBox.Text = "0";
            // 
            // velocityTextBox
            // 
            this.velocityTextBox.Location = new System.Drawing.Point(65, 75);
            this.velocityTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.velocityTextBox.Name = "velocityTextBox";
            this.velocityTextBox.Size = new System.Drawing.Size(57, 20);
            this.velocityTextBox.TabIndex = 5;
            this.velocityTextBox.Text = "0";
            // 
            // textLabelTPos
            // 
            this.textLabelTPos.AutoSize = true;
            this.textLabelTPos.Location = new System.Drawing.Point(234, 150);
            this.textLabelTPos.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.textLabelTPos.Name = "textLabelTPos";
            this.textLabelTPos.Size = new System.Drawing.Size(80, 13);
            this.textLabelTPos.TabIndex = 6;
            this.textLabelTPos.Text = "Target position:";
            // 
            // textLabelTPosX
            // 
            this.textLabelTPosX.AutoSize = true;
            this.textLabelTPosX.Location = new System.Drawing.Point(236, 172);
            this.textLabelTPosX.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.textLabelTPosX.Name = "textLabelTPosX";
            this.textLabelTPosX.Size = new System.Drawing.Size(17, 13);
            this.textLabelTPosX.TabIndex = 7;
            this.textLabelTPosX.Text = "X:";
            // 
            // textLabelTPosY
            // 
            this.textLabelTPosY.AutoSize = true;
            this.textLabelTPosY.Location = new System.Drawing.Point(236, 197);
            this.textLabelTPosY.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.textLabelTPosY.Name = "textLabelTPosY";
            this.textLabelTPosY.Size = new System.Drawing.Size(17, 13);
            this.textLabelTPosY.TabIndex = 8;
            this.textLabelTPosY.Text = "Y:";
            // 
            // targetPosXLabel
            // 
            this.targetPosXLabel.AutoSize = true;
            this.targetPosXLabel.Location = new System.Drawing.Point(261, 172);
            this.targetPosXLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.targetPosXLabel.Name = "targetPosXLabel";
            this.targetPosXLabel.Size = new System.Drawing.Size(13, 13);
            this.targetPosXLabel.TabIndex = 9;
            this.targetPosXLabel.Text = "0";
            // 
            // targetPosYLabel
            // 
            this.targetPosYLabel.AutoSize = true;
            this.targetPosYLabel.Location = new System.Drawing.Point(261, 197);
            this.targetPosYLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.targetPosYLabel.Name = "targetPosYLabel";
            this.targetPosYLabel.Size = new System.Drawing.Size(13, 13);
            this.targetPosYLabel.TabIndex = 10;
            this.targetPosYLabel.Text = "0";
            // 
            // textLabelPPos
            // 
            this.textLabelPPos.AutoSize = true;
            this.textLabelPPos.Location = new System.Drawing.Point(236, 44);
            this.textLabelPPos.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.textLabelPPos.Name = "textLabelPPos";
            this.textLabelPPos.Size = new System.Drawing.Size(95, 13);
            this.textLabelPPos.TabIndex = 11;
            this.textLabelPPos.Text = "Projectile postition:";
            // 
            // textLabelPPosX
            // 
            this.textLabelPPosX.AutoSize = true;
            this.textLabelPPosX.Location = new System.Drawing.Point(236, 65);
            this.textLabelPPosX.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.textLabelPPosX.Name = "textLabelPPosX";
            this.textLabelPPosX.Size = new System.Drawing.Size(17, 13);
            this.textLabelPPosX.TabIndex = 12;
            this.textLabelPPosX.Text = "X:";
            // 
            // textLabelPPosY
            // 
            this.textLabelPPosY.AutoSize = true;
            this.textLabelPPosY.Location = new System.Drawing.Point(236, 86);
            this.textLabelPPosY.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.textLabelPPosY.Name = "textLabelPPosY";
            this.textLabelPPosY.Size = new System.Drawing.Size(17, 13);
            this.textLabelPPosY.TabIndex = 13;
            this.textLabelPPosY.Text = "Y:";
            // 
            // projPosX
            // 
            this.projPosX.AutoSize = true;
            this.projPosX.Location = new System.Drawing.Point(264, 65);
            this.projPosX.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.projPosX.Name = "projPosX";
            this.projPosX.Size = new System.Drawing.Size(13, 13);
            this.projPosX.TabIndex = 14;
            this.projPosX.Text = "0";
            // 
            // projPosY
            // 
            this.projPosY.AutoSize = true;
            this.projPosY.Location = new System.Drawing.Point(264, 86);
            this.projPosY.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.projPosY.Name = "projPosY";
            this.projPosY.Size = new System.Drawing.Size(13, 13);
            this.projPosY.TabIndex = 15;
            this.projPosY.Text = "0";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(101, 244);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(13, 13);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 200;
            // 
            // textLabelTime
            // 
            this.textLabelTime.AutoSize = true;
            this.textLabelTime.Location = new System.Drawing.Point(12, 293);
            this.textLabelTime.Name = "textLabelTime";
            this.textLabelTime.Size = new System.Drawing.Size(32, 13);
            this.textLabelTime.TabIndex = 17;
            this.textLabelTime.Text = "time: ";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(51, 293);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(13, 13);
            this.timeLabel.TabIndex = 18;
            this.timeLabel.Text = "0";
            // 
            // textLabelStatus
            // 
            this.textLabelStatus.AutoSize = true;
            this.textLabelStatus.Location = new System.Drawing.Point(62, 244);
            this.textLabelStatus.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.textLabelStatus.Name = "textLabelStatus";
            this.textLabelStatus.Size = new System.Drawing.Size(40, 13);
            this.textLabelStatus.TabIndex = 19;
            this.textLabelStatus.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 315);
            this.Controls.Add(this.textLabelStatus);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.textLabelTime);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.projPosY);
            this.Controls.Add(this.projPosX);
            this.Controls.Add(this.textLabelPPosY);
            this.Controls.Add(this.textLabelPPosX);
            this.Controls.Add(this.textLabelPPos);
            this.Controls.Add(this.targetPosYLabel);
            this.Controls.Add(this.targetPosXLabel);
            this.Controls.Add(this.textLabelTPosY);
            this.Controls.Add(this.textLabelTPosX);
            this.Controls.Add(this.textLabelTPos);
            this.Controls.Add(this.velocityTextBox);
            this.Controls.Add(this.angleTextBox);
            this.Controls.Add(this.textLabelVelocity);
            this.Controls.Add(this.textLabelAngle);
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
        private System.Windows.Forms.Label textLabelAngle;
        private System.Windows.Forms.Label textLabelVelocity;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.TextBox velocityTextBox;
        private System.Windows.Forms.Label textLabelTPos;
        private System.Windows.Forms.Label textLabelTPosX;
        private System.Windows.Forms.Label textLabelTPosY;
        private System.Windows.Forms.Label targetPosXLabel;
        private System.Windows.Forms.Label targetPosYLabel;
        private System.Windows.Forms.Label textLabelPPos;
        private System.Windows.Forms.Label textLabelPPosX;
        private System.Windows.Forms.Label textLabelPPosY;
        private System.Windows.Forms.Label projPosX;
        private System.Windows.Forms.Label projPosY;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label textLabelTime;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label textLabelStatus;
    }
}

