using System;
using System.Collections.Generic;

namespace FireEmblem
{
	public class Character
	{
		public Character ()
		{
		}

		public int Health { 
			get { return m_Health; }
			set { m_Health = value; }
		}

		public int Defense {
			get { return m_Defense; }
			set { m_Defense = value; }
		}

		public int Consitution {
			get { return m_Constitution; }
			set { m_Constitution = value; }
		}

		public int AttackSpeed {
			get { return m_Attack_Speed; }
			set { m_Attack_Speed = value; }
		}

		public int Luck {
			get { return m_Luck; }
			set { m_Luck = value; }
		}

		public int Strength {
			get { return m_Strength; }
			set { m_Strength = value; }
		}

		public int Speed {
			get { return m_Speed; }
			set { m_Speed = value; }
		}

		public int Skill {
			get { return m_Skill; }
			set { m_Skill = value; }
		}

		public int Magic {
			get { return m_Magic; }
			set { m_Magic = value; }
		}

		public int Movement {
			get { return m_Movement; }
			set { m_Movement = value; }
		}

		public int Resistance {
			get { return m_Resistance; }
			set { m_Resistance = value; }
		}

		public Profession Class {
			get { return m_Current_Profession; }
			set { m_Current_Profession = value; }
		}

		public Weapon EquippedWeapon {
			get { return m_Active_Weapon; }
			set { m_Active_Weapon = value; }
		}

		public int Rating {
			get { return m_Strength + m_Magic + m_Skill + m_Speed + m_Luck + m_Defense + m_Resistance; }
		}

		public int Level {
			get { return m_Cumulative_Level; }
			set { m_Cumulative_Level = value; }
		}

		public int InnerLevel {
			get { return m_Displayed_Level + PromotionBonus + m_Cumulative_Level; }
		}

		public int DisplayedLevel {
			get { return m_Displayed_Level; }
			set { m_Displayed_Level = value; }
		}

		public int PromotionBonus {
			get { return (m_Promoted_Class) ? (int) 20 : (int) 0; }
		}

		public bool Dead {
			get { return m_Dead; }
		}

		public void switchClass(Profession new_profession) {
			m_Cumulative_Level += (DisplayedLevel + PromotionBonus - 1) / 2;
			m_Second_Seals_Used++;
			m_Displayed_Level = 1;
			m_Current_Profession = new_profession;

			if (new_profession is Promotion) {
				m_Promoted_Class = true;
			} else {
				m_Promoted_Class = false;
			}
		}

		public void promote(Promotion new_promotion) {
			m_Promoted_Class = true;
			m_Current_Profession = new_promotion;
		}

		public int Attack_Recovery_Bonus() {
		 	if (m_Active_Weapon is Sword || m_Active_Weapon is Staff) {
				if (m_Weapon_And_Skill [WeaponType.Sword] == SkillLevel.C) {
					return 1;
				} else if (m_Weapon_And_Skill [WeaponType.Sword] == SkillLevel.B) {
					return 2;
				} else if (m_Weapon_And_Skill [WeaponType.Sword] == SkillLevel.A) {
					return 3;
				}
			} else if (m_Active_Weapon is Lance || m_Active_Weapon is Bow || m_Active_Weapon is Tome) {
				if (m_Weapon_And_Skill [WeaponType.Sword] == SkillLevel.C) {
					return 1;
				} else if (m_Weapon_And_Skill [WeaponType.Sword] == SkillLevel.B) {
					return 1;
				} else if (m_Weapon_And_Skill [WeaponType.Sword] == SkillLevel.A) {
					return 2;
				}
			} else if (m_Active_Weapon is Axe) {
				if (m_Weapon_And_Skill[WeaponType.Axe] == SkillLevel.A) {
					return 1;
				}
			}
			return 0;
		}

		public int Hit_Rate_Bonus() {
			if (m_Active_Weapon is Lance || m_Active_Weapon is Bow || m_Active_Weapon is Tome) {
				if (m_Weapon_And_Skill [WeaponType.Sword] == SkillLevel.B 
				    || m_Weapon_And_Skill [WeaponType.Sword] == SkillLevel.A) {
					return 5;
				} 
			} else if (m_Active_Weapon is Axe) {
				if (m_Weapon_And_Skill[WeaponType.Axe] == SkillLevel.C) {
					return 5;
				} else if (m_Weapon_And_Skill[WeaponType.Axe] == SkillLevel.B) {
					return 10;
				} else if (m_Weapon_And_Skill[WeaponType.Axe] == SkillLevel.A) {
					return 15;
				}
			}
			return 0;
		}

		public int TimesAttacked {
			get { return m_Times_Attacked; }
		}

		public SkillLevel skillForType(WeaponType type) {
			return m_Weapon_And_Skill [type];
		}

		public void kill() {
			m_Dead = true;
		}

		public int Experience {
			get { return m_Experience; }
			set { m_Experience = value; }
		}

		public string Name {
			get { return m_Name; }
		}

		//protected
		//name, items carried, skill levels, skills
		protected string m_Name;
		protected Equipment m_Equipment;
		protected static Dictionary<WeaponType, SkillLevel> m_Weapon_And_Skill;
		//battle
		protected bool m_Dead = false;
		protected Weapon m_Active_Weapon;
		protected int m_Times_Attacked = 0;
		//profession
		protected Profession m_Current_Profession;
		protected int m_Second_Seals_Used = 0;
		protected static List<Profession> m_Alternative_Jobs;
		protected bool m_Promoted_Class = false;
		//leveling
		protected int m_Cumulative_Level = 0;
		protected int m_Displayed_Level = 1;
		protected int m_Experience = 0;
		//stats
		protected int m_Health;
		protected int m_Defense;
		protected int m_Constitution;
		protected int m_Attack_Speed;
		protected int m_Luck;
		protected int m_Strength;
		protected int m_Speed;
		protected int m_Skill;
		protected int m_Magic;
		protected int m_Resistance;
		protected int m_Movement;
		//temp
		protected int m_Health_Temp = 0;
		protected int m_Defense_Temp = 0;
		protected int m_Constitution_Temp = 0;
		protected int m_Attack_Speed_Temp = 0;
		protected int m_Luck_Temp = 0;
		protected int m_Strength_Temp = 0;
		protected int m_Speed_Temp = 0;
		protected int m_Skill_Temp = 0;
		protected int m_Magic_Temp = 0;
		protected int m_Resistance_Temp = 0;
		protected int m_Movement_Temp = 0;
	}
}

