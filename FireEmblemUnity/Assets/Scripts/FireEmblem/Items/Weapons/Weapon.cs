using System;

namespace FireEmblem {
	public abstract class Weapon : Item {
		public Weapon() {
		}

		public WeaponType getType() {
			return Type;
		}

		public SkillLevel getRequiredSkill() {
			return Required_Skill;
		}

		public bool isDegradable() {
			return Is_Degradable;
		}

		public Character[] getRequiredCharacters() {
			return Required_Characters;
		}

		public int getMight() {
			return Might;
		}

		public bool isPhysical() {
			return Is_Physical;
		}

		public bool isMagical() {
			return Is_Magical;
		}

		public int getHitRate() {
			return Hit_Rate;
		}

		public int getCritical() {
			return Critical_Hit_Rate;
		}

		public abstract WeaponTriangle weaponTriangleValue(WeaponType type);

		public abstract int damageMultiplier(BeastType type);

		protected WeaponType Type = WeaponType.None;
		protected SkillLevel Required_Skill = SkillLevel.E;
		protected bool Is_Degradable = true;
		protected Character[] Required_Characters;
		protected int Might = 1;
		protected bool Is_Physical = false;
		protected bool Is_Magical = false;
		protected int Hit_Rate = 0;
		protected int Critical_Hit_Rate = 0;
		protected int Range = 0;
	}
}

