using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tigran_ohannessian_task1
{
    public abstract class unit
    {
        // declearing some protected ints

        protected int X;

        protected int Y;

        protected string Team;

        protected int HP;

        protected int MaxHp;

        protected int Speed;

        protected int Attack;

        protected int Team2;

        protected int ATKrange;

        protected string wenATKimage;

        protected string Name;


        ///i dont understand how to use these properly but as i understand wer gaining access to our protected class



        public class UNIT : unit
        {
            public void U()
            {

                 Random rnd = new Random();
                
              
                base.Team = Team;
                base.Attack = Attack;
                base.Speed = Speed;
                base.MaxHp = MaxHp;
                base.ATKrange = ATKrange;
                base.X = rnd.Next(1,20);
                base.Y = rnd.Next(1, 20);
                base.Name = Name;
                base.HP = HP;
                base.wenATKimage = wenATKimage;





                class Unit
            {
                private int damage;
                public int Damage
                {
                    get { return damage; }
                    set { damage = Damage; }
                }




            }
        }

        
       
            

           


    public abstract void posnew(int x, int y);
        public abstract void fighting(int health, int attack, ref unit attack1, unit name);
        public abstract bool rngcheck(int x, int y, ref unit attack);
        public abstract unit nearestUnit(int x, int y);
        public abstract void death(int health, int x, int y);
        public abstract override string ToString();
    }

}




