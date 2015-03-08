using System;

namespace FireEmblem {
	public class GriffonRider : Promotion {
		public GriffonRider() {
			Max_Health = 80;
			Max_Strength = 40;
			Max_Magic = 30;
			Max_Skill = 43;
			Max_Speed = 41;
			Max_Luck = 45;
			Max_Defense = 40;
			Max_Resistance = 30;
			UsableWeapons.Add(WeaponType.Axe, SkillLevel.A);
			Movement = 8;
			Move_Type = MovementType.Air;
			Beast_Type = BeastType.Griffon;
		}
	}
}

