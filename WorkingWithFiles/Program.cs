using System;
using System.IO;

namespace WorkingWithFilesDirectoriesAndPath
{
    class Program
    {
        static void Main(string[] args)
        {
            //Working with Files
            //WorkingWithFiles();

            //Working With Directories
            WorkingWithDirectories();

            //Working With Path
            WorkingWithPath();
        }

        private static void WorkingWithFiles()
        {
            var path = @"c:\somefile.jpg";
            var path1 = @"c:\temp\myfile.jpg";
            var path2 = @"d:\temp\myfile.jpg";

            var content = File.ReadAllText(path);
            //Set overrite to true if same file name exists, otherwise false
            File.Copy(path1, path2, true);
            File.Delete(path2);
            if (File.Exists(path))
            {

            }

            //Recommened to use only for large operations
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(path1);
            fileInfo.Delete();
            if (fileInfo.Exists)
            {

            }
        }

        private static void WorkingWithDirectories()
        {
            //If folder exists it makes inside it if not creates new with name
            string path = @"e:\learning\temFolder\temp";
            string path1 = @"e:\learning\dot net\mosh hamedani";

            Directory.CreateDirectory(path);        //"*.*" Displays All
            //var files = Directory.GetFiles(path1, "*.docx*",SearchOption.AllDirectories);
            //foreach(var file in files)
            //    Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"e:\learning\dot net\mosh hamedani", 
                "*.*", SearchOption.TopDirectoryOnly);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists(path1); //True


            var directoryInfo = new DirectoryInfo(path);
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }

        public static void WorkingWithPath()
        {
            var path = @"c:\Projects\CSharp\HelloWorld\HelloWorld.sln";
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Path.GetExtension(path); //sln
            Path.GetFileName(path); //HelloWorld.sln
            Path.GetFileNameWithoutExtension(path); //HelloWorld
            Path.GetDirectoryName(path);  //c:\Projects\CSharp\HelloWorld
        }
    }
}
