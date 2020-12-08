                    case 1:
                        Console.WriteLine(PartOne[0] + PartOne[1] + PartOne[2] + PartOne[3] + PartOne[4] + PartOne[5], Color.Yellow);

                        EnterYourChoice();
                        AnswerInput();

                        if (input == "yes")
                        {
                            Writeline(PartOne[6], Color.Green);

                            Writeline(PartOne[8] + PartOne[9], Color.Yellow);
                            Inventory.Add("Batteries");
                        }

                        else if (input == "no")
                        {
                            Writeline(PartOne[7], Color.Red);

                            Writeline(PartOne[8] + PartOne[9] + PartTwo[0], Color.Yellow);
                            Inventory.Add("Cabinet Key");
                            Inventory.Add("Hammer");
                            Inventory.Add("Door key");
                            Inventory.Add("Flashlight without batteries");

                            Writeline(PartOne[10], Color.Yellow);

                            EnterYourChoice();
                            AnswerInput();

                            if (input == "yes")
                            {
                                Console.WriteLine(PartOne[11] + PartOne[12], Color.Yellow);
                                Inventory.Add("Crowbar");
                            }
                            else if (input == "no")
                            {
                                Console.Clear();

                                Console.WriteLine(PartTwo[1], Color.Yellow);
                                Console.ReadKey();

                                EnterYourChoice();
                                AnswerInput();

                                if (input == "yes")
                                {
                                    Writeline(PartTwo[3], Color.Yellow);
                                    Writeline(PartTwo[4], Color.Green);

                                    Writeline("", Color.White);
                                    PressEnter();
                                    Console.ReadKey();

                                }
                                else if (input == "no")
                                {
                                    Writeline(PartTwo[2], Color.Red);
                                    EndGame();

                                    Inventory.Clear();
                                    Writeline("", Color.White);
                                    PressEnter();
                                    Console.ReadKey();
                                }
                            }
                        }



                        break;
                    case 2:

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

                                Writeline(PartThree[3], Color.Green);

                            }
                            if (input == "no")
                            {

                                Writeline(PartThree[4], Color.Red);
                                PressEnter();
                                Console.ReadKey();

                                Inventory.Clear();

                                //Calling the endgame class
                                EndGame();

                            }
                        }
                        else
                            Writeline(PartThree[1], Color.Yellow);


                        break;
                    case 3:



                        Writeline(PartThree[2], Color.Yellow);
                        Inventory.Add("Spare Parts");

                        EnterYourChoice();
                        AnswerInput();

                        if (input == "yes")
                        {
                            Writeline(PartThree[6], Color.Yellow);
                            Inventory.Add("Spacecraft Keys");
                        }
                        else
                            Writeline(PartThree[8], Color.Red);

                        Write(PartThree[9], Color.Yellow);

                        EnterYourChoice();
                        AnswerInput();

                        if (input == "yes")
                        {

                            Writeline(PartThree[10] + PartThree[11], Color.Yellow);

                            Inventory.Add("Spacecraft Keys");
                            Inventory.Add("Remainings of iron, copper and silicon");
                            Inventory.Add("Astroid samples");

                            PressEnter();
                            Console.ReadKey();



                            Writeline(PartThree[12], Color.Yellow);

                            PressEnter();
                            Console.ReadKey();

                            //Calling the congratz class
                            Congratz();
                        }
                        else
                            Write(PartThree[7], Color.Yellow);


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