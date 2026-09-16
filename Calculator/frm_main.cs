using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frm_main : Form
    {
        private char[,] buttons =
        {
            {'%', '\u0152', 'C', '\u232B'},
            {'\u215F', '\u00B2', '\u221A', '\u00F7'},
            {'7', '8', '9', 'X'},
            {'4', '5', '6', '-'},
            {'1', '2', '3', '+'},
            {'\u00B1', '0', ',', '='} //\u permette di definire un carattere col codice unicode
        };

        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            Make_Buttons();
        }

        private void Make_Buttons()
        {
            int btn_width = 80, btn_height = 60;
            int pos_y = 106;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                int pos_x = 0;
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    Button btn = new Button();
                    btn.Width = btn_width;
                    btn.Height = btn_height;
                    btn.Left = pos_x;
                    btn.Top = pos_y;
                    btn.Font = new Font("Segoe UI", 16);
                    btn.Text = buttons[i, j].ToString();
                    this.Controls.Add(btn);

                    pos_x += btn_width;
                }
                pos_y += btn_height;
            }
        }
    }
}
