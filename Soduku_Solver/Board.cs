using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Soduku_Solver
{
    class Board
    {
        private string mLoadfilePath;
        private string mSavefilePath;
        private Grid grid;
        List<int> values;


        public Board()
        {
            loadBoard();
        }
        public Board(string LoadFilePath, string SaveFilePath)
        {
            mLoadfilePath = LoadFilePath;
            mSavefilePath = SaveFilePath;
        }

        private void loadBoard()
        {
            //StreamReader reader = new StreamReader("c:\\Soduku_Solver\Soduku_Solver\load_testBoard.txt");
            string[] file = File.ReadAllLines(@"c:\users\ninja\documents\visual studio 2015\Projects\Soduku_Solver\Soduku_Solver\load_testBoard.txt");
            values = new List<int>();


            string[] s = file[0].Split(',');

            for (int i = 0; i < file.Length; i++)
            {
                Console.WriteLine(file[i].ToString());
            }

            for (int j = 0; j < s.Length; j++)
            {

               // Console.WriteLine(j + " : " + s[j]);
                values.Add(Int32.Parse(s[j]));
            }

            makeBoard();
            grid.printGrid();



        }

        private void saveBoard()
        {

        }

        private void makeBoard()
        {
            grid = new Grid();

            for (int x = 0; x < grid.Squares.GetLength(0); x++)
            {
                for (int y = 0; y < grid.Squares.GetLength(1); y++)
                {
                    int value = values[x * 9 + y];
                    grid.Squares[x, y] = new Square(value,x,y);

                    // Console.WriteLine(x + " , " + y + " : "+ grid.Cells[x,y].Value.ToString());

                }
            }
        }

        internal Grid Grid
        {
            get
            {
                return grid;
            }

            set
            {
                grid = value;
            }
        }
    }

}
