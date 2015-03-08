using System;

namespace FireEmblem {
	public class Paladin : Promotion {
		public Paladin() {
			Max_Health = 80;
			Max_Strength = 42;
			Max_Magic = 30;
			Max_Skill = 40;
			Max_Speed = 40;
			Max_Luck = 45;
			Max_Defense = 42;
			Max_Resistance = 42;
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Lance, SkillLevel.A);
			Movement = 8;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.Horse;
		}
	}
}

