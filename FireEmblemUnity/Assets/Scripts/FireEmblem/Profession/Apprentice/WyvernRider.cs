using System;

namespace FireEmblem {
	public class WyvernRider : Profession {
		public WyvernRider() {
			Max_Health = 60;
			Max_Strength = 28;
			Max_Magic = 20;
			Max_Skill = 24;
			Max_Speed = 24;
			Max_Luck = 29;
			Max_Defense = 30;
			Max_Resistance = 20;
			Movement = 7;
			UsableWeapons.Add(WeaponType.Axe, SkillLevel.A);
			Promotions.Add(new WyvernLord());
			Promotions.Add(new GriffonRider());
			Move_Type = MovementType.Air;
			Beast_Type = BeastType.Wyvern;
		}
	}
}

