using System;
namespace FireEmblem {
	public class Rapier : Sword {
		public Rapier() {
			Name = "Rapier";
			Might = 5;
			Hit_Rate = 90;
			Critical_Hit_Rate = 10;
			Range = 1;
			Durability = 35;
			Cost = 1600;
		}

		public override int damageMultiplier(BeastType type) {
			if (type == BeastType.Armor || type == BeastType.Horse) {
				return 3;
			}
			return base.damageMultiplier(type);
		}
	}
}

