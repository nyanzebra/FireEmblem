using System;

namespace FireEmblem {
	public class DarkFlier : Promotion {
		public DarkFlier() {
			Max_Health = 80;
			Max_Strength = 36;
			Max_Magic = 42;
			Max_Skill = 41;
			Max_Speed = 42;
			Max_Luck = 45;
			Max_Defense = 32;
			Max_Resistance = 41;
			UsableWeapons.Add(WeaponType.Lance, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Tome, SkillLevel.A);
			Movement = 8;
			Move_Type = MovementType.Air;
			Beast_Type = BeastType.Pegasus;
		}
	}
}

