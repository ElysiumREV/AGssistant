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
            button6 = new Button();
            title = new Label();
            button1 = new Button();
            panelContainer = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panelContainer.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(title);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 60);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.Location = new Point(697, 12);
            button6.Name = "button6";
            button6.Size = new Size(75, 30);
            button6.TabIndex = 4;
            button6.Text = "Sobre";
            button6.UseVisualStyleBackColor = true;
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
            title.Click += title_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
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
            panelContainer.Location = new Point(0, 60);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(784, 381);
            panelContainer.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(784, 381);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;   
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.Location = new Point(697, 32);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 1;
            button2.Text = "Dica 1";
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Right;
            button5.Location = new Point(697, 140);
            button5.Name = "button5";
            button5.Size = new Size(75, 30);
            button5.TabIndex = 3;
            button5.Text = "Mais Dicas";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.Location = new Point(697, 68);
            button3.Name = "button3";
            button3.Size = new Size(75, 30);
            button3.TabIndex = 2;
            button3.Text = "Dica 2";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Right;
            button4.Location = new Point(697, 104);
            button4.Name = "button4";
            button4.Size = new Size(75, 30);
            button4.TabIndex = 3;
            button4.Text = "Dica 3";
            button4.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(784, 441);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label title;
        private Panel panelContainer;
        private Panel panel3;
        private Panel drawstring;
        private Button button6;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button3;
        private Button button4;
    }
}
