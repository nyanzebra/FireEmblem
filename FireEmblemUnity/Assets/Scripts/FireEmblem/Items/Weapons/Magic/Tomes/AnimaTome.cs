using System;

namespace FireEmblem
{
	public class AnimaTome
	{
		public AnimaTome ()
		{
		}

		public WeaponTriangle weaponTriangleValue(WeaponType type, TomeType ttype) {
			if (type == WeaponType.Tome) {
				if (ttype == TomeType.LightTome) {
					return WeaponTriangle.Advantage;
				} else if (ttype == TomeType.DarkTome){
					return WeaponTriangle.Disadvantage;
				} 
			}
			return WeaponTriangle.None;
		}
		
		public int damageMultiplier(BeastType type) {
			return 1;
		}
	}
}

