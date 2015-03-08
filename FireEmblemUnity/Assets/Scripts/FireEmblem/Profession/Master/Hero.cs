using System;

namespace FireEmblem {
	public class Hero : Promotion {
		public Hero() {
			Max_Health = 80;
			Max_Strength = 42;
			Max_Magic = 30;
			Max_Skill = 46;
			Max_Speed = 42;
			Max_Luck = 45;
			Max_Defense = 40;
			Max_Resistance = 36;
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Axe, SkillLevel.A);
			Movement = 6;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

