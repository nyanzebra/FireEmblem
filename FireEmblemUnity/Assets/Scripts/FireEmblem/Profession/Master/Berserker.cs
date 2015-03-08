using System;
namespace FireEmblem {
	public class Berserker : Promotion {
		public Berserker() {
			Max_Health = 80;
			Max_Strength = 50;
			Max_Magic = 30;
			Max_Skill = 35;
			Max_Speed = 44;
			Max_Luck = 45;
			Max_Defense = 34;
			Max_Resistance = 30;
			UsableWeapons.Add(WeaponType.Axe, SkillLevel.A);
			Movement = 8;
			Move_Type = MovementType.Land;
			Beast_Type = BeastType.None;
		}
	}
}

