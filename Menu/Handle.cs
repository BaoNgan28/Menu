using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class Handle
    {
        private int positions;


        public void ClearConsole()
        {
            Console.Clear();
        }
        public int HandleKey(string[] array)
        {
            ConsoleKeyInfo key = Console.ReadKey(true); 
            if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow)
            {
                if (positions == 0)
                {
                    positions = array.Length;
                }
                positions--;
            }
            if (key.Key == ConsoleKey.S || key.Key == ConsoleKey.DownArrow)
            {
                positions++;
                if (positions == array.Length)
                {
                    positions = 0;
                }
            }
            if (key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.Spacebar)
            {
                switch (positions)
                {
                    case 1:
                        ClearConsole();
                        menustart.printf_Positions("CHỌN ĐÚNG RỒI!! GIỎI QUÁ", 18, 12, ConsoleColor.Magenta);
                        Console.ReadKey();
                        break;
                    case 2:
                        ClearConsole();
                        menustart.printf_Positions("CHỌN ĐÚNG RỒI!! GIỎI QUÁ", 18, 12, ConsoleColor.Red);
                        Console.ReadKey();
                        break;
                    case 3:
                        ClearConsole();
                        menustart.printf_Positions("CHỌN ĐÚNG RỒI!! GIỎI QUÁ", 18, 12, ConsoleColor.Cyan);
                        Console.ReadKey();
                        break;
                }
            }
            return positions;
        }
        public int GetPosition()
        {
            return positions;
        }
    }
}