namespace Registration
{
    partial class Registeration
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.InvalidNameMessage = new System.Windows.Forms.Label();
            this.InvalidEmailMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RunningCheckBox = new System.Windows.Forms.CheckBox();
            this.SwimmingCheckBox = new System.Windows.Forms.CheckBox();
            this.ReadingCheckBox = new System.Windows.Forms.CheckBox();
            this.HobbiesLabel = new System.Windows.Forms.Label();
            this.InvalidHobbyMessage = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ValidRegisterationMessage = new System.Windows.Forms.Label();
            this.InvalidGenderMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(23, 25);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(68, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(23, 98);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(65, 25);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(97, 25);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(214, 22);
            this.NameTextBox.TabIndex = 2;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(97, 101);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(214, 22);
            this.EmailTextBox.TabIndex = 3;
            // 
            // InvalidNameMessage
            // 
            this.InvalidNameMessage.AutoSize = true;
            this.InvalidNameMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidNameMessage.ForeColor = System.Drawing.Color.Red;
            this.InvalidNameMessage.Location = new System.Drawing.Point(331, 25);
            this.InvalidNameMessage.Name = "InvalidNameMessage";
            this.InvalidNameMessage.Size = new System.Drawing.Size(352, 20);
            this.InvalidNameMessage.TabIndex = 4;
            this.InvalidNameMessage.Text = "Name must contain at least 5 characters";
            this.InvalidNameMessage.Visible = false;
            this.InvalidNameMessage.Click += new System.EventHandler(this.InvalidNameMessage_Click);
            // 
            // InvalidEmailMessage
            // 
            this.InvalidEmailMessage.AutoSize = true;
            this.InvalidEmailMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidEmailMessage.ForeColor = System.Drawing.Color.Red;
            this.InvalidEmailMessage.Location = new System.Drawing.Point(344, 101);
            this.InvalidEmailMessage.Name = "InvalidEmailMessage";
            this.InvalidEmailMessage.Size = new System.Drawing.Size(352, 20);
            this.InvalidEmailMessage.TabIndex = 5;
            this.InvalidEmailMessage.Text = "Name must contain at least 5 characters";
            this.InvalidEmailMessage.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gender";
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRadioButton.Location = new System.Drawing.Point(120, 23);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(69, 26);
            this.MaleRadioButton.TabIndex = 7;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleRadioButton.Location = new System.Drawing.Point(248, 23);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(90, 26);
            this.FemaleRadioButton.TabIndex = 8;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FemaleRadioButton);
            this.panel1.Controls.Add(this.MaleRadioButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 67);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RunningCheckBox);
            this.panel2.Controls.Add(this.SwimmingCheckBox);
            this.panel2.Controls.Add(this.ReadingCheckBox);
            this.panel2.Controls.Add(this.HobbiesLabel);
            this.panel2.Location = new System.Drawing.Point(14, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 67);
            this.panel2.TabIndex = 10;
            // 
            // RunningCheckBox
            // 
            this.RunningCheckBox.AutoSize = true;
            this.RunningCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunningCheckBox.Location = new System.Drawing.Point(397, 26);
            this.RunningCheckBox.Name = "RunningCheckBox";
            this.RunningCheckBox.Size = new System.Drawing.Size(92, 24);
            this.RunningCheckBox.TabIndex = 9;
            this.RunningCheckBox.Text = "Running";
            this.RunningCheckBox.UseVisualStyleBackColor = true;
            this.RunningCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SwimmingCheckBox
            // 
            this.SwimmingCheckBox.AutoSize = true;
            this.SwimmingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingCheckBox.Location = new System.Drawing.Point(261, 26);
            this.SwimmingCheckBox.Name = "SwimmingCheckBox";
            this.SwimmingCheckBox.Size = new System.Drawing.Size(108, 24);
            this.SwimmingCheckBox.TabIndex = 8;
            this.SwimmingCheckBox.Text = "Swimming";
            this.SwimmingCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReadingCheckBox
            // 
            this.ReadingCheckBox.AutoSize = true;
            this.ReadingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadingCheckBox.Location = new System.Drawing.Point(135, 26);
            this.ReadingCheckBox.Name = "ReadingCheckBox";
            this.ReadingCheckBox.Size = new System.Drawing.Size(92, 24);
            this.ReadingCheckBox.TabIndex = 7;
            this.ReadingCheckBox.Text = "Reading";
            this.ReadingCheckBox.UseVisualStyleBackColor = true;
            // 
            // HobbiesLabel
            // 
            this.HobbiesLabel.AutoSize = true;
            this.HobbiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HobbiesLabel.Location = new System.Drawing.Point(9, 23);
            this.HobbiesLabel.Name = "HobbiesLabel";
            this.HobbiesLabel.Size = new System.Drawing.Size(91, 25);
            this.HobbiesLabel.TabIndex = 6;
            this.HobbiesLabel.Text = "Hobbies";
            // 
            // InvalidHobbyMessage
            // 
            this.InvalidHobbyMessage.AutoSize = true;
            this.InvalidHobbyMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidHobbyMessage.ForeColor = System.Drawing.Color.Red;
            this.InvalidHobbyMessage.Location = new System.Drawing.Point(537, 273);
            this.InvalidHobbyMessage.Name = "InvalidHobbyMessage";
            this.InvalidHobbyMessage.Size = new System.Drawing.Size(232, 20);
            this.InvalidHobbyMessage.TabIndex = 11;
            this.InvalidHobbyMessage.Text = "Choose at least one hobby";
            this.InvalidHobbyMessage.Visible = false;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(325, 415);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(330, 39);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ValidRegisterationMessage
            // 
            this.ValidRegisterationMessage.AutoSize = true;
            this.ValidRegisterationMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidRegisterationMessage.ForeColor = System.Drawing.Color.ForestGreen;
            this.ValidRegisterationMessage.Location = new System.Drawing.Point(333, 487);
            this.ValidRegisterationMessage.Name = "ValidRegisterationMessage";
            this.ValidRegisterationMessage.Size = new System.Drawing.Size(322, 20);
            this.ValidRegisterationMessage.TabIndex = 13;
            this.ValidRegisterationMessage.Text = "Thank you , The registration is valid !";
            this.ValidRegisterationMessage.Visible = false;
            // 
            // InvalidGenderMessage
            // 
            this.InvalidGenderMessage.AutoSize = true;
            this.InvalidGenderMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidGenderMessage.ForeColor = System.Drawing.Color.Red;
            this.InvalidGenderMessage.Location = new System.Drawing.Point(386, 189);
            this.InvalidGenderMessage.Name = "InvalidGenderMessage";
            this.InvalidGenderMessage.Size = new System.Drawing.Size(270, 20);
            this.InvalidGenderMessage.TabIndex = 14;
            this.InvalidGenderMessage.Text = "You must choose one of them !";
            this.InvalidGenderMessage.Visible = false;
            // 
            // Registeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 552);
            this.Controls.Add(this.InvalidGenderMessage);
            this.Controls.Add(this.ValidRegisterationMessage);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.InvalidHobbyMessage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InvalidEmailMessage);
            this.Controls.Add(this.InvalidNameMessage);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Registeration";
            this.Text = "Registeration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label InvalidNameMessage;
        private System.Windows.Forms.Label InvalidEmailMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label HobbiesLabel;
        private System.Windows.Forms.CheckBox RunningCheckBox;
        private System.Windows.Forms.CheckBox SwimmingCheckBox;
        private System.Windows.Forms.CheckBox ReadingCheckBox;
        private System.Windows.Forms.Label InvalidHobbyMessage;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label ValidRegisterationMessage;
        private System.Windows.Forms.Label InvalidGenderMessage;
    }
}

