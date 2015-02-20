using System;

namespace FireEmblem
{
	public class Bow : Weapon
	{
		public Bow ()
		{
		}

		public override WeaponTriangle weaponTriangleValue(WeaponType type) {
			return WeaponTriangle.None;
		}

		public override int damageMultiplier(BeastType type) {
			if (type == BeastType.Pegasus) {
				return 3;
			}
			return 1;
		}
	}
}

