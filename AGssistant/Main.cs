using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace AGssistant
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();

            this.MinimumSize = new Size(this.Width, this.Height);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            title.Paint += title_Paint;
            label1.Paint += label1_Paint;
            label2.Paint += label2_Paint;
            label4.Paint += label4_Paint;
            label5.Paint += label5_Paint;
            panel2.Paint += panel2_Paint;
            button1.Paint += button1_Paint;
            button2.Paint += button2_Paint;
            button3.Paint += button3_Paint;
            button4.Paint += button4_Paint;
            button5.Paint += button5_Paint;
            button6.Paint += button6_Paint;

            // ??
            // CenterLabel(label4);
            InitializeButton(button1);
            InitializeButton(button2);
            InitializeButton(button3);
            InitializeButton(button4);
            InitializeButton(button5);
            InitializeButton(button6);

            MinimizeBox = false;
            MaximizeBox = false;

            // Adicionar Icone ao app
            // this.Icon = Properties.Resources.

            corpo1.Hide();
            mental1.Hide();
            seguranca1.Hide();
            sobreNos1.Hide();
        }

        private void InitializeButton(Button button)
        {
            string fundoAzul = "#1C5560";
            Color myColor = System.Drawing.ColorTranslator.FromHtml(fundoAzul);

            button.FlatStyle = FlatStyle.Flat; // Set the button to a flat style
            button.FlatAppearance.BorderSize = 0; // Remove the button border
            button.BackColor = Color.Transparent; // Make the button background transparent
            button.FlatAppearance.MouseOverBackColor = Color.Transparent; // Remove hover effect background
            button.FlatAppearance.MouseDownBackColor = Color.Transparent; // Remove background when clicked
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            string fundoAzul = "#1C5560";
            Color myColor = System.Drawing.ColorTranslator.FromHtml(fundoAzul);
            panel1.BackColor = myColor;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            string fundoAmarelo = "#FBFFCD";
            Color myColor = System.Drawing.ColorTranslator.FromHtml(fundoAmarelo);
            panel3.BackColor = myColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void title_Paint(object sender, PaintEventArgs e)
        {
            string fundoAzul = "#1C5560";
            Color myColor = System.Drawing.ColorTranslator.FromHtml(fundoAzul);
            title.BackColor = myColor;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //Esconder
            corpo1.Hide();
            mental1.Hide();
            seguranca1.Hide();

            //Mostrar            
            sobreNos1.Show();
        }

        private void button6_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            // Optionally, you can draw custom graphics here if needed
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Example of drawing custom text (if needed)
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle, btn.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            label2.Font = new Font("Fira Sans", 14, FontStyle.Regular);
            label2.ForeColor = Color.White;

            Label lbl = sender as Label;
            string fundoAzul = "#1C5560";
            Color myColor = System.Drawing.ColorTranslator.FromHtml(fundoAzul);

            // Define the rectangle for the label area, with padding to avoid text going out of the box
            Rectangle rect = new Rectangle(0, 0, lbl.Width, lbl.Height);

            // Define the radius for the rounded corners
            int radius = 20;

            // Create the GraphicsPath object for rounded corners
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top-left corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Top-right corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Fill the background with the rounded rectangle
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(myColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Define text bounds with padding to ensure the text fits within the rounded corners
            Rectangle textRect = new Rectangle(10, 10, lbl.Width - 20, lbl.Height - 20); // 10px padding from each side

            // Draw the text centered inside the label
            TextRenderer.DrawText(e.Graphics, lbl.Text, lbl.Font, textRect, lbl.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            corpo1.Hide();
            mental1.Hide();
            seguranca1.Hide();
            sobreNos1.Hide();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            // Optionally, you can draw custom graphics here if needed
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Example of drawing custom text (if needed)
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle, btn.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Paint(object sender, PaintEventArgs e)
        {
            label4.Text = "Bem-vindo ao AGssistant, um aplicativo que visa melhorar a qualidade de vida da população de idade trazendo dicas valiosas para sua saúde!\nPara navegar pelo aplicativo, apenas clique nos botões disponíveis nos botões laterais (aqui a direita) para ver dicas relevantes para o tipo de saúde escolhido. Caso queira voltar a esse menu, apenas clique no símbolo da casinha no canto superior esquerdo do aplicativo!";
            label4.Font = new Font("Fira Sans", 13, FontStyle.Regular);
            label4.ForeColor = Color.White;

            Label lbl = sender as Label;
            string fundoAzul = "#1C5560";
            Color myColor = System.Drawing.ColorTranslator.FromHtml(fundoAzul);

            // Define the rectangle for the label area, with padding to avoid text going out of the box
            Rectangle rect = new Rectangle(0, 0, lbl.Width, lbl.Height);

            // Define the radius for the rounded corners
            int radius = 20;

            // Create the GraphicsPath object for rounded corners
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top-left corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Top-right corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Fill the background with the rounded rectangle
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(myColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Define text bounds with padding to ensure the text fits within the rounded corners
            Rectangle textRect = new Rectangle(10, 10, lbl.Width - 20, lbl.Height - 20); // 10px padding from each side

            // Draw the text centered inside the label
            TextRenderer.DrawText(e.Graphics, lbl.Text, lbl.Font, textRect, lbl.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
        }

        private void CenterLabel(Label label)
        {
            // Calculate the center position
            int centerX = (this.ClientSize.Width - label.Width) / 2; // Center horizontally
            int centerY = (this.ClientSize.Height - label.Height) / 2; // Center vertically
            label.Location = new Point(centerX, centerY); // Set the new location
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Não lembro o que eu tava fazendo aqui

            /* 
            Panel lbl = sender as Panel;
            string fundoAzul = "#1C5560";
            Color myColor = System.Drawing.ColorTranslator.FromHtml(fundoAzul);

            // Define the rectangle for the label area, with padding to avoid text going out of the box
            Rectangle rect = new Rectangle(0, 0, lbl.Width, lbl.Height);

            // Define the radius for the rounded corners
            int radius = 20;

            // Create the GraphicsPath object for rounded corners
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top-left corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Top-right corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Fill the background with the rounded rectangle
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(myColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Define text bounds with padding to ensure the text fits within the rounded corners
            Rectangle textRect = new Rectangle(10, 10, lbl.Width - 20, lbl.Height - 20); // 10px padding from each side

            // Draw the text centered inside the label
            TextRenderer.DrawText(e.Graphics, lbl.Text, lbl.Font, textRect, lbl.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak); 
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = "Página Inicial";
            label1.Font = new Font("Fira Sans", 14, FontStyle.Regular);
            label1.ForeColor = Color.White;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Paint(object sender, PaintEventArgs e)
        {
            label5.Text = "Bem-vindo!";
            label5.Font = new Font("Fira Sans", 14, FontStyle.Regular);
            label5.ForeColor = Color.White;

            Label lbl = sender as Label;
            string fundoAzul = "#1C5560";
            Color myColor = System.Drawing.ColorTranslator.FromHtml(fundoAzul);

            // Define the rectangle for the label area, with padding to avoid text going out of the box
            Rectangle rect = new Rectangle(0, 0, lbl.Width, lbl.Height);

            // Define the radius for the rounded corners
            int radius = 20;

            // Create the GraphicsPath object for rounded corners
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top-left corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Top-right corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Fill the background with the rounded rectangle
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(myColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Define text bounds with padding to ensure the text fits within the rounded corners
            Rectangle textRect = new Rectangle(10, 10, lbl.Width - 20, lbl.Height - 20); // 10px padding from each side

            // Draw the text centered inside the label
            TextRenderer.DrawText(e.Graphics, lbl.Text, lbl.Font, textRect, lbl.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            //Esconder
            sobreNos1.Hide();
            seguranca1.Hide();
            mental1.Hide();
            
            //Mostrar
            corpo1.Show();
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            button2.Text = "Para o Corpo";

            button2.Font = new Font("Fira Sans", 10, FontStyle.Regular);
            button2.ForeColor = Color.White;

            Button btn = sender as Button;
            string fundoAzul = "#1C5560";
            Color myColor = System.Drawing.ColorTranslator.FromHtml(fundoAzul);

            // Define the rectangle for the label area, with padding to avoid text going out of the box
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);

            // Define the radius for the rounded corners
            int radius = 20;

            // Create the GraphicsPath object for rounded corners
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top-left corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Top-right corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Fill the background with the rounded rectangle
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(myColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Define text bounds with padding to ensure the text fits within the rounded corners
            Rectangle textRect = new Rectangle(10, 10, btn.Width - 20, btn.Height - 20); // 10px padding from each side

            // Draw the text centered inside the label
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, textRect, btn.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //Esconder
            corpo1.Hide();
            seguranca1.Hide();
            sobreNos1.Hide();
            
            //Mostrar
            mental1.Show();
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            button3.Text = "Para a mente";

            button3.Font = new Font("Fira Sans", 10, FontStyle.Regular);
            button3.ForeColor = Color.White;

            Button btn = sender as Button;
            string fundoAzul = "#1C5560";
            Color myColor = System.Drawing.ColorTranslator.FromHtml(fundoAzul);

            // Define the rectangle for the label area, with padding to avoid text going out of the box
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);

            // Define the radius for the rounded corners
            int radius = 20;

            // Create the GraphicsPath object for rounded corners
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top-left corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Top-right corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Fill the background with the rounded rectangle
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(myColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Define text bounds with padding to ensure the text fits within the rounded corners
            Rectangle textRect = new Rectangle(10, 10, btn.Width - 20, btn.Height - 20); // 10px padding from each side

            // Draw the text centered inside the label
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, textRect, btn.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button5_Paint(object sender, PaintEventArgs e)
        {
            button5.Text = "Mais dicas";

            button5.Font = new Font("Fira Sans", 10, FontStyle.Regular);
            button5.ForeColor = Color.White;

            Button btn = sender as Button;
            string fundoAzul = "#1C5560";
            Color myColor = System.Drawing.ColorTranslator.FromHtml(fundoAzul);

            // Define the rectangle for the label area, with padding to avoid text going out of the box
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);

            // Define the radius for the rounded corners
            int radius = 20;

            // Create the GraphicsPath object for rounded corners
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top-left corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Top-right corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Fill the background with the rounded rectangle
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(myColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Define text bounds with padding to ensure the text fits within the rounded corners
            Rectangle textRect = new Rectangle(10, 10, btn.Width - 20, btn.Height - 20); // 10px padding from each side

            // Draw the text centered inside the label
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, textRect, btn.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Esconder
            corpo1.Hide();
            mental1.Hide();
            sobreNos1.Hide();


            //Mostrar
            seguranca1.Show();
        }

        private void button4_Paint(object sender, PaintEventArgs e)
        {
            button4.Text = "Segurança";

            button4.Font = new Font("Fira Sans", 10, FontStyle.Regular);
            button4.ForeColor = Color.White;

            Button btn = sender as Button;
            string fundoAzul = "#1C5560";
            Color myColor = System.Drawing.ColorTranslator.FromHtml(fundoAzul);

            // Define the rectangle for the label area, with padding to avoid text going out of the box
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);

            // Define the radius for the rounded corners
            int radius = 20;

            // Create the GraphicsPath object for rounded corners
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top-left corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Top-right corner
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Fill the background with the rounded rectangle
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(myColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Define text bounds with padding to ensure the text fits within the rounded corners
            Rectangle textRect = new Rectangle(10, 10, btn.Width - 20, btn.Height - 20); // 10px padding from each side

            // Draw the text centered inside the label
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, textRect, btn.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
        }
    }
}
