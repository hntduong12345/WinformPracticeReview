namespace WinFormsDemo
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
            btn_Play = new Button();
            btn_PlayAgain = new Button();
            btn_NewRound = new Button();
            btn_Close = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btn_Play
            // 
            btn_Play.Location = new Point(349, 97);
            btn_Play.Name = "btn_Play";
            btn_Play.Size = new Size(107, 41);
            btn_Play.TabIndex = 0;
            btn_Play.Text = "Play";
            btn_Play.UseVisualStyleBackColor = true;
            btn_Play.Click += btn_Play_Click;
            // 
            // btn_PlayAgain
            // 
            btn_PlayAgain.Location = new Point(349, 160);
            btn_PlayAgain.Name = "btn_PlayAgain";
            btn_PlayAgain.Size = new Size(107, 41);
            btn_PlayAgain.TabIndex = 1;
            btn_PlayAgain.Text = "PlayAgain";
            btn_PlayAgain.UseVisualStyleBackColor = true;
            // 
            // btn_NewRound
            // 
            btn_NewRound.Location = new Point(349, 226);
            btn_NewRound.Name = "btn_NewRound";
            btn_NewRound.Size = new Size(107, 41);
            btn_NewRound.TabIndex = 2;
            btn_NewRound.Text = "New Round";
            btn_NewRound.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(349, 295);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(107, 41);
            btn_Close.TabIndex = 3;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(517, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btn_Close);
            Controls.Add(btn_NewRound);
            Controls.Add(btn_PlayAgain);
            Controls.Add(btn_Play);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Play;
        private Button btn_PlayAgain;
        private Button btn_NewRound;
        private Button btn_Close;
        private TextBox textBox1;
    }
}
