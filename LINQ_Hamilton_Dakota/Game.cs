using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Hamilton_Dakota
{
    class Game
    {
        
        public string Title { get; }
        
        public char Esrb { get; }
        
        public string Genre { get; }
        
        public Game(string titleParam, char esrbParam, string genreParam)
    {
            Title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam;
    }

    }
}
