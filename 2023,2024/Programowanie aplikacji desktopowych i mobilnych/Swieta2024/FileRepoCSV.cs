using Swieta2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swieta2024
{
    public class FileRepoCSV : IRepository
    {
        public List<Danie>? Dania { get; set; }

        public FileRepoCSV(string filename = "dane.txt")
        {
            Dania = DanieFromFile(filename);
        }

        private List<Danie>? DanieFromFile(string filename)
        {
            //todo
            List<string> lines = new List<string>();
            if (File.Exists(filename))
            {
                lines = File.ReadAllLines(filename).ToList();
            }
            return null;
        }


        public List<Danie> GetDanie()
        {
            return Dania ?? new List<Danie>();
        }

        public Danie? GetDanieById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
