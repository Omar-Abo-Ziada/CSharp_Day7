namespace Day7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMsg = new Button();
            lblMsg = new Label();
            txtMsg = new TextBox();
            radRed = new RadioButton();
            radGreen = new RadioButton();
            radBlue = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            SuspendLayout();
            // 
            // btnMsg
            // 
            btnMsg.Location = new Point(294, 132);
            btnMsg.Margin = new Padding(3, 4, 3, 4);
            btnMsg.Name = "btnMsg";
            btnMsg.Size = new Size(137, 71);
            btnMsg.TabIndex = 0;
            btnMsg.Text = "button1";
            btnMsg.UseVisualStyleBackColor = true;
            btnMsg.Click += btnMsg_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMsg.Location = new Point(538, 79);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(180, 41);
            lblMsg.TabIndex = 1;
            lblMsg.Text = "Helleo there";
            // 
            // txtMsg
            // 
            txtMsg.Location = new Point(538, 153);
            txtMsg.Margin = new Padding(3, 4, 3, 4);
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(153, 27);
            txtMsg.TabIndex = 2;
            txtMsg.TextChanged += txtMsg_TextChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radRed.Location = new Point(43, 79);
            radRed.Margin = new Padding(3, 4, 3, 4);
            radRed.Name = "radRed";
            radRed.Size = new Size(90, 45);
            radRed.TabIndex = 3;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radColor_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radGreen.Location = new Point(43, 156);
            radGreen.Margin = new Padding(3, 4, 3, 4);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(119, 45);
            radGreen.TabIndex = 4;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radColor_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radBlue.Location = new Point(43, 233);
            radBlue.Margin = new Padding(3, 4, 3, 4);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(96, 45);
            radBlue.TabIndex = 5;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radColor_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(481, 252);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(181, 45);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(481, 331);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(181, 45);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(481, 408);
            checkBox3.Margin = new Padding(3, 4, 3, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(181, 45);
            checkBox3.TabIndex = 8;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(914, 600);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(radBlue);
            Controls.Add(radGreen);
            Controls.Add(radRed);
            Controls.Add(txtMsg);
            Controls.Add(lblMsg);
            Controls.Add(btnMsg);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            MouseLeave += Form1_MouseLeave;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMsg;
        private Label lblMsg;
        private TextBox txtMsg;
        private RadioButton radRed;
        private RadioButton radGreen;
        private RadioButton radBlue;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
    }
}