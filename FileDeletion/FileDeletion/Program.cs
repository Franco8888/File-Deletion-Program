using System;
using System.Collections.Generic;

namespace FileDeletion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Folder Path:");

            var inputPath = Console.ReadLine();

            List<string> extensions = new();

            Console.WriteLine("Enter extensions, each seperated by an enter, press 1 to exit");

            while(true)
            {
                var extension = Console.ReadLine();
                if(extension == "1" )
                {
                    break;
                }
                extensions.Add(extension);
            }

            DeleteExtension delExt = new(inputPath, extensions);

            delExt.DeleteFiles();
        }
    }
}
