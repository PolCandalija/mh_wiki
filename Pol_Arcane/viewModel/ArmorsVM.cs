using mh.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mh.datasource;

namespace mh.viewModel
{
    public class ArmorsVM : utilites.ViewModelBase
    {
        public static string DBTable = "Armor";
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

        private List<Armor> Armor_List;

        public ArmorsVM()
        {
            Armor_List = new List<Armor>();
            DataTable dt = DBDatasource.GetData(ArmorsVM.DBTable);

            foreach (DataRow dr in dt.Rows)
            {
                Armor armor = new Armor();
                armor._Id = Convert.ToInt32(dr["_Id"]);
                armor.Defense = Convert.ToInt32(dr["Defense"]);
                armor.FireRes = Convert.ToInt32(dr["FireRes"]);
                armor.WaterRes = Convert.ToInt32(dr["WaterRes"]);
                armor.IceRes = Convert.ToInt32(dr["IceRes"]);
                armor.ThunderRes = Convert.ToInt32(dr["ThunderRes"]);
                armor.DragonRes = Convert.ToInt32(dr["DragonRes"]);
                armor.Sockets = Convert.ToInt32(dr["Sockets"]);
                armor.SkillId = Convert.ToInt32(dr["SkillId"]);

                Armor_List.Add(armor);
            }
        }

        public List<Armor> GetArmors()
        {
            ArmorsVM armors = new ArmorsVM();

            return armors.Armor_List;
        }
    }
}
