namespace MathGameProject
{
    partial class GameScreen
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
            instrLabel = new Label();
            pictureBoxQuestion = new PictureBox();
            pictureBoxAnswer1 = new PictureBox();
            pictureBoxAnswer2 = new PictureBox();
            pictureBoxAnswer3 = new PictureBox();
            textBoxAnswer1 = new TextBox();
            textBoxAnswer2 = new TextBox();
            textBoxAnswer3 = new TextBox();
            buttonSubmit1 = new Button();
            buttonSubmit2 = new Button();
            buttonSubmit3 = new Button();
            buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnswer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnswer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnswer3).BeginInit();
            SuspendLayout();
            // 
            // instrLabel
            // 
            instrLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            instrLabel.AutoSize = true;
            instrLabel.Font = new Font("Aharoni", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instrLabel.Location = new Point(701, 9);
            instrLabel.Name = "instrLabel";
            instrLabel.Size = new Size(384, 28);
            instrLabel.TabIndex = 0;
            instrLabel.Text = "ספרו כל חיה ורשמו כמה יש מכל אחת";
            // 
            // pictureBoxQuestion
            // 
            pictureBoxQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxQuestion.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxQuestion.Location = new Point(54, 60);
            pictureBoxQuestion.Name = "pictureBoxQuestion";
            pictureBoxQuestion.Size = new Size(1018, 278);
            pictureBoxQuestion.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxQuestion.TabIndex = 1;
            pictureBoxQuestion.TabStop = false;
            // 
            // pictureBoxAnswer1
            // 
            pictureBoxAnswer1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAnswer1.Location = new Point(54, 366);
            pictureBoxAnswer1.Name = "pictureBoxAnswer1";
            pictureBoxAnswer1.Size = new Size(215, 217);
            pictureBoxAnswer1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAnswer1.TabIndex = 2;
            pictureBoxAnswer1.TabStop = false;
            // 
            // pictureBoxAnswer2
            // 
            pictureBoxAnswer2.Location = new Point(456, 366);
            pictureBoxAnswer2.Name = "pictureBoxAnswer2";
            pictureBoxAnswer2.Size = new Size(218, 217);
            pictureBoxAnswer2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAnswer2.TabIndex = 3;
            pictureBoxAnswer2.TabStop = false;
            // 
            // pictureBoxAnswer3
            // 
            pictureBoxAnswer3.Location = new Point(867, 366);
            pictureBoxAnswer3.Name = "pictureBoxAnswer3";
            pictureBoxAnswer3.Size = new Size(205, 217);
            pictureBoxAnswer3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAnswer3.TabIndex = 4;
            pictureBoxAnswer3.TabStop = false;
            // 
            // textBoxAnswer1
            // 
            textBoxAnswer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAnswer1.Location = new Point(70, 589);
            textBoxAnswer1.Name = "textBoxAnswer1";
            textBoxAnswer1.Size = new Size(175, 23);
            textBoxAnswer1.TabIndex = 5;
            // 
            // textBoxAnswer2
            // 
            textBoxAnswer2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAnswer2.Location = new Point(475, 589);
            textBoxAnswer2.Name = "textBoxAnswer2";
            textBoxAnswer2.Size = new Size(175, 23);
            textBoxAnswer2.TabIndex = 6;
            // 
            // textBoxAnswer3
            // 
            textBoxAnswer3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAnswer3.Location = new Point(885, 589);
            textBoxAnswer3.Name = "textBoxAnswer3";
            textBoxAnswer3.Size = new Size(175, 23);
            textBoxAnswer3.TabIndex = 7;
            // 
            // buttonSubmit1
            // 
            buttonSubmit1.BackColor = Color.LightGray;
            buttonSubmit1.FlatAppearance.BorderSize = 5;
            buttonSubmit1.Font = new Font("Aharoni", 12F, FontStyle.Bold);
            buttonSubmit1.Location = new Point(92, 618);
            buttonSubmit1.Name = "buttonSubmit1";
            buttonSubmit1.Size = new Size(114, 23);
            buttonSubmit1.TabIndex = 8;
            buttonSubmit1.Text = "בדיקה";
            buttonSubmit1.UseVisualStyleBackColor = false;
            // 
            // buttonSubmit2
            // 
            buttonSubmit2.BackColor = Color.LightGray;
            buttonSubmit2.FlatAppearance.BorderSize = 5;
            buttonSubmit2.Font = new Font("Aharoni", 12F, FontStyle.Bold);
            buttonSubmit2.Location = new Point(498, 618);
            buttonSubmit2.Name = "buttonSubmit2";
            buttonSubmit2.Size = new Size(109, 23);
            buttonSubmit2.TabIndex = 9;
            buttonSubmit2.Text = "בדיקה";
            buttonSubmit2.UseVisualStyleBackColor = false;
            // 
            // buttonSubmit3
            // 
            buttonSubmit3.BackColor = Color.LightGray;
            buttonSubmit3.FlatAppearance.BorderSize = 5;
            buttonSubmit3.Font = new Font("Aharoni", 12F, FontStyle.Bold);
            buttonSubmit3.Location = new Point(918, 618);
            buttonSubmit3.Name = "buttonSubmit3";
            buttonSubmit3.Size = new Size(104, 23);
            buttonSubmit3.TabIndex = 10;
            buttonSubmit3.Text = "בדיקה";
            buttonSubmit3.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Transparent;
            buttonExit.FlatAppearance.BorderSize = 2;
            buttonExit.Location = new Point(0, -3);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(127, 40);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "לסגור משחק";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1084, 644);
            Controls.Add(buttonExit);
            Controls.Add(buttonSubmit3);
            Controls.Add(buttonSubmit2);
            Controls.Add(buttonSubmit1);
            Controls.Add(textBoxAnswer3);
            Controls.Add(textBoxAnswer2);
            Controls.Add(textBoxAnswer1);
            Controls.Add(pictureBoxAnswer3);
            Controls.Add(pictureBoxAnswer2);
            Controls.Add(pictureBoxAnswer1);
            Controls.Add(pictureBoxQuestion);
            Controls.Add(instrLabel);
            Name = "GameScreen";
            Text = "GameScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnswer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnswer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnswer3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label instrLabel;
        private PictureBox pictureBoxQuestion;
        private PictureBox pictureBoxAnswer1;
        private PictureBox pictureBoxAnswer2;
        private PictureBox pictureBoxAnswer3;
        private TextBox textBoxAnswer1;
        private TextBox textBoxAnswer2;
        private TextBox textBoxAnswer3;
        private Button buttonSubmit1;
        private Button buttonSubmit2;
        private Button buttonSubmit3;
        private Button buttonExit;
    }
}