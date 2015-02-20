using System;

namespace FireEmblem
{
	public class WyvernRider : Profession
	{
		public WyvernRider ()
		{
			m_Max_Health = 60;
			m_Max_Strength = 28;
			m_Max_Magic = 20;
			m_Max_Skill = 24;
			m_Max_Speed = 24;
			m_Max_Luck = 29;
			m_Max_Defense = 30;
			m_Max_Resistance = 20;
			m_Movement = 7;
			m_UsableWeapons.Add (WeaponType.Axe, SkillLevel.A);
			m_Promotions.Add (new WyvernLord());
			m_Promotions.Add (new GriffonRider());
			m_Move_Type = MovementType.Air;
			m_Beast_Type = BeastType.Wyvern;
		}
	}
}

