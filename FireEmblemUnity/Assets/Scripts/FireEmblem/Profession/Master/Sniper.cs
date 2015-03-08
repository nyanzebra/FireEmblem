using System;

namespace FireEmblem {
	public class Sniper : Promotion {
		public Sniper() {
			Max_Health = 80;
			Max_Strength = 41;
			Max_Magic = 30;
			Max_Skill = 48;
			Max_Speed = 40;
			Max_Luck = 45;
			Max_Defense = 40;
			Max_Resistance = 31;
			UsableWeapons.Add(WeaponType.Bow, SkillLevel.A);
			Movement = 6;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

