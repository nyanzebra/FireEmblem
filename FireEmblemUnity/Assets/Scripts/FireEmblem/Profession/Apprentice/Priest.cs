using System;

namespace FireEmblem {
	public class Priest : Profession {
		public Priest() {
			Max_Health = 60;
			Max_Strength = 22;
			Max_Magic = 25;
			Max_Skill = 24;
			Max_Speed = 25;
			Max_Luck = 30;
			Max_Defense = 22;
			Max_Resistance = 27;
			Movement = 5;
			UsableWeapons.Add(WeaponType.Staff, SkillLevel.A);
			Promotions.Add(new WarMonk());
			Promotions.Add(new Sage());
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

