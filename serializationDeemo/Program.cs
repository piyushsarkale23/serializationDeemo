using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializationDeemo
{
   public class Program
    {
        static void Main(string[] args)
        {
            string path = @"A:\DotNet20DecBatch\Sample.txt";
            Student student = new Student(12, "Saul", 65);
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, student);
            fs.Close();
            Console.WriteLine("File created Successfully " + path);
            Console.ReadLine();


        }
    }
}
