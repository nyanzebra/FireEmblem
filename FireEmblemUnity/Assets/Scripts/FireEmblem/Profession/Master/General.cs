using System;

namespace FireEmblem {
	public class General : Promotion {
		public General() {
			Max_Health = 80;
			Max_Strength = 50;
			Max_Magic = 30;
			Max_Skill = 41;
			Max_Speed = 35;
			Max_Luck = 45;
			Max_Defense = 50;
			Max_Resistance = 35;
			UsableWeapons.Add(WeaponType.Lance, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Axe, SkillLevel.A);
			Movement = 5;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.Armor;
		}
	}
}

