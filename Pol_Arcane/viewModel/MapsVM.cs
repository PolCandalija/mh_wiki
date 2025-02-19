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

namespace mh.viewModel
{
    internal class MapsVM : utilites.ViewModelBase
    {
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

        public MapsVM()
        {
            map = new Map();

            map.Name = string.Empty;
        }
    }
}
