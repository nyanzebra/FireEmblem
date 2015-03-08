using System;

namespace FireEmblem {
	public class Lord : Profession {
		public Lord() {
			Max_Health = 60;
			Max_Strength = 28;
			Max_Magic = 20;
			Max_Skill = 26;
			Max_Speed = 27;
			Max_Luck = 31;
			Max_Defense = 25;
			Max_Resistance = 25;
			Movement = 5;
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			Promotions.Add(new GreatLord());
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

