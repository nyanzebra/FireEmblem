using System;

namespace FireEmblem
{
	public class Cliff : Terrain
	{
		public Cliff ()
		{
			m_Move_Cost = 1;
			m_Highest_Movement_Requirement = MovementType.Air;
		}
	}
}

