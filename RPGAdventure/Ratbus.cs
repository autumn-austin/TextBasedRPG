using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public class Ratbus : Enemy
    {
        public Ratbus()
        {
            this.Health = 5;
            this.Power = 2;
            this.Name = "Skelebone";
            this.InitialStatement =
                @"
                        ,,==.
                       //    `
                      ||      ,--~~~~-._ _(|--,_
                       \\._,-~   )      '    *  `o
                        `---~|( _/,___( /_/`---~~
                              ``==-    `==-,
                            *shakes violently* 
                     =============================
                 ";
        }

        public override void Attack()
        {
            Console.WriteLine($"You bring your torch down toward the ground when {this.Name} blocks with a wheel of sharp cheddar.");
            Console.WriteLine("*SQUEEK*");

            int damage = this.Power - Program.currentPlayer.armorValue;
            if (damage < 0)
                damage = 0;

            int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);

            Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage.");

            Program.currentPlayer.health -= damage;
            this.Health -= attack;

            Console.ReadKey();
            Console.Clear();
        }

        public override void Defend()
        {

        }
        public override void Speak()
        {

        }
        public override void Flee()
        {
            
        }
        public override void Heal()
        {

        }



    }
}
