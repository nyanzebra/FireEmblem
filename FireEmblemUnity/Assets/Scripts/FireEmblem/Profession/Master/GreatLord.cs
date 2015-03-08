using System;

namespace FireEmblem {
	public class GreatLord : Promotion {
		public GreatLord() {
			Max_Health = 80;
			Max_Strength = 44;
			Max_Magic = 30;
			Max_Skill = 42;
			Max_Speed = 44;
			Max_Luck = 46;
			Max_Defense = 41;
			Max_Resistance = 40;
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Lance, SkillLevel.A);
			Movement = 6;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

