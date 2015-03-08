using System;

namespace FireEmblem {
	public class HighGround : Terrain {
		public HighGround()	{
			Move_Cost = 1;
			Highest_Movement_Requirement = MovementType.Air;
		}
	}
}

