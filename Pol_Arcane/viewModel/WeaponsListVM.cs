using System.Collections.ObjectModel;
using System.Data;
using System;
using System.Windows.Input;
using mh.datasource;
using mh.model;
using mh.view;
using mh.viewModel;
using System.Diagnostics;

namespace mh.viewModel
{
    public class WeaponsListVM : utilites.ViewModelBase
    {
        public ObservableCollection<Weapon> Weapons { get; set; }
        public ICommand LoadWeaponsCommand { get; }

        public WeaponsListVM(string type)
        {
            Weapons = new ObservableCollection<Weapon>();
            LoadWeaponByType(type);
        }

        private void LoadWeaponByType(string type)
        {
            Weapons.Clear();
            DataTable dt = DBDatasource.GetWeaponsByType(type);

            if (dt.Rows.Count > 0)
            {
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

                    Weapons.Add(weapon);
                }
            }
            else
            {
                Weapons.Add(new Weapon
                {
                    _Id = -1,
                    Name = "No Weapon Found",
                    Type = "Unknown",
                    RawDamage = 0,
                    Element = "None",
                    ElementDamage = 0,
                    Sharpness = "None"
                });
            }
        }
    }
}
