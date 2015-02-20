using System;

namespace FireEmblem
{
	public class PegasusKnight : Profession
	{
		public PegasusKnight ()
		{
			m_Max_Health = 60;
			m_Max_Strength = 24;
			m_Max_Magic = 23;
			m_Max_Skill = 28;
			m_Max_Speed = 27;
			m_Max_Luck = 30;
			m_Max_Defense = 22;
			m_Max_Resistance = 25;
			m_Movement = 7;
			m_UsableWeapons.Add (WeaponType.Lance, SkillLevel.A);
			m_Promotions.Add (new FalconKnight ());
			m_Promotions.Add (new DarkFlier ());
			m_Move_Type = MovementType.Air;
			m_Beast_Type = BeastType.Pegasus;
		}
	}
}

