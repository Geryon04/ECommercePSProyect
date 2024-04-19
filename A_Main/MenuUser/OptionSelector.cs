using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_Main.MenuUser
{
    public class OptionSelector
    {
        public static int Option(){
            int optionSelect = int.Parse(Console.ReadLine());
            return optionSelect;
        }
    }
}