using System;

namespace FireEmblem {
	public class Sword : Weapon {
		public Sword()	{
		}

		public override WeaponTriangle weaponTriangleValue(WeaponType type) {
			if (type == WeaponType.Axe) {
				return WeaponTriangle.Advantage;
			} else if (type == WeaponType.Lance) {
				return WeaponTriangle.Disadvantage;
			}
			return WeaponTriangle.None;
		}
		
		public override int damageMultiplier(BeastType type) {
			return 1;
		}
	}
}

