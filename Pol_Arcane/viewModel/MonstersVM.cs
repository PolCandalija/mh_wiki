using System;
using System.Collections.ObjectModel;
using System.Data;
using mh.datasource;
using mh.model;

namespace mh.viewModel
{
    public class MonstersVM : utilites.ViewModelBase
    {
        public static string DBTable = "Monster";
        public ObservableCollection<Monster> Monster_List { get; set; }

        public MonstersVM()
        {
            Monster_List = new ObservableCollection<Monster>();
            LoadMonsters();
        }

        private void LoadMonsters()
        {
            DataTable dt = DBDatasource.GetData(DBTable);

            foreach (DataRow dr in dt.Rows)
            {
                Monster monster = new Monster
                {
                    _Id = Convert.ToInt32(dr["_Id"]),
                    Name = Convert.ToString(dr["Name"]),
                    Hr = Convert.ToInt32(dr["Hr"]),
                    MapId = Convert.ToInt32(dr["MapId"]),
                    ArmorId = Convert.ToInt32(dr["ArmorId"]),
                    WeaponId = Convert.ToInt32(dr["WeaponId"]),
                    Description = Convert.ToString(dr["Description"]),
                    FireRes = Convert.ToInt32(dr["FireRes"]),
                    WaterRes = Convert.ToInt32(dr["WaterRes"]),
                    IceRes = Convert.ToInt32(dr["IceRes"]),
                    ThunderRes = Convert.ToInt32(dr["ThunderRes"]),
                    DragonRes = Convert.ToInt32(dr["DragonRes"]),
                    Type = Convert.ToString(dr["Type"]),
                    IconUrl = Convert.ToString(dr["IconUrl"])
                };

                Monster_List.Add(monster);
            }
        }
    }
}
