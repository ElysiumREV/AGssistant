using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGssistant
{
    public partial class mental : UserControl
    {
        public mental()
        {
            InitializeComponent();

            label1.Paint += label1_Paint;
        }

        private void mental_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = "Estimulação Cognitiva: Atividades como palavras-cruzadas, leitura, quebra-cabeças e jogos de tabuleiro ajudam a exercitar o cérebro e a manter as funções cognitivas em alta.\r\nAprendizado Contínuo: Manter-se curioso e aberto a aprender coisas novas, como um hobby, uma língua estrangeira ou habilidades tecnológicas, é ótimo para estimular o cérebro e prevenir o declínio cognitivo.\r\nSocialização: Participar de atividades sociais, seja com a família, amigos ou em grupos da comunidade, ajuda a reduzir o risco de solidão e depressão, além de manter a mente engajada.\r\nMeditação e Relaxamento: Praticar meditação, mindfulness ou técnicas de respiração profunda auxilia na redução do estresse e da ansiedade, promovendo clareza mental e bem-estar emocional.\r\nSono de Qualidade: Ter um sono reparador é essencial para a saúde mental. Dormir de 7 a 8 horas por noite ajuda na consolidação de memórias e na regeneração do cérebro.";
        }
    }
}
