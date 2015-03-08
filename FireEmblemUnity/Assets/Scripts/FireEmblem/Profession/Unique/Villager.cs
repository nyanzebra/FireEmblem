using System;

namespace FireEmblem {
	public class Villager : Profession {
		public Villager() {
			Max_Health = 60;
			Max_Strength = 21;
			Max_Magic = 20;
			Max_Skill = 19;
			Max_Speed = 20;
			Max_Luck = 33;
			Max_Defense = 20;
			Max_Resistance = 20;
			UsableWeapons.Add (WeaponType.Lance, SkillLevel.A);
			//no promotions
		}
	}
}

