using System;

namespace FireEmblem {
	public class DarkMage : Profession {
		public DarkMage() {
			Max_Health = 60;
			Max_Strength = 20;
			Max_Magic = 27;
			Max_Skill = 25;
			Max_Speed = 25;
			Max_Luck = 30;
			Max_Defense = 25;
			Max_Resistance = 27;
			Movement = 6;
			UsableWeapons.Add(WeaponType.Tome, SkillLevel.A);
			Promotions.Add(new Sorcerer());
			Promotions.Add(new DarkKnight());
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

