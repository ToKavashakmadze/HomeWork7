using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    public abstract class FileWorker
    {
        public int Size { get; set; }
        
        public abstract string TypeOfFile { get; set; }

        public abstract void Read();
        public abstract void Write();
        public abstract void Edit();
        public abstract void Delete();
        public class File1 : FileWorker
        {

            string typeOffile = "";

            public override string TypeOfFile
            {
                get => typeOffile;
                set => typeOffile = value;
            }
            public override void Write()
            {
                Console.WriteLine($"I Can write to {TypeOfFile} file with max storage{Size}");
            }
            public override void Read()
            {
                Console.WriteLine($"I Can Read to {TypeOfFile} file with max storage{Size}");
            }
            public override void Delete()
            {
                Console.WriteLine($"I Can delete from {TypeOfFile} file with max storage{Size}");
            }
            public override void Edit()
            {
                Console.WriteLine($"I Can Edit {TypeOfFile} file with ma storage {Size}");
            }

        }                  
        
    }
}
