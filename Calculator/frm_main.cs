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

        private Label RESULT_LABEL;

        public struct Btn_Struct
        {
            public char Content;
            public Color Bg_Color;
            public Btn_Struct(char content, Color bg_color)
            {
                this.Content = content;
                this.Bg_Color = bg_color;
            }

            //Necessario mettere override qui così che sia relativo alla struct
            public override string ToString() //Modifichiamo il tostring in modo che restituisce il testo bene senza .content
            {
                return Content.ToString();
            }
        }

        private Btn_Struct[,] buttons =
        {
            {new Btn_Struct('%', OPERATION_BG), new Btn_Struct('\u0152', OPERATION_BG), new Btn_Struct('C', OPERATION_BG), new Btn_Struct('\u232B', OPERATION_BG)},
            {new Btn_Struct('\u215F', OPERATION_BG), new Btn_Struct('\u00B2', OPERATION_BG), new Btn_Struct('\u221A', OPERATION_BG), new Btn_Struct('\u00F7', OPERATION_BG)},
            {new Btn_Struct('7', NUMBER_BG), new Btn_Struct('8', NUMBER_BG), new Btn_Struct('9', NUMBER_BG), new Btn_Struct('X', OPERATION_BG)},
            {new Btn_Struct('4', NUMBER_BG), new Btn_Struct('5', NUMBER_BG), new Btn_Struct('6', NUMBER_BG), new Btn_Struct('-', OPERATION_BG)},
            {new Btn_Struct('1', NUMBER_BG), new Btn_Struct('2', NUMBER_BG), new Btn_Struct('3', NUMBER_BG), new Btn_Struct('+', OPERATION_BG)},
            {new Btn_Struct('\u00B1', NUMBER_BG), new Btn_Struct('0', NUMBER_BG), new Btn_Struct(',', NUMBER_BG), new Btn_Struct('=', EQUAL_BG)} //\u permette di definire un carattere col codice unicode
        };

        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            Make_Result_Label();
            Make_Buttons();
        }

        private void Make_Result_Label()
        {
            RESULT_LABEL = new Label()
            {
                Font = new Font("Segoe", 16),
                TextAlign = ContentAlignment.MiddleRight,
                AutoSize = false,
                Location = new Point(0, 0),
                Size = new Size(this.Width, 100)
                //BackColor = Color.Red
            };

            this.Controls.Add(RESULT_LABEL);
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
                    //btn.Text = buttons[i, j].Content.ToString();
                    btn.Text = buttons[i, j].ToString();
                    btn.BackColor = buttons[i, j].Bg_Color;

                    btn.Click += Btn_Click;
                    this.Controls.Add(btn);

                    pos_x += btn_width;
                }
                pos_y += btn_height;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
