using System;
namespace FireEmblem
{
	public class DarkTome
	{
		public DarkTome ()
		{
		}

		public WeaponTriangle weaponTriangleValue(WeaponType type, TomeType ttype) {
			if (type == WeaponType.Tome) {
				if (ttype == TomeType.AnimaTome) {
					return WeaponTriangle.Advantage;
				} else if (ttype == TomeType.LightTome){
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

