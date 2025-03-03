using mh.model;
using mh.datasource;
using System;
using System.Collections.ObjectModel;
using System.Data;

namespace mh.viewModel
{
    public class WeaponsVM : utilites.ViewModelBase
    {
        public static string DBTable = "Weapon";
        public ObservableCollection<Weapon> Weapon_List { get; set; }

        public WeaponsVM()
        {
            Weapon_List = new ObservableCollection<Weapon>();
            LoadWeapons();
        }

        private void LoadWeapons()
        {
            DataTable dt = DBDatasource.GetData(DBTable);

            foreach (DataRow dr in dt.Rows)
            {
                Weapon weapon = new Weapon
                {
                    _Id = Convert.ToInt32(dr["_Id"]),
                    Name = Convert.ToString(dr["Name"]),
                    Type = Convert.ToString(dr["Type"]),
                    RawDamage = Convert.ToInt32(dr["RawDamage"]),
                    Element = Convert.ToString(dr["Element"]),
                    ElementDamage = Convert.ToInt32(dr["ElementDamage"]),
                    Sharpness = Convert.ToString(dr["Sharpness"])
                };

                Weapon_List.Add(weapon);
            }
        }
    }
}
