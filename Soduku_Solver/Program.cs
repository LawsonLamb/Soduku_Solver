using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Soduku_Solver
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Board board = new Board();
            board.Grid.findMatches();
            Console.ReadKey();
        }

    }
}
