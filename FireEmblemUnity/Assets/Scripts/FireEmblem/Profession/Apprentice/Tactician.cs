using System;

namespace FireEmblem
{
	public class Tactician : Profession
	{
		public Tactician ()
		{
			m_Max_Health = 60;
			m_Max_Strength = 25;
			m_Max_Magic = 25;
			m_Max_Skill = 25;
			m_Max_Speed = 25;
			m_Max_Luck = 30;
			m_Max_Defense = 25;
			m_Max_Resistance = 25;
			m_Movement = 5;
			m_UsableWeapons.Add (WeaponType.Tome, SkillLevel.C);
			m_UsableWeapons.Add (WeaponType.Sword, SkillLevel.C);
			m_Promotions.Add (new Grandmaster());
			m_Move_Type = MovementType.Land;
			m_Beast_Type = BeastType.None;
		}
	}
}

