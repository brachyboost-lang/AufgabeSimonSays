using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabeSimonSays
{
    public partial class HafnerSays : Form
    {
        private int combo = 0;
        private int input = 0;
        public int Combo { get => combo; set { combo = value; UpdateDisplays(); } }
        public int Input { get => input; set { input = value; UpdateDisplays(); } }

        List<Button> sequence = new List<Button>();
        int[] colors = { 1, 2, 3, 4 };
        Random rand = new Random();

        public HafnerSays()
        {
            InitializeComponent();
            UpdateDisplays();
        }
        public void UpdateDisplays()
        {
            lb_combo.Text = "Combo: " + Combo;
            lb_input.Text = "Input: " + Input;
        }
        public void StartGame()
        {
            RndNextCombo();
            ShowCombo();
        }

        void RndNextCombo()
        {
            Combo++;
            int nextColor = colors[rand.Next(colors.Length)];
            switch (nextColor)
            {
                case 1:
                    sequence.Add(bt_red);
                    break;
                case 2:
                    sequence.Add(bt_yellow);
                    break;
                case 3:
                    sequence.Add(bt_green);
                    break;
                case 4:
                    sequence.Add(bt_blue);
                    break;
            }
        }
        void ShowCombo()
        {
            foreach (Button btn in sequence)
            {
                btn.BackColor = Color.FromArgb(255, 255, 255);
                Thread.Sleep(500);
                btn.BackColor = Color.FromArgb(255, 192, 192);
            }
        }
        void PlayerInput(object btn, EventArgs e)
        {
            Button button = btn as Button;
            if (btn == sequence[Input])
            {
                Input++;
                if (Input == Combo)
                {
                    Input = 0;
                    RndNextCombo();
                    Thread.Sleep(500);
                    ShowCombo();
                }
            }
            else
            {
                MessageBox.Show("Game Over! Your combo was: " + Combo);
                Combo = 0;
                Input = 0;
                sequence.Clear();
            }
        }

        private void bt_red_Click(object sender, EventArgs e)
        {
            PlayerInput(sender, e);
        }

        private void bt_yellow_Click(object sender, EventArgs e)
        {
            PlayerInput(sender, e);
        }

        private void bt_green_Click(object sender, EventArgs e)
        {
            PlayerInput(sender, e);
        }

        private void bt_blue_Click(object sender, EventArgs e)
        {
            PlayerInput(sender, e);
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}
