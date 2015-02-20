using System;

namespace FireEmblem
{
	public class Mercenary : Profession
	{
		public Mercenary ()
		{
			m_Max_Health = 60;
			m_Max_Strength = 26;
			m_Max_Magic = 20;
			m_Max_Skill = 28;
			m_Max_Speed = 26;
			m_Max_Luck = 30;
			m_Max_Defense = 25;
			m_Max_Resistance = 23;
			m_Movement = 5;
			m_UsableWeapons.Add(WeaponType.Sword, SkillLevel.A);
			m_Promotions.Add (new BowKnight ());
			m_Promotions.Add (new Hero ());
			m_Move_Type = MovementType.Land;
			m_Beast_Type = BeastType.None;
		}
	}
}

