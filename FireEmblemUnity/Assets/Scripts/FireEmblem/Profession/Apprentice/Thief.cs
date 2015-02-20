using System;

namespace FireEmblem
{
	public class Thief : Profession
	{
		public Thief ()
		{
			m_Max_Health = 60;
			m_Max_Strength = 22;
			m_Max_Magic = 20;
			m_Max_Skill = 30;
			m_Max_Speed = 28;
			m_Max_Skill = 30;
			m_Max_Defense = 21;
			m_Max_Resistance = 20;
			m_UsableWeapons.Add (WeaponType.Sword, SkillLevel.A);
			m_Promotions.Add (new Trickster ());
			m_Promotions.Add (new Assassin ());
			m_Movement = 5;
			m_Move_Type = MovementType.Land;
			m_Beast_Type = BeastType.None;
		}
	}
}

