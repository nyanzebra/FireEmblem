using System;

namespace FireEmblem {
	public class WarCleric : Promotion {
		public WarCleric() {
			Max_Health = 80;
			Max_Strength = 40;
			Max_Magic = 40;
			Max_Skill = 38;
			Max_Speed = 41;
			Max_Luck = 45;
			Max_Defense = 38;
			Max_Resistance = 43;
			UsableWeapons.Add(WeaponType.Axe, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Staff, SkillLevel.A);
			Movement = 6;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

