using System;
using System.Collections.Generic;
using UnityEngine;

namespace FireEmblem {
	public class Chrom : PlayableCharacter {
		public Chrom() {
			Name = "Chrom";

			Current_Profession = new Lord();
			Equipment.add(new Falchion());
			Equipment.add(new Vulnerary());
			Equipment.add(new Rapier());

			Weapon_And_Skill = new Dictionary<WeaponType, SkillLevel>() { 
				{WeaponType.Sword, SkillLevel.E } 
			};

			Alternative_Jobs = new List<Profession>() {

			};

			Skills.Add(new DualStrike());

			Characteristics.setPermanentAttribute(AttributeName.Health, 20);
			Characteristics.setPermanentAttribute(AttributeName.Health, 20);

			Characteristics.setPermanentAttribute(AttributeName.Defense, 7);
			Characteristics.setPermanentAttribute(AttributeName.Luck, 5);
			Characteristics.setPermanentAttribute(AttributeName.Magic, 1);
			Characteristics.setPermanentAttribute(AttributeName.Resistance, 1);
			Characteristics.setPermanentAttribute(AttributeName.Skill, 8);
			Characteristics.setPermanentAttribute(AttributeName.Speed, 8);
			Characteristics.setPermanentAttribute(AttributeName.Strength, 7);
		}
	}
}

