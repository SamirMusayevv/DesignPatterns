using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit
{
    abstract class Component
    {
        public abstract void Draw();
    }

    class MyFolder : Component
    {
        private List<Component> Components { get; set; }
        private DirectoryInfo Directory { get; set; }

        public MyFolder(string path)
        {
            Components = new List<Component>();
            Directory = new DirectoryInfo(path);
            Scan();
        }

        private void Scan()
        {
            DirectoryInfo[] directories = Directory.GetDirectories();

            if (directories != null)
                foreach (var directory in directories)
                    Components.Add(new MyFolder(directory.FullName));

            FileInfo[] files = Directory.GetFiles();

            if (files != null)
                foreach (var file in files)
                    Components.Add(new MyFile(file.FullName));
        }

        public override void Draw()
        {
            Console.WriteLine($".<{Directory.Name}>");

            foreach (var item in Components)
                item.Draw();

            Console.WriteLine($".</{Directory.Name}>");
        }
    }

    class MyFile : Component
    {
        private FileInfo File { get; set; }

        public MyFile(string path)
        {
            if (!System.IO.File.Exists(path))
                throw new ArgumentException("File not found!");

            File = new FileInfo(path);
        }

        public override void Draw()
        {
            Console.WriteLine($"{File.Name}     {Size.Calculate(File.Length)}");
        }
    }
}
