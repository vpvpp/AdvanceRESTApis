﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceRestAPIs.Models
{
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3
    }
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;


        public User User { get; set; }

        public Weapon Weapon { get; set; }
        public RpgClass Class { get; set; } = RpgClass.Knight;

        //for field is for....many to many reletionship
        public List<CharacterSkill> CharacterSkills { get; set; }

    }
}
