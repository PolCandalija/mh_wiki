using mh.model;
using mh.view;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mh.datasource;

namespace mh.viewModel
{
    internal class SkillsVM : utilites.ViewModelBase
    {
        public static string DBTable = "Skill";
        private readonly Skill skill;

        public int Skill_Id
        {
            get { return skill._Id; }
            set { skill._Id = value; OnProperyChanged(); }
        }
        public string Skill_Name
        {
            get { return skill.Name; }
            set { skill.Name = value; OnProperyChanged(); }
        }
        public int Skill_Levels
        {
            get { return skill.Levels; }
            set { skill.Levels = value; OnProperyChanged(); }
        }
        public string Skill_Description
        {
            get { return skill.Description; }
            set { skill.Description = value; OnProperyChanged(); }
        }

        private List<Skill> Skill_List;

        public SkillsVM()
        {
            Skill_List = new List<Skill>();
            DataTable dt = DBDatasource.GetData(SkillsVM.DBTable);

            foreach (DataRow dr in dt.Rows)
            {
                Skill skill = new Skill();
                skill._Id = Convert.ToInt32(dr["_Id"]);
                skill.Name = Convert.ToString(dr["Name"]);
                skill.Levels = Convert.ToInt32(dr["Levels"]);
                skill.Description = Convert.ToString(dr["Description"]);

                Skill_List.Add(skill);
            }
        }

        public List<Skill> GetSkills()
        {
            SkillsVM skills = new SkillsVM();

            return skills.Skill_List;
        }
    }
}
