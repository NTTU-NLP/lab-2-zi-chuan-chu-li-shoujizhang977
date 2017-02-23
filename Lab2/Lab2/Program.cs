
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\admin\Downloads\lab-2-zi-chuan-chu-li-shoujizhang977\Data\Input.txt"))
            {
                int ss = 0;
                while (sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    foreach (var ch in line)
                    {
                        if (ch == '?')
                        {
                            Console.Write('?' + "\n");
                            ss++;
                        }
                        else if (ch == '.')
                        {
                            Console.Write('.' + "\n");
                            ss++;
                        }
                        else if (ch == '!')
                        {
                            Console.Write('!' + "\n");
                            ss++;
                        }
                        else if (ss != 0)
                        {
                            Console.Write("");
                            ss = 0;
                        }
                        else
                            Console.Write(ch);
                    }

                }
            }
            Console.Read();
        }
    }
}
