using System;

namespace FireEmblem
{
	public class Taguel : Profession
	{
		public Taguel ()
		{
			m_Max_Health = 80;
			m_Max_Strength = 35;
			m_Max_Magic = 30;
			m_Max_Skill = 40;
			m_Max_Speed = 40;
			m_Max_Luck = 45;
			m_Max_Defense = 35;
			m_Max_Resistance = 30;
			m_Movement = 6;
			m_UsableWeapons.Add (WeaponType.Stone, SkillLevel.A);
			//no promotions
		}
	}
}

