using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tigran_ohannessian_task1
{
    class MAP
    {
        int units = 0;

        public void Read()
        {
            // read method 
        }

        public class Map
        {
            public unit[] units = new unit[10];

            public Map()
            {
                Random r = new Random();
                for (int i = 0; i < 10; i++)
                {
                    int X = r.Next(0, 20);
                    int Y = r.Next(0, 20);
                    int Team = i % 2;
                    int tempAttack = 0;
                    switch (r.Next(0, 4))
                    {
                        case 0: tempAttack = 5; break;
                        case 1: tempAttack = 10; break;
                        case 2: tempAttack = 15; break;
                        case 3: tempAttack = 20; break;
                    }
                    switch (r.Next(0, 2))
                    {
                        case 0: units[i] = new Meleeunit(X, Y, 100, 1, tempAttack, 1, Team, i.ToString()); break;
                        case 1: units[i] = new RangedUnit(X, Y, 100, 1, tempAttack, 4, Team, i.ToString()); break;
                    }
                }
                //        units[0] = new MeleeUnit(0, 0, 100, 1, 10, 0, 0, "0");
                //        units[1] = new MeleeUnit(20, 20, 100, 1, 10, 1, 1, "0");
            }
        }
    }
