using System;

namespace FireEmblem
{
	public class Barbarian : Profession
	{
		public Barbarian ()
		{
			m_Max_Health = 60;
			m_Max_Strength = 30;
			m_Max_Magic = 20;
			m_Max_Skill = 23;
			m_Max_Speed = 27;
			m_Max_Luck = 30;
			m_Max_Defense = 22;
			m_Max_Resistance = 20;
			m_Movement = 5;
			m_Promotions.Add (new Berserker ());
			m_Promotions.Add (new Warrior ());
			m_UsableWeapons.Add (WeaponType.Axe, SkillLevel.A);
			m_Move_Type = MovementType.Land;
			m_Beast_Type = BeastType.None;
		}
	}
}

