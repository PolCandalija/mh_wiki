using System;
using System.Collections.ObjectModel;
using System.Data;
using mh.datasource;
using mh.model;

namespace mh.viewModel
{
    public class SkillsVM : utilites.ViewModelBase
    {
        public static string DBTable = "Skill";
        public ObservableCollection<Skill> Skills { get; set; }

        public SkillsVM()
        {
            Skills = new ObservableCollection<Skill>();
            LoadSkills();
        }

        private void LoadSkills()
        {
            DataTable dt = DBDatasource.GetData(SkillsVM.DBTable);

            foreach (DataRow dr in dt.Rows)
            {
                Skills.Add(new Skill
                {
                    _Id = Convert.ToInt32(dr["_Id"]),
                    Name = Convert.ToString(dr["Name"]),
                    Levels = Convert.ToInt32(dr["Levels"]),
                    Description = Convert.ToString(dr["Description"]),
                    IconUrl = Convert.ToString(dr["IconUrl"])
                });
            }
        }
    }
}
