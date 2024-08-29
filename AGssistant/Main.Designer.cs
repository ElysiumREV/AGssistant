namespace AGssistant
{
    partial class Main
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
            panel1 = new Panel();
            title = new Label();
            panel2 = new Panel();
            button1 = new Button();
            panelContainer = new Panel();
            button2 = new Button();
            panel3 = new Panel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(title);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 60);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            title.ForeColor = Color.White;
            title.Location = new Point(302, 0);
            title.Name = "title";
            title.Size = new Size(193, 50);
            title.TabIndex = 0;
            title.Text = "AGssistant";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 39);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(12, 5);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(panel3);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 99);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(784, 342);
            panelContainer.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(93, 5);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 1;
            button2.Text = "Dica 1";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(784, 342);
            panel3.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(174, 5);
            button3.Name = "button3";
            button3.Size = new Size(75, 30);
            button3.TabIndex = 2;
            button3.Text = "Dica 2";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(255, 5);
            button4.Name = "button4";
            button4.Size = new Size(75, 30);
            button4.TabIndex = 3;
            button4.Text = "Dica 3";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(697, 5);
            button5.Name = "button5";
            button5.Size = new Size(75, 30);
            button5.TabIndex = 3;
            button5.Text = "Quiz";
            button5.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(784, 441);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AGssistant";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label title;
        private Panel panelContainer;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel3;
    }
}
