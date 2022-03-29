using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventure
{
    public class Ghostopher : Enemy
    {
        public Ghostopher()
        {
            Console.Clear();
            this.Health = 5;
            this.Power = 2;
            this.Name = "Ghostopher";
            this.InitialStatement =
                @"
     .-.
   .'   `.
   :g g   :
   : o    `.
  :         ``.
 :             `.
:  :         .   `.
:   :          ` . `.
 `.. :            `. ``;
    `:;             `:'
       :              `.
        `.              `.     .
         `'`'`'`---..,___`;.-'
        'Oooooo Spooooooky'      
===============================";
        }

        public override void Attack()
        {
            Console.WriteLine($"You smack {this.Name} with your torch.{this.Name} doesn't feel anything.");
            Console.WriteLine($"You forgot {this.Name} is a ghost...");

            int damage = this.Power - Program.currentPlayer.armorValue;
            if (damage < 0)
                damage = 0;
            int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);

            Program.currentPlayer.health -= damage;
            this.Health -= attack;

        }

        public override void Defend()
        {
            int damage = (this.Power / 4) - Program.currentPlayer.armorValue;
            if (damage < 0)
                damage = 0;

            int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;

            Console.WriteLine($"You lose sight of {this.Name} but {this.Name} feel a cold spot on your head.");
            Console.ReadKey();
            Console.WriteLine("'I'm your hat now.'");
            Console.ReadKey();
            Console.WriteLine($"You lose {damage} health from from shivering and deal {attack} damage to {this.Name}'s sheet. It's egyptian cotton.");

            Program.currentPlayer.health -= damage;
            this.Health -= attack;
        }

        public override void Speak()
        {
            //speak
            Console.WriteLine("You attempt to gain information from " + this.Name + " but " + this.Name + " just sways in the wind.");
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
                Console.WriteLine($"You distract {this.Name} with a new silk sheet as you slink away to safety.");
                Console.ReadKey();
                Console.ResetColor();
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
