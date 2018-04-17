using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;




namespace Transaction_File_Processor
{
    class Program
    {
        static void Main(string[] args)
        {


            // arguments are
            //  colno - column to index the mapping table
            //  header - yes|no, whether transfile has a header row
            //  mapfile - file with mapping info
            //  transfile - file with raw transactions
            //  trancprocfile - file to contain processed transactions

            // mapping file format:
            //   first column will be read as a regex
            //   second and subsquent columns will be inserted on the left in the processed table


            // algorithm:
            // read mapping file
            //    error if uneven number of columns
            // open trans file
            //    if header, process the header row
            //      add "proc1", ...
            //    for each row
            //      try regex.match for each entry in mapping
            //      fail out if multiple matches
            //      if no matches, insert nomatch in each new column
            //      if one match, insert values from mapping
            //      write to transprocfile
            

            string d = Directory.GetCurrentDirectory();
            StreamReader mf = new StreamReader("\\onedrive\\ao\\transactions\\map1.txt");
            string[] s;
            s = File.ReadAllLines("\\onedrive\\ao\\transactions\\map1.txt");

            Console.WriteLine("hello");
            Console.ReadLine();


        }
    }
}
