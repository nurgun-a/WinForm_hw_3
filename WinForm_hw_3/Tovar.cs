using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_hw_3
{
    [Serializable]
    public class Tovar
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public double Price { get; set; }
        public override string ToString() => $"{Name} - {Price} руб.";
    }
}
