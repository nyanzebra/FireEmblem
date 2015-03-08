using System;

namespace FireEmblem {
	public class Valkyrie : Promotion {
		public Valkyrie() {
			Max_Health = 80;
			Max_Strength = 30;
			Max_Magic = 42;
			Max_Skill = 38;
			Max_Speed = 43;
			Max_Luck = 45;
			Max_Defense = 30;
			Max_Resistance = 45;
			UsableWeapons.Add(WeaponType.Tome, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Staff, SkillLevel.A);
			Movement = 8;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.Horse;
		}
	}
}

