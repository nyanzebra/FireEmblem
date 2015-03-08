using System;

namespace FireEmblem {
	public class Archer : Profession {
		public Archer() {
			Max_Health = 60;
			Max_Strength = 26;
			Max_Magic = 20;
			Max_Skill = 29;
			Max_Speed = 25;
			Max_Luck = 30;
			Max_Defense = 25;
			Max_Resistance = 21;
			UsableWeapons.Add (WeaponType.Bow, SkillLevel.B);
			Movement = 5;
			Promotions.Add (new Sniper ());
			Promotions.Add (new BowKnight ());
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

