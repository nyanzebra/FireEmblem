using System;

namespace FireEmblem {
	public class Axe : Weapon {
		public Axe() {
		}

		public override WeaponTriangle weaponTriangleValue(WeaponType type) {
			if (type == WeaponType.Lance) {
				return WeaponTriangle.Advantage;
			} else if (type == WeaponType.Sword) {
				return WeaponTriangle.Disadvantage;
			}
			return WeaponTriangle.None;
		}
		
		public override int damageMultiplier(BeastType type) {
			return 1;
		}
	}
}

