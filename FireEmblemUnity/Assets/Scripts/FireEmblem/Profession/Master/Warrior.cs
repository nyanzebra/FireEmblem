using System;

namespace FireEmblem {
	public class Warrior : Promotion {
		public Warrior() {
			Max_Health = 80;
			Max_Strength = 48;
			Max_Magic = 30;
			Max_Skill = 42;
			Max_Speed = 40;
			Max_Luck = 45;
			Max_Defense = 40;
			Max_Resistance = 35;
			UsableWeapons.Add(WeaponType.Axe, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Bow, SkillLevel.A);
			Movement = 6;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

