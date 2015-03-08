using System;

namespace FireEmblem {
	public class DarkKnight : Promotion {
		public DarkKnight() {
			Max_Health = 80;
			Max_Strength = 38;
			Max_Magic = 41;
			Max_Skill = 40;
			Max_Speed = 40;
			Max_Luck = 45;
			Max_Defense = 42;
			Max_Resistance = 38;
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Tome, SkillLevel.A);
			Movement = 8;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.Horse;
		}
	}
}

