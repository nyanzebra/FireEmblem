using System;

namespace FireEmblem
{
	public class Knight : Profession
	{
		public Knight ()
		{
			m_Max_Health = 60;
			m_Max_Strength = 30;
			m_Max_Magic = 20;
			m_Max_Skill = 26;
			m_Max_Speed = 23;
			m_Max_Luck = 30;
			m_Max_Defense = 30;
			m_Max_Resistance = 22;
			m_Movement = 5;
			m_UsableWeapons.Add (WeaponType.Lance, SkillLevel.A);
			m_Promotions.Add (new General ());
			m_Promotions.Add (new GreatKnight ());
			m_Move_Type = MovementType.Land;
			m_Beast_Type = BeastType.None;
		}
	}
}

