using mh.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mh.viewModel
{
    public class ArmorsVM : utilites.ViewModelBase
    {
        private readonly Armor armor;

        public int Armor_Id
        {
            get { return armor._Id; }
            set { armor._Id = value; OnProperyChanged(); }
        }
        public int Armor_Defense
        {
            get { return armor.Defense; }
            set { armor.Defense = value; OnProperyChanged(); }
        }
        public int Armor_FireRes
        {
            get { return armor.FireRes; }
            set { armor.FireRes = value; OnProperyChanged(); }
        }
        public int Armor_WaterRes
        {
            get { return armor.WaterRes; }
            set { armor.WaterRes = value; OnProperyChanged(); }
        }
        public int Armor_IceRes
        {
            get { return armor.IceRes; }
            set { armor.IceRes = value; OnProperyChanged(); }
        }
        public int Armor_ThunderRes
        {
            get { return armor.ThunderRes; }
            set { armor.ThunderRes = value; OnProperyChanged(); }
        }
        public int Armor_DragonRes
        {
            get { return armor.DragonRes; }
            set { armor.DragonRes = value; OnProperyChanged(); }
        }
        public int Armor_Sockets
        {
            get { return armor.Sockets; }
            set { armor.Sockets = value; OnProperyChanged(); }
        }
        public int Armor_SkillId
        {
            get { return armor.SkillId; }
            set { armor.SkillId = value; OnProperyChanged(); }
        }


        public ArmorsVM()
        {
            armor = new Armor();

            armor.Defense = 0;
        }
    }
}
