using System;

namespace FireEmblem {
	public class Cavalier : Profession {
		public Cavalier() {
			Max_Health = 61;
			Max_Strength = 27;
			Max_Magic = 21;
			Max_Skill = 26;
			Max_Speed = 26;
			Max_Luck = 31;
			Max_Defense = 25;
			Max_Resistance = 25;
			UsableWeapons.Add(WeaponType.Lance, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			Promotions.Add(new GreatKnight ());
			Promotions.Add(new Paladin ());
			Movement = 7;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.Horse;
		}
	}
}

