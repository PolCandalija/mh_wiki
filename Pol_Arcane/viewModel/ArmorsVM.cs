using mh.model;
using System;
using System.Collections.Generic;
using System.Data;
using mh.datasource;
using System.Collections.ObjectModel;

namespace mh.viewModel
{
    public class ArmorsVM : utilites.ViewModelBase
    {
        public static string DBTable = "Armor";
        public ObservableCollection<Armor> Armors { get; set; }
        public ObservableCollection<Skill> Skills { get; set; }

        public ArmorsVM()
        {
            Armors = new ObservableCollection<Armor>();
            Skills = new ObservableCollection<Skill>();
            LoadSkills();
            LoadArmors();
        }

        private void LoadArmors()
        {
            DataTable dt = DBDatasource.GetData(DBTable);

            foreach (DataRow dr in dt.Rows)
            {
                Armor armor = new Armor
                {
                    _Id = Convert.ToInt32(dr["_Id"]),
                    Name = Convert.ToString(dr["Name"]),
                    Defense = Convert.ToInt32(dr["Defense"]),
                    FireRes = Convert.ToInt32(dr["FireRes"]),
                    WaterRes = Convert.ToInt32(dr["WaterRes"]),
                    IceRes = Convert.ToInt32(dr["IceRes"]),
                    ThunderRes = Convert.ToInt32(dr["ThunderRes"]),
                    DragonRes = Convert.ToInt32(dr["DragonRes"]),
                    Sockets = Convert.ToInt32(dr["Sockets"]),
                    SkillId = Convert.ToInt32(dr["SkillId"]),
                    HeadIconUrl = Convert.ToString(dr["HeadIconUrl"]),
                    ChestIconUrl = Convert.ToString(dr["ChestIconUrl"]),
                    ArmsIconUrl = Convert.ToString(dr["ArmsIconUrl"]),
                    WaistIconUrl = Convert.ToString(dr["WaistIconUrl"]),
                    LegIconUrl = Convert.ToString(dr["LegIconUrl"]),
                    SetSkill = GetSetSkill(Convert.ToInt32(dr["SkillId"]))
                };

                Armors.Add(armor);
            }
        }

        private void LoadSkills()
        {
            DataTable dt = DBDatasource.GetData(SkillsVM.DBTable);

            foreach (DataRow dr in dt.Rows)
            {
                Skill skill = new Skill
                {
                    _Id = Convert.ToInt32(dr["_Id"]),
                    Name = Convert.ToString(dr["Name"]),
                    Levels = Convert.ToInt32(dr["Levels"]),
                    Description = Convert.ToString(dr["Description"]),
                    IconUrl = Convert.ToString(dr["IconUrl"])
                };

                Skills.Add(skill);
            }
        }
        private Skill GetSetSkill(int id)
        {
            for (int i = 0; i < Skills.Count; i++)
            {
                if (Skills[i]._Id == id)
                {
                    return Skills[i];
                }
            }
            return null;
        }
    }
}
