using System;

namespace FireEmblem {
	public class FalconKnight : Promotion {
		public FalconKnight() {
			Max_Health = 80;
			Max_Strength = 38;
			Max_Magic = 35;
			Max_Skill = 45;
			Max_Speed = 44;
			Max_Luck = 45;
			Max_Defense = 33;
			Max_Resistance = 40;
			UsableWeapons.Add(WeaponType.Lance, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Staff, SkillLevel.A);
			Movement = 8;
			Move_Type = MovementType.Air;
			Beast_Type = BeastType.Pegasus;
		}
	}
}

