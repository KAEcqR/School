using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cw9.models
{
    public class Numbers
    {
        private List<int> _numbers;
        public int Min;
        public int Max;
        public Numbers(int size) {
            _numbers = new List<int>();
            Fill(size);
            
        }

        private void Fill(int size)
        {
            Random rnd = new Random();


            for (int i = 0; i < size; i++)
            {
                _numbers.Add(rnd.Next(100));
            };
        
             Min = _numbers.Min();
             Max = _numbers.Max();
        }

        public List<int> GetNumbers {
            get { return _numbers; }
        }

       
        public string getMin()
        {
            return _numbers.Min().ToString();
        }
        public string getMax()
        {
            return _numbers.Max().ToString();
        }
    }
}
