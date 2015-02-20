using System;

namespace FireEmblem
{
	public class WindTome
	{
		public WindTome ()
		{
		}

		public WeaponTriangle weaponTriangleValue(WeaponType type, TomeType ttype, AnimaType atype) {
			if (type == WeaponType.Tome && ttype == TomeType.AnimaTome) {
				if (atype == AnimaType.Thunder) {
					return WeaponTriangle.Advantage;
				} else if (atype == AnimaType.Fire){
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

