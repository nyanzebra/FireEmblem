using System;
using System.Collections.Generic;
using UnityEngine;

namespace FireEmblem {
	public class Character {
		public Character() {
		}

		public Profession getProfession() {
			return Current_Profession;
		}

		public void setProfession(Profession profession) {
			Current_Profession = profession;
		}

		public Attributes getAttributes() {
			return Characteristics;
		}

		public LevelSystem getLevel() {
			return Level;
		}

		public Weapon getEquippedWeapon() {
			for(int item = 0; item < 5; ++item) {
				if (Equipment.getItem(item) is Weapon) {
					return Equipment.getItem(item) as Weapon;
				}
			}
			return null;
		}

		public bool isDead() {
			return Is_Dead;
		}

		public void switchProfession(Profession new_profession) {
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
			Weapon equipped_weapon = getEquippedWeapon();
			if (equipped_weapon is Sword || equipped_weapon is Staff) {
				if (Weapon_And_Skill[WeaponType.Sword] == SkillLevel.C) {
					return 1;
				} else if (Weapon_And_Skill[WeaponType.Sword] == SkillLevel.B) {
					return 2;
				} else if (Weapon_And_Skill[WeaponType.Sword] == SkillLevel.A) {
					return 3;
				}
			} else if (equipped_weapon is Lance || equipped_weapon is Bow || equipped_weapon is Tome) {
				if (Weapon_And_Skill[WeaponType.Sword] == SkillLevel.C) {
					return 1;
				} else if (Weapon_And_Skill[WeaponType.Sword] == SkillLevel.B) {
					return 1;
				} else if (Weapon_And_Skill[WeaponType.Sword] == SkillLevel.A) {
					return 2;
				}
			} else if (equipped_weapon is Axe) {
				if (Weapon_And_Skill[WeaponType.Axe] == SkillLevel.A) {
					return 1;
				}
			}
			return 0;
		}

		public int Hit_Rate_Bonus() {
			Weapon equipped_weapon = getEquippedWeapon();
			if (equipped_weapon is Lance || equipped_weapon is Bow || equipped_weapon is Tome) {
				if (Weapon_And_Skill[WeaponType.Sword] == SkillLevel.B 
					|| Weapon_And_Skill[WeaponType.Sword] == SkillLevel.A) {
					return 5;
				} 
			} else if (equipped_weapon is Axe) {
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

		public Equipment getEquipment() {
			return Equipment;
		}

		public void damage(int damage) {
			if (damage > 0) {
				int current_health = Characteristics.getTemporaryAttribute(AttributeName.Health);
				Characteristics.setTemporaryAttribute(AttributeName.Health, current_health - damage);
				if (Characteristics.getTemporaryAttribute(AttributeName.Health) <= 0) {
					Is_Dead = true;
				}
			}
		}

		public void loadSprites() {
			for (int i = 0; i < 4; ++i) {

				Sprites.Add(Resources.Load(Name + "_" + Current_Profession.ToString() + "_" + "select_" + i.ToString()));
				Sprites.Add(Resources.Load(Name + "_" + Current_Profession.ToString() + "_" + "forward_" + i.ToString()));
				Sprites.Add(Resources.Load(Name + "_" + Current_Profession.ToString() + "_" + "backward_" + i.ToString()));
				Sprites.Add(Resources.Load(Name + "_" + Current_Profession.ToString() + "_" + "left_" + i.ToString()));
				Sprites.Add(Resources.Load(Name + "_" + Current_Profession.ToString() + "_" + "right_" + i.ToString()));
				Sprites.Add(Resources.Load(Name + "_" + Current_Profession.ToString() + "_" + "upleft_" + i.ToString()));
				Sprites.Add(Resources.Load(Name + "_" + Current_Profession.ToString() + "_" + "upright_" + i.ToString()));
				Sprites.Add(Resources.Load(Name + "_" + Current_Profession.ToString() + "_" + "downleft_" + i.ToString()));
				Sprites.Add(Resources.Load(Name + "_" + Current_Profession.ToString() + "_" + "downright_" + i.ToString()));
			}
		}

		public string getName() {
			return Name;
		}

		protected string Name;
		protected Equipment Equipment = new Equipment();
		protected static Dictionary<WeaponType, SkillLevel> Weapon_And_Skill = new Dictionary<WeaponType, SkillLevel>();
		protected bool Is_Dead = false;
		protected int Times_Attacked = 0;
		protected Profession Current_Profession;
		protected int Second_Seals_Used = 0;
		protected static List<Profession> Alternative_Jobs = new List<Profession>();
		protected LevelSystem Level;
		protected Attributes Characteristics = new Attributes();
		protected List<Skill> Skills = new List<Skill>();
		protected List<Sprite> Sprites = new List<Sprite>();
	}
}

