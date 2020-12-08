/*
* Space Disaster
* Yazan Al Akkad, 20-10-2020
* Copyrights reserved to the author
* 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing;
using Console = Colorful.Console;

namespace Space_Disasters
{
    class Program
    {

        private static void Main(string[] args)
        {
            //Prints out the game title and overview, then it proceeds to the next sections
            GameTitle();
        }




        //====================================================================================//
        //Identifiers and classes:

        //This will change the Console.writeline into Writeline instead
        private static void Writeline(string text, Color color)
        {

            Console.WriteLine(text, color);
        }

        private static void Write(string text, Color color)
        {

            Console.Write(text, color);

        }

        //Character name identifier
        private static String CharacterName;

        //Inventory identifier
        private static List<string> Inventory = new List<string>();

        //This will read the input as a string
        private static string input;

        //This will change the color of the input and accept lowercase characters
        private static void AnswerInput()
        {

            System.Console.ForegroundColor = ConsoleColor.White;
            input = System.Console.ReadLine();
            input = input.ToLower();
            Console.ResetColor();
        }

        //This is just showing the "Please enter your choice: " text in Red
        private static void EnterYourChoice()
        {

            Write("Please enter your choice: ", Color.Red);

        }

        //This is just showing the "Press any key to continue " text in Red
        private static void PressEnter()
        {

            Writeline("Press any key to continue!\n", Color.Red);


        }

        //This will display a thanks message
        private static void ThanksMyDude()
        {

            Writeline("Thank you for playing. Do you want to try again? Enter your answer below:\n", Color.Green);

        }

        //=========================================================================================//



        //This is a maximizing function which calls a special windows dll file to maximize the console
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);

        private static void Maximize()
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3); //SW_MAXIMIZE = 3
        }



        private static void GameTitle()
        {
            //Call the maximizing funtion which has been added
            Maximize();

            //Changes the color to blue!
            //Here is the ASCII title
            Console.Title = "Space Disaster - V1.0";

            string title = @"


             ::::::::  :::::::::     :::      ::::::::  ::::::::::       ::::::::: ::::::::::: ::::::::      :::      :::::::: ::::::::::: :::::::::: :::::::::  
            :+:    :+: :+:    :+:  :+: :+:   :+:    :+: :+:              :+:    :+:    :+:    :+:    :+:   :+: :+:   :+:    :+:    :+:     :+:        :+:    :+: 
            +:+        +:+    +:+ +:+   +:+  +:+        +:+              +:+    +:+    +:+    +:+         +:+   +:+  +:+           +:+     +:+        +:+    +:+ 
            +#++:++#++ +#++:++#+ +#++:++#++: +#+        +#++:++#         +#+    +:+    +#+    +#++:++#++ +#++:++#++: +#++:++#++    +#+     +#++:++#   +#++:++#:  
                   +#+ +#+       +#+     +#+ +#+        +#+              +#+    +#+    +#+           +#+ +#+     +#+        +#+    +#+     +#+        +#+    +#+ 
            #+#    #+# #+#       #+#     #+# #+#    #+# #+#              #+#    #+#    #+#    #+#    #+# #+#     #+# #+#    #+#    #+#     #+#        #+#    #+# 
             ########  ###       ###     ###  ########  ##########       ######### ########### ########  ###     ###  ########     ###     ########## ###    ### 
";
            Writeline(title, Color.Blue);

            Writeline("", Color.White);

            Copyrights();

            Console.ResetColor();
            string start = "Press Enter to continue...";
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + start.Length / 2) + "}", start);

            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

            StartGame();
        }









        //Here is the game start code which calls for character and carrys on
        private static void StartGame()
        {

            Console.Write("Welcome ", Color.Blue);
            Console.ResetColor();
            Console.Write("user", Color.White);
            Console.Write(", to your first mission with the coalition of Nasa & SpaceX space organizations!\n", Color.Blue);

            Writeline("", Color.White);
            NameCharacter();
            Choice();
            EndGame();
        }








        //Copyrights section
        private static void Copyrights()
        {
            //Sets the color to red and prints out the owner's name which is me, basically..
            string owner = "Owner: Yazan Al Akkad\n";
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("{0," + ((Console.WindowWidth / 2) + owner.Length / 2) + "}", owner);

            //Changes the color to blue
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Copyrights :D
            string copy = "Copyrights reserved 2020 - 2021\n";
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + copy.Length / 2) + "}", copy);


        }









        //asks player for name and save it
        private static void NameCharacter()
        {

            Writeline("What would you like your name to be?\n", Color.Blue);

            //Changes the color back to white
            Console.ResetColor();

            CharacterName = Console.ReadLine();
            Writeline("", Color.White);


            Console.Write("Great! Nice to have you on board ", Color.Blue);

            //Prints out the chosen name for the main character
            Console.Write(CharacterName, Color.White);


            Writeline(", we are excited to have you here!\n", Color.Blue);

            //Resets the color again
            Console.ResetColor();

            PressEnter();

            //Waiting for key to be pressed
            Console.ReadKey();

            //Clears the console
            Console.Clear();
        }








        private static void Choice()
        {
            //Scenarios count and loop funtion
            for (int scenario = 1; scenario <= Scenarios; scenario++)
            {



                //Here it will run through all scenarios one by one 
                switch (scenario)
                {




















                }
            }
        }

        private static int Scenarios = 3;

        private static string[] PartOne = {

           


        };

        private static string[] PartTwo = {

            
        };

        private static string[] PartThree = {

           
        };







        //A new class of the items
        private static class Items
        {


        }






        private static void Congratz()
        {
            Console.Clear();

            string YouwinTitle = (@"
                                                        ____                            _         _       _   _                 _ 
                                                       / ___|___  _ __   __ _ _ __ __ _| |_ _   _| | __ _| |_(_) ___  _ __  ___| |
                                                      | |   / _ \| '_ \ / _` | '__/ _` | __| | | | |/ _` | __| |/ _ \| '_ \/ __| |
                                                      | |__| (_) | | | | (_| | | | (_| | |_| |_| | | (_| | |_| | (_) | | | \__ \_|
                                                       \____\___/|_| |_|\__, |_|  \__,_|\__|\__,_|_|\__,_|\__|_|\___/|_| |_|___(_)
                                                                        |___/                                                                                                    
");
            Writeline(YouwinTitle, Color.Green);

            Writeline("You've made it to the base safe and sound!", Color.Green);

            Write("\n\n" + CharacterName, Color.White);
            Write(" you have collected the following throughout your journey:\n\n", Color.Purple);

            //This will list the items in inventory
            foreach (string item in Inventory)
                Writeline(item + Environment.NewLine, Color.White);


            if (Inventory.Contains("Astroid samples"))
            {

                Writeline("\n\nGood job! You have collected the samples and returned them to the earth command base, now scientists can study them for future missions!", Color.AliceBlue);
            }
            else
                Writeline("\n\nYou haven't gotten the smaples, scientists are big mad!\n\n", Color.MediumVioletRed);


            //Thnking the player ofr playing and asks if he/she wants to play again!
            ThanksMyDude();
            AnswerInput();

            //Resturn back after loosing or finishing the game
            if (input == "yes")
            {

                Console.ResetColor();
                Console.Clear();
                StartGame();
            }
            else
                Environment.Exit(0);
        }







        private static void EndGame()
        {
            Console.Clear();

            //Game over text
            string gameover = (@"

                                     ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ ██╗
                                    ██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗██║
                                    ██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝██║
                                    ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗╚═╝
                                    ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║██╗
                                     ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝╚═╝
               
");
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("{0," + ((Console.WindowWidth / 2) + gameover.Length / 2) + "}", gameover);

            Writeline("You died! What unfortunate....", Color.DarkRed);

            Write("\n\n" + CharacterName, Color.White);
            Write(" you have lost all of your items in space", Color.Red);

            //This will list the items in inventory
            foreach (string item in Inventory)
                Writeline(item + Environment.NewLine, Color.White);


            //Thnking the player ofr playing and asks if he/she wants to play again!
            ThanksMyDude();
            AnswerInput();

            //Resturn back after loosing or finishing the game
            if (input == "yes")
            {

                Console.ResetColor();
                Console.Clear();
                StartGame();
            }
            else
                Environment.Exit(0);
        }
    }
}
