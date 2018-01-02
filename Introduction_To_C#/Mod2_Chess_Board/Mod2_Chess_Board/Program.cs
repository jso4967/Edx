using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Chess_Board
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 8; row++)
            {
                bool IsRowEven;
                if ((row % 2) == 0)
                    IsRowEven = true;
                else
                    IsRowEven = false;

                //if (IsRowEven)
                //    Console.WriteLine("XOXOXOXO");
                //else 
                //    Console.WriteLine("OXOXOXOX");

                if (IsRowEven)
                {
                    for (int column = 0; column < 8; column++)
                    {
                        bool IsColumnEven;
                        if ((column % 2) == 0)
                            IsColumnEven = true;
                        else
                            IsColumnEven = false;

                        if (IsColumnEven)
                            Console.Write("X");
                        else
                            Console.Write("O");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int column = 0; column < 8; column++)
                    {
                        bool IsColumnEven;
                        if ((column % 2) == 0)
                            IsColumnEven = true;
                        else
                            IsColumnEven = false;

                        if (IsColumnEven)
                            Console.Write("O");
                        else
                            Console.Write("X");
                    }
                    Console.WriteLine();
                }
                    
            }
        }
    }
}
