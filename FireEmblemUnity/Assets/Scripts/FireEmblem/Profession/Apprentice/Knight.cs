using System;

namespace FireEmblem {
	public class Knight : Profession {
		public Knight() {
			Max_Health = 60;
			Max_Strength = 30;
			Max_Magic = 20;
			Max_Skill = 26;
			Max_Speed = 23;
			Max_Luck = 30;
			Max_Defense = 30;
			Max_Resistance = 22;
			Movement = 5;
			UsableWeapons.Add(WeaponType.Lance, SkillLevel.A);
			Promotions.Add(new General());
			Promotions.Add(new GreatKnight());
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

