using System;

namespace FireEmblem
{
	public class Ire : Terrain
	{
		public Ire ()
		{
			m_Defense_Bonus = 3;
			m_Avoid_Bonus = 20;
			m_Can_Move_Over_Tile = false;
			m_Can_Stop_On_Tile = false;
		}
	}
}

