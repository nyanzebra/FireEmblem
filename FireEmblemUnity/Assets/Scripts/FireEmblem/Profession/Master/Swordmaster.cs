using System;

namespace FireEmblem {
	public class Swordmaster : Promotion {
		public Swordmaster() {
			Max_Health = 80;
			Max_Strength = 38;
			Max_Magic = 34;
			Max_Skill = 44;
			Max_Speed = 46;
			Max_Luck = 45;
			Max_Defense = 33;
			Max_Resistance = 38;
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			Movement = 6;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

