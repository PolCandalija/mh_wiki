using mh.model;
using mh.view;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using mh.datasource;

namespace mh.viewModel
{
    internal class WeaponsVM : utilites.ViewModelBase
    {
        public static string DBTable = "Weapon";
        private readonly Weapon weapon;

        public int Weapon_Id
        {
            get { return weapon._Id; }
            set { weapon._Id = value; OnProperyChanged(); }
        }
        public string Weapon_Type
        {
            get { return weapon.Type; }
            set { weapon.Type = value; OnProperyChanged(); }
        }
        public int Weapon_RawDamage
        {
            get { return weapon.RawDamage; }
            set { weapon.RawDamage = value; OnProperyChanged(); }
        }
        public string Weapon_Element
        {
            get { return weapon.Element; }
            set { weapon.Element = value; OnProperyChanged(); }
        }
        public int Weapon_ElementDamage
        {
            get { return weapon.ElementDamage; }
            set { weapon.ElementDamage = value; OnProperyChanged(); }
        }
        public string Weapon_Sharpness
        {
            get { return weapon.Sharpness; }
            set { weapon.Sharpness = value; OnProperyChanged(); }
        }
        public string Weapon_Name
        {
            get { return weapon.Name; }
            set { weapon.Name = value; OnProperyChanged(); }
        }

        private List<Weapon> Weapon_List;

        public WeaponsVM()
        {
            Weapon_List = new List<Weapon>();
            DataTable dt = DBDatasource.GetData(WeaponsVM.DBTable);

            foreach (DataRow dr in dt.Rows)
            {
                Weapon weapon = new Weapon();
                weapon._Id = Convert.ToInt32(dr["_Id"]);
                weapon.Name = Convert.ToString(dr["Name"]);
                weapon.Type = Convert.ToString(dr["Type"]);
                weapon.RawDamage = Convert.ToInt32(dr["RawDamage"]);
                weapon.Element = Convert.ToString(dr["Element"]);
                weapon.ElementDamage = Convert.ToInt32(dr["ElementDamage"]);
                weapon.Sharpness = Convert.ToString(dr["Sharpness"]);


                Weapon_List.Add(weapon);
            }
        }

        public List<Weapon> GetWeapons()
        {
            WeaponsVM weapons = new WeaponsVM();

            return weapons.Weapon_List;
        }

        public WeaponsVM(int playerId)
        {
            int weaponId = -1;
            weapon = new Weapon();
            
            string consulta = "SELECT * FROM Monster WHERE _id=@pId";

            MySqlCommand sqlComanda = new MySqlCommand(consulta, DBDatasource.DBConnection);

            MySqlDataAdapter elMeuAdaptador = new MySqlDataAdapter(sqlComanda);
            using (elMeuAdaptador)
            {

                sqlComanda.Parameters.AddWithValue("@pId", playerId);

                DataTable ordersTable = new DataTable();
                elMeuAdaptador.Fill(ordersTable);
                if (ordersTable.Rows.Count > 0)
                {
                    weaponId = Convert.ToInt32(ordersTable.Rows[0]["WeaponId"]);
                }
                else
                {
                    weaponId = -1;
                }
            }

            if (weaponId != -1)
            {
                consulta = "SELECT * FROM Weapon WHERE _id=@wId";

                sqlComanda = new MySqlCommand(consulta, DBDatasource.DBConnection);

                elMeuAdaptador = new MySqlDataAdapter(sqlComanda);
                using (elMeuAdaptador)
                {

                    sqlComanda.Parameters.AddWithValue("@wId", weaponId);

                    DataTable ordersTable = new DataTable();
                    elMeuAdaptador.Fill(ordersTable);
                    if (ordersTable.Rows.Count > 0)
                    {
                        Weapon_Id = Convert.ToInt32(ordersTable.Rows[0]["_id"]);
                        Weapon_Type = Convert.ToString(ordersTable.Rows[0]["Type"]);
                        Weapon_RawDamage = Convert.ToInt32(ordersTable.Rows[0]["RawDamage"]);
                    }
                    else
                    {
                        Weapon_Id = -1;
                        Weapon_Type = "null";
                        Weapon_RawDamage = -1;
                    }
                }
            }

        }

        
    }
}
