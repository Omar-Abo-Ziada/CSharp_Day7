namespace Trainees_List
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
            this.checkedListBoxTrainees = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxLabTrainees = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oneToRightBtn = new System.Windows.Forms.Button();
            this.allToRightBtn = new System.Windows.Forms.Button();
            this.allToLeftBtn = new System.Windows.Forms.Button();
            this.oneToLeftBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxTrainees
            // 
            this.checkedListBoxTrainees.FormattingEnabled = true;
            this.checkedListBoxTrainees.Location = new System.Drawing.Point(43, 74);
            this.checkedListBoxTrainees.Name = "checkedListBoxTrainees";
            this.checkedListBoxTrainees.Size = new System.Drawing.Size(288, 293);
            this.checkedListBoxTrainees.TabIndex = 0;
            this.checkedListBoxTrainees.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkedListBoxLabTrainees
            // 
            this.checkedListBoxLabTrainees.FormattingEnabled = true;
            this.checkedListBoxLabTrainees.Location = new System.Drawing.Point(482, 74);
            this.checkedListBoxLabTrainees.Name = "checkedListBoxLabTrainees";
            this.checkedListBoxLabTrainees.Size = new System.Drawing.Size(288, 293);
            this.checkedListBoxLabTrainees.TabIndex = 1;
            this.checkedListBoxLabTrainees.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxLabTrainees_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trainees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lab Trainees";
            // 
            // oneToRightBtn
            // 
            this.oneToRightBtn.Location = new System.Drawing.Point(388, 105);
            this.oneToRightBtn.Name = "oneToRightBtn";
            this.oneToRightBtn.Size = new System.Drawing.Size(40, 27);
            this.oneToRightBtn.TabIndex = 4;
            this.oneToRightBtn.Text = ">";
            this.oneToRightBtn.UseVisualStyleBackColor = true;
            this.oneToRightBtn.Click += new System.EventHandler(this.oneToRightBtn_Click);
            // 
            // allToRightBtn
            // 
            this.allToRightBtn.Location = new System.Drawing.Point(388, 162);
            this.allToRightBtn.Name = "allToRightBtn";
            this.allToRightBtn.Size = new System.Drawing.Size(40, 27);
            this.allToRightBtn.TabIndex = 5;
            this.allToRightBtn.Text = ">>";
            this.allToRightBtn.UseVisualStyleBackColor = true;
            this.allToRightBtn.Click += new System.EventHandler(this.allToRightBtn_Click);
            // 
            // allToLeftBtn
            // 
            this.allToLeftBtn.Location = new System.Drawing.Point(388, 317);
            this.allToLeftBtn.Name = "allToLeftBtn";
            this.allToLeftBtn.Size = new System.Drawing.Size(40, 27);
            this.allToLeftBtn.TabIndex = 7;
            this.allToLeftBtn.Text = "<<";
            this.allToLeftBtn.UseVisualStyleBackColor = true;
            this.allToLeftBtn.Click += new System.EventHandler(this.allToLeftBtn_Click);
            // 
            // oneToLeftBtn
            // 
            this.oneToLeftBtn.Location = new System.Drawing.Point(388, 260);
            this.oneToLeftBtn.Name = "oneToLeftBtn";
            this.oneToLeftBtn.Size = new System.Drawing.Size(40, 27);
            this.oneToLeftBtn.TabIndex = 6;
            this.oneToLeftBtn.Text = "<";
            this.oneToLeftBtn.UseVisualStyleBackColor = true;
            this.oneToLeftBtn.Click += new System.EventHandler(this.oneToLeftBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allToLeftBtn);
            this.Controls.Add(this.oneToLeftBtn);
            this.Controls.Add(this.allToRightBtn);
            this.Controls.Add(this.oneToRightBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxLabTrainees);
            this.Controls.Add(this.checkedListBoxTrainees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxTrainees;
        private System.Windows.Forms.CheckedListBox checkedListBoxLabTrainees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button oneToRightBtn;
        private System.Windows.Forms.Button allToRightBtn;
        private System.Windows.Forms.Button allToLeftBtn;
        private System.Windows.Forms.Button oneToLeftBtn;
    }
}

