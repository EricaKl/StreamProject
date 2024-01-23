using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace StreamProject
{
    internal class Program2
    {

        static void Main()
        {
            int ch = 0;
            char character;
            do
            {
                Console.WriteLine(".....MENU.....");
                Console.WriteLine("1.Create a New File");
                Console.WriteLine("2.Add Contents to the File");
                Console.WriteLine("3.Append Contents to the File");
                Console.WriteLine("4.Display Contents one by one");
                Console.WriteLine("5.Display All Contents together");
                Console.WriteLine("6.Delete");
                Console.WriteLine("Enter your choice");
                ch = int.Parse(Console.ReadLine());
                string path = "C:\\Users\\EricaAttal\\Desktop\\Stream\\Demo\\abc.txt";
                switch (ch)
                {
                    case 1:
                        {
                          FileInfo fileinfo = new FileInfo(path);
                            if(!fileinfo.Exists)
                            {
                                FileStream fs = new FileStream(path, FileMode.Create);

                                Console.WriteLine("File Created");
                                fs.Close();
                            }
                            else
                            {
                                Console.WriteLine("File exists already");
                            }
                          
                            break;
                        }
                    case 2:
                        {
                            FileInfo file = new FileInfo(path);
                            if (file.Exists)
                            {
                                FileStream fs1 = file.Open(FileMode.Open, FileAccess.Write);
                                StreamWriter sw = new StreamWriter(fs1);
                                sw.WriteLine("Hi there I am Erica, Writing content to file");
                                sw.Close();

                            }
                            else
                            {
                                Console.WriteLine("File does not exists");
                            }
                            break;

                        }
                    case 3:
                        {
                            FileInfo file = new FileInfo(path);
                            if (file.Exists)
                            {
                                using (StreamWriter sw = File.AppendText(path))
                                {
                                    sw.WriteLine("Append contents to file");
                                    sw.Close();
                                }
                                
                            }
                            else
                            {
                                Console.WriteLine("File not exists");
                            }
                            break;
                        }
                    case 4:
                        {
                            FileInfo file = new FileInfo(path);
                            if (file.Exists)
                            {
                                using (StreamReader sr = new StreamReader(path))
                                {
                                    string line;
                                    while ((line = sr.ReadLine()) != null)
                                    {
                                        Console.WriteLine(line);
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("File not exists");
                            }
                           
                            break;
                        }

                    case 5:
                        {
                            FileInfo file = new FileInfo(path);
                            if(file.Exists)
                            {
                                string textread = File.ReadAllText(path);
                                Console.WriteLine(textread);

                            }
                            else
                            {
                                Console.WriteLine("File not Exists");
                            }
                           
                            break;
                        }
                    case 6:
                        {
                            DirectoryInfo di = new DirectoryInfo("C:\\Users\\EricaAttal\\Desktop\\Stream\\Demo");
                            foreach( FileInfo file in di.GetFiles())
                            {
                                file.Delete();
                            }
                            Console.WriteLine("File Deleted!!");
                            break;

                        }
                }



                Console.WriteLine("Wish to continue...(y/n)");
                character = char.Parse(Console.ReadLine());
            } while (character == 'y');
        }

    }
}
     