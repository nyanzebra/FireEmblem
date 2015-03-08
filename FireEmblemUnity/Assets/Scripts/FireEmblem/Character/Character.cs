using System;
using System.Collections.Generic;
using UnityEngine;

namespace FireEmblem {
	public class Character {
		public Character() {
		}

		public Profession getClass() {
			return Current_Profession;
		}

		public void setClass(Profession profession) {
			Current_Profession = profession;
		}

		public Attributes getAttributes() {
			return Stats;
		}

		public LevelSystem getLevel() {
			return Level;
		}

		public Weapon getEquippedWeapon() {
			return Active_Weapon;
		}

		public void setEquippedWeapon(Weapon weapon) {
			Active_Weapon = weapon;
		}

		public bool isDead() {
			return Is_Dead;
		}

		public void switchClass(Profession new_profession) {
			Level.levelUp();
			Second_Seals_Used++;
			Current_Profession = new_profession;

			if (new_profession is Promotion) {
				Level.setPromotionBonus(true);
			} else {
				Level.setPromotionBonus(false);
			}
		}

		public void promote(Promotion new_promotion) {
			Level.setPromotionBonus(true);
			Current_Profession = new_promotion;
		}

		public int Attack_Recovery_Bonus() {
			if (Active_Weapon is Sword || Active_Weapon is Staff) {
				if (Weapon_And_Skill[WeaponType.Sword] == SkillLevel.C) {
					return 1;
				} else if (Weapon_And_Skill[WeaponType.Sword] == SkillLevel.B) {
					return 2;
				} else if (Weapon_And_Skill[WeaponType.Sword] == SkillLevel.A) {
					return 3;
				}
			} else if (Active_Weapon is Lance || Active_Weapon is Bow || Active_Weapon is Tome) {
				if (Weapon_And_Skill[WeaponType.Sword] == SkillLevel.C) {
					return 1;
				} else if (Weapon_And_Skill[WeaponType.Sword] == SkillLevel.B) {
					return 1;
				} else if (Weapon_And_Skill[WeaponType.Sword] == SkillLevel.A) {
					return 2;
				}
			} else if (Active_Weapon is Axe) {
				if (Weapon_And_Skill[WeaponType.Axe] == SkillLevel.A) {
					return 1;
				}
			}
			return 0;
		}

		public int Hit_Rate_Bonus() {
			if (Active_Weapon is Lance || Active_Weapon is Bow || Active_Weapon is Tome) {
				if (Weapon_And_Skill[WeaponType.Sword] == SkillLevel.B 
					|| Weapon_And_Skill[WeaponType.Sword] == SkillLevel.A) {
					return 5;
				} 
			} else if (Active_Weapon is Axe) {
				if (Weapon_And_Skill[WeaponType.Axe] == SkillLevel.C) {
					return 5;
				} else if (Weapon_And_Skill[WeaponType.Axe] == SkillLevel.B) {
					return 10;
				} else if (Weapon_And_Skill[WeaponType.Axe] == SkillLevel.A) {
					return 15;
				}
			}
			return 0;
		}

		public int getTimesAttacked() {
			return Times_Attacked;
		}

		public SkillLevel skillForType(WeaponType type) {
			return Weapon_And_Skill[type];
		}

		public void kill() {
			Is_Dead = true;
		}

		public void useItem(int position) {
			Item item_to_use = Equipment.getItem(position);
			if (item_to_use is Weapon) {
				setEquippedWeapon(item_to_use as Weapon);
			} else if (item_to_use is Consumable) {
				
			}
		}

		public void damage(int damage) {
			Stats.setHealth(Stats.getHealth() - damage);
			if (Stats.getHealth() <= 0) {
				Is_Dead = true;
			}
		}

		public void loadSprites() {
			for (int i = 0; i < 40; ++i) {

				//Sprites.Add(Sprite.Create());
			}
		}

		public string getName() {
			return Name;
		}

		protected string Name;
		protected Equipment Equipment;
		protected static Dictionary<WeaponType, SkillLevel> Weapon_And_Skill;
		protected bool Is_Dead = false;
		protected Weapon Active_Weapon;
		protected int Times_Attacked = 0;
		protected Profession Current_Profession;
		protected int Second_Seals_Used = 0;
		protected static List<Profession> Alternative_Jobs;
		protected LevelSystem Level;
		protected Attributes Stats;
		protected List<Skill> Skills = new List<Skill>();
		protected List<Sprite> Sprites = new List<Sprite>();
	}
}

