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



		static string[] PartOne = {

			"You have been launched into space for a mission. The launch seems to be going well until, it left the atmosphere of the Earth. Then problems start to occur slowly!",
			"The third stage of the rocket crashes into the space station before it could slow down for docking ",
			"You have now to find a way out of the crashed rocket to get to the malfunctioning station. The crash has caused you to hit your head and pass out. You wake up to see the tragedy, your other crew members sadly didn't survive the crash. You will have to find your way out of the rocket to reach the station before you get hurt. You come across a locked door. Due to a failure in the systems, you will need to open it manually. You found a button which opens the door, but it's covered with glass. You will need to find something sharp that can break the glass. You look around and you notice a red hammer in a glass cabinet that is surounded by metal which also needs a key to be opened. You search around and find two drawers under a safe. Open the first drawer?",
			//Yes
			"You find  some batteries",
			//No
			"Open the second drawer?",
			//Yes
			"You find a key for the hammer cabinet. You take the key and go to the glass cabinet which holds the hammer. You take the hammer and you go back to the button and smash the glass cover. You proceed with pressing it and the door opens. Now you need to get out of the rocket seen the air pressure is getting low and you don't time. You look around and you find a blocked door, it's blocked by a metal object, try pushing the object away?",
			//Yes
			"You can't seem to be able to push it, however it can be pushed with a strong item, you look around and you find a crowbar in a cabinet. Take the crowbar? ",
			//Yes
			"You hold it against the metal object and manage to remove it the object out of the way. You manage to get out of the rocket to the space station safe and sound!",
			//No
			"The air pressure gets so low that you can't breath anymore which unfortunatly cause you a horrible death!",

		};

		static string[] PartTwo = {

			"Open the second drawer?",
			//No
			"You find nothing. Keep looking?",
			//Yes
			"You go back and open the first drawer and find some batteries. After that you keep looking for another way out",
			//Yes
			"You find a sadfe, it is locked but can be unlocked with a special code. You need to look for the code! Turn the mirror around?",
			//No
			"The air pressure gets so low that you can't breath anymore which unfortunatly cause you a horrible death!",
			//Yes
			"You see a code that can be used to open the safe. You open the safe with the code seen on the back side of the mirror. You find a key to open the door of the room with as well as a flashlight without batteries, pretty unfortunate huh? You proceed with opening the door with the provided key and you put the previous found batteries in the flashlight. You turn on the flashlight and now you need to get out of the rocket seen the air pressure is getting low and you don't time. You get out of the first room and see a blocked door, you also see a window by shining the flashlight around. The window is closed but can be opened so you attempt to open it, you open it and manage to get out of the rocket to the space station safe and sound!",
		};

		static string[] PartThree = {

			"Yo meet with an ISS crew member which has thankfully survived alongside to another member which has barely made it. They provide you with some equipment and food so you can survive in space. You notice that the space station is in a bad shape and needs some repairs. Do you want to try to help repairing it? 1",
			//First Yes
			"You look around and see some tools and some spare parts laying around in the station, they have been reserved for such situations. You put on the a space suit and tie yourself to the station with a special belt that would help you not get lost in space. You get out of the space station and you take tools and spares with you, you float in space next to the station looking for the damages caused. A crew member gets out to help you fix the issues. You find a hole in the space station which is causing a leak in the oxygen that is stored. The oxygen generator has also been effected by the crash which caused it to fail. Do you want to proceed with fixing the hole and the leak? 2",
			//First No
			"You inform the crew that you can not help for some reason, but you will however use some spare parts to build a small rocket to get to the moon base.",
			"You get to a special place where a small rocket can be built and attached to the station. You will need some materials for your rocket, so you go into the station and grab some spare parts. While picking up spare parts, you notice that the station lacks some materials like metal, iron, copper and silicon. You see a small space shuttle that can be used for gathering resources around from asteroids. Do you want to board it? 3",
			//Second Yes
			"You pickup some tools and some spare parts you found and fix the issues with them, you fix the issues and close down the hole and resolve the leak. The oxygen generator is now up and running again, good job!",
			//Second No
			"The space station runs out of oxygen that causes the remaining crew members to suffocate",
			// followup to the latest issue fix
			"You get to a special place where a small rocket can be built and attached to the station. You will need some materials for your rocket, so you go into the station and grab some spare parts. While picking up spare parts, you notice that the station lacks some materials like metal, iron, copper and silicon. You see a small space shuttle that can be used for gathering resources around from asteroids. Do you want to board it? 3",
			//Third Yes
			"You will need keys to be able to start the spacecraft, you look around and you see a cabinet. You open the cabinet and find a key for the spacecraft, yey I guess! You take the space craft and fly around till you approach a big astroid. Land on top it with the space craft?",
			//No 
			"You skip it but you are going too far from the space station and the space craft is not capable of going very far which causes it to shut down due to a communication loss. You are now stuck in space! Game over!",
			//Third No
			"You look around or materials but you don't find anything, do you want to go back and board the ship to get the needed materials?",
			//Follow up
			"You will need keys to be able to start the spacecraft, you look around and you see a cabinet. You open the cabinet and find a key for the spacecraft, yey I guess! You take the space craft and fly around till you approach a big astroid. Land on top it with the space craft?",
			//Yes
			"You land on top it and get your tools to see if you can extract some resources. With a camera system that works with infrared technology you detect that the asteroid is full of different resources and materials. You get out your tools and begin extracting iron, copper and silicon. With iron you can make metal plates which will help you build the rocket. You collect as much resources as you can. Then you go back to the space craft to get back to the station, you also take some samples with you to study on earth. You start the ion thrusters engine and you go back to the station safe and sound. You now have enough materials to build the small rocket. You pickup your items and begin assembling your rocket. You finish assembling and welding everything with each other. You will now need a battery and some ION thrusters which you can find in the space station",
			//Follow up
			"Your rocket now is ready to go, you start it up after gather your things and you launch into space towards the moon command base. From there you take another rocket after telling the command center about everything and you get launched towards the earth. You land on the ocean surface, you send out a distress signal to the command center on earth which make them send a special boat to pick you up.",
			//Follow up
			"You now go back to the command center and tell them about the disaster that has occured while you were in space, the space disaster! You also give the the samples that you collected earlier and you had some other materials which you also gave as you don't need them. ",
		};




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
		
				string exit = "Thank you for playing. Now you can proceed by pressing the Enter button to Exit! Have a great day!";
				Console.WriteLine("{0," + ((Console.WindowWidth / 2) + exit.Length / 2) + "}", exit);

			Console.ReadKey();

		}

	}
}
