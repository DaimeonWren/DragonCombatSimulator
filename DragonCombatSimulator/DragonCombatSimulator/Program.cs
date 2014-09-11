using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCombatSimulator
{
    class Program
    {
       // I set all my global variables, the health for my two fighters
        static int LeonHealth = 1500;
        static int CloudsHealth = 1100;
       // I use the random number gen to call it into any of my functions
        Random rng = new Random();
        static string UserName = string.Empty;
      
        static void Main(string[] args)
        {
           Console.Title ="Final Fantasy";
            Console.WriteLine("You! What is your name?!?");
                Opening(UserName);
            Fight();
        }
        static void Opening(@" ")
        static void Fight()
        {
        bool loop = true;
            while(loop)
         {
            if (LeonHealth < 1 && CloudsHealth > 1)
            {
            Console.WriteLine("You have defeated Leon");
                Console.ReadKey();
             loop = false;
                break;
            }
            else if (LeonHealth > 1 && CloudsHealth < 1)
            {
            Console.WriteLine("Leon has split you in two.");
                Console.ReadKey();
                loop = false;
                break;
            }
            else if (LeonHealth < 1 && CloudsHealth <1)
            {
            Console.WriteLine("You both have bested one another, you take shelter to fight another day.");
                Console.ReadKey();
                loop = false;
                break;
                GamePlay();
            }
        } 
     }  
        static void GamePlay()
        {
        Console.WriteLine("Clouds Health" + CloudsHealth + "\n Leons Health sits at: " +LeonHealth);
            Console.WriteLine("Ready yourself Cloud!");
            string input = Console.ReadLine();
            switch (input.ToLower()) 
            {
                case "1":
                    Console.WriteLine("You Dash sword straight for Leon!");
                    turn (input); 
                    break;
                case "2":
                    Console.WriteLine("Your hand conjures up some lightning");
                    turn (input);
                    break;
                case "3":
                    Console.WriteLine("You take a health postion");
                    turn (input);
                    break;

            }
        }
        static void turn(string input)
        {
        int dmg  = 0;
            switch(input)
            {
                case "1":
                    if (rng.Next(100,201)>130)
                    {
                   Console.WriteLine("Great hit! You fly through Leon with your sword dash.");
                        dmg = rng.Next(100,200);
                        Console.WriteLine(dmg + " damage has been done");
                        LeonHealth -= dmg;
                    }
                    else 
                    {
                    Console.WriteLine("Damn! He's much faster than he looks, you missed");
                    }
                    break;
               
                case "2":
                    if (rng.Next(50,120)<0)
                    {
                   Console.WriteLine("You can't dodoge lighting!");
                        dmg = rng.Next(50,120);
                        Console.WriteLine(dmg + " damage has been done");
                        LeonHealth -= dmg;
                    }
                    break;

                case"3":
                    dmg = rng.Next(50, 70);
                    Console.WriteLine("You heal for "+dmg);
                    CloudsHealth += dmg;
                    break;
            
            }
            if (rng.Next(120, 250)>175)
            {
                Console.WriteLine("Leon readies himself for an attack.");
                switch ( rng.Next(1,3)) 
                {
                    case "1":
                        dmg = rng.Next(150, 250);
                        Console.WriteLine("Leon come down on you with an aerial slash");
                        CloudsHealth -= dmg;      
                }      
       
            }
            else 
                {
                Console.WriteLine("You block his aerial attack.");
                }break;
             
            if (rng.Next(120, 150)>125)
            {  
            case "2":
            dmg = rng.Next (120,150);
            Console.WriteLine("Leon shoots you with a fireball from his GunBlade");
            CloudsHealth -= dmg;
            }
           break;

            case"3":
                    dmg = rng.Next(50, 70);
                    Console.WriteLine("Leon heals for "+dmg);
                    LeonHealth += dmg;
                    break;
            
        }
        
        static void Clean()
        {
        Console.Title = " Final Fantasy Leons health " + LeonHealth + "Clouds Health: " + CloudsHealth;

        }

