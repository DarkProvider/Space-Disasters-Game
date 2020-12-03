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

namespace Space_Disasters
{
	class Program
	{

		static void Main(string[] args)
		{
			//Prints out the game title and overview, then it proceeds to the next sections
				GameTitle();
		}







		//This will change the Console.writeline into Writeline instead
			public static void Writeline(string text)
			{

				Console.WriteLine(text);
			}








		static void GameTitle()
		{
				//Changes the height of the window
				Console.WindowHeight = Console.LargestWindowHeight - 20;
				//Changes the width of the window
				Console.WindowWidth = Console.LargestWindowWidth - 80;
				//Changes the color to blue!
				Console.ForegroundColor = ConsoleColor.Blue;
				//Here is the ASCII title
				Console.Title = "ASCII Art";

			string title = @"

       ::::::::  :::::::::     :::      ::::::::  ::::::::::      ::::::::: ::::::::::: ::::::::      :::      :::::::: ::::::::::: :::::::::: :::::::::  
      :+:    :+: :+:    :+:  :+: :+:   :+:    :+: :+:             :+:    :+:    :+:    :+:    :+:   :+: :+:   :+:    :+:    :+:     :+:        :+:    :+: 
      +:+        +:+    +:+ +:+   +:+  +:+        +:+             +:+    +:+    +:+    +:+         +:+   +:+  +:+           +:+     +:+        +:+    +:+ 
      +#++:++#++ +#++:++#+ +#++:++#++: +#+        +#++:++#        +#+    +:+    +#+    +#++:++#++ +#++:++#++: +#++:++#++    +#+     +#++:++#   +#++:++#:  
             +#+ +#+       +#+     +#+ +#+        +#+             +#+    +#+    +#+           +#+ +#+     +#+        +#+    +#+     +#+        +#+    +#+ 
      #+#    #+# #+#       #+#     #+# #+#    #+# #+#             #+#    #+#    #+#    #+#    #+# #+#     #+# #+#    #+#    #+#     #+#        #+#    #+# 
       ########  ###       ###     ###  ########  ##########      ######### ########### ########  ###     ###  ########     ###     ########## ###    ### 


";
			Writeline(title);

			Copyrights();

				Console.ResetColor();
				string start = "Press Enter to continue...";
				Console.WriteLine("{0," + ((Console.WindowWidth / 2) + start.Length / 2) + "}", start);

				Console.ReadKey();
				Console.ResetColor();
				Console.Clear();

			StartGame();
		}









		//Character name identifier
		public static String CharacterName = "";








		//Here is the game start code which calls for character and carrys on
		static void StartGame()
		{
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.Write("Welcome ");
				Console.ResetColor();
				Console.Write("user");
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.Write(", to your first mission with the coalition of Nasa & SpaceX space organizations!\n");

			Writeline("");
			NameCharacter();
			Choice();
			EndGame();
		}








		//Copyrights section
		static void Copyrights()
		{
				//Sets the color to red
				Console.ForegroundColor = ConsoleColor.Red;
				//Prints out the owner's name which is me, basically..
				string owner = "Owner: Yazan Al Akkad\n";
				Console.WriteLine("{0," + ((Console.WindowWidth / 2) + owner.Length / 2) + "}", owner);

				//Changes the color to blue
				Console.ForegroundColor = ConsoleColor.Blue;
				//Copyrights :D
				string copy = "Copyrights reserved 2020 - 2021\n";
				Console.WriteLine("{0," + ((Console.WindowWidth / 2) + copy.Length / 2) + "}", copy);
			
			
		}









		//asks player for name and save it
		static void NameCharacter()
		{

				Writeline("What would you like your name to be?\n");

				//Changes the color back to white
				Console.ResetColor();

				CharacterName = Console.ReadLine();
			Writeline("");

				//Changes the color to green
				Console.ForegroundColor = ConsoleColor.Green;

				Console.Write("Great! Nice to have you on board ");

				//Displays the written name of a character in white
				Console.ForegroundColor = ConsoleColor.White;

				//Prints out the chosen name for the main character
				Console.Write(CharacterName);

				//Changes the color to green
				Console.ForegroundColor = ConsoleColor.Green;

				Writeline(", we are excited to have you here!\n");

				//Resets the color again
			Console.ResetColor();

				Writeline("Press any key to continue!\n");

			//Waiting for key to be pressed
			Console.ReadKey();

			//Clears the console
			Console.Clear();
		}








		static void Choice()
		{
				Console.ForegroundColor = ConsoleColor.Blue;

			string input;

				Writeline(CharacterName + ", Which way do you wanna go? A or B?");

					//Making an identifier that we can use later
					input = Console.ReadLine();

					//Using that identifier to detect small case letters
					input = input.ToUpper();

			//An if statemnent
			if (input == "A")
			{
				Writeline("You've chosen A as a way to go!\n");
			}
			else
			{
				Writeline("You've Chosen B as a way to go! You Lost!");
			}
			Console.ReadKey();
		}








		//A new class of the items
		static class Items
		{


		}









		static void EndGame()
		{
			Console.Clear();

			string gameover = (@"

                                     ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ ██╗
                                    ██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗██║
                                    ██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝██║
                                    ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗╚═╝
                                    ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║██╗
                                     ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝╚═╝
               
");
			Writeline(gameover);
		
				string exit = "Press Enter to Exit";
				Console.WriteLine("{0," + ((Console.WindowWidth / 2) + exit.Length / 2) + "}", exit);

			Console.ReadKey();

		}

	}
}
