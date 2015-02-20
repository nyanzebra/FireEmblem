using System;

namespace FireEmblem
{
	public class Manakete : Profession
	{
		public Manakete ()
		{
			m_Max_Health = 80;
			m_Max_Strength = 40;
			m_Max_Magic = 35;
			m_Max_Skill = 35;
			m_Max_Speed = 35;
			m_Max_Luck = 45;
			m_Max_Defense = 40;
			m_Max_Resistance = 40;
			m_Movement = 6;
			m_UsableWeapons.Add (WeaponType.Stone, SkillLevel.A);
			//no promotions
		}
	}
}

