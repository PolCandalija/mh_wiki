using mh.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mh.viewModel
{
    public class MonstersVM : utilites.ViewModelBase
    {
        private readonly Monster monster;

        public int Monster_Id
        {
            get { return monster._Id; }
            set { monster._Id = value; OnProperyChanged(); }
        }
        public string Monster_Name
        {
            get { return monster.Name; }
            set { monster.Name = value; OnProperyChanged(); }
        }
        public int Monster_Hr
        {
            get { return monster.Hr; }
            set { monster.Hr = value; OnProperyChanged(); }
        }
        public int Monster_MapId
        {
            get { return monster.MapId; }
            set { monster.MapId = value; OnProperyChanged(); }
        }
        public int Monster_ArmorId
        {
            get { return monster.ArmorId; }
            set { monster.ArmorId = value; OnProperyChanged(); }
        }
        public int Monster_WeaponId
        {
            get { return monster.WeaponId; }
            set { monster.WeaponId = value; OnProperyChanged(); }
        }
        public string Monster_Description
        {
            get { return monster.Description; }
            set { monster.Description = value; OnProperyChanged(); }
        }
        public int Monster_FireRes
        {
            get { return monster.FireRes; }
            set { monster.FireRes = value; OnProperyChanged(); }
        }
        public int Monster_WaterRes
        {
            get { return monster.WaterRes; }
            set { monster.WaterRes = value; OnProperyChanged(); }
        }
        public int Monster_IceRes
        {
            get { return monster.IceRes; }
            set { monster.IceRes = value; OnProperyChanged(); }
        }
        public int Monster_ThunderRes
        {
            get { return monster.ThunderRes; }
            set { monster.ThunderRes = value; OnProperyChanged(); }
        }
        public int Monster_DragonRes
        {
            get { return monster.DragonRes; }
            set { monster.DragonRes = value; OnProperyChanged(); }
        }
        public string Monster_Type
        {
            get { return monster.Type; }
            set { monster.Type = value; OnProperyChanged(); }
        }
        

        public MonstersVM(int playerId)
        {
            monster = new Monster();

            string consulta = "SELECT * FROM Monster WHERE _id=@pId";

            MySqlCommand sqlComanda = new MySqlCommand(consulta, MainWindow.elservidorSqlConnection);

            MySqlDataAdapter elMeuAdaptador = new MySqlDataAdapter(sqlComanda);
            using (elMeuAdaptador)
            {

                sqlComanda.Parameters.AddWithValue("@pId", playerId);

                DataTable ordersTable = new DataTable();
                elMeuAdaptador.Fill(ordersTable);
                if (ordersTable.Rows.Count > 0)
                {
                    int id = Convert.ToInt32(ordersTable.Rows[0]["_id"]);
                    string name = Convert.ToString(ordersTable.Rows[0]["Name"]);
                    string race = Convert.ToString(ordersTable.Rows[0]["Type"]);
                    int orderid = Convert.ToInt32(ordersTable.Rows[0]["WeaponId"]);

                    Monster_Id = id;
                    Monster_Name = name;
                    Monster_Type = race;
                    Monster_Id = orderid;
                }
                else
                {
                    Monster_Id = -1;
                    Monster_Name = "null";
                    Monster_Type = "null";
                    Monster_Id = -1;
                }
            }
        }
    }
}
