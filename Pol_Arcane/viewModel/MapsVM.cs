using mh.model;
using System;
using System.Data;
using mh.datasource;
using System.Collections.ObjectModel;

namespace mh.viewModel
{
    public class MapsVM : utilites.ViewModelBase
    {
        public static string DBTable = "Map";
        public ObservableCollection<Map> Maps { get; set; }

        public MapsVM()
        {
            Maps = new ObservableCollection<Map>();
            LoadMaps();
        }

        private void LoadMaps()
        {
            DataTable dt = DBDatasource.GetData(DBTable);

            foreach (DataRow dr in dt.Rows)
            {
                Map map = new Map
                {
                    _Id = Convert.ToInt32(dr["_Id"]),
                    Name = Convert.ToString(dr["Name"]),
                    NumberOfZones = Convert.ToInt32(dr["NumberOfZones"]),
                    Description = Convert.ToString(dr["Description"]),
                    IconUrl = Convert.ToString(dr["IconUrl"])
                };

                Maps.Add(map);
            }
        }
    }
}
