using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace tigran_ohannessian_task1
{
    class GameEngine
    {


        public MAP MAP = new MAP();
        private Form1 form;
        private GroupBox messageGroup;

        public GameEngine(Form1 form, GroupBox messageGroup)
        {
            this.form = form;
            this.messageGroup = messageGroup;
            foreach (unit u in MAP.units)
            {
                Button b = new Button();



                




                b.Text = u.wenatkimg;

                b.Location = new Point(u.y * 35, u.y * 35);
                b.Size = new Size(30, 30);

                if (u.Team == 0)
                {
                    b.BackColor = Color.Red;
                }
                else
                {
                    b.BackColor = Color.Green;
                }

                if (u.GetType() == typeof(Meleeunit))
                {
                    b.ForeColor = Color.White;
                }
                else
                {
                    b.ForeColor = Color.Black;
                }

                b.Click += buttonClick;
                this.form.Controls.Add(b);
            }
        }

        public void UpdateDisplay()
        {
            form.Controls.Clear();
            form.Controls.Add(messageGroup);
            foreach (unit  u in MAP.unit)
            {
                Button b = new Button();
                b.Location = new Point(u.x * 35, u.y * 35);
                b.Size = new Size(30, 30);
                b.Text = u.wenatkimg;

                if (u.team2 == 0)
                {
                    b.BackColor = Color.Red;
                }
                else
                {
                    b.BackColor = Color.Green;
                }

                if (u.GetType() == typeof(Meleeunit))
                {
                    b.ForeColor = Color.White;
                }
                else
                {
                    b.ForeColor = Color.Black;
                }

                b.Click += buttonClick;
                form.Controls.Add(b);
            }
        }

        public void UpdateMap()
        {
            foreach (unit u in MAP.unit)
            {
                unit nearunit = u.nearestUnit(ref MAP.unit);

                try
                {
                    u.Move(ref nearunit);
                }
                catch (death d)
                {
                    form.displayInfo(d.Message);
                    unit[] temp = new unit[MAP.units.Count() - 1];
                    int j = 0;
                    for (int i = 0; i < MAP.unit.Count(); i++)
                    {
                        if (u != MAP.unit[i])
                        {
                            temp[j++] = MAP.unit[i];
                        }
                    }

                    MAP.unit = temp;
                }
            }
        }

        public void buttonClick(object sender, EventArgs args)
        {
            foreach (unit u in MAP.unit)
            {
                if (((Button)sender).Text == u.wenatkimg)
                {
                    form.displayInfo(u.ToString()); // ((Button)sender).Left + " " + ((Button)sender).Right);
                    break;
                }
            }
        }
    }
}
