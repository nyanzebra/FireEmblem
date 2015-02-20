using System;

namespace FireEmblem
{
	public class Dancer : Profession
	{
		public Dancer ()
		{
			m_Max_Health = 80;
			m_Max_Strength = 30;
			m_Max_Magic = 30;
			m_Max_Skill = 40;
			m_Max_Speed = 40;
			m_Max_Luck = 45;
			m_Max_Defense = 30;
			m_Max_Resistance = 30;
			m_Movement = 5;
			//no promotions
			//no weapons
		}
	}
}

