using System;
using System.Collections.Generic;
using System.Text;

namespace ProgLibraryCatalog
{
    class Drawer
    {
        public static void test()
        {
            {
                List<string> a = new List<string>();

                a.Add("asdfdg");
                a.Add("asd213");
                a.Add("asfsdgsg");
                a.Add("asdsfvbdg");
                a.Add("asdfdasdfadg");

                Console.SetCursorPosition(1, 5);



                foreach (var t in a)
                {
                    Console.WriteLine(t);
                    Console.CursorLeft = 1;
                }

                Console.SetCursorPosition(0, 5);
                Console.Write(">");

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.CursorLeft = 0;
                    Console.CursorVisible = false;
                    var input_key = Console.ReadKey(true);

                    switch (input_key.Key)
                    {
                        case ConsoleKey.DownArrow:

                            Console.Write(" ");
                            Console.CursorTop += 1;
                            Console.CursorLeft -= 1;
                            Console.Write(">");
                            break;

                        case ConsoleKey.UpArrow:
                            Console.Write(" ");
                            Console.CursorTop -= 1;
                            Console.CursorLeft -= 1;
                            Console.Write(">");
                            break;
                    }



                }



            }

        }
    }
}
