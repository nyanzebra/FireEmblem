using System;

namespace FireEmblem
{
	public class LightTome
	{
		public LightTome ()
		{
		}

		public WeaponTriangle weaponTriangleValue(WeaponType type, TomeType ttype) {
			if (type == WeaponType.Tome) {
				if (ttype == TomeType.DarkTome) {
					return WeaponTriangle.Advantage;
				} else if (ttype == TomeType.AnimaTome){
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

