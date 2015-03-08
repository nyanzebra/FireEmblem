using System;

namespace FireEmblem {
	public class PegasusKnight : Profession {
		public PegasusKnight() {
			Max_Health = 60;
			Max_Strength = 24;
			Max_Magic = 23;
			Max_Skill = 28;
			Max_Speed = 27;
			Max_Luck = 30;
			Max_Defense = 22;
			Max_Resistance = 25;
			Movement = 7;
			UsableWeapons.Add(WeaponType.Lance, SkillLevel.A);
			Promotions.Add(new FalconKnight());
			Promotions.Add(new DarkFlier());
			Move_Type = MovementType.Air;
			Beast_Type = BeastType.Pegasus;
		}
	}
}

