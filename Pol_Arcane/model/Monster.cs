using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mh.model
{
    public class Monster
    {
        public int _Id {  get; set; }
        public string Name { get; set; }
        public int Hr { get; set; }
        public int MapId { get; set; }
        public int ArmorId { get; set; }
        public int WeaponId { get; set; }
        public string Description { get; set; }
        public int FireRes { get; set; }
        public int WaterRes { get; set; }
        public int IceRes { get; set; }
        public int ThunderRes { get; set; }
        public int DragonRes { get; set; }
        public string Type { get; set; }

    }
}
