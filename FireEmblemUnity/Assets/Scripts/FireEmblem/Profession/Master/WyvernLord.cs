using System;

namespace FireEmblem {
	public class WyvernLord : Promotion {
		public WyvernLord() {
			Max_Health = 80;
			Max_Strength = 46;
			Max_Magic = 30;
			Max_Skill = 38;
			Max_Speed = 38;
			Max_Luck = 45;
			Max_Defense = 46;
			Max_Resistance = 30;
			UsableWeapons.Add(WeaponType.Lance, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Axe, SkillLevel.A);
			Movement = 8;
			Move_Type = MovementType.Air;
			Beast_Type = BeastType.Wyvern;
		}
	}
}

