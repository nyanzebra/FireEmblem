using System;

namespace FireEmblem {
	public class Thief : Profession {
		public Thief() {
			Max_Health = 60;
			Max_Strength = 22;
			Max_Magic = 20;
			Max_Skill = 30;
			Max_Speed = 28;
			Max_Skill = 30;
			Max_Defense = 21;
			Max_Resistance = 20;
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			Promotions.Add(new Trickster());
			Promotions.Add(new Assassin());
			Movement = 5;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

