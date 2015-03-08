using System;

namespace FireEmblem {
	public class Sorcerer : Promotion {
		public Sorcerer() {
			Max_Health = 80;
			Max_Strength = 30;
			Max_Magic = 44;
			Max_Skill = 38;
			Max_Speed = 40;
			Max_Luck = 45;
			Max_Defense = 41;
			Max_Resistance = 44;
			UsableWeapons.Add(WeaponType.Tome, SkillLevel.A);
			Movement = 6;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

