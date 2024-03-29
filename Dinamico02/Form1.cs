using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamico02
{
    public partial class Form1 : Form
    {
        Button[] b = new Button[20];
        char letra = 'A'; // 0100 0001 em decimal 65 e em hexa 41
        int contador = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object Botao, EventArgs verde)
        {
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 20; ++j)
                {
                    b[j] = new Button();

                    b[j].Name = $"{j + 1}";
                    b[j].Text = letra + $"{(j + 1)}";
                    b[j].Location = new Point(50 * (j + 1), 40 * (i + 1));
                    b[j].Size = new System.Drawing.Size(40, 40);
                    b[j].BackColor = Color.ForestGreen;
                    b[j].ForeColor = System.Drawing.Color.White;
                    b[j].Click += new System.EventHandler(this.metodoGenerico);
                    Controls.Add(b[j]);

                }

                //adc enter 
                ++letra;
            }

        }

        private void metodoGenerico(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (botao.BackColor == Color.Red)
            {
                DialogResult dialogResult = MessageBox.Show("Desja cancelar a reserva?", "Cancelamento", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    botao.BackColor = Color.ForestGreen;
                    contador--;
                }

            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Desja confirmar esta reserva?", "Confirmação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    botao.BackColor = Color.Red;
                    contador++;
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int valor = contador * 20;

            MessageBox.Show($"Atualmente o faturamento do Cinema é de R${valor},00");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}