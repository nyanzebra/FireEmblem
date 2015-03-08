using System;

namespace FireEmblem {
	public class GreatKnight : Promotion {
		public GreatKnight() {
			Max_Health = 80;
			Max_Strength = 50;
			Max_Magic = 20;
			Max_Skill = 36;
			Max_Speed = 35;
			Max_Luck = 45;
			Max_Defense = 50;
			Max_Resistance = 30;
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Axe, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Lance, SkillLevel.A);
			Movement = 7;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.Horse;
		}
	}
}

