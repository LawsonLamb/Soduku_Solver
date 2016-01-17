using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soduku_Solver
{
    class Square
    {
        private int mValue;
        public int row;
        public int col;
       
        public Square()
        {
            mValue = 0;

        }
        public Square(int Value)
        {
            mValue = Value;
        }
        public Square(int Value, int Row, int Col){
            mValue = Value;
            row = Row;
            col = Col;
            }
        
        public int Value
        {
            get
            {
                return mValue;
            }

            set
            {
                mValue = value;
            }
        }
    }
}
