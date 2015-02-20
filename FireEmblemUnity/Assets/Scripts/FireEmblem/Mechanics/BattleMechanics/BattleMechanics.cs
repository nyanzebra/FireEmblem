using System;

namespace FireEmblem
{
	public class BattleMechanics
	{
		public BattleMechanics ()
		{
		}

		public void forecast(Character attacker, Character defender) {
		}
		
		public void combat(Character attacker, Character defender) {
			
			
			if (attacker.AttackSpeed > defender.AttackSpeed) {
				
				attack(attacker, defender);
			} else {
				
			}
		}
		
		private int LunaticPenalty(Character enemy) {
			return System.Math.Min (3 - enemy.TimesAttacked, 0);
		}
		
		private int CharacterBonus() {
			return 0;
		}
		
		private int calculateExperience(Character subject, Character enemy, int damage, bool kill) {
			//not sure if displayed level or cumulative level
			int LevelDifference = (enemy.DisplayedLevel + enemy.PromotionBonus) - subject.InnerLevel;
			int Base = 0;
			
			if (damage == 0) {
				return 1;
			}
			
			if (!kill) {
				if(LevelDifference >= 0) {
					Base = (31 + LevelDifference) / 3;
				} else if (LevelDifference == -1) {
					Base = 10;
				} else if (LevelDifference <= -2) {
					Base = System.Math.Max((33 + LevelDifference) / 3, 1);
				}
				Base -= LunaticPenalty(enemy);
			} else {
				if(LevelDifference >= 0) {
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
			Weapon aw = attacker.EquippedWeapon;
			Weapon dw = defender.EquippedWeapon;
			
			WeaponTriangle triangle = aw.weaponTriangleValue (dw.Type);
			
			SkillLevel rank = attacker.skillForType(aw.Type);
			int att = calculateAttack(attacker, aw.weaponTriangleValue(dw.Type), rank);
			
			if (doesHit(calculateHitRate(attacker, triangle, rank))) {
				if (isCrit(calculateCritical(attacker))) {
					att = att * 3;
				}
				defender.Health -= (defender.Defense - att);
			}
			
			if (defender.Health <= 0) {
				defender.kill();
			}
			
			attacker.Experience += calculateExperience (attacker, defender, att, defender.Dead);
			if (attacker.Experience >= 100) {
				attacker.DisplayedLevel++;
				attacker.Experience -= 100;
			}
		}
		
		private int calculateAttack(Character character, WeaponTriangle triangle, SkillLevel rank) {
			int Attack = 0;
			if (character.EquippedWeapon.Physical) {
				Attack = character.Strength;
			} else if (character.EquippedWeapon.Magical) {
				Attack = character.Magic;
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
			
			return Attack + character.EquippedWeapon.Might + character.Attack_Recovery_Bonus();
		}
		
		private bool canAttackTwice(Character attacker, Character defender) {
			if ((attacker.Speed - defender.Speed) >= 5) {
				return true;
			}
			return false;
		}
		
		private int calculateAvoid(Character character) {
			return ((character.Speed * 3) + character.Luck) / 2;
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
		
		private bool doesHit(int hitrate) {
			int r = (int) UnityEngine.Random.value;
			if (r <= hitrate) {
				return true;
			}
			return false;
		}
		
		private bool isCrit(int critrate) {
			int r = (int)UnityEngine.Random.value;
			if (r <= critrate) {
				return true;
			}
			return false;
		}
		
		private int calculateHitRate(Character character, WeaponTriangle triangle, SkillLevel rank) {
			int HitRate = character.EquippedWeapon.HitRate + character.Hit_Rate_Bonus();
			if (triangle == WeaponTriangle.Advantage) {
				HitRate += calculateHitRateHelper(rank, 1);
			} else if (triangle == WeaponTriangle.Disadvantage) {
				HitRate += calculateHitRateHelper(rank, -1);
			}
			return HitRate + calculateAvoid (character);
		}
		
		private int calculateCritical(Character character) {
			return (character.Skill / 2) + character.EquippedWeapon.Critical;
		}
	}
}

