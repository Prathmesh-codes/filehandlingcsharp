using System;
using System.IO;
namespace Experiment7
{
    class Program
    {
        static void Main(string[] args)

        {
        logic:
            int option;
            Console.WriteLine("\n1]Create Diretory\n2]Create File\n3]Copy File\n4]Delete File\n5]Put Text In File\n6]View Text\n7]Append text\n8] Exit");
            Console.WriteLine("\nSelect option-");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {

                case 1:

                    {
                        DirectoryInfo DIR = new DirectoryInfo(@"E:\Csharp");

                        try
                        {
                            if (DIR.Exists)
                            {
                                Console.WriteLine("Folder Exists");
                            }
                            else
                            {
                                DIR.Create();
                                Console.WriteLine("Folder Created");
                            }
                        }

                        catch (Exception E)
                        {
                            Console.WriteLine("Folder can not be created" + E);
                        }

                        goto logic;
                        break;
                    }

                case 2:

                    {

                        FileInfo file = new FileInfo(@"E:\Csharp\myinfo.txt");

                        if (file.Exists)
                        {
                            Console.WriteLine("File Exists");
                        }
                        else
                        {
                            file.Create();
                            Console.WriteLine("File Created");
                        }

                        goto logic;
                        break;
                    }


                case 3:

                    {

                        FileInfo file = new FileInfo(@"E:\Csharp\myinfo.txt");

                        file.CopyTo(@"E:\Csharp\CSIT_1704038.txt");
                        goto logic;
                        break;
                    }

                case 4:

                    {
                        File.Delete(@"E:\Csharp\myinfo.txt");
                        goto logic;
                        break;
                    }

                case 5:

                    {
                        FileInfo file = new FileInfo(@"E:\Csharp\myinfo.txt");
                        StreamWriter writer = file.CreateText();

                        Console.WriteLine("Enter Text-");
                        string text = Console.ReadLine();
                        writer.WriteLine(text);
                        writer.Close();
                        goto logic;
                        break;
                    }
                case 6:

                    {
                        FileInfo file = new FileInfo(@"E:\Csharp\myinfo.txt");
                        if (file.Exists)
                        {
                            StreamReader reader = file.OpenText();

                            string str = "";
                            while ((str = reader.ReadLine()) != null)
                            {
                                Console.WriteLine(str);
                            }
                            reader.Close();

                        }
                        else
                        {
                            Console.WriteLine("File does not exist");
                        }
                        goto logic;
                        break;
                    }

                case 7:
                    {
                        try
                        {
                            FileInfo file = new FileInfo(@"E:\Csharp\myinfo.txt");
                            StreamWriter writer = file.AppendText();

                            Console.WriteLine("Enter Text-");
                            string text = Console.ReadLine();
                            writer.WriteLine(text);
                            writer.Close();
                            Console.WriteLine("\nAppend Successfull");
                            goto logic;
                        }

                        catch (Exception e)
                        {

                            FileInfo file = new FileInfo(@"E:\exceptioninfo.txt");
                            StreamWriter writer = file.CreateText();
                            writer.WriteLine(e);
                            writer.Close();
                            Console.WriteLine("\nException Handled successfully see info in exceptioninfo.txt");

                            goto logic;

                        }

                        break;

                    }

                case 8:
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid option");
                        goto logic;
                        break;
                    }
            }
        }
    }
}

