using System;
using System.Collections.Generic;

namespace FireEmblem {
	abstract public class Profession {
		public Profession() {
		}

		public MovementType getMovementType() {
			return Move_Type;
		}

		public int getMovement() {
			return Movement;
		}

		protected bool isUpgradable;
		protected Dictionary<WeaponType, SkillLevel>  UsableWeapons = new Dictionary<WeaponType, SkillLevel>();
		protected List<Promotion> Promotions = new List<Promotion>();

		protected int Max_Health;
		protected int Max_Defense;
		protected int Max_Constitution;
		protected int Max_Luck;
		protected int Max_Strength;
		protected int Max_Speed;
		protected int Max_Skill;
		protected int Max_Magic;
		protected int Max_Resistance;
		protected int Movement;
		protected MovementType Move_Type;
		protected BeastType Beast_Type;
	}
}

