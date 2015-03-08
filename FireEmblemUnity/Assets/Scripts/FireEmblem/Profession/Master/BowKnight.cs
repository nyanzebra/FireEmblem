using System;

namespace FireEmblem {
	public class BowKnight : Promotion {
		public BowKnight() {
			Max_Health = 80;
			Max_Strength = 40;
			Max_Magic = 30;
			Max_Skill = 43;
			Max_Speed = 41;
			Max_Luck = 45;
			Max_Defense = 35;
			Max_Resistance = 30;
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Bow, SkillLevel.A);
			Movement = 8;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.Horse;
		}
	}
}

