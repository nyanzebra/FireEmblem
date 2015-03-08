using System;

namespace FireEmblem {
	public class Tactician : Profession {
		public Tactician() {
			Max_Health = 60;
			Max_Strength = 25;
			Max_Magic = 25;
			Max_Skill = 25;
			Max_Speed = 25;
			Max_Luck = 30;
			Max_Defense = 25;
			Max_Resistance = 25;
			Movement = 5;
			UsableWeapons.Add(WeaponType.Tome, SkillLevel.C);
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.C);
			Promotions.Add(new Grandmaster());
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

