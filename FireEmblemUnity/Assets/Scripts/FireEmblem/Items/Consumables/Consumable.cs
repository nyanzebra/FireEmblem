using System;
namespace FireEmblem {
	public class Attribute_Effect_Pair {
		public Attribute_Effect_Pair(AttributeName name, int value) {
			Name = name;
			Value = value;
		}

		AttributeName Name;
		int Value;
	}

	public abstract class Consumable : Item {
		public Consumable() {
		}

		public abstract Attribute_Effect_Pair use();
	}
}

