namespace OutGuess {
    internal class Program {
        static void Main(string[] args) {
            //120:30 Default Size | 160:40 Ideal Size ■
            bool isCPU = false;
            byte difficulty = 0;
            string input = "";
            byte vB = 0;
            int vI = 0;
            while (true) {
                ScreenSizeCheck();
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("╔═══════════════════╗\n║                   ║\n║ OUTGUESS LAUNCHER ║\n║                   ║\n╚═══════════════════╝\n");
                Console.WriteLine("Select Model\n╔══════════╗\n║ Standard ║\n╚══════════╝\n╔══════════╗\n║ Addendum ║\n╚══════════╝\n");
                Console.Write("> ");
                Console.CursorVisible = true;
                input = Console.ReadLine().ToUpper();
                Console.CursorVisible = false;
                Console.WriteLine();
                if (input == "DEBUG") {
                    Console.WriteLine("           DEBUG MENU           \n╔════════════╗ ╔═══════════════╗\n║ Toggle CPU ║ ║ Test Function ║\n╚════════════╝ ╚═══════════════╝\n");
                    Console.Write("> ");
                    Console.CursorVisible = true;
                    input = Console.ReadLine().ToUpper();
                    Console.CursorVisible = false;
                    Console.WriteLine();
                    if (input == "CPU") {
                        isCPU = !isCPU;
                    } else if (input == "FUNCTION") {
                        Console.WriteLine("            Execute Function:            \n╔═══════════════════════════════════════╗\n║ 1) TextBox             | 6) FakeCrash ║\n║ 2) Portraits           | 7)           ║\n║ 3) WinnerText          | 8)           ║\n║ 4) DisplayNumbers      | 9)           ║\n║ 5) LoudIncorrectBuzzer | 0)           ║\n╚═══════════════════════════════════════╝\n");
                        Console.Write("> ");
                        Console.CursorVisible = true;
                        input = Console.ReadLine().ToUpper();
                        Console.CursorVisible = false;
                        Console.WriteLine();
                        if (input == "1") {
                            TextBox();
                            Thread.Sleep(5000);
                        } else if (input == "2") {
                            Portraits();
                            Thread.Sleep(5000);
                        } else if (input == "3") {
                            Console.Write("> ");
                            Console.CursorVisible = true;
                            input = Console.ReadLine();
                            Console.CursorVisible = false;
                            Console.WriteLine();
                            WinnerText(input);
                        } else if (input == "4") {
                            Console.Write("> ");
                            Console.CursorVisible = true;
                            vI = int.Parse(Console.ReadLine());
                            Console.CursorVisible = false;
                            Console.WriteLine();
                            Numbers(vI);
                            Thread.Sleep(5000);
                        } else if (input == "5") {
                            Console.Write("> ");
                            Console.CursorVisible = true;
                            vB = byte.Parse(Console.ReadLine());
                            Console.CursorVisible = false;
                            Console.WriteLine();
                            LoudIncorrectBuzzer(vB);
                            Thread.Sleep(5000);
                        } else if (input == "6") {
                            Console.Write("> ");
                            Console.CursorVisible = true;
                            vB = byte.Parse(Console.ReadLine());
                            Console.CursorVisible = false;
                            Console.WriteLine();
                            FakeCrash(vB);
                        } else if (input == "7") {
                        } else if (input == "8") {
                        } else if (input == "9") {
                        } else if (input == "0") {
                        }
                    }
                } else if (input == "STANDARD") {
                    Console.WriteLine("    Select a Difficulty:    \n╔══════╗ ╔════════╗ ╔══════╗\n║ Easy ║ ║ Normal ║ ║ Hard ║\n╚══════╝ ╚════════╝ ╚══════╝\n");
                    Console.Write("> ");
                    Console.CursorVisible = true;
                    input = Console.ReadLine().ToUpper();
                    Console.CursorVisible = false;
                    Console.WriteLine();
                    if (input == "EASY") {
                        difficulty = 0;
                    } else if (input == "NORMAL") {
                        difficulty = 1;
                    } else if (input == "HARD") {
                        difficulty = 2;
                    } else {
                        difficulty = 1;
                    }
                    OutGuess(isCPU, difficulty);
                } else if (input == "ADDENDUM") {
                    OutGuessAdd(false, 1);
                }
            }
            static void OutGuess(bool isCPU, byte difficulty) {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.CursorVisible = false;
                QuickSizeCheck();
                Console.Clear();
                TextBox();
                Dialogue("Hello there, and welcome to MCA's favorite game show!", 55, 5);
                Thread.Sleep(1000);
                Dialogue("GUESS", 60, 7);
                Thread.Sleep(1000);
                Dialogue("THE", 85, 15);
                Thread.Sleep(1000);
                Dialogue("NUMBER", 105, 9);
                Thread.Sleep(1000);
                TextBox();
                Dialogue("And now for our host!", 75, 8);
                Thread.Sleep(3000);
                TextBox();
                Sonis();
                Dialogue("Sonis!", 40, 2);
                Thread.Sleep(3000);
                BoxRefresh();
                Dialogue("Hello everyone, im Sonis, Sonis Hedgehog! and I am the host of Guess the Number.", 40, 2);
                Thread.Sleep(2000);
                BoxRefresh();
                Dialogue("But enough about me, we gotta introduce our contestants!", 40, 2);
                Thread.Sleep(2000);
                Portraits();
                BoxRefresh();
                Dialogue("Lets go in order!                Contestants, be ready to move forward!", 40, 2);
                Thread.Sleep(2000);
                Dialogue("CONTESTANT A: ", 40, 7);
                Thread.Sleep(2000);
                Player();
                Console.ForegroundColor = ConsoleColor.Gray;
                Dialogue("You Watanabe!", 54, 7);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                Dialogue("CONTESTANT B: ", 40, 11);
                Thread.Sleep(2000);
                Cirno();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Dialogue("Cirno Fumo!", 54, 11);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                Dialogue("CONTESTANT C: ", 40, 15);
                Thread.Sleep(2000);
                Goku();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Dialogue("Son Goku!", 54, 15);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                BoxRefresh();
                Dialogue("The rules of the game are simple, pick a number between 1 through 100. Who ever picks the correct number wins!", 40, 2);
                Thread.Sleep(3000);
                BoxRefresh();
                Dialogue("Now that everyone has been introduced, lets begin...", 40, 2);
                Thread.Sleep(3000);
                bool isWin = false;
                while (!isWin) {
                    Random random = new Random();
                    string input = "";
                    string name = "";
                    bool isValid = false;
                    bool isGame = false;
                    int number = random.Next(1, 100);
                    int lowest = 1;
                    int highest = 100;
                    int guess = 0;
                    byte fail = 0;
                    byte wrog = 0;
                    for (byte z = 0; z < 9; z++) {
                        BoxRefresh();
                        if (z == 0 || z == 1 || z == 2) {
                            wrog = 0;
                        } else if (z == 3 || z == 4 || z == 5) {
                            wrog = 1;
                        } else if (z == 6 || z == 7 || z == 8) {
                            wrog = 2;
                        }
                        if (z == 0 || z == 3 || z == 6) {
                            name = "You";
                        } else if (z == 1 || z == 4 || z == 7) {
                            name = "Cirno";
                        } else {
                            name = "Goku";
                        }
                        if (difficulty == 0) {
                            Dialogue($"Turn {z + 1}. {name}, plz guess the number between {lowest} - {highest}.", 40, 2);
                        } else {
                            Dialogue($"Turn {z + 1}. {name}, plz guess the number between 1 - 100.", 40, 2);
                        }
                        Dialogue("INPUT HERE: ", 40, 11);
                        if (z == 0 || z == 3 || z == 6) {
                            if (isCPU) {
                                guess = CPUInput(lowest, highest, difficulty, z);
                                Console.CursorVisible = true;
                                input = guess.ToString();
                                Thread.Sleep(2500);
                                Typing($"{guess}", 52, 11);
                                Console.CursorVisible = false;
                            } else {
                                Console.CursorVisible = true;
                                input = Console.ReadLine();
                                Console.CursorVisible = false;
                                isValid = Validation(input);
                                if (!isValid) {
                                    guess = 0;
                                    Thread.Sleep(5000);
                                    fail = FakeCrash(fail);
                                } else {
                                    guess = int.Parse(input);
                                }
                            }
                        } else {
                            guess = CPUInput(lowest, highest, difficulty, z);
                            Console.CursorVisible = true;
                            input = guess.ToString();
                            Thread.Sleep(2500);
                            Typing($"{guess}", 52, 11);
                            Console.CursorVisible = false;
                        }
                        BoxRefresh();
                        Dialogue($"Alright {name}!    You inputted...", 40, 2);
                        Thread.Sleep(2000);
                        BoxRefresh();
                        Numbers(guess);
                        Dialogue($"{input}!", 40, 2);
                        Thread.Sleep(2000);
                        BoxRefresh();
                        Numbers(guess);
                        Dialogue($"Lets see the answer!", 40, 2);
                        Thread.Sleep(3000);
                        BoxRefresh();
                        if (guess == number) {
                            Dialogue($"..........NO WAY!!! THAT WAS THE CORRECT NUMBER!", 40, 2);
                            Thread.Sleep(2000);
                            isGame = false;
                            break;
                        } else {
                            Thread.Sleep(100);
                            wrog = LoudIncorrectBuzzer(wrog);
                            Thread.Sleep(2000);
                            if (guess <= 0 || guess >= 101) {
                                Dialogue($"What you inputted was invalid..", 40, 2);
                                Thread.Sleep(1500);
                                Dialogue($"Did you input that on purpose??", 40, 4);
                                Thread.Sleep(3000);
                            } else if (guess > number) {
                                Dialogue($"The number is too high!!!", 40, 2);
                                Thread.Sleep(3000);
                                if (difficulty <= 0) {
                                    if (highest > guess) {
                                        highest = guess - 1;
                                    }
                                } else if (difficulty == 1) {
                                    highest = guess;
                                } else if (difficulty >= 2) {
                                    highest = guess - 1;
                                }
                            } else if (guess < number) {
                                Dialogue($"The number is too low!!!", 40, 2);
                                Thread.Sleep(3000);
                                if (difficulty <= 0) {
                                    if (lowest < guess) {
                                        lowest = guess + 1;
                                    }
                                } else if (difficulty == 1) {
                                    lowest = guess;
                                } else if (difficulty >= 2) {
                                    lowest = guess + 1;
                                }
                            }
                        }
                        isGame = true;
                    }
                    if (!isGame) {
                        if (name == "You") {
                            BoxRefresh();
                            Dialogue($"THE WINNER IS YOU WATANABE!!!          CONGRATULATIONS!!!", 40, 2);
                            Thread.Sleep(3000);
                        } else if (name == "Cirno") {
                            BoxRefresh();
                            Dialogue($"THE WINNER IS CIRNO FUMO!!!          CONGRATULATIONS!!!", 40, 2);
                            Thread.Sleep(3000);
                        } else {
                            BoxRefresh();
                            Dialogue($"THE WINNER IS SON GOKU!!!          CONGRATULATIONS!!!", 40, 2);
                            Thread.Sleep(3000);
                        }
                        WinnerText(name);
                        if (name == "You") {
                            isWin = true;
                        } else {
                            Dialogue($"Dont worry, im sure you will win next round, press any key to retry, or close the game to quit.", 40, 2);
                            Console.ReadKey();
                        }
                    } else {
                        if (fail >= 3) {
                            BoxRefresh();
                            Dialogue($"Okay buddy, listen up.        YOU SUCK!        You did that on purpose I know it.", 40, 2);
                            Thread.Sleep(3000);
                            BoxRefresh();
                            Dialogue($"Alright look, ill give you 1 (one) more chance, hear that ONE MORE CHANCE to guess the number...", 40, 2);
                            Thread.Sleep(3000);
                            BoxRefresh();
                            Dialogue($"Turn 10... YOU, GUESS the DAMN number between {lowest} - {highest}...", 40, 2);
                            Dialogue("INPUT HERE: ", 40, 11);
                            Console.CursorVisible = true;
                            input = Console.ReadLine();
                            Console.CursorVisible = false;
                            isValid = Validation(input);
                            if (!isValid) {
                                guess = 0;
                                Thread.Sleep(5000);
                                fail = FakeCrash(fail);
                            } else {
                                guess = int.Parse(input);
                                if (guess == number) {
                                    Dialogue($"..................how....how....HOW......IM GOING CRAZY HOW DID YOU GUESS IT", 40, 2);
                                    Dialogue($"CORRECTLY, AFTER SCREWING EVERYTHING UP. IM...IM...Ahh forget it.   Go home.", 40, 3);
                                    Thread.Sleep(3000);
                                    break;
                                } else {
                                    Dialogue($"WRONG! GAME OVER!! GOODBYE!!!", 40, 2);
                                    Thread.Sleep(3000);
                                    break;
                                }
                            }
                        } else {
                            BoxRefresh();
                            Dialogue($"GAME OVER!!!! Looks like nobody won, its okay, even I sometimes fail to guess the number too.", 40, 2);
                            Thread.Sleep(5000);
                            BoxRefresh();
                            Dialogue($"Dont worry, im sure you will win next round, press any key to retry, or close the game to quit.", 40, 2);
                            Console.ReadKey();
                        }
                    }

                }
                Console.Clear();
            }
            static void OutGuessAdd(bool isCPU, byte difficulty) {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.CursorVisible = false;
                QuickSizeCheck();
                Console.Clear();
                TextBox();
                Dialogue("Hello there, and welcome to MCA's favorite game show!", 55, 5);
                Thread.Sleep(1000);
                Dialogue("GUESS", 60, 7);
                Thread.Sleep(1000);
                Dialogue("THE", 70, 13);
                Thread.Sleep(1000);
                Dialogue("NUMBER", 85, 9);
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Red;
                Dialogue("ADDEMDUM", 100, 12);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
                TextBox();
                Dialogue("And now for our host!", 75, 8);
                Thread.Sleep(3000);
                TextBox();
                Sonis();
                Dialogue("Sonis!", 40, 2);
                Thread.Sleep(3000);
                BoxRefresh();
                Dialogue("Hello everyone, im Sonis, Sonis Hedgehog! and I am the host of Guess the Number Addendum.", 40, 2);
                Thread.Sleep(2000);
                BoxRefresh();
                Dialogue("But enough about me, we gotta introduce our contestants!", 40, 2);
                Thread.Sleep(2000);
                Portraits();
                BoxRefresh();
                Dialogue("Lets go in order!                Contestants, be ready to move forward!", 40, 2);
                Thread.Sleep(2000);
                Dialogue("CONTESTANT A: ", 40, 7);
                Thread.Sleep(2000);
                Player();
                Console.ForegroundColor = ConsoleColor.Gray;
                Dialogue("You Watanabe!", 54, 7);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                Dialogue("CONTESTANT B: ", 40, 11);
                Thread.Sleep(2000);
                Cirno();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Dialogue("Cirno Fumo!", 54, 11);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                Dialogue("CONTESTANT C: ", 40, 15);
                Thread.Sleep(2000);
                Goku();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Dialogue("Son Goku!", 54, 15);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                BoxRefresh();
                Dialogue("The rules of the game are simple, one must pick a number between 1 through 100.", 40, 2);
                Thread.Sleep(3000);
                Dialogue("But before one can guess, money must be wagered, run out of money and its game over!", 40, 4);
                Thread.Sleep(3000);
                Dialogue("Who ever gets the most correct guesses, wins!", 40, 6);
                Thread.Sleep(3000);
                BoxRefresh();
                Dialogue("Now that everyone has been introduced, lets begin...", 40, 2);
                Thread.Sleep(3000);
                bool isValid = false;
                string input = "";
                int PlayerMoney = 0;
                int CirnoMoney = 0;
                int GokuMoney = 0;
                for (int i = 0; i < 3; i++) {
                    BoxRefresh();
                    if (i == 0) {
                        Dialogue("You Watanabe! Please place forward your money to the table, place between $1 - $333.", 40, 2);
                    } else if (i == 1) {
                        Dialogue("Cirno Fumo! Please place forward your money to the table, place between $1 - $333.", 40, 2);
                    } else {
                        Dialogue("Son Goku! Please place forward your money to the table, place between $1 - $333.", 40, 2);
                    }
                    Thread.Sleep(1500);
                    Dialogue("INPUT HERE: ", 40, 11);
                    if (i == 0) {
                        Console.CursorVisible = true;
                        input = Console.ReadLine();
                        Console.CursorVisible = false;
                        isValid = Validation(input);
                        if (!isValid) {
                            PlayerMoney = 0;
                            BoxRefresh();
                            Dialogue("Since you wanna be so funny, you put NO MONEY!", 40, 2);
                            Thread.Sleep(1500);
                            BoxRefresh();
                            Numbers(PlayerMoney);
                            Dialogue("ZERO!!!!!", 40, 2);
                            Thread.Sleep(2000);
                        } else {
                            PlayerMoney = int.Parse(input);
                            if (PlayerMoney >= 334) {
                                PlayerMoney = 333;
                                BoxRefresh();
                                Dialogue("You gave a little too much, i capped it at 333 for you.", 40, 2);
                                Thread.Sleep(1500);
                                BoxRefresh();
                                Numbers(PlayerMoney);
                                Thread.Sleep(2000);
                            } else if (PlayerMoney <= 0) {
                                PlayerMoney = 1;
                                BoxRefresh();
                                Dialogue("Are you like, broke or something? Ungh fine... Have one dollar...", 40, 2);
                                Thread.Sleep(1500);
                                BoxRefresh();
                                Numbers(PlayerMoney);
                                Thread.Sleep(2000);
                            }
                            BoxRefresh();
                            Numbers(PlayerMoney);
                            Thread.Sleep(2000);
                        }
                    } else if (i == 1) {
                        CirnoMoney = CPUMoney(PlayerMoney);
                        Console.CursorVisible = true;
                        input = CirnoMoney.ToString();
                        Thread.Sleep(2500);
                        Typing($"{CirnoMoney}", 52, 11);
                        Console.CursorVisible = false;
                        BoxRefresh();
                        Numbers(CirnoMoney);
                        Thread.Sleep(2000);
                    } else {
                        GokuMoney = CPUMoney(PlayerMoney);
                        Console.CursorVisible = true;
                        input = GokuMoney.ToString();
                        Thread.Sleep(2500);
                        Typing($"{GokuMoney}", 52, 11);
                        Console.CursorVisible = false;
                        BoxRefresh();
                        Numbers(GokuMoney);
                        Thread.Sleep(2000);
                    }
                }
                BoxRefresh();
                Dialogue("Awesome! Now that everyone has added their money were gonna add it all up!", 40, 2);
                Thread.Sleep(3000);
                int Vault = PlayerMoney + CirnoMoney + GokuMoney;
                BoxRefresh();
                Numbers(Vault);
                Thread.Sleep(3000);
            }
            static void ScreenSizeCheck() {
                Console.Clear();
                Console.CursorVisible = false;
                while (Console.WindowWidth < 161 || Console.WindowHeight < 41) {
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Screen too small! {161 - Console.WindowWidth} - {41 - Console.WindowHeight}");
                }
                Console.Clear();
                Console.WriteLine("Screen Correct!");
                Thread.Sleep(1000);
                Console.Clear();
                QuickSizeCheck();
            }
            static void QuickSizeCheck() {
                bool ProperSize = Console.WindowWidth > 161 || Console.WindowHeight > 41;
                if (!ProperSize) {
                    Console.Clear();
                    Console.CursorVisible = false;
                    while (Console.WindowWidth < 161 || Console.WindowHeight < 41) {
                        Console.SetCursorPosition(0, 0);
                        Console.Write($"Screen too small!");
                    }
                    Console.Clear();
                    Console.WriteLine("Screen Correct!");
                    Thread.Sleep(1000);
                    ProperSize = true;
                    Console.Clear();
                }
            }
            static int CPUMoney(int YousoroMoney) {
                Random random = new Random();
                int MoneyLowest = YousoroMoney - 25;
                int MoneyHighest = YousoroMoney + 25;
                if (MoneyLowest <= 0) {
                    MoneyLowest = 1;
                }
                if (MoneyLowest >= 334) {
                    MoneyLowest = 333;
                }
                int MoneyPicker = random.Next(MoneyLowest, MoneyHighest);
                return MoneyPicker;
            }
            static int CPUInput(int lowest, int highest, byte difficulty, byte z) {
                int Guess = 0;
                Random random = new Random();
                if (difficulty <= 0) {
                    int bakaLowest = lowest - 5;
                    int bakaHighest = highest + 5;
                    if (bakaLowest <= 0) {
                        bakaLowest = 1;
                    }
                    if (bakaHighest >= 101) {
                        bakaHighest = 100;
                    }
                    Guess = random.Next(bakaLowest, bakaHighest);
                } else if (difficulty == 1) {
                    Guess = random.Next(lowest, highest);
                } else if (difficulty >= 2) {
                    if (z <= 2) {
                        int knowledge = ((highest - lowest) / 2) + lowest;
                        Guess = knowledge;
                    } else {
                        Guess = random.Next(lowest, highest);
                    }
                }
                QuickSizeCheck();
                return Guess;
            }
            static bool Validation(string stringInput) {
                int userInput;
                bool isValid = false;
                isValid = int.TryParse(stringInput, out userInput);
                QuickSizeCheck();
                return isValid;
            }
            static void Dialogue(string text, byte x, byte y) {
                Console.SetCursorPosition(x, y);
                for (int i = 0; i < text.Length; i++) {
                    QuickSizeCheck();
                    Console.Write(text[i]);
                    Thread.Sleep(50);
                }
            }
            static void Typing(string text, byte x, byte y) {
                Console.SetCursorPosition(x, y);
                for (int i = 0; i < text.Length; i++) {
                    QuickSizeCheck();
                    Console.Write(text[i]);
                    Thread.Sleep(1000);
                }
            }
            static void BoxRefresh() {
                QuickSizeCheck();
                TextBox();
                Sonis();
            }
            static void TextBox() {
                QuickSizeCheck();
                string s01 = "╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗";
                string s02 = "║                                                                                                                                                              ║";
                string s03 = "║                                                                                                                                                              ║";
                string s04 = "║                                                                                                                                                              ║";
                string s05 = "║                                                                                                                                                              ║";
                string s06 = "║                                                                                                                                                              ║";
                string s07 = "║                                                                                                                                                              ║";
                string s08 = "║                                                                                                                                                              ║";
                string s09 = "║                                                                                                                                                              ║";
                string s10 = "║                                                                                                                                                              ║";
                string s11 = "║                                                                                                                                                              ║";
                string s12 = "║                                                                                                                                                              ║";
                string s13 = "║                                                                                                                                                              ║";
                string s14 = "║                                                                                                                                                              ║";
                string s15 = "║                                                                                                                                                              ║";
                string s16 = "║                                                                                                                                                              ║";
                string s17 = "║                                                                                                                                                              ║";
                string s18 = "║                                                                                                                                                              ║";
                string s19 = "║                                                                                                                                                              ║";
                string s20 = "╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝";
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(s01);
                Console.WriteLine(s02);
                Console.WriteLine(s03);
                Console.WriteLine(s04);
                Console.WriteLine(s05);
                Console.WriteLine(s06);
                Console.WriteLine(s07);
                Console.WriteLine(s08);
                Console.WriteLine(s09);
                Console.WriteLine(s10);
                Console.WriteLine(s11);
                Console.WriteLine(s12);
                Console.WriteLine(s13);
                Console.WriteLine(s14);
                Console.WriteLine(s15);
                Console.WriteLine(s16);
                Console.WriteLine(s17);
                Console.WriteLine(s18);
                Console.WriteLine(s19);
                Console.WriteLine(s20);
            }
            static void Portraits() {
                QuickSizeCheck();
                string s01 = "╔══════════════════════════════════════╗";
                string s02 = "║                                      ║";
                string s03 = "║                                      ║";
                string s04 = "║                                      ║";
                string s05 = "║                                      ║";
                string s06 = "║                                      ║";
                string s07 = "║                                      ║";
                string s08 = "║                                      ║";
                string s09 = "║                                      ║";
                string s10 = "║                                      ║";
                string s11 = "║                                      ║";
                string s12 = "║                                      ║";
                string s13 = "║                                      ║";
                string s14 = "║                                      ║";
                string s15 = "║                                      ║";
                string s16 = "║                                      ║";
                string s17 = "║                                      ║";
                string s18 = "║                                      ║";
                string s19 = "║                                      ║";
                string s20 = "╚══════════════════════════════════════╝";
                int v = 0;
                for (int j = 0; j < 3; j++) {
                    Console.SetCursorPosition(v, 20);
                    Console.Write(s01);
                    Console.SetCursorPosition(v, 21);
                    Console.Write(s02);
                    Console.SetCursorPosition(v, 22);
                    Console.Write(s03);
                    Console.SetCursorPosition(v, 23);
                    Console.Write(s04);
                    Console.SetCursorPosition(v, 24);
                    Console.Write(s05);
                    Console.SetCursorPosition(v, 25);
                    Console.Write(s06);
                    Console.SetCursorPosition(v, 26);
                    Console.Write(s07);
                    Console.SetCursorPosition(v, 27);
                    Console.Write(s08);
                    Console.SetCursorPosition(v, 28);
                    Console.Write(s09);
                    Console.SetCursorPosition(v, 29);
                    Console.Write(s10);
                    Console.SetCursorPosition(v, 30);
                    Console.Write(s11);
                    Console.SetCursorPosition(v, 31);
                    Console.Write(s12);
                    Console.SetCursorPosition(v, 32);
                    Console.Write(s13);
                    Console.SetCursorPosition(v, 33);
                    Console.Write(s14);
                    Console.SetCursorPosition(v, 34);
                    Console.Write(s15);
                    Console.SetCursorPosition(v, 35);
                    Console.Write(s16);
                    Console.SetCursorPosition(v, 36);
                    Console.Write(s17);
                    Console.SetCursorPosition(v, 37);
                    Console.Write(s18);
                    Console.SetCursorPosition(v, 38);
                    Console.Write(s19);
                    Console.SetCursorPosition(v, 39);
                    Console.Write(s20);
                    v += 60;
                }
            }
            static void Player() {
                QuickSizeCheck();
                string s01 = "                     ____-----__      ";
                string s02 = "                  _--_//    --_ \\_    ";
                string s03 = "                 //      __    \\  \\_  ";
                string s04 = "                 /  _-|\\   \\    |   \\ ";
                string s05 = "                // /_ | \\_  \\    \\  | ";
                string s06 = "             _/////  -\\  _-_ \\   |  / ";
                string s07 = "            / ////|/=\\ \\    --|  | |  ";
                string s08 = "       __--/  _-'|| ()    ___ |  / |  ";
                string s09 = "     _//|\\' ___//|\\         ▀/ _/)  ) ";
                string s10 = "   _/  \\\\===/   \\||L '      ///=/  ((7";
                string s11 = "  /        /    /||'-_'--'  _/\\ \\  )) ";
                string s12 = " /       /_____--/--- -__--- _\\) )((_ ";
                string s13 = "/     _//    \\ || |  /     / __-\\_   ";
                string s14 = "\\    -=        \\|| |---__-/_-=/ /__\\  ";
                string s15 = " ---_____       \\|| |  /_-=--/ /    \\ ";
                string s16 = "         ------// >\\---7_---//    /- |";
                string s17 = "              __--//--/    //    /   |";
                string s18 = "              \\   /   \\   //|   /  _--";
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(1, 21);
                Console.Write(s01);
                Console.SetCursorPosition(1, 22);
                Console.Write(s02);
                Console.SetCursorPosition(1, 23);
                Console.Write(s03);
                Console.SetCursorPosition(1, 24);
                Console.Write(s04);
                Console.SetCursorPosition(1, 25);
                Console.Write(s05);
                Console.SetCursorPosition(1, 26);
                Console.Write(s06);
                Console.SetCursorPosition(1, 27);
                Console.Write(s07);
                Console.SetCursorPosition(1, 28);
                Console.Write(s08);
                Console.SetCursorPosition(1, 29);
                Console.Write(s09);
                Console.SetCursorPosition(1, 30);
                Console.Write(s10);
                Console.SetCursorPosition(1, 31);
                Console.Write(s11);
                Console.SetCursorPosition(1, 32);
                Console.Write(s12);
                Console.SetCursorPosition(1, 33);
                Console.Write(s13);
                Console.SetCursorPosition(1, 34);
                Console.Write(s14);
                Console.SetCursorPosition(1, 35);
                Console.Write(s15);
                Console.SetCursorPosition(1, 36);
                Console.Write(s16);
                Console.SetCursorPosition(1, 37);
                Console.Write(s17);
                Console.SetCursorPosition(1, 38);
                Console.Write(s18);
                Console.ForegroundColor = ConsoleColor.White;
            }
            static void Cirno() {
                QuickSizeCheck();
                string s01 = "        /    --___    __-      \\      ";
                string s02 = "       |          \\__/         \\      ";
                string s03 = "      _|___---____----____ --__ |     ";
                string s04 = "     /      _/            \\_   --_    ";
                string s05 = "     \\     /                \\     \\   ";
                string s06 = "      \\   /     /\\    /\\     \\   /    ";
                string s07 = "       \\  |   /___\\  /__\\    | /      ";
                string s08 = "        \\ |   |___  \\____|   |/       ";
                string s09 = "          |   |P |   |°  |   |        ";
                string s10 = "          \\ /\\|\\_/    \\_/|/  |        ";
                string s11 = "           |/\\\\_  \\__/  _/ \\ /        ";
                string s12 = "           /\\ /  ------   / /         ";
                string s13 = "         _--  \\ |\\ /\\ \\|/---_         ";
                string s14 = "        (____-- / / \\ /  -___)        ";
                string s15 = "            /   --___-     \\          ";
                string s16 = "          / L_---\\    /----\\\\         ";
                string s17 = "         |---/--\\-___-/---\\\\          ";
                string s18 = "          --\\   /-___-\\   /           ";
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(61, 21);
                Console.Write(s01);
                Console.SetCursorPosition(61, 22);
                Console.Write(s02);
                Console.SetCursorPosition(61, 23);
                Console.Write(s03);
                Console.SetCursorPosition(61, 24);
                Console.Write(s04);
                Console.SetCursorPosition(61, 25);
                Console.Write(s05);
                Console.SetCursorPosition(61, 26);
                Console.Write(s06);
                Console.SetCursorPosition(61, 27);
                Console.Write(s07);
                Console.SetCursorPosition(61, 28);
                Console.Write(s08);
                Console.SetCursorPosition(61, 29);
                Console.Write(s09);
                Console.SetCursorPosition(61, 30);
                Console.Write(s10);
                Console.SetCursorPosition(61, 31);
                Console.Write(s11);
                Console.SetCursorPosition(61, 32);
                Console.Write(s12);
                Console.SetCursorPosition(61, 33);
                Console.Write(s13);
                Console.SetCursorPosition(61, 34);
                Console.Write(s14);
                Console.SetCursorPosition(61, 35);
                Console.Write(s15);
                Console.SetCursorPosition(61, 36);
                Console.Write(s16);
                Console.SetCursorPosition(61, 37);
                Console.Write(s17);
                Console.SetCursorPosition(61, 38);
                Console.Write(s18);
                Console.ForegroundColor = ConsoleColor.White;
            }
            static void Goku() {
                QuickSizeCheck();
                string s01 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s02 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s03 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s04 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s05 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s06 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s07 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s08 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s09 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s10 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s11 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s12 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s13 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s14 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s15 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s16 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s17 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s18 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(121, 21);
                Console.Write(s01);
                Console.SetCursorPosition(121, 22);
                Console.Write(s02);
                Console.SetCursorPosition(121, 23);
                Console.Write(s03);
                Console.SetCursorPosition(121, 24);
                Console.Write(s04);
                Console.SetCursorPosition(121, 25);
                Console.Write(s05);
                Console.SetCursorPosition(121, 26);
                Console.Write(s06);
                Console.SetCursorPosition(121, 27);
                Console.Write(s07);
                Console.SetCursorPosition(121, 28);
                Console.Write(s08);
                Console.SetCursorPosition(121, 29);
                Console.Write(s09);
                Console.SetCursorPosition(121, 30);
                Console.Write(s10);
                Console.SetCursorPosition(121, 31);
                Console.Write(s11);
                Console.SetCursorPosition(121, 32);
                Console.Write(s12);
                Console.SetCursorPosition(121, 33);
                Console.Write(s13);
                Console.SetCursorPosition(121, 34);
                Console.Write(s14);
                Console.SetCursorPosition(121, 35);
                Console.Write(s15);
                Console.SetCursorPosition(121, 36);
                Console.Write(s16);
                Console.SetCursorPosition(121, 37);
                Console.Write(s17);
                Console.SetCursorPosition(121, 38);
                Console.Write(s18);
                Console.ForegroundColor = ConsoleColor.White;
            }
            static void Sonis() {
                QuickSizeCheck();
                string s01 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s02 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s03 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s04 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s05 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s06 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s07 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s08 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s09 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s10 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s11 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s12 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s13 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s14 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s15 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                string s16 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(3, 2);
                Console.Write(s01);
                Console.SetCursorPosition(3, 3);
                Console.Write(s02);
                Console.SetCursorPosition(3, 4);
                Console.Write(s03);
                Console.SetCursorPosition(3, 5);
                Console.Write(s04);
                Console.SetCursorPosition(3, 6);
                Console.Write(s05);
                Console.SetCursorPosition(3, 7);
                Console.Write(s06);
                Console.SetCursorPosition(3, 8);
                Console.Write(s07);
                Console.SetCursorPosition(3, 9);
                Console.Write(s08);
                Console.SetCursorPosition(3, 10);
                Console.Write(s09);
                Console.SetCursorPosition(3, 11);
                Console.Write(s10);
                Console.SetCursorPosition(3, 12);
                Console.Write(s11);
                Console.SetCursorPosition(3, 13);
                Console.Write(s12);
                Console.SetCursorPosition(3, 14);
                Console.Write(s13);
                Console.SetCursorPosition(3, 15);
                Console.Write(s14);
                Console.SetCursorPosition(3, 16);
                Console.Write(s15);
                Console.SetCursorPosition(3, 17);
                Console.Write(s16);
                Console.ForegroundColor = ConsoleColor.White;
            }
            static void WinnerText(string P) {
                string s01 = "                                                                                                                                                              00000               00000    000000000000000    00000          00000    00000          00000    000000000000000    00000000000                   000000000000000      0000000000000             ";
                string s02 = "                                                                                                                                                              00000               00000    000000000000000    00000          00000    00000          00000    000000000000000    000000000000000               000000000000000     000000000000000            ";
                string s03 = "                                                                                                                                                              00000               00000    000000000000000    00000          00000    00000          00000    000000000000000    00000000000000000             000000000000000    000000000000000             ";
                string s04 = "                                                                                                                                                               00000             00000          00000         00000000       00000    00000000       00000    00000              00000     00000000                 00000         00000                       ";
                string s05 = "                                                                                                                                                               00000             00000          00000         00000000       00000    00000000       00000    00000              00000        00000                 00000         000                         ";
                string s06 = "                                                                                                                                                               00000             00000          00000         00000000       00000    00000000       00000    00000              00000        00000                 00000         000                         ";
                string s07 = "                                                                                                                                                                00000   00000   00000           00000         00000 00000    00000    00000 00000    00000    00000              00000     00000000                 00000         00000                       ";
                string s08 = "                                                                                                                                                                00000   00000   00000           00000         00000 00000    00000    00000 00000    00000    000000000000000    00000000000000000                  00000         000000000000                ";
                string s09 = "                                                                                                                                                                00000   00000   00000           00000         00000 00000    00000    00000 00000    00000    000000000000000    000000000000000                    00000          0000000000000              ";
                string s10 = "                                                                                                                                                                 00000 000 000 00000            00000         00000    00000 00000    00000    00000 00000    000000000000000    00000000000                        00000           0000000000000             ";
                string s11 = "                                                                                                                                                                 00000 000 000 00000            00000         00000    00000 00000    00000    00000 00000    00000              00000 00000                        00000                   000000            ";
                string s12 = "                                                                                                                                                                 00000 000 000 00000            00000         00000    00000 00000    00000    00000 00000    00000              00000  00000                       00000                     0000            ";
                string s13 = "                                                                                                                                                                  0000000   0000000             00000         00000       00000000    00000       00000000    00000              00000   00000                      00000                      000            ";
                string s14 = "                                                                                                                                                                  0000000   0000000             00000         00000       00000000    00000       00000000    00000              00000    00000                     00000                     0000            ";
                string s15 = "                                                                                                                                                                  0000000   0000000             00000         00000       00000000    00000       00000000    00000              00000     00000                    00000                   000000            ";
                string s16 = "                                                                                                                                                                   00000     00000         000000000000000    00000          00000    00000          00000    000000000000000    00000      00000              000000000000000    000000000000000             ";
                string s17 = "                                                                                                                                                                   00000     00000         000000000000000    00000          00000    00000          00000    000000000000000    00000       00000             000000000000000    00000000000000              ";
                string s18 = "                                                                                                                                                                   00000     00000         000000000000000    00000          00000    00000          00000    000000000000000    00000        00000            000000000000000    000000000000                ";
                if (P == "You") {
                    s01 += "00000         00000           0000000000           00000                00000    00000                                                                                                                                                                   ";
                    s02 += "00000         00000         00000000000000         00000                00000    00000                                                                                                                                                                   ";
                    s03 += "00000         00000       000000000000000000       00000                00000    00000                                                                                                                                                                   ";
                    s04 += "  00000     00000        000000        000000      00000                00000    00000                                                                                                                                                                   ";
                    s05 += "  00000     00000       00000            00000     00000                00000    00000                                                                                                                                                                   ";
                    s06 += "  00000     00000       00000            00000     00000                00000    00000                                                                                                                                                                   ";
                    s07 += "    00000 00000        00000              00000    00000                00000    00000                                                                                                                                                                   ";
                    s08 += "    00000 00000        00000              00000    00000                00000    00000                                                                                                                                                                   ";
                    s09 += "    00000 00000        00000              00000    00000                00000    00000                                                                                                                                                                   ";
                    s10 += "       00000           00000              00000    00000                00000    00000                                                                                                                                                                   ";
                    s11 += "       00000           00000              00000    00000                00000    00000                                                                                                                                                                   ";
                    s12 += "       00000           00000              00000    00000                00000    00000                                                                                                                                                                   ";
                    s13 += "       00000            00000            00000     00000                00000                                                                                                                                                                            ";
                    s14 += "       00000            00000            00000      00000              00000                                                                                                                                                                             ";
                    s15 += "       00000             000000        000000        000000          000000                                                                                                                                                                              ";
                    s16 += "       00000              00000000000000000           00000000000000000000       00000                                                                                                                                                                   ";
                    s17 += "       00000                00000000000000              0000000000000000         00000                                                                                                                                                                   ";
                    s18 += "       00000                  0000000000                   0000000000            00000                                                                                                                                                                   ";
                } else if (P == "Cirno") {
                    s01 += "       000000000000    000000000000000    00000000000           00000          00000           0000000000           00000                                                                                                                                                                   ";
                    s02 += "     00000000000000    000000000000000    000000000000000       00000          00000         00000000000000         00000                                                                                                                                                                   ";
                    s03 += "   0000000000000000    000000000000000    00000000000000000     00000          00000       000000000000000000       00000                                                                                                                                                                   ";
                    s04 += "  000000                    00000         00000     00000000    00000000       00000      000000        000000      00000                                                                                                                                                                   ";
                    s05 += " 00000                      00000         00000        00000    00000000       00000     00000            00000     00000                                                                                                                                                                   ";
                    s06 += " 00000                      00000         00000        00000    00000000       00000     00000            00000     00000                                                                                                                                                                   ";
                    s07 += "00000                       00000         00000     00000000    00000 00000    00000    00000              00000    00000                                                                                                                                                                   ";
                    s08 += "00000                       00000         00000000000000000     00000 00000    00000    00000              00000    00000                                                                                                                                                                   ";
                    s09 += "00000                       00000         000000000000000       00000 00000    00000    00000              00000    00000                                                                                                                                                                   ";
                    s10 += "00000                       00000         00000000000           00000    00000 00000    00000              00000    00000                                                                                                                                                                   ";
                    s11 += "00000                       00000         00000 00000           00000    00000 00000    00000              00000    00000                                                                                                                                                                   ";
                    s12 += "00000                       00000         00000  00000          00000    00000 00000    00000              00000    00000                                                                                                                                                                   ";
                    s13 += " 00000                      00000         00000   00000         00000       00000000     00000            00000                                                                                                                                                                             ";
                    s14 += " 00000                      00000         00000    00000        00000       00000000     00000            00000                                                                                                                                                                             ";
                    s15 += "  000000                    00000         00000     00000       00000       00000000      000000        000000                                                                                                                                                                              ";
                    s16 += "   0000000000000000    000000000000000    00000      00000      00000          00000       000000000000000000       00000                                                                                                                                                                   ";
                    s17 += "     00000000000000    000000000000000    00000       00000     00000          00000         00000000000000         00000                                                                                                                                                                   ";
                    s18 += "       000000000000    000000000000000    00000        00000    00000          00000           0000000000           00000                                                                                                                                                                   ";
                } else if (P == "Goku") {
                    s01 += "       000000000000           0000000000           00000      0000    00000                00000    00000                                                                                                                                                                   ";
                    s02 += "     00000000000000         00000000000000         00000    0000      00000                00000    00000                                                                                                                                                                   ";
                    s03 += "   0000000000000000       000000000000000000       00000    0000      00000                00000    00000                                                                                                                                                                   ";
                    s04 += "  000000                 000000        000000      00000    0000      00000                00000    00000                                                                                                                                                                   ";
                    s05 += " 00000                  00000            00000     00000  0000        00000                00000    00000                                                                                                                                                                   ";
                    s06 += " 00000                  00000            00000     00000  0000        00000                00000    00000                                                                                                                                                                   ";
                    s07 += "00000                  00000              00000    00000  0000        00000                00000    00000                                                                                                                                                                   ";
                    s08 += "00000                  00000              00000    00000000           00000                00000    00000                                                                                                                                                                   ";
                    s09 += "00000                  00000              00000    00000000           00000                00000    00000                                                                                                                                                                   ";
                    s10 += "00000     000000000    00000              00000    00000000           00000                00000    00000                                                                                                                                                                   ";
                    s11 += "00000     000000000    00000              00000    00000000           00000                00000    00000                                                                                                                                                                   ";
                    s12 += "00000     000000000    00000              00000    00000  0000        00000                00000    00000                                                                                                                                                                   ";
                    s13 += " 00000        00000     00000            00000     00000  0000        00000                00000                                                                                                                                                                            ";
                    s14 += " 00000        00000     00000            00000     00000  0000         00000              00000                                                                                                                                                                             ";
                    s15 += "  000000      00000      000000        000000      00000    0000        000000          000000                                                                                                                                                                              ";
                    s16 += "   0000000000000000       000000000000000000       00000    0000         00000000000000000000       00000                                                                                                                                                                   ";
                    s17 += "     00000000000000         00000000000000         00000    0000           0000000000000000         00000                                                                                                                                                                   ";
                    s18 += "       000000000000           0000000000           00000      0000            0000000000            00000                                                                                                                                                                   ";
                }
                int i = 0;
                int j = 0;
                int p = 0;
                int l = 0;
                Console.CursorVisible = false;
                while (l < s01.Length - 158) {
                    i = 0;
                    if (p > 18) {
                        p = 0;
                        j++;
                        l++;
                        Thread.Sleep(0);
                    }
                    Console.SetCursorPosition(1, 1 + p);
                    while (i < 158) {
                        QuickSizeCheck();
                        if (j >= s01.Length) {
                            j -= s01.Length;
                        }
                        switch (p) {
                            case 0: Console.Write(s01[j]); break;
                            case 1: Console.Write(s02[j]); break;
                            case 2: Console.Write(s03[j]); break;
                            case 3: Console.Write(s04[j]); break;
                            case 4: Console.Write(s05[j]); break;
                            case 5: Console.Write(s06[j]); break;
                            case 6: Console.Write(s07[j]); break;
                            case 7: Console.Write(s08[j]); break;
                            case 8: Console.Write(s09[j]); break;
                            case 9: Console.Write(s10[j]); break;
                            case 10: Console.Write(s11[j]); break;
                            case 11: Console.Write(s12[j]); break;
                            case 12: Console.Write(s13[j]); break;
                            case 13: Console.Write(s14[j]); break;
                            case 14: Console.Write(s15[j]); break;
                            case 15: Console.Write(s16[j]); break;
                            case 16: Console.Write(s17[j]); break;
                            case 17: Console.Write(s18[j]); break;
                        }
                        i++;
                        j++;
                    }
                    j -= 158;
                    p++;
                }
            }
            static void Numbers(int digit) {
                byte hun = 0;
                byte ten = 0;
                byte one = 0;
                string[] a01 = { "        0000000000         ",
                             "      00000000000000       ",
                             "    000000000000000000     ",
                             "   000000         000000   ",
                             " 00000               00000 ",
                             " 00000               00000 ",
                             "00000                 00000",
                             "00000      0000       00000",
                             "00000     000000      00000",
                             "00000     000000      00000",
                             "00000      0000       00000",
                             "00000                 00000",
                             " 00000               00000 ",
                             " 00000               00000 ",
                             "  000000          000000   ",
                             "   00000000000000000000    ",
                             "     0000000000000000      ",
                             "       000000000000        "
            };
                string[] b01 = { "111111111111111            ",
                             "111111111111111            ",
                             "111111111111111            ",
                             "           1111            ",
                             "           1111            ",
                             "           1111            ",
                             "           1111            ",
                             "           1111            ",
                             "           1111            ",
                             "           1111            ",
                             "           1111            ",
                             "           1111            ",
                             "           1111            ",
                             "           1111            ",
                             "           1111            ",
                             "111111111111111111111111111",
                             "111111111111111111111111111",
                             "111111111111111111111111111"
            };
                string[] c01 = { "      222222222222222      ",
                             "  222222222222222222222    ",
                             "2222222222222222222222222  ",
                             "222222           222222222 ",
                             "22                  2222222",
                             "                      22222",
                             "                       2222",
                             "                       2222",
                             "                    2222222",
                             "              2222222222222",
                             "    2222222222222222222222 ",
                             "  222222222222222222       ",
                             "222222222222               ",
                             "2222                       ",
                             "2222                       ",
                             "222222222222222222222222222",
                             "222222222222222222222222222",
                             "222222222222222222222222222"
            };
                string[] d01 = { "          333333333333     ",
                             "    33333333333333333333   ",
                             "33333333333333333333333333 ",
                             "3333333333          333333 ",
                             "3333                  33333",
                             "                       3333",
                             "                      33333",
                             "                    333333 ",
                             "     33333333333333333333  ",
                             "     33333333333333333333  ",
                             "                    333333 ",
                             "                      33333",
                             "                       3333",
                             "3333                  33333",
                             "3333333333          333333 ",
                             "33333333333333333333333333 ",
                             "    33333333333333333333   ",
                             "          333333333333     "
            };
                string[] e01 = { "4444               4444    ",
                             "4444               4444    ",
                             "4444               4444    ",
                             "4444               4444    ",
                             "4444               4444    ",
                             "4444               4444    ",
                             "4444               4444    ",
                             "4444               4444    ",
                             "444444444444444444444444444",
                             "444444444444444444444444444",
                             "                   4444    ",
                             "                   4444    ",
                             "                   4444    ",
                             "                   4444    ",
                             "                   4444    ",
                             "                   4444    ",
                             "                   4444    ",
                             "                   4444    "
            };
                string[] f01 = { "555555555555555555555555555",
                             "555555555555555555555555555",
                             "555555555555555555555555555",
                             "5555                       ",
                             "5555                       ",
                             "5555                       ",
                             "555555555555555555         ",
                             "5555555555555555555555     ",
                             "5555555555555555555555555  ",
                             "                5555555555 ",
                             "                    5555555",
                             "                       5555",
                             "                       5555",
                             "                    5555555",
                             "                5555555555 ",
                             "5555555555555555555555555  ",
                             "5555555555555555555555     ",
                             "555555555555555555         "
            };
                string[] g01 = { "            666666666     ",
                             "         666666666666666  ",
                             "      666666         66666",
                             "    666666                ",
                             "  666666                  ",
                             " 66666                    ",
                             " 6666                     ",
                             "6666                      ",
                             "6666                      ",
                             "6666   666666666666       ",
                             "66666666666666666666666   ",
                             "666666              66666 ",
                             "6666                  6666",
                             "6666                  6666",
                             "6666                  6666",
                             " 66666              66666 ",
                             "   66666666666666666666   ",
                             "       666666666666       "
            };
                string[] h01 = { "77777777777777777777777777",
                             "77777777777777777777777777",
                             "77777777777777777777777777",
                             "                     7777 ",
                             "                    7777  ",
                             "                   7777   ",
                             "                  7777    ",
                             "                 7777     ",
                             "                7777      ",
                             "               7777       ",
                             "              7777        ",
                             "             7777         ",
                             "            7777          ",
                             "           7777           ",
                             "          7777            ",
                             "         7777             ",
                             "        7777              ",
                             "       7777               "
            };
                string[] i01 = { "       888888888888       ",
                             "   88888888888888888888   ",
                             " 8888888          8888888 ",
                             "888888              888888",
                             "88888                88888",
                             "88888                88888",
                             "88888                88888",
                             " 888888            888888 ",
                             "  8888888888888888888888  ",
                             "  8888888888888888888888  ",
                             " 888888            888888 ",
                             "88888                88888",
                             "88888                88888",
                             "88888                88888",
                             "888888              888888",
                             " 8888888          8888888 ",
                             "   88888888888888888888   ",
                             "       888888888888       "
            };
                string[] j01 = { "       999999999999       ",
                             "   99999999999999999999   ",
                             " 99999              99999 ",
                             "9999                  9999",
                             "9999                  9999",
                             "9999                  9999",
                             " 9999                99999",
                             "   99999999999999999999999",
                             "       9999999999999  9999",
                             "                      9999",
                             "                      9999",
                             "                     9999 ",
                             "                    99999 ",
                             "                  999999  ",
                             "                999999    ",
                             "99999         999999      ",
                             "  999999999999999         ",
                             "     999999999            "
            };
                while (true) {
                    QuickSizeCheck();
                    digit -= 100;
                    if (digit >= 0) {
                        hun++;
                    } else {
                        digit += 100;
                        break;
                    }
                }
                while (true) {
                    QuickSizeCheck();
                    digit -= 10;
                    if (digit >= 0) {
                        ten++;
                    } else {
                        digit += 10;
                        break;
                    }
                }
                while (true) {
                    QuickSizeCheck();
                    digit--;
                    if (digit >= 0) {
                        one++;
                    } else {
                        digit++;
                        break;
                    }
                }
                switch (hun) {
                    case 0: DisplayNumbers(a01, 0); break;
                    case 1: DisplayNumbers(b01, 0); break;
                    case 2: DisplayNumbers(c01, 0); break;
                    case 3: DisplayNumbers(d01, 0); break;
                    case 4: DisplayNumbers(e01, 0); break;
                    case 5: DisplayNumbers(f01, 0); break;
                    case 6: DisplayNumbers(g01, 0); break;
                    case 7: DisplayNumbers(h01, 0); break;
                    case 8: DisplayNumbers(i01, 0); break;
                    case 9: DisplayNumbers(j01, 0); break;
                }
                switch (ten) {
                    case 0: DisplayNumbers(a01, 1); break;
                    case 1: DisplayNumbers(b01, 1); break;
                    case 2: DisplayNumbers(c01, 1); break;
                    case 3: DisplayNumbers(d01, 1); break;
                    case 4: DisplayNumbers(e01, 1); break;
                    case 5: DisplayNumbers(f01, 1); break;
                    case 6: DisplayNumbers(g01, 1); break;
                    case 7: DisplayNumbers(h01, 1); break;
                    case 8: DisplayNumbers(i01, 1); break;
                    case 9: DisplayNumbers(j01, 1); break;
                }
                switch (one) {
                    case 0: DisplayNumbers(a01, 2); break;
                    case 1: DisplayNumbers(b01, 2); break;
                    case 2: DisplayNumbers(c01, 2); break;
                    case 3: DisplayNumbers(d01, 2); break;
                    case 4: DisplayNumbers(e01, 2); break;
                    case 5: DisplayNumbers(f01, 2); break;
                    case 6: DisplayNumbers(g01, 2); break;
                    case 7: DisplayNumbers(h01, 2); break;
                    case 8: DisplayNumbers(i01, 2); break;
                    case 9: DisplayNumbers(j01, 2); break;
                }
            }
            static byte LoudIncorrectBuzzer(byte wrog) {
                string[] a01 = { "000000000000000000000000000",
                             "000000000000000000000000000",
                             "000000000000000000000000000",
                             "00000                 00000",
                             "00000  0000     0000  00000",
                             "00000  0000     0000  00000",
                             "00000   0000   0000   00000",
                             "00000   0000   0000   00000",
                             "00000    000000000    00000",
                             "00000    000000000    00000",
                             "00000   0000   0000   00000",
                             "00000   0000   0000   00000",
                             "00000  0000     0000  00000",
                             "00000  0000     0000  00000",
                             "00000                 00000",
                             "000000000000000000000000000",
                             "000000000000000000000000000",
                             "000000000000000000000000000"
            };
                Console.ForegroundColor = ConsoleColor.Red;
                QuickSizeCheck();
                if (wrog >= 0) {
                    for (int i = 0; i < a01.Length; i++) {
                        Console.SetCursorPosition(131, i + 1);
                        Console.Write(a01[i]);
                    }
                }
                QuickSizeCheck();
                if (wrog >= 1) {
                    for (int i = 0; i < a01.Length; i++) {
                        Console.SetCursorPosition(101, i + 1);
                        Console.Write(a01[i]);
                    }
                }
                QuickSizeCheck();
                if (wrog >= 2) {
                    for (int i = 0; i < a01.Length; i++) {
                        Console.SetCursorPosition(71, i + 1);
                        Console.Write(a01[i]);
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                wrog++;
                return wrog;
            }
            static void DisplayNumbers(string[] number, byte order) {
                if (order == 0) {
                    for (int i = 0; i < number.Length; i++) {
                        QuickSizeCheck();
                        Console.SetCursorPosition(71, i + 1);
                        Console.Write(number[i]);
                    }
                }
                if (order == 1) {
                    for (int i = 0; i < number.Length; i++) {
                        QuickSizeCheck();
                        Console.SetCursorPosition(101, i + 1);
                        Console.Write(number[i]);
                    }
                }
                if (order == 2) {
                    for (int i = 0; i < number.Length; i++) {
                        QuickSizeCheck();
                        Console.SetCursorPosition(131, i + 1);
                        Console.Write(number[i]);
                    }
                }
            }
            static byte FakeCrash(byte fails) {
                Console.CursorVisible = false;
                if (fails == 0) {
                    Console.WriteLine();
                    Console.WriteLine(" ");
                    Console.WriteLine("C:\\Users\\MCA-20\\source\\repos\\OutGuess\\bin\\Debug\\net8.0\\OutGuess.exe (process 69420) exited with code 9001.");
                    Console.WriteLine("To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.");
                    Console.WriteLine("Press any key to close this window . . .");
                    Thread.Sleep(4000);
                    QuickSizeCheck();
                    TextBox();
                    Portraits();
                    Player();
                    Cirno();
                    Goku();
                    Sonis();
                    Dialogue($"LOL! Did i scare you? Did you feel victorious with breaking my gameshow? You thought!", 40, 2);
                    Thread.Sleep(5000);
                    fails++;
                    return fails;
                } else if (fails == 1) {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("             ██");
                    Console.WriteLine("            ██ ");
                    Console.WriteLine("     ██    ██  ");
                    Console.WriteLine("           ██  ");
                    Console.WriteLine("     ██    ██  ");
                    Console.WriteLine("            ██ ");
                    Console.WriteLine("             ██");
                    Console.WriteLine();
                    Console.WriteLine("     Your PC ran into a problem and needs to restart. We're");
                    Console.WriteLine("     just collecting some error info, and then we'll restart for");
                    Console.WriteLine("     you.");
                    Console.WriteLine();
                    Console.WriteLine("     0% complete");
                    Thread.Sleep(10000);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    QuickSizeCheck();
                    TextBox();
                    Portraits();
                    Player();
                    Cirno();
                    Goku();
                    Sonis();
                    Dialogue($"What? Stop trying to break the game! Its gonna hurt our ratings!", 40, 2);
                    Thread.Sleep(5000);
                    fails++;
                    return fails;

                } else if (fails == 2) {
                    Random random = new Random();
                    int x = 0;
                    int y = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    for (int i = 0; i < 100; i++) {
                        x = random.Next(0, Console.WindowWidth);
                        y = random.Next(0, Console.WindowHeight - 1);
                        Console.SetCursorPosition(x,y);
                        Console.Write("STOP TRYING");
                        Thread.Sleep(100 - i);
                    }
                    for (int i = 0; i < 1000; i++) {
                        x = random.Next(0, Console.WindowWidth);
                        y = random.Next(0, Console.WindowHeight - 1);
                        Console.SetCursorPosition(x, y);
                        Console.Write("STOP TRYING");
                        Thread.Sleep(1);
                    }
                    for (int i = 0; i < 10000; i++) {
                        x = random.Next(0, Console.WindowWidth);
                        y = random.Next(0, Console.WindowHeight - 1);
                        Console.SetCursorPosition(x, y);
                        Console.Write("STOP TRYING");
                    }
                    Thread.Sleep(4000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    QuickSizeCheck();
                    TextBox();
                    Portraits();
                    Player();
                    Cirno();
                    Goku();
                    Sonis();
                    Dialogue($"I KNEW IT, you dont like fun, its always \"How can i ruin this man's hard work\" its quite PATHETIC!!!", 40, 2);
                    Thread.Sleep(2000);
                    Dialogue($"Just so you know, I saw you eagerly and PURPOSEFULLY typing strings and ILLEGAL numbers into the input", 40, 4);
                    Dialogue($"and trying to be wrong on PURPOSE!!!", 40, 5);
                    Thread.Sleep(2000);
                    Dialogue($"Guess what buddy. I recorded the whole thing.........", 40, 7);
                    Thread.Sleep(2000);
                    Dialogue($"Say hello to YouTube, your going on the Guess the Number's Official YouTube Channel.", 40, 9);
                    Thread.Sleep(2000);
                    Dialogue($"You will forever be known as the guy seen in the popular \"Guess the Number Cringe Compilation Series\"", 40, 11);
                    Thread.Sleep(2000);
                    Dialogue($"THERE.        IS.        NOTHING.        TO.        GAIN.", 40, 13);
                    Thread.Sleep(2000);
                    Dialogue($"I hope people point and laugh at you at grocery stores!!!!", 40, 15);
                    Thread.Sleep(5000);
                    fails++;
                    return fails;
                } else {
                    Console.Clear();
                    Thread.Sleep(5000);
                    int i = 0;
                    byte x = 0;
                    bool Fader = false;
                    while (!Fader) {
                        string s = "";
                        switch (x) {
                            case 0: Console.ForegroundColor = ConsoleColor.Black; Console.BackgroundColor = ConsoleColor.Black; s = "█"; break;
                            case 1: Console.ForegroundColor = ConsoleColor.DarkGray; Console.BackgroundColor = ConsoleColor.Black; s = "░"; break;
                            case 2: Console.ForegroundColor = ConsoleColor.DarkGray; Console.BackgroundColor = ConsoleColor.Black; s = "▒"; break;
                            case 3: Console.ForegroundColor = ConsoleColor.DarkGray; Console.BackgroundColor = ConsoleColor.Black; s = "▓"; break;
                            case 4: Console.ForegroundColor = ConsoleColor.Black; Console.BackgroundColor = ConsoleColor.DarkGray; s = "▓"; break;
                            case 5: Console.ForegroundColor = ConsoleColor.Black; Console.BackgroundColor = ConsoleColor.DarkGray; s = "▒"; break;
                            case 6: Console.ForegroundColor = ConsoleColor.Black; Console.BackgroundColor = ConsoleColor.DarkGray; s = "░"; break;
                            case 7: Console.ForegroundColor = ConsoleColor.DarkGray; Console.BackgroundColor = ConsoleColor.DarkGray; s = "█"; break;
                            case 8: Console.ForegroundColor = ConsoleColor.Gray; Console.BackgroundColor = ConsoleColor.DarkGray; s = "░"; break;
                            case 9: Console.ForegroundColor = ConsoleColor.Gray; Console.BackgroundColor = ConsoleColor.DarkGray; s = "▒"; break;
                            case 10: Console.ForegroundColor = ConsoleColor.Gray; Console.BackgroundColor = ConsoleColor.DarkGray; s = "▓"; break;
                            case 11: Console.ForegroundColor = ConsoleColor.DarkGray; Console.BackgroundColor = ConsoleColor.Gray; s = "▓"; break;
                            case 12: Console.ForegroundColor = ConsoleColor.DarkGray; Console.BackgroundColor = ConsoleColor.Gray; s = "▒"; break;
                            case 13: Console.ForegroundColor = ConsoleColor.DarkGray; Console.BackgroundColor = ConsoleColor.Gray; s = "░"; break;
                            case 14: Console.ForegroundColor = ConsoleColor.Gray; Console.BackgroundColor = ConsoleColor.Gray; s = "█"; break;
                            case 15: Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.DarkGray; s = "▓"; break;
                            case 16: Console.ForegroundColor = ConsoleColor.DarkGray; Console.BackgroundColor = ConsoleColor.White; s = "▒"; break;
                            case 17: Console.ForegroundColor = ConsoleColor.DarkGray; Console.BackgroundColor = ConsoleColor.White; s = "░"; break;
                            case 18: Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.White; s = "█"; break;
                        }
                        string b = s;
                        while (s.Length != Console.WindowWidth) {
                            s += b;
                        }
                        Console.SetCursorPosition(0, 0);
                        for (int l = 0; l < Console.WindowHeight - 1; l++) {
                            Console.WriteLine(s);
                        }
                        x++;
                        Fader = x == 19;
                        Thread.Sleep(500);
                    }
                    Thread.Sleep(5000);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Dialogue(" ", 0, 0);
                    Dialogue("C:\\Users\\MCA-20\\source\\repos\\OutGuess\\bin\\Debug\\net8.0\\OutGuess.exe (process 69420) exited with code 9001.", 0, 1);
                    Dialogue("To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.", 0, 2);
                    Dialogue("Press any key to close this window . . .", 0, 3);
                    Thread.Sleep(5000);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    QuickSizeCheck();
                    TextBox();
                    Portraits();
                    Player();
                    Cirno();
                    Goku();
                    Sonis();
                    return fails;
                }
            }
            #region Defaults
            static byte PromptTryByte(string dataRequest) {
                byte userInput = 0;
                bool isValid = false;
                do {
                    Console.Write(dataRequest);
                    isValid = byte.TryParse(Console.ReadLine(), out userInput);
                } while (isValid == false);
                return userInput;
            }
            static sbyte PromptTrySByte(string dataRequest) {
                sbyte userInput = 0;
                bool isValid = false;
                do {
                    Console.Write(dataRequest);
                    isValid = sbyte.TryParse(Console.ReadLine(), out userInput);
                } while (isValid == false);
                return userInput;
            }
            static short PromptTryShort(string dataRequest) {
                short userInput = 0;
                bool isValid = false;
                do {
                    Console.Write(dataRequest);
                    isValid = short.TryParse(Console.ReadLine(), out userInput);
                } while (isValid == false);
                return userInput;
            }
            static ushort PromptTryUShort(string dataRequest) {
                ushort userInput = 0;
                bool isValid = false;
                do {
                    Console.Write(dataRequest);
                    isValid = ushort.TryParse(Console.ReadLine(), out userInput);
                } while (isValid == false);
                return userInput;
            }
            static int PromptTryInt(string dataRequest) {
                int userInput = 0;
                bool isValid = false;
                do {
                    Console.Write(dataRequest);
                    isValid = int.TryParse(Console.ReadLine(), out userInput);
                } while (isValid == false);
                return userInput;
            }
            static uint PromptTryUInt(string dataRequest) {
                uint userInput = 0;
                bool isValid = false;
                do {
                    Console.Write(dataRequest);
                    isValid = uint.TryParse(Console.ReadLine(), out userInput);
                } while (isValid == false);
                return userInput;
            }
            static long PromptTryLong(string dataRequest) {
                long userInput = 0;
                bool isValid = false;
                do {
                    Console.Write(dataRequest);
                    isValid = long.TryParse(Console.ReadLine(), out userInput);
                } while (isValid == false);
                return userInput;
            }
            static ulong PromptTryULong(string dataRequest) {
                ulong userInput = 0;
                bool isValid = false;
                do {
                    Console.Write(dataRequest);
                    isValid = ulong.TryParse(Console.ReadLine(), out userInput);
                } while (isValid == false);
                return userInput;
            }
            static float PromptTryFloat(string dataRequest) {
                float userInput = 0f;
                bool isValid = false;
                do {
                    Console.Write(dataRequest);
                    isValid = float.TryParse(Console.ReadLine(), out userInput);
                } while (isValid == false);
                return userInput;
            }
            static double PromptTryDouble(string dataRequest) {
                double userInput = 0;
                bool isValid = false;
                do {
                    Console.Write(dataRequest);
                    isValid = double.TryParse(Console.ReadLine(), out userInput);
                } while (isValid == false);
                return userInput;
            }
            static decimal PromptTryDecimal(string dataRequest) {
                decimal userInput = 0m;
                bool isValid = false;
                do {
                    Console.Write(dataRequest);
                    isValid = decimal.TryParse(Console.ReadLine(), out userInput);
                } while (isValid == false);
                return userInput;
            }
            static string Prompt(string dataRequest) {
                string userInput = "";
                Console.Write(dataRequest);
                userInput = Console.ReadLine();
                return userInput;
            }
            static byte PromptByte(string dataRequest) {
                byte userInput = 0;
                userInput = byte.Parse(Prompt(dataRequest));
                return userInput;
            }
            static sbyte PromptSByte(string dataRequest) {
                sbyte userInput = 0;
                userInput = sbyte.Parse(Prompt(dataRequest));
                return userInput;
            }
            static short PromptShort(string dataRequest) {
                short userInput = 0;
                userInput = short.Parse(Prompt(dataRequest));
                return userInput;
            }
            static ushort PromptUShort(string dataRequest) {
                ushort userInput = 0;
                userInput = ushort.Parse(Prompt(dataRequest));
                return userInput;
            }
            static int PromptInt(string dataRequest) {
                int userInput = 0;
                userInput = int.Parse(Prompt(dataRequest));
                return userInput;
            }
            static uint PromptUInt(string dataRequest) {
                uint userInput = 0;
                userInput = uint.Parse(Prompt(dataRequest));
                return userInput;
            }
            static long PromptLong(string dataRequest) {
                long userInput = 0;
                userInput = long.Parse(Prompt(dataRequest));
                return userInput;
            }
            static ulong PromptULong(string dataRequest) {
                ulong userInput = 0;
                userInput = ulong.Parse(Prompt(dataRequest));
                return userInput;
            }
            static float PromptFloat(string dataRequest) {
                float userInput = 0f;
                userInput = float.Parse(Prompt(dataRequest));
                return userInput;
            }
            static double PromptDouble(string dataRequest) {
                double userInput = 0;
                userInput = double.Parse(Prompt(dataRequest));
                return userInput;
            }
            static decimal PromptDecimal(string dataRequest) {
                decimal userInput = 0m;
                userInput = decimal.Parse(Prompt(dataRequest));
                return userInput;
            }
            #endregion
        }
    }
}