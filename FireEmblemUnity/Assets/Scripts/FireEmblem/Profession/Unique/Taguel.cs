using System;

namespace FireEmblem {
	public class Taguel : Profession {
		public Taguel()	{
			Max_Health = 80;
			Max_Strength = 35;
			Max_Magic = 30;
			Max_Skill = 40;
			Max_Speed = 40;
			Max_Luck = 45;
			Max_Defense = 35;
			Max_Resistance = 30;
			Movement = 6;
			UsableWeapons.Add (WeaponType.Stone, SkillLevel.A);
			//no promotions
		}
	}
}

