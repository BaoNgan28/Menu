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
            return positions;
        }
        public int GetPosition()
        {
            return positions;
        }
    }
}