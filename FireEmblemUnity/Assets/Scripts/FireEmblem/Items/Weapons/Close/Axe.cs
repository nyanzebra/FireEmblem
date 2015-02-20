using System;

namespace FireEmblem
{
	public class Axe
	{
		public Axe ()
		{
		}

		public WeaponTriangle weaponTriangleValue(WeaponType type) {
			if (type == WeaponType.Lance) {
				return WeaponTriangle.Advantage;
			} else if (type == WeaponType.Sword) {
				return WeaponTriangle.Disadvantage;
			}
			return WeaponTriangle.None;
		}
		
		public virtual int damageMultiplier(BeastType type) {
			return 1;
		}
	}
}

