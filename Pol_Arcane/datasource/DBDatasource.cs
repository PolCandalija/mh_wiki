﻿using mh.model;
using mh.viewModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mh.datasource
{
    public static class DBDatasource
    {
        public static MySqlConnection DBConnection = new MySqlConnection("Server=ellaboratori.cat;Database=pol;User ID=pol;Password=pol*;SslMode=none");

        private static bool TableChecker(string table)
        {
            if (table != "Armor" &&
                table != "Map" &&
                table != MonstersVM.DBTable &&
                table != "Skill" &&
                table != "Weapon")
            {
                return false;
            }
            return true;
        }
        public static DataTable GetData(string table)
        {
            if(!TableChecker(table))
                return null;

            string sqlPrompt = "SELECT * FROM " + table;

            MySqlCommand sqlCommand = new MySqlCommand(sqlPrompt, DBConnection);

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
        public static DataTable GetDataById(string table, int id)
        {
            if (!TableChecker(table))
                return null;

            string sqlPrompt = "SELECT * FROM " + table + " WHERE _id=@id";

            MySqlCommand sqlCommand = new MySqlCommand(sqlPrompt, DBConnection);
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);

            sqlCommand.Parameters.AddWithValue("@id", id);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
        public static DataTable GetWeaponsByType(string type)
        {
            string sqlPrompt = "SELECT * FROM Weapon WHERE Type=@type";

            MySqlCommand sqlCommand = new MySqlCommand(sqlPrompt, DBConnection);
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);

            sqlCommand.Parameters.AddWithValue("@type", type);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }

        public static DataTable GetMonsterByName(string name)
        {
            string sqlPrompt = "SELECT * FROM Monster WHERE Name=@name";

            MySqlCommand sqlCommand = new MySqlCommand(sqlPrompt, DBConnection);
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);

            sqlCommand.Parameters.AddWithValue("@name", name);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}
