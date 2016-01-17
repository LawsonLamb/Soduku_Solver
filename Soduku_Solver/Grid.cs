using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soduku_Solver
{
    class Grid
    {
        public static int rowSize = 9;
        public static int colSize = 9;
        private Square[,] mSquares;
        private List<Square> matches = new List<Square>();
        
        public Grid()
        {
            mSquares = new Square[9, 9];
        }


        internal Square[,] Squares
        {
            get
            {
                return mSquares;
            }

            set
            {
                mSquares = value;
            }
        }

        public void printGrid()
        {

            int rowLength = Squares.GetLength(0);
            int colLength = Squares.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if ((j) % 3 == 0)
                    {
                        Console.Write(" | ");
                    }
                    if (i % 3 == 0)
                    {
                        //   Console.WriteLine(Environment.NewLine + "-----");
                    }


                    Console.Write(string.Format("{0}", Squares[i, j].Value));
                    if (j == 8)
                    {
                        Console.Write("|");
                    }

                }

                if ((i + 1) % 3 == 0 && i != 0)
                {
                    Console.Write(Environment.NewLine + " -------------------");
                }

                Console.Write(Environment.NewLine);
            }
            Console.ReadLine();
        }


        public void findMatches()
        {
            //search for 0 values put them in arrary of matches that has all the potential matches;
            

            for (int row = 0; row < rowSize; row++)
            {
                for (int col = 0; col < colSize; col++)
                {
                    if (Squares[row, col].Value == 0)
                    {
                        matches.Add(Squares[row, col]);
                        Console.WriteLine("Potentail Matches at " + row + "," + col);
                    }
                   
                }
            }
        }

        public void CheckMatches()
        {
            
        }

        public void checkRow(int row)
        {
            for(int col = 0; col < colSize; col++)
            {
                Console.WriteLine(Squares[row, col].Value);
            }

        }
        public void checkCol(int col)
        {
            for(int row = 0; row < rowSize; row++)
            {
               Console.WriteLine(Squares[row, col].Value);
            }

        }
        public void checkBlock(int Row, int Col)
        {
            int x = Row % 3;
            int y = Col / 3;

            for (int row = 0; row < rowSize; row++)
            {
                for (int col = 0; col < colSize; col++)
                {
                    if (row % 3 == x && col/3==y)
                    {
                        Console.WriteLine(Squares[row, col].Value);
                    }
                    
                
                }
            }
        }
    }
}
