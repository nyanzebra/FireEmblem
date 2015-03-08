using System;

namespace FireEmblem {
	public class Lava : Terrain	{
		public Lava() {
			Highest_Movement_Requirement = MovementType.Air;
			Can_Stop_On_Tile = false;
		}
	}
}

