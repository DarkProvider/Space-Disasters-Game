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
					case 1:
						Console.WriteLine(PartOne[0] + PartOne[1] + PartOne[2] + PartOne[3] + PartOne[4] + PartOne[5], Color.Yellow);

							EnterYourChoice();
							AnswerInput();

						if (input == "yes")
							{							
							Writeline(PartOne[6], Color.Green);
							Inventory.Add("Batteries");
							}
						else
							Writeline(PartOne[7], Color.Red);
							
						
						Console.WriteLine(PartOne[8] + PartOne[9], Color.Yellow );
						Inventory.Add("Cabinet Key" + "Hammer");

							EnterYourChoice();
							AnswerInput();

						if (input == "yes")
						{
							Console.WriteLine(PartOne[10] + PartOne[11], Color.Yellow);
							Inventory.Add("Crowbar");
						}
						else
						{
							Console.WriteLine(PartOne[12], Color.Red);						
								Console.ReadKey();

								Inventory.Clear();
							EndGame();	
						}

						
						Writeline("", Color.White);
							PressEnter();
							Console.ReadKey();
						
						break;
					case 2:
						Console.Clear();

						Writeline(PartTwo[0] + PartTwo[1], Color.Yellow);
						Inventory.Add("Batteries");

							EnterYourChoice();
							AnswerInput();

						if (input == "yes")
						{
							Writeline(PartTwo[3], Color.Yellow);
							Inventory.Add("Door key" + "Flashlight withour batteries");
						}
						else
						{
							Writeline(PartTwo[2], Color.Red);
						}

						Writeline(PartTwo[4], Color.Green);

						Writeline("", Color.White);
							PressEnter();
							Console.ReadKey();

						break;
					case 3:

						Console.Clear();

						Writeline(PartThree[0], Color.Yellow);


							EnterYourChoice();
							AnswerInput();

						if (input == "yes")
						{
							Writeline(PartThree[1], Color.Yellow);

							EnterYourChoice();
							AnswerInput();

							if (input == "yes")
							{

								Writeline(PartThree[4], Color.Green);

							}
							if (input == "no")
							{

								Writeline(PartThree[5], Color.Red);
									PressEnter();
									Console.ReadKey();
								
								Inventory.Clear();

								//Calling the endgame class
								EndGame();

							}
						}
						else
							Writeline(PartThree[2], Color.Yellow);
							
						Writeline(PartThree[3], Color.Yellow);
						Inventory.Add("Spare Parts");

							EnterYourChoice();
							AnswerInput();

						if (input == "yes")
						{
							Writeline(PartThree[7], Color.Yellow);
							Inventory.Add("Spacecraft Keys");
						}
						else
							Writeline(PartThree[9], Color.Red);


						Writeline(PartThree[6], Color.Yellow);

							EnterYourChoice();
							AnswerInput();

						if (input == "yes")
						{

							Writeline(PartThree[7], Color.Yellow);							
							Inventory.Add("Spacecraft Keys");

							EnterYourChoice();
							AnswerInput();


							if (input == "yes")
							{

								Writeline(PartThree[11] + PartThree[12], Color.Yellow);

								Inventory.Add("Spacecraft Keys" + "Remainings of iron, copper and silicon" + "Astroid samples");
									PressEnter();
									Console.ReadKey();

								Writeline(PartThree[13], Color.Yellow);

									PressEnter();
									Console.ReadKey();

								//Calling the congratz class
								Congratz();

							}

							if (input == "no")
							{

								Writeline(PartThree[8], Color.Yellow);

									PressEnter();
									Console.ReadKey();
								
								Inventory.Clear();
								
								//Calling the endgame class
								EndGame();


							}
						}

						Write(PartThree[10], Color.Yellow);

							EnterYourChoice();
							AnswerInput();

						if (input == "yes")
						{

							Writeline(PartThree[11] + PartThree[12], Color.Yellow);

							Inventory.Add("Spacecraft Keys" + "Remainings of iron, copper and silicon" + "Astroid samples");
								
								PressEnter();
								Console.ReadKey();
							
							

							Writeline(PartThree[13], Color.Yellow);
							
								PressEnter();
								Console.ReadKey();

							//Calling the congratz class
							Congratz();
						}
						else
							Write(PartThree[8], Color.Yellow);


								PressEnter();
								Console.ReadKey();
							Inventory.Clear();

							//Calling the endgame class
							EndGame();

						Writeline("", Color.White);
						PressEnter();

						break;
					default:
						EndGame();
						break;
				}
		}
}

		private static int Scenarios = 3;

		private static string[] PartOne = {

			"You have been launched into space for a mission. The launch seems to be going well until, it left the atmosphere of the Earth. \n\nThen problems start to occur slowly!\n",
			"\nThe third stage of the rocket crashes into the space station before it could slow down for docking. ",
			"You have now to find a way out of the crashed rocket \nto get to the malfunctioning station. The crash has caused you to hit your head and pass out.  \nYou will need to find something sharp that can break the glass.",
			"\nYou wake up to see the tragedy, your other crew members sadly didn't survive the crash. \nYou will have to find your way out of the rocket to reach the station before you get hurt.",
			"You come across a locked door. Due to a failure in the systems, \nyou will need to open it manually. You look around and you find an emergency button \nwhich normally opens the door in such situations, but it's covered with glass.",
			"\nYou look around and you notice a red hammer in a glass cabinet that is surounded by metal which also needs a key to be opened. \nYou search around and notice two drawers under a safe. Open the first drawer?\n",
			//Yes
			"\nYou find  some batteries",
			//Follow up
			"\nKeep looking..",
			//No
			"\nYou open the second drawer. ",
			//Yes
			"You find a key for the hammer cabinet. You take the key and go to the glass cabinet which holds the hammer. You take out the \nhammer and you go back to the emergency button and smash the glass cover. You proceed with pressing it and the door opens. \nNow you need to get out of the rocket seen the air pressure is getting low and you don't have much time. You look around and you find a blocked door \nit's blocked by a metal object, try pushing the object away?\n",
			//Yes
			"\nYou can't seem to be able to push it, however it can be pushed with a strong item you look around and you find \na crowbar in a cabinet. You take the crowbar and ",
			//Yes
			"you hold it against the metal object and manage to remove the object out of the way. \nYou manage to get out of the rocket to the space station safe and sound!",
			//No
			"\nThe air pressure gets so low that you can't breath anymore which unfortunatly cause you a horrible death!\n",

		};

		private static string[] PartTwo = {

			"\nYou go back and open the first drawer and find some batteries. After that you keep looking for another way out. ",
			"You find a safe, \nit is locked but can be unlocked with a special code. You need to look for the code! You see a mirror hanging on the wall, turn the mirror around?\n",
			//No
			"\nThe air pressure gets so low that you can't breath anymore which unfortunatly cause you a horrible death!\n",
			//Yes
			"\nYou see a code that can be used to open the safe. You open the safe with the code seen on the back side of the mirror. You find a key to open the door of the room as well as a flashlight without batteries, pretty unfortunate huh? \nYou proceed with opening the door with the provided key and you put the previous found batteries in the flashlight. You turn on the flashlight, now you need to get out of the rocket \nseen that the air pressure is getting low and you don't much time. You get out of the first room and see a blocked door, you also see a window by shining the flashlight around. \nThe window is closed but can be opened so you attempt to open it, you open it and manage to get out of the rocket to the space station safe and sound!",
			"\nYou meet with an ISS crew member which has thankfully survived alongside to another member which has barely made it.",
		};

		private static string[] PartThree = {

			"\nThey provide you with some equipment and food so you can survive in space. You notice that the space station is in a bad shape and needs some repairs. \nDo you want to try to help repairing it?",
			//First Yes
			"\nYou look around and see some tools and some spare parts laying around in the station, they have been reserved for such situations. You put on a space suit and tie yourself to the station with \na special belt that would help you not getting lost in space. You get out of the space station and you take tools and spares with you, you float in space next to the station looking for the damages caused. \nA crew member gets out to help you fix the issues. You find a hole in the space station which is causing a leak in the oxygen that is stored. \nThe oxygen generator has also been badly effected by the crash which caused it to fail. Do you want to proceed with fixing the hole and the leak?\n",
			//First No
			"You inform the crew that you can not help for some reason, but you will however use some spare parts to build a small rocket to get to the moon base.\n\n",
			"You get to a special place where a small rocket can be built and attached to the station. You will need some materials for your rocket, so you go into the station and grab some spare parts. \nWhile picking up spare parts you notice that the station lacks some materials like metal, iron, copper and silicon. \n\nIn a distance you see a small space shuttle that can be used for gathering resources around from asteroids. Do you want to board it? \n",
			//Second Yes
			"\nYou pickup some tools and some spare parts you found and fix the issues with them, you fix the issues and close down the hole and resolve the leak. The oxygen generator is now up and running again, good job!\n",
			//Second No
			"The space station runs out of oxygen that causes the remaining crew members to suffocate\n\n",
			// followup to the latest issue fix
			"You get to a special place where a small rocket can be built and attached to the station. You will need some materials for your rocket, so you go into the station and grab some spare parts. While picking up spare parts, \nyou notice that the station lacks some materials like metal, iron, copper and silicon. \nYou see a small space shuttle that can be used for gathering resources around from asteroids. \nDo you want to board it?\n",
			//Third Yes
			"You will need keys to be able to start the spacecraft, you look around and you see a cabinet. \nYou open the cabinet and find a key for the spacecraft, yey I guess! You take the space craft and fly around till you approach a big astroid. Land on top of it with the space craft?",
			//No 
			"You skip it but you are going too far from the space station and the space craft is not \ncapable of going very far, which causes it to shut down due to a communication loss. \nYou are now stuck in space! Game over!",
			//Third No
			"You look around for materials but you don't find anything, \nyou go back to the spacecraft to board it so you get the needed materials but wait... ",
			//Follow up
			"You will need keys to be able to start the spacecraft, you look around and you see a cabinet. \nYou open the cabinet and find a key for the spacecraft, yey I guess! You take the space craft and fly around till you approach a big astroid. Land on top of it with the space craft?",
			//Yes
			"You land on top it and get your tools to see if you can extract some resources. \nWith a camera system that works with infrared technology you detect that the asteroid is full of different resources and materials. \nYou get out your tools and begin extracting iron, copper and silicon. With iron you can make metal plates which will help you build the rocket. You collect as much resources as you can. \nThen you go back to the space craft to get back to the station, you also take some samples with you to study on earth. You start the ion thrusters engine and you go back to the station safe and sound. \nYou now have enough materials to build the small rocket. You pickup your items and begin assembling your rocket. You finish assembling and welding everything with each other. \nYou will now need a battery and some ION thrusters which you can find in the space station",
			//Follow up
			"Your rocket now is ready to go, you start it up after gather your things and you launch into space towards \nthe moon command base. From there you take another rocket after telling the command center about everything and you get launched towards the earth. \nYou land on the ocean surface, you send out a distress signal to the command center on Earth which make them send a special boat to pick you up.",
			//Follow up
			"You now go back to the command center and tell them about the disaster that has occured while you were in space the space disaster! \nYou also give the the samples that you collected earlier and you had some other materials which you also gave as you don't need them. ",
		};




		


		//A new class of the items
		private static class Items
		{


		}






		private static void Congratz()
		{
			Console.Clear();

			string YouwinTitle = (@"
                ______                                       _            _                  _ 
               / _____)                            _        | |      _   (_)                | |
              | /      ___  ____   ____  ____ ____| |_ _   _| | ____| |_  _  ___  ____   ___| |
              | |     / _ \|  _ \ / _  |/ ___) _  |  _) | | | |/ _  |  _)| |/ _ \|  _ \ /___)_|
              | \____| |_| | | | ( ( | | |  ( ( | | |_| |_| | ( ( | | |__| | |_| | | | |___ |_ 
               \______)___/|_| |_|\_|| |_|   \_||_|\___)____|_|\_||_|\___)_|\___/|_| |_(___/|_|
                                 (_____|                                                       
");
			Writeline(YouwinTitle, Color.Green);

			Writeline("You've made it to the base safe and sound!", Color.Green);

			Writeline(CharacterName + " you have collected the following throughout your journey:\n\n", Color.Purple);
			
			//This will list the items in inventory
			foreach (string item in Inventory)
				Writeline(item + Environment.NewLine, Color.White);


			if (Inventory.Contains("Astroid samples"))
			{

				Writeline("\nGood job! You have collected the samples and returned them to the earth command base, now scientists can study them for future missions!", Color.AliceBlue);
			}
			else
				Writeline("You haven't gotten the smalples, scientists are big mad!", Color.MediumVioletRed);


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
