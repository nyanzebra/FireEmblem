using System;

namespace FireEmblem {
	public class Vulnerary : Consumable {
		public Vulnerary() {
			Cost = 300;
			Durability = 3;
			Name = "Vulnerary";
			Description = "Restores 10 HP";
			Is_Stackable = false;
		}

		public override Attribute_Effect_Pair use() {
			Durability--;
			return new Attribute_Effect_Pair(AttributeName.Health, 10);
		}
	}
}

