using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programming
{
   public class Replace
    {
    
        public static void Rep()
        {
            String str = "hello<user name> how are you";//first string =user name
            Console.WriteLine("before replacing\n");
            Console.WriteLine(str);

            Console.WriteLine("\nafter replacing\n");
            Console.WriteLine(str.Replace("<username>", "rahul"));//ReplaceUserString string =rahul

        }
    }
}
    

