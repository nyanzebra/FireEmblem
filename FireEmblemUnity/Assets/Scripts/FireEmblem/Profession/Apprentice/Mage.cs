using System;

namespace FireEmblem {
	public class Mage : Profession {
		public Mage() {
			Max_Health = 60;
			Max_Strength = 20;
			Max_Magic = 28;
			Max_Skill = 27;
			Max_Speed = 26;
			Max_Luck = 30;
			Max_Defense = 21;
			Max_Resistance = 25;
			Movement = 5;
			UsableWeapons.Add(WeaponType.Tome, SkillLevel.A);
			Promotions.Add(new DarkKnight());
			Promotions.Add(new Sage());
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

