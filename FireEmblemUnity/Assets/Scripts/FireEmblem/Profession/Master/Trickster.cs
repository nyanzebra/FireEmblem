using System;

namespace FireEmblem {
	public class Trickster : Promotion {
		public Trickster() {
			Max_Health = 80;
			Max_Strength = 35;
			Max_Magic = 38;
			Max_Skill = 45;
			Max_Speed = 43;
			Max_Luck = 45;
			Max_Defense = 30;
			Max_Resistance = 40;
			UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			UsableWeapons.Add(WeaponType.Staff, SkillLevel.A);
			Movement = 6;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

