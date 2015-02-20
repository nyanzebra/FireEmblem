using System;

namespace FireEmblem
{
	public abstract class Terrain
	{
		public Terrain ()
		{
		}

		public void setAsEnemySpawn() {
			m_Enemy_Spawn_Position = true;
		}

		public bool canMoveOverTile {
			get { return m_Can_Move_Over_Tile; }
			set { m_Can_Move_Over_Tile = value; }
		}

		public uint DefenseBonus {
			get { return m_Defense_Bonus; }
		}

		public uint AvoidBonus {
			get { return m_Avoid_Bonus; }
		}

		public uint HealPercentage {
			get { return m_Heal_Percentage; }
		}

		public uint MoveCost {
			get { return m_Move_Cost; }
		}

		protected uint m_Defense_Bonus = 0;
		protected uint m_Avoid_Bonus = 0;
		protected uint m_Heal_Percentage = 0;
		protected uint m_Move_Cost = 0;
		protected bool m_Can_Move_Over_Tile = true;
		protected bool m_Enemy_Spawn_Position = false;
		protected MovementType m_Highest_Movement_Requirement = MovementType.Land;
		protected bool m_Can_Stop_On_Tile = true;
	}
}

