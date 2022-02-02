
namespace WinUI
{
    partial class GradeFourm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passingStatusTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.correctlyAnsweredTextBox = new System.Windows.Forms.TextBox();
            this.incorrectlyAnsweredTextBox = new System.Windows.Forms.TextBox();
            this.missedQuestionsListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passing Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correctly Answered";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Incorrectly Answered";
            // 
            // passingStatusTextBox
            // 
            this.passingStatusTextBox.Location = new System.Drawing.Point(124, 28);
            this.passingStatusTextBox.Name = "passingStatusTextBox";
            this.passingStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.passingStatusTextBox.TabIndex = 4;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(124, 77);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradeTextBox.TabIndex = 5;
            // 
            // correctlyAnsweredTextBox
            // 
            this.correctlyAnsweredTextBox.Location = new System.Drawing.Point(124, 126);
            this.correctlyAnsweredTextBox.Name = "correctlyAnsweredTextBox";
            this.correctlyAnsweredTextBox.Size = new System.Drawing.Size(100, 20);
            this.correctlyAnsweredTextBox.TabIndex = 6;
            // 
            // incorrectlyAnsweredTextBox
            // 
            this.incorrectlyAnsweredTextBox.Location = new System.Drawing.Point(124, 175);
            this.incorrectlyAnsweredTextBox.Name = "incorrectlyAnsweredTextBox";
            this.incorrectlyAnsweredTextBox.Size = new System.Drawing.Size(100, 20);
            this.incorrectlyAnsweredTextBox.TabIndex = 7;
            // 
            // missedQuestionsListBox
            // 
            this.missedQuestionsListBox.FormattingEnabled = true;
            this.missedQuestionsListBox.Location = new System.Drawing.Point(257, 25);
            this.missedQuestionsListBox.Name = "missedQuestionsListBox";
            this.missedQuestionsListBox.Size = new System.Drawing.Size(167, 225);
            this.missedQuestionsListBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Missed Questions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 264);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.missedQuestionsListBox);
            this.Controls.Add(this.incorrectlyAnsweredTextBox);
            this.Controls.Add(this.correctlyAnsweredTextBox);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.passingStatusTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GradeFourmLoaded);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passingStatusTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.TextBox correctlyAnsweredTextBox;
        private System.Windows.Forms.TextBox incorrectlyAnsweredTextBox;
        private System.Windows.Forms.ListBox missedQuestionsListBox;
        private System.Windows.Forms.Label label5;
    }
}

