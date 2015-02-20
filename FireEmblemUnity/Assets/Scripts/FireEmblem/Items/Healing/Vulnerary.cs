using System;

namespace FireEmblem
{
	public class Vulnerary : Item
	{
		public Vulnerary ()
		{
			m_Cost = 300;
			m_Durability = 3;
			m_Name = "Vulnerary";
			m_Description = "Restores 10 HP";
			m_Is_Stackable = false;
		}


	}
}

