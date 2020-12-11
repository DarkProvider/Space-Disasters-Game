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
using System.Threading;

namespace Space_Disasters
{
    class Game
    {

        private static void Main(string[] args)
        {
            //Prints out the game title and overview, then it proceeds to the next sections
            GameTitle();
        }




        //=========================================================================================//
        //Identifiers, classes and methods:

        //This will change the Console.writeline into Writeline instead
        private static void Writeline(string text, Color color)
        {

            Console.WriteLine(text, color);
        }

        //=========================================================================================//

        private static void Write(string text, Color color)
        {

            Console.Write(text, color);

        }

        //=========================================================================================//

        private static void centerText(String text, Color color)
        {
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(text, color);
        }

        //=========================================================================================//

        private static void centerTextWrite(String text, Color color)
        {
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.Write(text, color);
        }

        //=========================================================================================//

        //Character name identifier
        private static String CharacterName;

        //=========================================================================================//

        //Inventory identifier
        private static List<string> Inventory = new List<string>();

        //=========================================================================================//

        //This will read the input as a string
        private static string input;

        //=========================================================================================//

        //This will change the color of the input and accept lowercase characters
        private static void AnswerInput()
        {

            System.Console.ForegroundColor = ConsoleColor.White;
            input = System.Console.ReadLine();
            input = input.ToLower();
            Console.ResetColor();
        }

        //=========================================================================================//

        //This is just showing the "Please enter your choice: " text in Red
        private static void EnterYourChoice()
        {

            Write("Please enter your choice: ", Color.Red);

        }

        //=========================================================================================//

        //This is just showing the "Press any key to continue " text in Red
        private static void PressEnter()
        {

            Writeline("Press any key to continue!\n", Color.Red);
            Console.ReadKey();


        }
        
        //=========================================================================================//

        //This will display a thanks message
        private static void ThanksMyDude()
        {

            Writeline("\n\nThank you for playing. Do you want to try again? Enter your answer below:\n", Color.Green);

        }

        //=========================================================================================//

        //This is a maximizing function which calls a special windows dll file to maximize the console
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);

        private static void Maximize()
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3); //SW_MAXIMIZE = 3
        }
        //=========================================================================================//

        //Loading bar
        static class ProgressBar
        {
            const char _block = '■';
            const string _back = "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b";
            const string _twirl = "-\\|/";
            public static void WriteProgressBar(int percent, bool update = false)
            {
                if (update)
                    Console.Write(_back);
                Console.Write("[", Color.LightBlue);
                var p = (int)((percent / 10f) + .5f);
                for (var i = 0; i < 10; ++i)
                {
                    if (i >= p)
                        Console.Write(' ');
                    else
                        Console.Write(_block, Color.LightBlue);
                }
                Console.Write("] {0,3:##0}%", percent, Color.LightBlue);
            }
            public static void WriteProgress(int progress, bool update = false)
            {
                if (update)

                    Console.Write("\b");
                Console.Write(_twirl[progress % _twirl.Length]);

            }
        }
        //=========================================================================================//
        
        //Loading bar method
        private static void loading()
            {

            Writeline("Loading...", Color.LightGreen);

            Writeline("", Color.White);

            ProgressBar.WriteProgressBar(0);
            for (var i = 0; i <= 100; ++i)
            {
                ProgressBar.WriteProgressBar(i, true);
                Thread.Sleep(50);
            }
            Console.WriteLine("\n\n");
            ProgressBar.WriteProgress(0);
            for (var i = 0; i <= 100; ++i)
            {
                ProgressBar.WriteProgress(i, true);
                Thread.Sleep(50);
            }

}


        //=========================================================================================//

        //Choices: 

        private static void AlternativeChoice()
        { 
            Writeline(PartNine[1], Color.Yellow);

                        EnterYourChoice();
                        AnswerInput();

                        if (input == "yes")
                        {


                            Writeline(PartTen[0], Color.LightGreen);
                            Inventory.Add("Spare Parts");

                            PressEnter();
                            Console.Clear();

                        }
                        else
                        {
                            Writeline(PartEleven[0], Color.IndianRed);
                            Inventory.Clear();
                            PressEnter();
                            EndGame();
                        }

        }


                //=========================================================================================//




                private static void GameTitle()
        {
            //Call the maximizing funtion which has been added
            Maximize();

            //Changes the color to blue!
            //Here is the ASCII title
            Console.Title = "Space Disaster - V2.0";

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

            centerText("Press Enter to continue...\n\n", Color.White);

            var PressEnter = Console.ReadKey(true);
            if (PressEnter.Key == ConsoleKey.Enter)
            {
                Console.ResetColor();
                Console.Clear();

                Writeline("Hang on please...", Color.LightBlue);

                Writeline("", Color.White);
                loading();


                Console.Clear();
                StartGame();

            }
            /*If player has not pressed ENTER*/
            else
            {
                centerText("Please press 'ENTER', not any other key!", Color.DarkRed);
                Console.ReadKey();

                Console.Clear();
                GameTitle();
                
            }
        }









        //Here is the game start code which calls for character and carrys on
        private static void StartGame()
        {

            Console.Write("Welcome ", Color.Blue);
            Console.ResetColor();
            Console.Write("player", Color.White);
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
            centerText("Owner: Yazan Al Akkad\n", Color.Red);

            //Changes the color to blue
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Copyrights :D
            centerText("Copyrights reserved 2020 - 2021\n", Color.Red);

        }




        //asks player for name and save it
        public static void NameCharacter()
        {



            Writeline("Nice to meet you, would you like to introduce yourself, what's your name?\n", Color.LightBlue);

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


                    case 1:

                        string Pic = (@"


    ▒▒▒▒▒▒▒▒▒▒▒║║║║╢╢╢╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒
    ▒▒▒▒▒▒▒▒▒║║▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒╢▒▒▒▒▒╢▒▒▒▒▒▒▒▒╢║╢▒▒▒▒▒▒▒▒▒▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▒▒▒▒▒▒╢╢▒▒▒▒▒▒▒▒╢╢▒▒╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
    ▒▒▒▒▒▒▒▒▒▒▒╢║║║║║║║║Ñ▒║╢▒▒▒▒▒║║╢╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
    ▒▒▒▒╢▒▒╢╢▒╢╢▒║╠║╠║║║Ñ▓║╢╢╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒╜▒▒║▒▒│▒
    ▒▒▒▒▒▒▒▒╢╢╢╢║║║║║║║║M▒║╠║║║╢╢▒▒▒▒▒▒║▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒╜▒▒╙Ñ∩║Ñ║▒MNÑ╢▒║▓▓▒
    ╠╠╠║╢║║╢║║▒║║║║║║║║╠∩▒╠╠╠║║║║║╢╢╢╢▒║╢▒╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒║║Ñ┌7#╚╙╓L╔║╢▒▒▒M║▒▒▒▓▓▒
    ║║║║╠╠╠╠╠╠╠╠╠ÑÑÑÑ┤┤┤∩▒╠╠╠╠╠╠╠║║║║║╢╢╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒┌∩╙ :║║▒▒▒▒Ñ╔#╠▒▒▒▒▒▓
    │╙Ñ║║╚╠╠╠╠╠╠╠┤┤┤┤┤│∩:╠││Ñ╠╠╠╠╠║║║╠╠║║║║║╢╢╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒╙│╚N,│║╙∩║░└║║▒▒╢▒▓▒▒
    ∩││N║╚╚╠║╠╠╠╠┤┤┤│∩∩   '││┤Ñ╠╠╠╠╠╠║║║║║║║║║║║╢╢▒▒▒▒▒▒▒▒▒╢╙∩(┌│Ñ║▒║▒⌂╠║╢▒▒║▒▒░│░▒▓
    NNNN##║║║║╠║║║╠╠┤∩∩    │││┤╠╠║║║║║║║║║╢╢▒▒▒▒║╢╢▒╙Ñ╠╠Ñ▒▒Ñ(\└└⌠╠║Ñ║▒│\╓║▒▒▒▒╔║▒▒▓▓
    ║║║║║║║║║║║║║║╠╠┤∩∩:  (│N╠║║║║║╢╢╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒┘╠╠╠╠Ñ▒⌠NN∩║║╢┌╠╠║╠▒▒▒▓▒▒▒▓▒▒██
    ║║║║║║║║║║║║║╠╠╠╠╠¿∩  ││╠║╠║║║║║╢╢╢╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒││║╠║▒┤▒║╢▒▒▒Ñ║╢▒▒▒▓▓▒▓▒▒▒▒▒▒
    ║║║║║║║║║╠Ñ╠Ñ║╠╠║M¼#  │NNNÑ╠╠║║║║║║╠║║║╢╢║║║║▒┘Ñ╠Ñ╠││N╠║M▓▓▓Ñ▒▒▒║▒▒▓▓▓██▒▒▓▒▒▒▒▓
    ╠╠║║║║║║╠║║║▒╢║╠╠▒░L  ║╠║║║║║║║║╠╠╠╠Ñ╠╠╠╠╠╠╠╠╠░;#║║#NÑÑ║║▒▒▒▒▒▒▒▒▓▓▒▒▒▒▓▓▓▓▓▒▒▒▓
    ║║║╚╚║║║║║║▒▒╠╠Ñ║╙║░  ║╠╠╠╠╠╠Ñ╠╠╠╠╠╠║║║║║╠║║╠╠┤∩│╠║║║╠║║║▒▒▒▒▒▓▓▓▓▓▓▓▓▓▒▒▒▓█▓▓▒╠
    ║╠Ñ(':NN∩N│Ñ▒╠╚∩≈╓∩└  ║╠║╙░╠╙│╠║▓Ñ╠║║║║║╠╠╠║Ñ╠╠N╠╠╠║║║║║║╢▒▒▒▒▓▓▓▓▓▓▓▒▒▒▒▓▓▓████
    ╜╚│╓╔#║▒░∩∩║▒▒ (│N┤∩ (╙╙└«╢╓║▒▓▒▒▒║║║║║║║║║║║╠Ñ││╙╠╠ÑÑ║╢╢▒▒▒▒▒▒▓▓▓▓▓▒▒▒▒▒▓▓▓▒▒██
    #║╚▒▒▒▒▒▒▒▒#░▒╠╔░║∩≈#M∩║╢\▒Ñ▒▒▒▓▓▒▒▒╜║║▒╜╜╠║Ñ∩∩││NNÑN║╠║▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▓▓▓▓▓▓▓▓
    ▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒╠▒▒▒▒▓▒▒╡▒▒▒▒▒▒▓▓▒▒▒▒Ñ#∩╓▒▒▒▄░║╠╠╠║║╢▒▒Ñ║▒▒╢▒▒▒▒▒▒▒▒▒▒▓▓▓▒▓▓▓▓▓
    █████▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▒▒▒▒▒▓▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓██████▓▓▓▓▓▓█▓█▓
    ██████████▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓████▓███████▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▓███████████████▓███
    ███████████████▓█▓▓▓▓▓▓╫▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▀▀▓▓▓█▓▓▓▓▓▓▓███▓▓███████████▓█████████▓█

");
                        Writeline(Pic, Color.LightYellow);
                        Writeline(PartOne[0] + PartOne[1] + PartOne[2] + PartOne[3] + PartOne[4] + PartOne[5], Color.Yellow);

                        EnterYourChoice();
                        AnswerInput();

                        if (input == "yes")
                        {

                            Writeline(PartTwo[0], Color.LightGreen);
                            Inventory.Add("Batteries");
                            Inventory.Add("Cabinet Key");
                            Inventory.Add("Hammer");

                            Writeline(PartTwo[1] + PartTwo[2], Color.Yellow);

                        }
                        else
                        { 
                            Writeline(PartThree[0], Color.Red);
                            Writeline(PartThree[1] + PartThree[2] + PartThree[3], Color.Yellow);
                            Inventory.Add("Cabinet Key");
                            Inventory.Add("Hammer");
                            Inventory.Add("Batteries");
                        }

                        break;



                    case 2:

                        Writeline(PartFour[0], Color.Yellow);

                        EnterYourChoice();
                        AnswerInput();

                        if (input == "yes")
                        {

                            Writeline(PartFour[1] + PartFour[2], Color.MediumPurple);
                            Inventory.Add("Crowbar");

                        }
                        else
                        { 

                            Writeline(PartFive[0], Color.IndianRed);

                        EnterYourChoice();
                        AnswerInput();

                        if (input == "yes")
                        {

                            Writeline(PartSix[0], Color.Yellow);
                            Inventory.Add("Flashlight without batteries");
                            Inventory.Add("Access card");

                        }
                        else
                        { 
                         //End of the game if the person loses, it will clear his/her inventory as he died
                            Writeline(PartSeven[0], Color.Red);
                            Inventory.Clear();
                            PressEnter();
                            EndGame();
                        }
                        }
                            Writeline(PartSix[1], Color.Cyan);

                            PressEnter();
                            Console.Clear();
                        

                        break;



                    case 3:

                            Writeline(PartEight[0], Color.Yellow);


                        EnterYourChoice();
                        AnswerInput();

                        if (input == "yes")
                        {

                            Writeline(PartNine[0], Color.Yellow);
                            AlternativeChoice();

                        }
                        else
                        { 
                            Writeline(PartTwelve[0], Color.Yellow);
                        }

                        Writeline(PartThirteen[0], Color.Yellow);
                        
                        EnterYourChoice();
                        AnswerInput();

                        if (input == "yes")
                        {

                            Writeline(PartFourteen[0], Color.Yellow);
                            Inventory.Add("Spacecraft Keys");

                        EnterYourChoice();
                        AnswerInput();

                        if (input == "yes")
                        {

                            Writeline(PartSeventeen[0], Color.LightGreen);
                            Inventory.Add("Astroid samples");
                            Inventory.Add("Remainings of iron, copper and silicon");

                        }
                        else
                        {
                                //End of the game if the person loses, it will clear his/her inventory as he died
                            Writeline(PartSixteen[0], Color.IndianRed);
                            Inventory.Clear();
                            PressEnter();
                            EndGame();
                        }

                        }
                        else
                        { 
                            Writeline(PartFifteen[0] + PartFifteen[1], Color.Yellow);
                            Inventory.Add("Spacecraft Keys");

                        EnterYourChoice();
                        AnswerInput();

                        if (input == "yes")
                        {

                            Writeline(PartSeventeen[0], Color.LightGreen);
                            Inventory.Add("Astroid samples");
                            Inventory.Add("Remainings of iron, copper and silicon");

                        }
                        else
                        { 
                         //End of the game if the person loses, it will clear his/her inventory as he died
                            Writeline(PartSixteen[0], Color.IndianRed);
                            Inventory.Clear();
                            PressEnter();
                            EndGame();
                        }
                        }
                        //End of the game if the person won
                            Writeline(PartEighteen[0] + PartEighteen[1], Color.Cyan);
                            PressEnter();
                            Congratz();


                        break;
                }
            }
        }





        private static int Scenarios = 5;

        private static string[] PartOne = {
           
          //Main story
          "You have been launched into space for a mission. The launch seems to be going well until, it left the atmosphere of the Earth. \n\nThen problems start to occur slowly!\n",
          "\nThe third stage of the rocket crashes into the space station before it could slow down for docking. ",
          "You have now to find a way out of the crashed rocket \nto get to the malfunctioning station. The crash has caused you to hit your head and pass out.  \nYou will need to find something sharp that can break the glass.",
          "\nYou wake up to see the tragedy, your other crew members sadly didn't survive the crash. \nYou will have to find your way out of the rocket to reach the station before you get hurt.",
          "You come across a locked door. Due to a failure in the systems, \nyou will need to open it manually. You look around and you find an emergency button \nwhich normally opens the door in such situations, but it's covered with glass.",
          "\nYou look around and you notice a red hammer in a glass cabinet that is surounded by metal which also needs a key to be opened. \nYou search around and notice two drawers under a safe. Open the first drawer?\n",
        };

        private static string[] PartTwo = {

          "\nYou find some batteries",
		  //Follow up
          "\nYou open the second drawer. ",
		  //Yes
		  "You find a key for the hammer cabinet. You take the key and go to the glass cabinet which holds the hammer. You take out the \nhammer and you go back to the emergency button and smash the glass cover. You proceed with pressing it and the door opens.",

        };

        private static string[] PartThree = {

          "\nKeep looking..",

          "\nYou open the second drawer. ",

		  "You find a key for the hammer cabinet. You take the key and go to the glass cabinet which holds the hammer. You take out the \nhammer and you go back to the emergency button and smash the glass cover. You proceed with pressing it and the door opens.",

          "\nYou go back and open the first drawer and find some batteries. After that you keep looking for another way out. \n\n",

        };

        private static string[] PartFour = {


          "\nNow you need to get out of the rocket seen the air pressure is getting low and you don't have much time. You look around and you find a blocked door \nit's blocked by a metal object, try pushing the object away?\n",
          
          "\nYou can't seem to be able to push it, however it can be pushed with a strong item you look around and you find \na crowbar in a cabinet. You take the crowbar and ",
		
		  "you hold it against the metal object and manage to remove the object out of the way. \nYou manage to get out of the rocket to the space station safe and sound!",

        };

        private static string[] PartFive = {


          "\n\nYou arrive at a locked door, which can be unlocked with a code. You find a safe, \nit is locked but can be unlocked with a special code. You need to look for the code! You see a mirror hanging on the wall, turn the mirror around?\n",


        };

        private static string[] PartSix = {


          "\n\nYou see a code that can be used to open the safe. You open the safe with the code seen on the back side of the mirror. You find an access card that opens the door of the room as well as a flashlight without batteries, pretty unfortunate huh? \nYou proceed with opening the door with the provided key and you put the previous found batteries in the flashlight. \n\nYou turn on the flashlight, now you need to get out of the rocket seen that the air pressure is getting low and you don't much time. \nYou get out of the first room and see a blocked door, you also see a window by shining the flashlight around. \nThe window is closed but can be opened so you attempt to open it, you open it and manage to get out of the rocket to the space station safe and sound!\n\n",
          
            
          "\nYou meet with an ISS crew member which has thankfully survived alongside to another member which has barely made it.\n\n",




        };

        private static string[] PartSeven = {



          "\nThe air pressure gets so low that you can't breath anymore which unfortunatly cause you a horrible death!\n",



        };

        private static string[] PartEight = {


          "\nThey provide you with some equipment and food so you can survive in space. You notice that the space station is in a bad shape and needs some repairs. \n\nDo you want to try to help repairing it?\n\n",




        };
        
        private static string[] PartNine = {


          "\nYou look around and see some tools and some spare parts laying around in the station, they have been reserved for such situations. You put on a space suit and tie yourself to the station with \na special belt that would help you not getting lost in space. You get out of the space station and you take tools and spares with you, you float in space next to the station looking for the damages caused. \nA crew member gets out to help you fix the issues. You find a hole in the space station which is causing a leak in the oxygen that is stored.",

          "\n\nThe oxygen generator has also been badly effected by the crash which caused it to fail. Do you want to proceed with fixing the hole and the leak?\n",

        };

        private static string[] PartTen = {

          "\nYou pickup some tools and some spare parts you found and fix the issues with them, you fix the issues and close down the hole and resolve the leak. The oxygen generator is now up and running again, good job!\n",

        };

        private static string[] PartEleven = {

          "The space station runs out of oxygen that causes the remaining crew members to suffocate\n\n",


        };

        private static string[] PartTwelve = {

          "\n\nYou inform the crew that you can not help for some reason, but you will however use some spare parts to build a small rocket to get to the moon base.\n\n",


        };

        private static string[] PartThirteen = {


          "\nAfter that you get to a special place where a small rocket can be built and attached to the station. You will need some materials for your rocket, so you go into the station and grab some spare parts. \nWhile picking up spare parts you notice that the station lacks some materials like metal, iron, copper and silicon. \n\nIn a distance you see a small space shuttle that can be used for gathering resources around from asteroids. Do you want to board it? \n",


        };

        private static string[] PartFourteen = {

          "\n\nYou will need keys to be able to start the spacecraft, you look around and you see a cabinet. You open the cabinet and find the keys for the spacecraft \nyey I guess! Now you board the space craft and fly around till you approach a big astroid. Land on top of it with the spacecraft?\n\n",


        };

        private static string[] PartFifteen = {

          "\n\nYou look around for materials but you don't find anything, you go back to the spacecraft to board it so you get the needed materials but wait... ",
          "\n\nYou will need keys to be able to start the spacecraft, you look around and you see a cabinet. You open the cabinet and find the keys for the spacecraft, \nyey I guess! You take the space craft and fly around till you approach a big astroid. Land on top of it with the spacecraft?\n\n",


        };

        private static string[] PartSixteen = {

          "\n\nYou skip it but you are going too far from the space station and the space craft is not \ncapable of going very far, which causes it to shut down due to a communication loss. \n\nYou are now stuck in space! Game over!\n\n",


        };

        private static string[] PartSeventeen = {

          "\n\nYou land on top it and get your tools to see if you can extract some resources. \nWith a camera system that works with infrared technology you detect that the asteroid is full of different resources and materials. \nYou get out your tools and begin extracting iron, copper and silicon. With iron you can make metal plates which will help you build the rocket. You collect as much resources as you can. \nThen you go back to the spacecraft to get back to the station, you also take some samples with you to study on earth which will be sealed during the journey. \n\nYou start the ion thrusters engine and you go back to the station safe and sound. You now have enough materials to build the small rocket. \nYou pickup your items and begin assembling your rocket. You finish assembling and welding everything with each other. You will now only need a battery and some ION thrusters \nwhich you can find in the space station\n\n",


        };

        private static string[] PartEighteen = {

          "\nYour rocket now is ready to go, you start it up after gather your things and you launch into space towards \nthe moon command base. From there you take another rocket after telling the command center about everything and you get launched towards the earth. \nYou land on the ocean surface, you send out a distress signal to the command center on Earth which make them send a special boat to pick you up.\n\n",

	      "You now go back to the command center and tell them about the disaster that has occured while you were in space the space disaster! \nYou also give the the samples that you collected earlier and you had some other materials which you also gave as you don't need them. \n\n",


        };







        private static void Congratz()
        {

            loading();

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

            centerText("You've made it to the base safe and sound!", Color.Green);

            Write("\n\n" + CharacterName, Color.White);
            Write(" you have collected the following throughout your journey:\n\n", Color.Purple);

            //This will list the items in inventory
            foreach (string item in Inventory)
                Writeline(item + Environment.NewLine, Color.White);


            if (Inventory.Contains("Astroid samples"))
            {

                Writeline("\n\nGood job! You have collected the samples and returned them to the earth command base, now scientists can study them for future missions!", Color.Green);
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

            Writeline(gameover, Color.DarkRed);

            centerText("You died! What unfortunate....\n", Color.DarkRed);
            centerText("Good luck next time!", Color.Red);

            Write("\n\n" + CharacterName, Color.White);
            Write(" you have lost all of your items in space!", Color.Red);



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
