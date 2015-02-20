using System;
using System.Collections.Generic;

namespace FireEmblem
{
	abstract public class Profession
	{
		public Profession ()
		{
		}

		protected bool m_CanUpgrade;
		protected static Dictionary<WeaponType, SkillLevel>  m_UsableWeapons;
		protected static List<Promotion> m_Promotions;

		//stats
		protected uint m_Max_Health;
		protected uint m_Max_Defense;
		protected uint m_Max_Constitution;
		protected uint m_Max_AttackSpeed;
		protected uint m_Max_Affinity;
		protected uint m_Max_Luck;
		protected uint m_Max_Strength;
		protected uint m_Max_Speed;
		protected uint m_Max_Skill;
		protected uint m_Max_Magic;
		protected uint m_Max_Resistance;
		protected uint m_Movement;
		protected MovementType m_Move_Type;
		protected BeastType m_Beast_Type;
	}
}

