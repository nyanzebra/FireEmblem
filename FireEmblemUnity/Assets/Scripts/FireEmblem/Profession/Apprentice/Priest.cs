using System;

namespace FireEmblem
{
	public class Priest : Profession
	{
		public Priest ()
		{
			m_Max_Health = 60;
			m_Max_Strength = 22;
			m_Max_Magic = 25;
			m_Max_Skill = 24;
			m_Max_Speed = 25;
			m_Max_Luck = 30;
			m_Max_Defense = 22;
			m_Max_Resistance = 27;
			m_Movement = 5;
			m_UsableWeapons.Add (WeaponType.Staff, SkillLevel.A);
			m_Promotions.Add (new WarMonk ());
			m_Promotions.Add (new Sage ());
			m_Move_Type = MovementType.Land;
			m_Beast_Type = BeastType.None;
		}
	}
}

