using System;
using System.Linq;

namespace LINQ_Hamilton_Dakota
{
    class Program
    {
        /* IT ONLY PRINTS OUT WHAT IT IS TOLD TO
         * IT ALSO PRINTS THE OBJECT []new Game ("Minecraft,'E',"Action-Adventure") TO THE CONSOLE
         * IT IS PRINTED OUT AS "Title: Minecraft, ESRB: E, Genre: Action"
         * IT ALSO FINDS AND PRINTS OUT "T Rated" GAMES
         * IT ALSO FINDS AND PRINTS OUT "E Rated Action" GAMES
         */
        static void Main(string[] args)
        {
            Game[] games = new Game[]
            {
                new Game("Minecraft",'E',"Action-Adventure"),
                new Game("GOV: NIKKE",'T',"Third-Person-Shooter"),
                new Game("Team Fortress 2",'T',"First-Person-Shooter"),
                new Game("COD Black Ops",'M',"First-Person-Shooter"),
                new Game("COD Black Ops II",'M',"First-Person-Shooter"),
                new Game("Halo 3: ODST",'M',"First-Person-Shooter"),
                new Game("Terraria",'T',"Side Scrolling Adventure Game"),
                new Game("Garry's Mod",'M',"Sandbox"),
                new Game("Borderlands",'M',"Sci Fi First-Person-Shooter"),
                new Game("Neon Abyss",'T',"Roguelike")
            };

            // Finds an Object/s
            var shortGames = from game in games
                             
                             // Finds that Object/s that has the least amount of Letters
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            // Prints an Object to the Console based on the Length
            foreach(var game in shortGames)
            {
                Console.WriteLine(game);
            }

            // Finds the Similar String and Shows it
            var mineCraft = games.Where(game => game.Title == "Minecraft")
                            .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre:{game.Genre}");

            Console.WriteLine(mineCraft.FirstOrDefault());

            // Finds the Objects with the specific Char
            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;

            // Prints the Objects with the specified Char
            Console.WriteLine("T Rated Games:");
            foreach(var game in tRated)
            {
                Console.WriteLine(game);
            }

            // Finds the Objects with the specified Char and String
            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;

            // Prints the Objects with the specified Char and String
            Console.WriteLine("E Rated Action Games:");
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }
        }
    }
}
