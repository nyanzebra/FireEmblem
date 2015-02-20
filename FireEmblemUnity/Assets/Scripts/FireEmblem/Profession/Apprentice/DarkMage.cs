using System;

namespace FireEmblem
{
	public class DarkMage : Profession
	{
		public DarkMage ()
		{
			m_Max_Health = 60;
			m_Max_Strength = 20;
			m_Max_Magic = 27;
			m_Max_Skill = 25;
			m_Max_Speed = 25;
			m_Max_Luck = 30;
			m_Max_Defense = 25;
			m_Max_Resistance = 27;
			m_Movement = 6;
			m_UsableWeapons.Add (WeaponType.Tome, SkillLevel.A);
			m_Promotions.Add (new Sorcerer ());
			m_Promotions.Add (new DarkKnight ());
			m_Move_Type = MovementType.Land;
			m_Beast_Type = BeastType.None;
		}
	}
}

