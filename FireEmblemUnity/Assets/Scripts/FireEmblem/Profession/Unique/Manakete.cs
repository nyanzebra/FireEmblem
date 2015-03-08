using System;

namespace FireEmblem {
	public class Manakete : Profession {
		public Manakete() {
			Max_Health = 80;
			Max_Strength = 40;
			Max_Magic = 35;
			Max_Skill = 35;
			Max_Speed = 35;
			Max_Luck = 45;
			Max_Defense = 40;
			Max_Resistance = 40;
			Movement = 6;
			UsableWeapons.Add (WeaponType.Stone, SkillLevel.A);
			//no promotions
		}
	}
}

