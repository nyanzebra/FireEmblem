using System;

namespace FireEmblem
{
	public class HighGround : Terrain
	{
		public HighGround ()
		{
			m_Move_Cost = 1;
			m_Highest_Movement_Requirement = MovementType.Air;
		}
	}
}

