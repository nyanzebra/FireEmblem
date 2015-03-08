using System;

namespace FireEmblem {
	public class Mercenary : Profession {
		public Mercenary() {
			Max_Health = 60;
			Max_Strength = 26;
			Max_Magic = 20;
			Max_Skill = 28;
			Max_Speed = 26;
			Max_Luck = 30;
			Max_Defense = 25;
			Max_Resistance = 23;
			Movement = 5;
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			Promotions.Add(new BowKnight());
			Promotions.Add(new Hero());
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

