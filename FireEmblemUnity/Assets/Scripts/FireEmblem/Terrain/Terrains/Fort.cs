using System;

namespace FireEmblem {
	public class Fort : Terrain	{
		public Fort() {
			Defense_Bonus = 2;
			Avoid_Bonus = 20;
			Heal_Percentage = 20;
			Move_Cost = 1;
		}
	}
}

