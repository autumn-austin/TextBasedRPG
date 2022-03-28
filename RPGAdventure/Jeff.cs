using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    class Jeff : Enemy
    {

        public Jeff()
        {
            Console.Clear();
            this.Health = 6;
            this.Power = 2;
            this.Name = "Jeff The Amoeba";
            this.InitialStatement =
                @"
             ,,,,,,,,
           ,|||````||||
     ,,,,|||||       ||,
  ,||||```````       `||
,|||`                 |||,
||`     ....,          `|||
||     ::::::::          |||,
||     :::::::'     ||    ``|||,
||,     :::::'               `|||
`||,                           |||
 `|||,       ||          ||    ,||
   `||                        |||`
    ||                   ,,,||||
    `|||,,               ,|||
        ``|||||||||||||||`
      'Existance... hurts...
===============================";
        }

           public override void Attack()
        {
            Console.WriteLine($"You would try attacking {this.Name} but {this.Name} is too small to see.");

            int damage = this.Power - Program.currentPlayer.armorValue;
            if (damage < 0)
                damage = 0;

            int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);

            Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage.");

            Program.currentPlayer.health -= damage;
            this.Health -= attack;
        }
        public override void Defend()
        {
            int damage = (this.Power / 4) - Program.currentPlayer.armorValue;
            if (damage < 0)
                damage = 0;

            int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;

            Console.WriteLine($"{this.Name} tries to get your attention... You cant see {this.Name}.");
            Console.ReadKey();
            Console.WriteLine($"You lose {damage} health out of nowhere and deal {attack} damage to {this.Name}.");

            Program.currentPlayer.health -= damage;
            this.Health -= attack;
        }
        public override void Speak()
        {
            //speak
            Console.WriteLine("You attempt to gain information from " + this.Name + " but " + this.Name + " doesn't have much to say.");
            Console.ReadKey();
            Console.WriteLine("Why are you talking to an amoeba?");
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
            }
            else
            {
                Console.WriteLine($"You use a small Microscope to distract {this.Name} as you slink away to safety.");
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
        }

    }
}
