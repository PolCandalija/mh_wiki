using System.Collections.ObjectModel;
using System.Data;
using System;
using System.Windows.Input;
using mh.datasource;
using mh.model;
using mh.view;
using mh.viewModel;
using System.Diagnostics;
using System.Windows.Documents;

namespace mh.viewModel
{
    public class MonsterDetailsVM : utilites.ViewModelBase
    {
        public Monster Monster { get; set; }
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }
        public Map Map { get; set; }
        public Skill Skill { get; set; }

        public MonsterDetailsVM(int id)
        {
            LoadMonster(id);
        }

        private void LoadMonster(int id)
        {
            DataTable dt = DBDatasource.GetDataById(MonstersVM.DBTable, id);
            DataRowCollection monsters = dt.Rows;

            if (monsters.Count > 0)
            {
                Monster = new Monster
                {
                    _Id = Convert.ToInt32(monsters[0]["_Id"]),
                    Name = Convert.ToString(monsters[0]["Name"]),
                    Hr = Convert.ToInt32(monsters[0]["Hr"]),
                    MapId = Convert.ToInt32(monsters[0]["MapId"]),
                    ArmorId = Convert.ToInt32(monsters[0]["ArmorId"]),
                    WeaponId = Convert.ToInt32(monsters[0]["WeaponId"]),
                    Description = Convert.ToString(monsters[0]["Description"]),
                    Element = Convert.ToString(monsters[0]["Element"]),
                    Ailment = Convert.ToString(monsters[0]["Ailment"]),
                    FireRes = Convert.ToInt32(monsters[0]["FireRes"]),
                    WaterRes = Convert.ToInt32(monsters[0]["WaterRes"]),
                    IceRes = Convert.ToInt32(monsters[0]["IceRes"]),
                    ThunderRes = Convert.ToInt32(monsters[0]["ThunderRes"]),
                    DragonRes = Convert.ToInt32(monsters[0]["DragonRes"]),
                    Type = Convert.ToString(monsters[0]["Type"]),
                    IconUrl = Convert.ToString(monsters[0]["IconUrl"])
                };
            }
            else
            {
                Monster = new Monster
                {
                    _Id = -999,
                    Name = "Unknown",
                    Hr = -999,
                    MapId = -999,
                    ArmorId = -999,
                    WeaponId = -999,
                    Description = "Unknown",
                    FireRes = -999,
                    WaterRes = -999,
                    IceRes = -999,
                    ThunderRes = -999,
                    DragonRes = -999,
                    Type = "Unknown",
                    IconUrl = "Unknown"
                };
            }
        }
    }
}
