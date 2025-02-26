using mh.model;
using mh.view;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mh.view;
using mh.datasource;

namespace mh.viewModel
{
    internal class MapsVM : utilites.ViewModelBase
    {
        public static string DBTable = "Map";
        private readonly Map map;

        public int Map_Id
        {
            get { return map._Id; }
            set { map._Id = value; OnProperyChanged(); }
        }
        public string Map_Name
        {
            get { return map.Name; }
            set { map.Name = value; OnProperyChanged(); }
        }
        public string Map_Description
        {
            get { return map.Description; }
            set { map.Description = value; OnProperyChanged(); }
        }
        public int Map_NumberOfZones
        {
            get { return map.NumberOfZones; }
            set { map.NumberOfZones = value; OnProperyChanged(); }
        }

        private List<Map> Map_List;

        public MapsVM()
        {
            Map_List = new List<Map>();
            DataTable dt = DBDatasource.GetData(MapsVM.DBTable);

            foreach (DataRow dr in dt.Rows)
            {
                Map map = new Map();
                map._Id = Convert.ToInt32(dr["_Id"]);
                map.Name = Convert.ToString(dr["Name"]);
                map.Description = Convert.ToString(dr["Description"]);
                map.NumberOfZones = Convert.ToInt32(dr["NumberOfZones"]);

                Map_List.Add(map);
            }
        }

        public List<Map> GetMaps()
        {
            MapsVM maps = new MapsVM();

            return maps.Map_List;
        }
    }
}
