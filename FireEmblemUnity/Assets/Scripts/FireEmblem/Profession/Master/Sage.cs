using System;

namespace FireEmblem {
	public class Sage : Promotion {
		public Sage() {
			Max_Health = 80;
			Max_Strength = 30;
			Max_Magic = 46;
			Max_Skill = 43;
			Max_Speed = 42;
			Max_Luck = 45;
			Max_Defense = 31;
			Max_Resistance = 40;
			UsableWeapons.Add(WeaponType.Tome, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Staff, SkillLevel.A);
			Movement = 6;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

