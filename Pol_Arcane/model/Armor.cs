using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mh.model
{
    internal class Armor
    {
        public int _Id { get; set; }
        public int Defense { get; set; }
        public int FireRes { get; set; }
        public int WaterRes { get; set; }
        public int IceRes { get; set; }
        public int ThunderRes { get; set; }
        public int DragonRes { get; set; }
        public int Sockets { get; set; }
        public int SkillId { get; set; }
    }
}
