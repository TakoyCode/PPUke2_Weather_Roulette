namespace PPUke2_Weather_Roulette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var outfits = new Outfit[]
            {
                new ("Shorts og T sjorte" , "Sterk sol", "Fint med korte klær", "Fy, nå var det kalt ute"),
                new ("Regnfrakk" , "Regnvær", "Fint å ikke bli våt", "Blir i værtfall ikke våt"),
                new ("Vinterjakke og skibukse" , "Snøstorm", "Fint å ikke bli kald!", "Faen det er varmt"),
                new ("Vindjakke og bukser" , "Mye vind", "Bra å ha noe å stoppe vinden", "Trenger jeg virkelig en vindjakke i dette været?"),
            };

            var weather = new string[]
            {
                "Sterk sol",
                "Regnvær",
                "Snøstorm",
                "Mye vind"
            };

            var r = new Random();
            int points = 0;

            while (true)
            {
                Console.Clear();
                Game();
            }

            void Game()
            {
                Console.WriteLine($"Dine poeng: {points}");
                var chosenWeather = weather[r.Next(0, 4)];
                Console.WriteLine($"Det er {chosenWeather} ute, hva skal jeg ta på meg?");

                switch (chosenWeather)
                {
                    case "Sterk sol":
                        SunChoice();
                        break;
                    case "Regnvær":
                        RainChoice();
                        break;
                    case "Snøstorm":
                        SnowChoice();
                        break;
                    case "Mye vind":
                        WindChoice();
                        break;
                }

            }
            void WindChoice()
            {
                Console.WriteLine($"1) {outfits[1].OutfitName}");
                Console.WriteLine($"2) {outfits[3].OutfitName}");
                Console.WriteLine($"3) {outfits[2].OutfitName}");
                Console.WriteLine("Skriv X for å avslutte spillet");
                var userInputStr = Console.ReadLine();
                if (Int32.TryParse(userInputStr, out int userInput))
                {
                    switch (userInput)
                    {
                        case 2:
                            Console.WriteLine(outfits[3].CorrectOutfitMessage);
                            points++;
                            break;
                        case 1:
                            Console.WriteLine(outfits[2].WrongOutfitMessage);
                            points--;
                            break;
                        case 3:
                            Console.WriteLine(outfits[1].WrongOutfitMessage);
                            points--;
                            break;
                    }
                }
                else if (userInputStr == "x" || userInputStr == "X")
                {
                    Environment.Exit(69);
                }
                else
                {
                    Console.WriteLine("try to guess again!");
                }
            }

            void SnowChoice()
            {
                Console.WriteLine($"1) {outfits[0].OutfitName}");
                Console.WriteLine($"2) {outfits[1].OutfitName}");
                Console.WriteLine($"3) {outfits[2].OutfitName}");
                Console.WriteLine("Skriv X for å avslutte spillet");
                var userInputStr = Console.ReadLine();
                if (Int32.TryParse(userInputStr, out int userInput))
                {
                    switch (userInput)
                    {
                        case 3:
                            Console.WriteLine(outfits[2].CorrectOutfitMessage);
                            points++;
                            break;
                        case 2:
                            Console.WriteLine(outfits[1].WrongOutfitMessage);
                            points--;
                            break;
                        case 1:
                            Console.WriteLine(outfits[0].WrongOutfitMessage);
                            points--;
                            break;
                    }
                }
                else if (userInputStr == "x" || userInputStr == "X")
                {
                    Environment.Exit(69);
                }
                else
                {
                    Console.WriteLine("try to guess again!");
                }
            }

            void RainChoice()
            {
                Console.WriteLine($"1) {outfits[3].OutfitName}");
                Console.WriteLine($"2) {outfits[1].OutfitName}");
                Console.WriteLine($"3) {outfits[2].OutfitName}");
                Console.WriteLine("Skriv X for å avslutte spillet");
                var userInputStr = Console.ReadLine();
                if (Int32.TryParse(userInputStr, out int userInput))
                {
                    switch (userInput)
                    {
                        case 2:
                            Console.WriteLine(outfits[1].CorrectOutfitMessage);
                            points++;
                            break;
                        case 1:
                            Console.WriteLine(outfits[3].WrongOutfitMessage);
                            points--;
                            break;
                        case 3:
                            Console.WriteLine(outfits[2].WrongOutfitMessage);
                            points--;
                            break;
                    }
                }
                else if (userInputStr == "x" || userInputStr == "X")
                {
                    Environment.Exit(69);
                }
                else
                {
                    Console.WriteLine("try to guess again!");
                }
            }

            void SunChoice()
            {
                Console.WriteLine($"1) {outfits[0].OutfitName}");
                Console.WriteLine($"2) {outfits[1].OutfitName}");
                Console.WriteLine($"3) {outfits[2].OutfitName}");
                Console.WriteLine("Skriv X for å avslutte spillet");
                var userInputStr = Console.ReadLine();
                if (Int32.TryParse(userInputStr, out int userInput))
                {
                    switch (userInput)
                    {
                        case 1:
                            Console.WriteLine(outfits[0].CorrectOutfitMessage);
                            points++;
                            break;
                        case 2:
                            Console.WriteLine(outfits[1].WrongOutfitMessage);
                            points--;
                            break;
                        case 3:
                            Console.WriteLine(outfits[2].WrongOutfitMessage);
                            points--;
                            break;
                    }
                }
                else if (userInputStr == "x" || userInputStr == "X")
                {
                    Environment.Exit(69);
                }
                else
                {
                    Console.WriteLine("try to guess again!");
                }
            }
        }
    }
}
