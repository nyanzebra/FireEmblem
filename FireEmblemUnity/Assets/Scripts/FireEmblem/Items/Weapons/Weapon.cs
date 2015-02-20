//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
namespace FireEmblem
{
	public abstract class Weapon : Item
	{
		public Weapon ()
		{
		}

		public WeaponType Type {
			get { return m_Type; }
		}

		public SkillLevel Required_Skill {
			get { return m_Required_Skill; }
		}

		public bool Degradable {
			get { return !m_Undegradable; }
		}

		public Character[] Required_Characters {
			get { return m_Required_Characters; }
		}

		public int Might {
			get { return m_Might; }
		}

		public bool Physical {
			get { return m_Physical; }
		}

		public bool Magical {
			get { return m_Magical; }
		}

		public int HitRate {
			get { return m_Hit_Rate; }
		}

		public int Critical {
			get { return m_Critical; }
		}

		public abstract WeaponTriangle weaponTriangleValue(WeaponType type);

		public abstract int damageMultiplier(BeastType type);

		//protected
		protected WeaponType m_Type = WeaponType.None;
		protected SkillLevel m_Required_Skill = SkillLevel.E;
		protected bool m_Undegradable = false;
		protected Character[] m_Required_Characters;
		protected int m_Might = 1;
		protected bool m_Physical = false;
		protected bool m_Magical = false;
		protected int m_Hit_Rate = 0;
		protected int m_Critical = 0;
		protected int m_Range = 0;
	}
}

