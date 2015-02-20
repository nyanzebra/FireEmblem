using System;

namespace FireEmblem
{
	public class Fighter : Profession
	{
		public Fighter ()
		{
			m_Max_Health = 60;
			m_Max_Strength = 29;
			m_Max_Magic = 20;
			m_Max_Skill = 26;
			m_Max_Speed = 25;
			m_Max_Luck = 30;
			m_Max_Defense = 25;
			m_Max_Resistance = 23;
			m_Movement = 6;
			m_UsableWeapons.Add (WeaponType.Axe, SkillLevel.A);
			m_Promotions.Add (new Warrior ());
			m_Promotions.Add (new Hero ());
			m_Move_Type = MovementType.Land;
			m_Beast_Type = BeastType.None;
		}
	}
}

