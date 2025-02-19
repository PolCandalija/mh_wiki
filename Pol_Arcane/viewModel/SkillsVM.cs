using mh.model;
using mh.view;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mh.viewModel
{
    internal class SkillsVM : utilites.ViewModelBase
    {
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

        public SkillsVM()
        {
            skill = new Skill();

            skill.Name = string.Empty;
        }
    }
}
