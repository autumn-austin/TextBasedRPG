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
            this.Health = 6;
            this.Power = 2;
            this.Name = "Ratbus";
            this.InitialStatement =
                @"
                        ,,==.
                       //    `
                      ||      ,--~~~~-._ _(|--,_
                       \\._,-~   )      '    *  `o
                        `---~|( _/,___( /_/`---~~
                              ``==-    `==-,
                            *shakes violently* 
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
            int damage = (this.Power / 4) - Program.currentPlayer.armorValue;
            if (damage < 0)
                damage = 0;

            int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;

            Console.WriteLine($"{this.Name} offers you cheese... There is a large mouse trap attached...");
            Console.ReadKey();
            Console.WriteLine($"You lose {damage} health from your lactose allergy and deal {attack} damage to {this.Name}.");

            Program.currentPlayer.health -= damage;
            this.Health -= attack;
            Console.ReadKey();
            Console.Clear();
        }
        public override void Speak()
        {
            //speak
            Console.WriteLine("You attempt to gain information from " + this.Name + " but " + this.Name + " offers you a bite of cheese...");
            Console.ReadKey();
            Console.WriteLine("You do love sharp cheddar.");
            Console.ReadKey();
            Console.Clear();
        }
        public override void Flee()
        {
            //flee
            if (rand.Next(0, 2) == 0)
            {
                Console.WriteLine($"You attempt to flee... but it looks like {this.Name} has a strong gaze upon you.");
                Console.WriteLine("I don't think you are going anywhere...");
                int damage = this.Power - Program.currentPlayer.armorValue;

                if (damage < 0)
                    damage = 0;

                Console.WriteLine($"You lose {damage} health, and are unable to escape.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"You use a ball of Mozzorella to distract {this.Name} as you slink away to safety.");
                Console.ReadKey();
                new Town().Load(Program.currentPlayer);
                // CALL GO TO TOWN, FROM TOWN CAN ENTER STORE, CREATE CLASS FOR TOWN
            }
        }

        public override void Heal()
        {
            //heal
            if (Program.currentPlayer.potion == 0)
            {
                Console.WriteLine("You frantically search your pockets...");
                Console.WriteLine("...pocket lint...");
                int damage = this.Power - Program.currentPlayer.armorValue;
                if (damage < 0)
                    damage = 0;

                Console.WriteLine($"You take {damage} and {this.Name} wriggles around excitedly.");

                Console.ReadKey();
                Console.Clear();
            }

            else
            {
                Console.WriteLine("You frantically search your pockets...");
                Console.WriteLine("A giant red vial you pull from your pocket.");
                Console.WriteLine("How did that fit in there?\nYou drink the vial.");
                int potionValue = 5;
                Console.WriteLine($"You gain {potionValue} health and get the jitters.");
                Program.currentPlayer.health += potionValue;
                Program.currentPlayer.potion -= 1;
                Console.WriteLine("You had your back turned searching your pockets...");
                Console.WriteLine(this.Name + " strikes you in the rear. You blush...");
                int damage = (this.Power / 2) - Program.currentPlayer.armorValue;
                if (damage < 0)
                    damage = 0;
                Console.WriteLine($"You lose {damage} health.");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
        
}
