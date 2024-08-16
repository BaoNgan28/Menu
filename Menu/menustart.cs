using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Menu
{
    public class menustart
    {
        private Handle handle;
        private string[] menuItems = 
        { "QUANG MẮT LÒI ĐÚNG OR SAI????", "ĐÚNG", "RẤT ĐÚNG", "KHÔNG SAI" };
        public menustart(Handle handle)
        {
            this.handle = handle;
        }
        public void MenuStart()
        {
            while (true)
            {
                handle.ClearConsole();
                ShowMenu();
                int position = handle.HandleKey(menuItems);
            }
            //update
        }
        private void ShowMenu()
        {
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == handle.GetPosition())
                {
                    printf_Positions($"<> {menuItems[i]} <>", 18, 10 + i*2 , ConsoleColor.Blue);
                }
                else
                {
                    printf_Positions(menuItems[i], 20, 10 + i*2 , ConsoleColor.Yellow);
                }
            }
        }

        static void printf_Positions(string s, int x, int y, ConsoleColor color)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ResetColor();
        }
    }
}

