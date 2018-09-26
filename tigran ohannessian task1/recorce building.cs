using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tigran_ohannessian_task1
{
    class recorce_building
    {

     abstract class building;
    {


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

        protected string faction;

        protected int ResourceType;

        protected int ResourcesPergameTick;

        protected int ResourcesRemaining;



       

      
       
    }



    public building(string team2, int x, int y, int HP, int Speed, int attack, int atkRNG, string team, string wenATKimag)
    {



    }
    string Faction;
    public override string ToString()
    {
        string faction;
        if (team == Faction)
            faction = "green";
        else
            faction = "yellow";
        return "Building\nHP: " + HP + "\nFaction: " + faction;
    }
}

