using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mh.model
{
    public class Weapon
    {
        public int _Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int RawDamage { get; set; }
        public string Element { get; set; }
        public int ElementDamage { get; set; }
        public string Sharpness { get; set; }
        public string IconUrl { get; set; }
    }
}
