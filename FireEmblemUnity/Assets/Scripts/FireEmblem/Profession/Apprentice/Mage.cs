using System;

namespace FireEmblem
{
	public class Mage : Profession
	{
		public Mage ()
		{
			m_Max_Health = 60;
			m_Max_Strength = 20;
			m_Max_Magic = 28;
			m_Max_Skill = 27;
			m_Max_Speed = 26;
			m_Max_Luck = 30;
			m_Max_Defense = 21;
			m_Max_Resistance = 25;
			m_Movement = 5;
			m_UsableWeapons.Add (WeaponType.Tome, SkillLevel.A);
			m_Promotions.Add (new DarkKnight ());
			m_Promotions.Add (new Sage ());
			m_Move_Type = MovementType.Land;
			m_Beast_Type = BeastType.None;
		}
	}
}

