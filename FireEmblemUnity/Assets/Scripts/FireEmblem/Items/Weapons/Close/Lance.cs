using System;

namespace FireEmblem
{
	public class Lance
	{
		public Lance ()
		{
		}

		public WeaponTriangle weaponTriangleValue(WeaponType type) {
			if (type == WeaponType.Sword) {
				return WeaponTriangle.Advantage;
			} else if (type == WeaponType.Axe) {
				return WeaponTriangle.Disadvantage;
			}
			return WeaponTriangle.None;
		}
		
		public virtual int damageMultiplier(BeastType type) {
			return 1;
		}
	}
}

