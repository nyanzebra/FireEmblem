using System;

namespace FireEmblem {
	public class Assassin : Promotion {
		public Assassin() {
			Max_Health = 80;
			Max_Strength = 42;
			Max_Magic = 30;
			Max_Skill = 48;
			Max_Speed = 46;
			Max_Luck = 45;
			Max_Defense = 31;
			Max_Resistance = 30;
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Bow, SkillLevel.A);
			Movement = 6;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

