using System;

namespace FireEmblem {
	public class Cliff : Terrain {
		public Cliff() {
			Move_Cost = 1;
			Highest_Movement_Requirement = MovementType.Air;
		}
	}
}

