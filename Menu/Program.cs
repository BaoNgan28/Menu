using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class Program
    {
        static void Main(string[] args)
        {
            Handle handle = new Handle();
            menustart menu = new menustart(handle);
            menu.MenuStart();
        }
    }
}
