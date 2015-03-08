using System;

namespace FireEmblem {
	public abstract class Terrain {
		public Terrain() {
		}

		public void setAsEnemySpawn() {
			Enemy_Spawn_Position = true;
		}

		public bool canMoveOverTile() {
			return Can_Move_Over_Tile;
		}

		public int getDefenseBonus() {
			return Defense_Bonus;
		}

		public int getAvoidBonus() {
			return Avoid_Bonus;
		}

		public int getHealPercentage() {
			return Heal_Percentage;
		}

		public int getMoveCost() {
			return Move_Cost;
		}

		public MovementType getHighestMovementRequirement() {
			return Highest_Movement_Requirement;
		}

		protected int Defense_Bonus = 0;
		protected int Avoid_Bonus = 0;
		protected int Heal_Percentage = 0;
		protected int Move_Cost = 0;
		protected bool Can_Move_Over_Tile = true;
		protected bool Enemy_Spawn_Position = false;
		protected MovementType Highest_Movement_Requirement = MovementType.Land;
		protected bool Can_Stop_On_Tile = true;
	}
}

