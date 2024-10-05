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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            button6 = new Button();
            title = new Label();
            panelContainer = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            button2 = new Button();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            panelContainer.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(title);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 86);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 62);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Fira Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(370, 55);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // button6
            // 
            button6.Dock = DockStyle.Right;
            button6.Location = new Point(709, 0);
            button6.Name = "button6";
            button6.Size = new Size(75, 86);
            button6.TabIndex = 4;
            button6.Text = "Sobre";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Fira Sans", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(304, 10);
            title.Name = "title";
            title.Size = new Size(193, 45);
            title.TabIndex = 0;
            title.Text = "AGssistant";
            title.Click += title_Click;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(panel3);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 86);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(784, 355);
            panelContainer.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(784, 355);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.Font = new Font("Fira Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(582, 45);
            label2.Name = "label2";
            label2.Size = new Size(190, 40);
            label2.TabIndex = 4;
            label2.Text = "Nossas Dicas!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(582, 95);
            button2.Name = "button2";
            button2.Size = new Size(190, 30);
            button2.TabIndex = 1;
            button2.Text = "Para o Corpo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Right;
            button5.Location = new Point(582, 203);
            button5.Name = "button5";
            button5.Size = new Size(190, 30);
            button5.TabIndex = 3;
            button5.Text = "Mais Dicas";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.Location = new Point(582, 131);
            button3.Name = "button3";
            button3.Size = new Size(190, 30);
            button3.TabIndex = 2;
            button3.Text = "Para a Mente";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Right;
            button4.Location = new Point(582, 167);
            button4.Name = "button4";
            button4.Size = new Size(190, 30);
            button4.TabIndex = 3;
            button4.Text = "Para a Segurança";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(12, 6);
            label3.Name = "label3";
            label3.Size = new Size(230, 340);
            label3.TabIndex = 5;
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
        private Button button2;
        private Button button5;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}
