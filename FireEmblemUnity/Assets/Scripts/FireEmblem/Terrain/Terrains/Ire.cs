using System;

namespace FireEmblem {
	public class Ire : Terrain {
		public Ire() {
			Defense_Bonus = 3;
			Avoid_Bonus = 20;
			Can_Move_Over_Tile = false;
			Can_Stop_On_Tile = false;
		}
	}
}

