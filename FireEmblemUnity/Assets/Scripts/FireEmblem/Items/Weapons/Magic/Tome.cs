using System;

namespace FireEmblem
{
	public abstract class Tome
	{
		public Tome ()
		{
		}

		public abstract WeaponTriangle weaponTriangleValue (WeaponType type);
		
		public virtual int damageMultiplier(BeastType type) {
			return 1;
		}
	}
}

