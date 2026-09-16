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
        static private Color OPERATION_BG = Color.LightGray;
        static private Color NUMBER_BG = Color.WhiteSmoke;
        static private Color EQUAL_BG = Color.LightSeaGreen;

        public struct Btn_Struct
        {
            public char Content;
            public Color Bg_Color;
            public Btn_Struct(char content, Color bg_color)
            {
                this.Content = content;
                this.Bg_Color = bg_color;
            }
        }

        
        private Btn_Struct[,] buttons =
        {
            {new Btn_Struct('%', OPERATION_BG), new Btn_Struct('\u0152', OPERATION_BG), new Btn_Struct('C', OPERATION_BG), new Btn_Struct('\u232B', OPERATION_BG)},
            {new Btn_Struct('\u215F', OPERATION_BG), new Btn_Struct('\u00B2', OPERATION_BG), new Btn_Struct('\u221A', OPERATION_BG), new Btn_Struct('\u00F7', OPERATION_BG)},
            {new Btn_Struct('7', NUMBER_BG), new Btn_Struct('8', NUMBER_BG), new Btn_Struct('9', NUMBER_BG), new Btn_Struct('X', OPERATION_BG)},
            {new Btn_Struct('4', NUMBER_BG), new Btn_Struct('5', NUMBER_BG), new Btn_Struct('6', NUMBER_BG), new Btn_Struct('-', OPERATION_BG)},
            {new Btn_Struct('1', NUMBER_BG), new Btn_Struct('2', NUMBER_BG), new Btn_Struct('3', NUMBER_BG), new Btn_Struct('+', OPERATION_BG)},
            {new Btn_Struct('\u00B1', OPERATION_BG), new Btn_Struct('0', NUMBER_BG), new Btn_Struct(',', OPERATION_BG), new Btn_Struct('=', EQUAL_BG)} //\u permette di definire un carattere col codice unicode
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
                    btn.Text = buttons[i, j].Content.ToString();
                    btn.BackColor = buttons[i, j].Bg_Color;
                    this.Controls.Add(btn);

                    pos_x += btn_width;
                }
                pos_y += btn_height;
            }
        }
    }
}
