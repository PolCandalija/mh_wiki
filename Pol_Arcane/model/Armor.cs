using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mh.model
{
    public class Armor
    {
        public int _Id { get; set; }
        public string Name { get; set; }
        public int Defense { get; set; }
        public int FireRes { get; set; }
        public int WaterRes { get; set; }
        public int IceRes { get; set; }
        public int ThunderRes { get; set; }
        public int DragonRes { get; set; }
        public int Sockets { get; set; }
        public int SkillId { get; set; }
        public string HeadIconUrl { get; set; }
        public string ChestIconUrl { get; set; }
        public string ArmsIconUrl { get; set; }
        public string WaistIconUrl { get; set; }
        public string LegIconUrl { get; set; }
        public Skill SetSkill { get; set; }
    }
}
