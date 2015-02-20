using System;

namespace FireEmblem
{
	public class Lord : Profession
	{
		public Lord ()
		{
			m_Max_Health = 60;
			m_Max_Strength = 28;
			m_Max_Magic = 20;
			m_Max_Skill = 26;
			m_Max_Speed = 27;
			m_Max_Luck = 31;
			m_Max_Defense = 25;
			m_Max_Resistance = 25;
			m_Movement = 5;
			m_UsableWeapons.Add (WeaponType.Sword, SkillLevel.A);
			m_Promotions.Add (new GreatLord ());
			m_Move_Type = MovementType.Land;
			m_Beast_Type = BeastType.None;
		}
	}
}

