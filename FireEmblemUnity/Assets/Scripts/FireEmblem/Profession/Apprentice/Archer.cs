using System;

namespace FireEmblem
{
	public class Archer : Profession
	{
		public Archer ()
		{
			m_Max_Health = 60;
			m_Max_Strength = 26;
			m_Max_Magic = 20;
			m_Max_Skill = 29;
			m_Max_Speed = 25;
			m_Max_Luck = 30;
			m_Max_Defense = 25;
			m_Max_Resistance = 21;
			m_UsableWeapons.Add (WeaponType.Bow, SkillLevel.B);
			m_Movement = 5;
			m_Promotions.Add (new Sniper ());
			m_Promotions.Add (new BowKnight ());
			m_Move_Type = MovementType.Land;
			m_Beast_Type = BeastType.None;
		}
	}
}

