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
    public partial class corpo : UserControl
    {
        public corpo()
        {
            InitializeComponent();
            label1.Paint += label1_Paint;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {

            label1.Text = "Manter-se Ativo com Exercícios Leves: Atividades como caminhadas, alongamentos, hidroginástica ou yoga ajudam a melhorar a mobilidade, fortalecer os músculos e preservar o equilíbrio, reduzindo o risco de quedas.\r\nHidratação Constante: O envelhecimento diminui a sensação de sede, por isso é fundamental beber água ao longo do dia para manter o corpo hidratado e prevenir problemas como desidratação e infecções urinárias.\r\nAlimentação Balanceada: Priorize uma dieta rica em fibras, proteínas magras, frutas e vegetais, além de evitar alimentos ultraprocessados. Uma boa nutrição ajuda a fortalecer o sistema imunológico e manter o peso saudável.\r\nCuidado com a Pele: A pele se torna mais fina e seca com a idade. Usar hidratantes regularmente e aplicar protetor solar ao sair de casa ajuda a evitar ressecamento, rachaduras e queimaduras solares.\r\nExames Médicos Regulares: Manter consultas de rotina e fazer check-ups regulares são essenciais para monitorar a saúde e prevenir doenças.";
        }
    }
}
