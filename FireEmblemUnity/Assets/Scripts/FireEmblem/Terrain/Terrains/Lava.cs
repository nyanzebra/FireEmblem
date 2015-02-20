using System;

namespace FireEmblem
{
	public class Lava : Terrain
	{
		public Lava ()
		{
			m_Highest_Movement_Requirement = MovementType.Air;
			m_Can_Stop_On_Tile = false;
		}
	}
}

