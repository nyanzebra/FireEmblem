using System;

namespace FireEmblem
{
	public class Pillar : Terrain
	{
		public Pillar ()
		{
			m_Defense_Bonus = 1;
			m_Avoid_Bonus = 10;
			m_Move_Cost = 1;
		}
	}
}

