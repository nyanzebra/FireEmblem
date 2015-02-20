using System;

namespace FireEmblem
{
	public class Villager : Profession
	{
		public Villager ()
		{
			m_Max_Health = 60;
			m_Max_Strength = 21;
			m_Max_Magic = 20;
			m_Max_Skill = 19;
			m_Max_Speed = 20;
			m_Max_Luck = 33;
			m_Max_Defense = 20;
			m_Max_Resistance = 20;
			m_UsableWeapons.Add (WeaponType.Lance, SkillLevel.A);
			//no promotions
		}
	}
}

