using System;

namespace FireEmblem {
	public class Myrmidon : Profession {
		public Myrmidon() {
			Max_Health = 60;
			Max_Strength = 24;
			Max_Magic = 22;
			Max_Skill = 27;
			Max_Speed = 28;
			Max_Luck = 30;
			Max_Defense = 22;
			Max_Resistance = 24;
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			Movement = 5;
			Promotions.Add(new Swordmaster());
			Promotions.Add(new Assassin());
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

