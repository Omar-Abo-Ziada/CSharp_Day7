namespace WindowsFormsApp1
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
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.MeterToKilometer = new System.Windows.Forms.RadioButton();
            this.MeterToFoot = new System.Windows.Forms.RadioButton();
            this.MeterToDecemeter = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.Location = new System.Drawing.Point(28, 42);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(93, 29);
            this.ValueLabel.TabIndex = 0;
            this.ValueLabel.Text = "Value :";
            this.ValueLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(26, 124);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(101, 29);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Text = "Result :";
            this.ResultLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(133, 49);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(190, 22);
            this.ValueTextBox.TabIndex = 2;
            this.ValueTextBox.TextChanged += new System.EventHandler(this.ValueTextBox_TextChanged);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(133, 131);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(190, 22);
            this.ResultTextBox.TabIndex = 3;
            this.ResultTextBox.TextChanged += new System.EventHandler(this.ValueTextBox_TextChanged);
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseLabel.Location = new System.Drawing.Point(532, 41);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(156, 29);
            this.ChooseLabel.TabIndex = 4;
            this.ChooseLabel.Text = "Choose Unit";
            // 
            // MeterToKilometer
            // 
            this.MeterToKilometer.AutoSize = true;
            this.MeterToKilometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeterToKilometer.Location = new System.Drawing.Point(47, 21);
            this.MeterToKilometer.Name = "MeterToKilometer";
            this.MeterToKilometer.Size = new System.Drawing.Size(191, 29);
            this.MeterToKilometer.TabIndex = 5;
            this.MeterToKilometer.TabStop = true;
            this.MeterToKilometer.Text = "Meter to Kilometer";
            this.MeterToKilometer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.MeterToKilometer.UseVisualStyleBackColor = true;
            this.MeterToKilometer.CheckedChanged += new System.EventHandler(this.ConvertRadios_CheckedChanged);
            // 
            // MeterToFoot
            // 
            this.MeterToFoot.AutoSize = true;
            this.MeterToFoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeterToFoot.Location = new System.Drawing.Point(47, 121);
            this.MeterToFoot.Name = "MeterToFoot";
            this.MeterToFoot.Size = new System.Drawing.Size(148, 29);
            this.MeterToFoot.TabIndex = 6;
            this.MeterToFoot.TabStop = true;
            this.MeterToFoot.Text = "Meter to Foot";
            this.MeterToFoot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.MeterToFoot.UseVisualStyleBackColor = true;
            this.MeterToFoot.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MeterToDecemeter
            // 
            this.MeterToDecemeter.AutoSize = true;
            this.MeterToDecemeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeterToDecemeter.Location = new System.Drawing.Point(47, 72);
            this.MeterToDecemeter.Name = "MeterToDecemeter";
            this.MeterToDecemeter.Size = new System.Drawing.Size(204, 29);
            this.MeterToDecemeter.TabIndex = 6;
            this.MeterToDecemeter.TabStop = true;
            this.MeterToDecemeter.Text = "Meter to Decemeter";
            this.MeterToDecemeter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.MeterToDecemeter.UseVisualStyleBackColor = true;
            this.MeterToDecemeter.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MeterToDecemeter);
            this.panel1.Controls.Add(this.MeterToFoot);
            this.panel1.Controls.Add(this.MeterToKilometer);
            this.panel1.Location = new System.Drawing.Point(490, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 190);
            this.panel1.TabIndex = 7;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Urdu Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.Location = new System.Drawing.Point(299, 338);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(216, 51);
            this.ConvertButton.TabIndex = 8;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ResultTextBox);
            this.panel2.Controls.Add(this.ValueTextBox);
            this.panel2.Controls.Add(this.ResultLabel);
            this.panel2.Controls.Add(this.ValueLabel);
            this.panel2.Location = new System.Drawing.Point(28, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 215);
            this.panel2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChooseLabel);
            this.Name = "Form1";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label ChooseLabel;
        private System.Windows.Forms.RadioButton MeterToKilometer;
        private System.Windows.Forms.RadioButton MeterToFoot;
        private System.Windows.Forms.RadioButton MeterToDecemeter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Panel panel2;
    }
}

