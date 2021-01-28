using System;
using System.Drawing;
using System.Windows.Forms;

namespace Draughtboard
{
    public partial class Form1 : Form // Form1 extends Form (Inheritance)
    {
        public Form1()
        {
            InitializeComponent(); // Constructor(yapıcı metot)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons(); // Metod olarak çağırdık
        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {

                for (int j = 0; j <= buttons.GetUpperBound(1); j++) //GetUpperbound0 = 7
                {
                    buttons[i, j] = new Button(); // Button bir classtır, örneğini oluşturmuş oluruz.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    left += 50;
                    buttons[i, j].Top = top;

                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]); // Button'u ekrana koyar.
                }
                left = 0; // Diğer satıra geçildiğinde sola geçilmesi için sıfırlanması gerekir.
                top += 50; // Diğer satıra geçildiğinde aşağıya geçilmesi için arttırılması gerekir.
            }
        }
    }
}
