using System;

namespace FireEmblem {
	public class BattleManager {
		public BattleManager() {
		}

		public void forecast(Character attacker, Character defender) {
		}
		
		public void combat(Character attacker, Character defender) {
			if (attacker.getAttributes().getTemporaryAttribute(AttributeName.Speed) 
				> defender.getAttributes().getTemporaryAttribute(AttributeName.Speed)) {				
				attack(attacker, defender);
				attack(defender, attacker);
			} else {
				
			}
		}
		
		private int LunaticPenalty(Character enemy) {
			return System.Math.Min(3 - enemy.getTimesAttacked(), 0);
		}
		
		private int CharacterBonus() {
			return 0;
		}
		
		private int calculateExperience(Character subject, Character enemy, int damage, bool is_kill) {
			//not sure if displayed level or cumulative level
			int LevelDifference = (enemy.getLevel().getDisplayedLevel() + enemy.getLevel().getPromotionBonus()) 
				- subject.getLevel().getInnerLevel();
			int Base = 0;
			
			if (damage == 0) {
				return 1;
			}
			
			if (!is_kill) {
				if (LevelDifference >= 0) {
					Base = (31 + LevelDifference) / 3;
				} else if (LevelDifference == -1) {
					Base = 10;
				} else if (LevelDifference <= -2) {
					Base = System.Math.Max((33 + LevelDifference) / 3, 1);
				}
				Base -= LunaticPenalty(enemy);
			} else {
				if (LevelDifference >= 0) {
					Base = 20 + (LevelDifference * 3) + CharacterBonus();
				} else if (LevelDifference == -1) {
					Base = 20 + CharacterBonus();
				} else if (LevelDifference <= -2) {
					Base = System.Math.Max(26 + (LevelDifference * 3), 7);
				}
			}
			return Base;
		}
		
		private void attack(Character attacker, Character defender) {
			Weapon attackers_weapon = attacker.getEquippedWeapon();
			Weapon defenders_weapon = defender.getEquippedWeapon();
			
			WeaponTriangle triangle = attackers_weapon.weaponTriangleValue(defenders_weapon.getType());
			
			SkillLevel rank = attacker.skillForType(attackers_weapon.getType());
			int attack = calculateAttack(attacker, triangle, rank);
			
			if (willHit(calculateHitRate(attacker, triangle, rank))) {
				if (isCriticalHit(calculateCritical(attacker))) {
					attack *= 3;
				}
				defender.damage(attack - defender.getAttributes().getTemporaryAttribute(AttributeName.Defense));
			}
			
			attacker.getLevel().addExperience(calculateExperience(attacker, defender, attack, defender.isDead()));
		}
		
		private int calculateAttack(Character character, WeaponTriangle triangle, SkillLevel rank) {
			int Attack = 0;

			if (character.getEquippedWeapon().isPhysical()) {
				Attack = character.getAttributes().getTemporaryAttribute(AttributeName.Strength);
			} else if (character.getEquippedWeapon().isMagical()) {
				Attack = character.getAttributes().getTemporaryAttribute(AttributeName.Magic);
			} else {
				
			}
			
			if (triangle == WeaponTriangle.Disadvantage) {
				if (rank == SkillLevel.B || rank == SkillLevel.A) {
					Attack--;
				}
			} else if (triangle == WeaponTriangle.Advantage) {
				if (rank == SkillLevel.B || rank == SkillLevel.A) {
					Attack++;
				}
			}
			
			return Attack + character.getEquippedWeapon().getMight() + character.Attack_Recovery_Bonus();
		}
		
		private bool canAttackTwice(Character attacker, Character defender) {
			if ((attacker.getAttributes().getTemporaryAttribute(AttributeName.Speed) 
				- defender.getAttributes().getTemporaryAttribute(AttributeName.Speed)) >= 5) {
				return true;
			}
			return false;
		}
		
		private int calculateAvoid(Character character) {
			return ((character.getAttributes().getTemporaryAttribute(AttributeName.Speed) * 3) 
				+ character.getAttributes().getTemporaryAttribute(AttributeName.Luck)) / 2;
		}
		
		private int calculateHitRateHelper(SkillLevel rank, int multiplier) {
			switch (rank) {
				case SkillLevel.A:
					return (multiplier * 15);
				case SkillLevel.B:
					return (multiplier * 10);
				case SkillLevel.C:
					return (multiplier * 10);
				case SkillLevel.D:
					return (multiplier * 5);
				case SkillLevel.E:
					return (multiplier * 5);
				default:
					return 0;
			}
		}
		
		private bool willHit(int hitrate) {
			int r = (int)UnityEngine.Random.value;
			if (r <= hitrate) {
				return true;
			}
			return false;
		}
		
		private bool isCriticalHit(int critrate) {
			int r = (int)UnityEngine.Random.value;
			if (r <= critrate) {
				return true;
			}
			return false;
		}
		
		private int calculateHitRate(Character character, WeaponTriangle triangle, SkillLevel rank) {
			int HitRate = character.getEquippedWeapon().getHitRate() + character.Hit_Rate_Bonus();
			if (triangle == WeaponTriangle.Advantage) {
				HitRate += calculateHitRateHelper(rank, 1);
			} else if (triangle == WeaponTriangle.Disadvantage) {
				HitRate += calculateHitRateHelper(rank, -1);
			}
			return HitRate + calculateAvoid(character);
		}
		
		private int calculateCritical(Character character) {
			return (character.getAttributes().getTemporaryAttribute(AttributeName.Skill) / 2) 
				+ character.getEquippedWeapon().getCritical();
		}
	}
}

