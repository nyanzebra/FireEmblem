using System;

namespace FireEmblem {
	public class Grandmaster : Promotion {
		public Grandmaster() {
			Max_Health = 80;
			Max_Strength = 40;
			Max_Magic = 40;
			Max_Skill = 40;
			Max_Speed = 40;
			Max_Luck = 45;
			Max_Defense = 40;
			Max_Resistance = 40;
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Tome, SkillLevel.A);
			Movement = 6;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

