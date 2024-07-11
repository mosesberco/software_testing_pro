namespace MathGameProject
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
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Aharoni", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(205, 171);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(138, 58);
            button1.TabIndex = 0;
            button1.Text = "לחצו כאן";
            button1.UseVisualStyleBackColor = false;
            button1.Click += LoadGame;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Aharoni", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(60, 115);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(493, 28);
            label1.TabIndex = 1;
            label1.Text = "ברוכים הבאים! לחצו על הכפתור לתחילת המשחק";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            BackgroundImage = Properties.Resources.back2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(598, 364);
            Controls.Add(label1);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Counting Game";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Label label1;
    }
    #endregion
}
