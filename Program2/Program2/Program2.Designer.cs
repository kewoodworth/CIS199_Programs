namespace Program2
{
    partial class Program2
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.creditHoursLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.creditHoursBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.registrationDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::Program2.Properties.Resources.University_of_Louisville_logo;
            this.logo.Location = new System.Drawing.Point(12, 277);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(91, 84);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(46, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(307, 30);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "2018 Registration Dates";
            // 
            // creditHoursLabel
            // 
            this.creditHoursLabel.AutoSize = true;
            this.creditHoursLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditHoursLabel.Location = new System.Drawing.Point(81, 63);
            this.creditHoursLabel.Name = "creditHoursLabel";
            this.creditHoursLabel.Size = new System.Drawing.Size(222, 22);
            this.creditHoursLabel.TabIndex = 2;
            this.creditHoursLabel.Text = "Enter current credit hours";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(57, 147);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(287, 22);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Enter first letter of your last name";
            // 
            // creditHoursBox
            // 
            this.creditHoursBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditHoursBox.Location = new System.Drawing.Point(145, 100);
            this.creditHoursBox.Name = "creditHoursBox";
            this.creditHoursBox.Size = new System.Drawing.Size(100, 26);
            this.creditHoursBox.TabIndex = 4;
            this.creditHoursBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(145, 185);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 26);
            this.lastNameBox.TabIndex = 5;
            this.lastNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(85, 236);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(215, 23);
            this.enterButton.TabIndex = 6;
            this.enterButton.Text = "Calculate Registration Date";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // registrationDateLabel
            // 
            this.registrationDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationDateLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationDateLabel.ForeColor = System.Drawing.Color.Red;
            this.registrationDateLabel.Location = new System.Drawing.Point(145, 277);
            this.registrationDateLabel.Name = "registrationDateLabel";
            this.registrationDateLabel.Size = new System.Drawing.Size(220, 75);
            this.registrationDateLabel.TabIndex = 7;
            this.registrationDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Program2
            // 
            this.AcceptButton = this.enterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 373);
            this.Controls.Add(this.registrationDateLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.creditHoursBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.creditHoursLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.logo);
            this.Name = "Program2";
            this.Text = "Program2";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label creditHoursLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox creditHoursBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label registrationDateLabel;
    }
}

