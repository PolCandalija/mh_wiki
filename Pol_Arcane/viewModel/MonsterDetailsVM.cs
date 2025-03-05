using System.Collections.ObjectModel;
using System.Data;
using System;
using System.Windows.Input;
using mh.datasource;
using mh.model;
using mh.view;
using mh.viewModel;
using System.Diagnostics;
using System.Windows.Documents;

namespace mh.viewModel
{
    public class MonsterDetailsVM : utilites.ViewModelBase
    {
        public Monster Monster { get; set; }
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }
        public Map Map { get; set; }
        public Skill Skill { get; set; }

        public MonsterDetailsVM(string name)
        {
            LoadMonster(name);
            LoadWeapon(Monster.WeaponId);
            LoadArmor(Monster.ArmorId);
            LoadMap(Monster.MapId);
            LoadSkill(Armor.SkillId);
        }

        private void LoadMonster(string name)
        {
            DataTable dt = DBDatasource.GetMonsterByName(name);
            DataRowCollection monsters = dt.Rows;

            if (monsters.Count > 0)
            {
                Monster = new Monster
                {
                    _Id = Convert.ToInt32(monsters[0]["_Id"]),
                    Name = Convert.ToString(monsters[0]["Name"]),
                    Hr = Convert.ToInt32(monsters[0]["Hr"]),
                    MapId = Convert.ToInt32(monsters[0]["MapId"]),
                    ArmorId = Convert.ToInt32(monsters[0]["ArmorId"]),
                    WeaponId = Convert.ToInt32(monsters[0]["WeaponId"]),
                    Description = Convert.ToString(monsters[0]["Description"]),
                    Element = Convert.ToString(monsters[0]["Element"]),
                    Ailment = Convert.ToString(monsters[0]["Ailment"]),
                    FireRes = Convert.ToInt32(monsters[0]["FireRes"]),
                    WaterRes = Convert.ToInt32(monsters[0]["WaterRes"]),
                    IceRes = Convert.ToInt32(monsters[0]["IceRes"]),
                    ThunderRes = Convert.ToInt32(monsters[0]["ThunderRes"]),
                    DragonRes = Convert.ToInt32(monsters[0]["DragonRes"]),
                    Type = Convert.ToString(monsters[0]["Type"]),
                    IconUrl = Convert.ToString(monsters[0]["IconUrl"])
                };
            }
            else
            {
                Monster = new Monster
                {
                    _Id = -999,
                    Name = "Unknown",
                    Hr = -999,
                    MapId = -999,
                    ArmorId = -999,
                    WeaponId = -999,
                    Description = "Unknown",
                    FireRes = -999,
                    WaterRes = -999,
                    IceRes = -999,
                    ThunderRes = -999,
                    DragonRes = -999,
                    Type = "Unknown",
                    IconUrl = "Unknown"
                };
            }
        }
        private void LoadWeapon(int id)
        {
            DataTable dt = DBDatasource.GetDataById(WeaponsVM.DBTable, id);
            DataRowCollection monsters = dt.Rows;

            if (monsters.Count > 0)
            {
                Weapon = new Weapon
                {
                    _Id = Convert.ToInt32(monsters[0]["_Id"]),
                    Name = Convert.ToString(monsters[0]["Name"]),
                    RawDamage = Convert.ToInt32(monsters[0]["RawDamage"]),
                    Element = Convert.ToString(monsters[0]["Element"]),
                    ElementDamage = Convert.ToInt32(monsters[0]["ElementDamage"]),
                    Sharpness = Convert.ToString(monsters[0]["Sharpness"]),
                    Type = Convert.ToString(monsters[0]["Type"]),
                    IconUrl = Convert.ToString(monsters[0]["IconUrl"])
                };
            }
            else
            {
                Weapon = new Weapon
                {
                    _Id = -999,
                    Name = "Unknown",
                    RawDamage = -999,
                    Element = "Unknown",
                    ElementDamage = -999,
                    Sharpness = "Unknown",
                    Type = "Unknown",
                    IconUrl = "Unknown"
                };
            }
        }
        private void LoadArmor(int id)
        {
            DataTable dt = DBDatasource.GetDataById(ArmorsVM.DBTable, id);
            DataRowCollection monsters = dt.Rows;

            if (monsters.Count > 0)
            {
                Armor = new Armor
                {
                    _Id = Convert.ToInt32(monsters[0]["_Id"]),
                    Defense = Convert.ToInt32(monsters[0]["Defense"]),
                    FireRes = Convert.ToInt32(monsters[0]["FireRes"]),
                    WaterRes = Convert.ToInt32(monsters[0]["WaterRes"]),
                    IceRes = Convert.ToInt32(monsters[0]["IceRes"]),
                    ThunderRes = Convert.ToInt32(monsters[0]["ThunderRes"]),
                    DragonRes = Convert.ToInt32(monsters[0]["DragonRes"]),
                    Sockets = Convert.ToInt32(monsters[0]["Sockets"]),
                    SkillId = Convert.ToInt32(monsters[0]["SkillId"]),
                };
            }
            else
            {
                Armor = new Armor
                {
                    _Id = -999,
                    Defense = -999,
                    FireRes = -999,
                    WaterRes = -999,
                    IceRes = -999,
                    ThunderRes = -999,
                    DragonRes = -999,
                    Sockets = -999,
                    SkillId = -999,
                };
            }
        }
        private void LoadMap(int id)
        {
            DataTable dt = DBDatasource.GetDataById(MapsVM.DBTable, id);
            DataRowCollection monsters = dt.Rows;

            if (monsters.Count > 0)
            {
                Map = new Map
                {
                    _Id = Convert.ToInt32(monsters[0]["_Id"]),
                    Name = Convert.ToString(monsters[0]["Name"]),
                    Description = Convert.ToString(monsters[0]["Description"]),
                    NumberOfZones = Convert.ToInt32(monsters[0]["NumberOfZones"]),
                    IconUrl = Convert.ToString(monsters[0]["IconUrl"])
                };
            }
            else
            {
                Map = new Map
                {
                    _Id = -999,
                    Name = "Unknown",
                    Description = "Unknown",
                    NumberOfZones = -999,
                    IconUrl = "Unknown"
                };
            }
        }
        private void LoadSkill(int id)
        {
            DataTable dt = DBDatasource.GetDataById(SkillsVM.DBTable, id);
            DataRowCollection monsters = dt.Rows;

            if (monsters.Count > 0)
            {
                Skill = new Skill
                {
                    _Id = Convert.ToInt32(monsters[0]["_Id"]),
                    Name = Convert.ToString(monsters[0]["Name"]),
                    Levels = Convert.ToInt32(monsters[0]["Levels"]),
                    Description = Convert.ToString(monsters[0]["Description"]),
                    IconUrl = Convert.ToString(monsters[0]["IconUrl"])
                };
            }
            else
            {
                Skill = new Skill
                {
                    _Id = -999,
                    Name = "Unknown",
                    Levels = -999,
                    Description = "Unknown",
                    IconUrl = "Unknown"
                };
            }
        }
    }
}
