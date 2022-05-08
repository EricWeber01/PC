using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCLibrary
{
    [Serializable]
    public class PC
    {
        public string Mark { get; set; }
        public string SerialNum { get; set; }
        public int Price { get; set; }
        [NonSerialized]
        bool OnOff = false;
        public PC()
        {
            Mark = null;
            SerialNum = null;
            Price = 0;

        }
        public PC(string m, string s, int p)
        {
            Mark = m;
            SerialNum = s;
            Price = p;
        }

        public void TurnOnOff()
        {
            if (!OnOff)
            {
                Console.WriteLine($"PC {Mark} has been turned on");
                OnOff = true;
            }
            else
            {
                Console.WriteLine($"PC {Mark} has been turned off");
                OnOff = false;
            }
        }
        public override string ToString()
        {
            return $"{Mark} | {SerialNum} | {Price}$";
        }



    }
}
