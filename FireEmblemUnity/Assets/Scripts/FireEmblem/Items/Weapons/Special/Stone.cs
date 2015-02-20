using System;

namespace FireEmblem
{
	public class Stone
	{
		public Stone ()
		{
		}

		public WeaponTriangle weaponTriangleValue(WeaponType type) {
			return WeaponTriangle.None;
		}
		
		public int damageMultiplier(BeastType type) {
			return 1;
		}
	}
}

