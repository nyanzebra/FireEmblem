using System;

namespace FireEmblem {
	public class Barbarian : Profession	{
		public Barbarian() {
			Max_Health = 60;
			Max_Strength = 30;
			Max_Magic = 20;
			Max_Skill = 23;
			Max_Speed = 27;
			Max_Luck = 30;
			Max_Defense = 22;
			Max_Resistance = 20;
			Movement = 5;
			Promotions.Add (new Berserker ());
			Promotions.Add (new Warrior ());
			UsableWeapons.Add (WeaponType.Axe, SkillLevel.A);
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

