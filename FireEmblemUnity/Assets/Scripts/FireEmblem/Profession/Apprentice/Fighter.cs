using System;

namespace FireEmblem {
	public class Fighter : Profession {
		public Fighter() {
			Max_Health = 60;
			Max_Strength = 29;
			Max_Magic = 20;
			Max_Skill = 26;
			Max_Speed = 25;
			Max_Luck = 30;
			Max_Defense = 25;
			Max_Resistance = 23;
			Movement = 6;
			UsableWeapons.Add(WeaponType.Axe, SkillLevel.A);
			Promotions.Add(new Warrior());
			Promotions.Add(new Hero());
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

