using System;

namespace FireEmblem
{
	public class Fort : Terrain
	{
		public Fort ()
		{
			m_Defense_Bonus = 2;
			m_Avoid_Bonus = 20;
			m_Heal_Percentage = 20;
			m_Move_Cost = 1;
		}
	}
}

