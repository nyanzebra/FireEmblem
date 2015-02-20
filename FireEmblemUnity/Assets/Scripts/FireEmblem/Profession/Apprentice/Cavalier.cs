using System;

namespace FireEmblem
{
	public class Cavalier : Profession
	{
		public Cavalier ()
		{
			m_Max_Health = 61;
			m_Max_Strength = 27;
			m_Max_Magic = 21;
			m_Max_Skill = 26;
			m_Max_Speed = 26;
			m_Max_Luck = 31;
			m_Max_Defense = 25;
			m_Max_Resistance = 25;
			m_UsableWeapons.Add (WeaponType.Lance, SkillLevel.A);
			m_UsableWeapons.Add (WeaponType.Sword, SkillLevel.A);
			m_Promotions.Add (new GreatKnight ());
			m_Promotions.Add (new Paladin ());
			m_Movement = 7;
			m_Move_Type = MovementType.Land;
			m_Beast_Type = BeastType.Horse;
		}
	}
}

