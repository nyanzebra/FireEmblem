using System;

namespace FireEmblem
{
	public class Myrmidon : Profession
	{
		public Myrmidon ()
		{
			m_Max_Health = 60;
			m_Max_Strength = 24;
			m_Max_Magic = 22;
			m_Max_Skill = 27;
			m_Max_Speed = 28;
			m_Max_Luck = 30;
			m_Max_Defense = 22;
			m_Max_Resistance = 24;
			m_UsableWeapons.Add (WeaponType.Sword, SkillLevel.A);
			m_Movement = 5;
			m_Promotions.Add (new Swordmaster ());
			m_Promotions.Add (new Assassin ());
			m_Move_Type = MovementType.Land;
			m_Beast_Type = BeastType.None;
		}
	}
}

