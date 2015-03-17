using System;
using System.Collections.Generic;

namespace FireEmblem {
	public enum AttributeName {
		Health,
		Defense,
		Luck,
		Strength,
		Speed,
		Skill,
		Magic,
		Resistance
	}

	public class Attribute_Pair {
		public Attribute_Pair(int permanent_value, int temporary_value) {
			permanent = permanent_value;
			temporary = temporary_value;
		}
		public int permanent;
		public int temporary;
	}

	public class Attributes {
		public Attributes() {
			Characteristics.Add(AttributeName.Health, new Attribute_Pair(0, 0));
			Characteristics.Add(AttributeName.Defense, new Attribute_Pair(0, 0));
			Characteristics.Add(AttributeName.Luck, new Attribute_Pair(0, 0));
			Characteristics.Add(AttributeName.Magic, new Attribute_Pair(0, 0));
			Characteristics.Add(AttributeName.Resistance, new Attribute_Pair(0, 0));
			Characteristics.Add(AttributeName.Skill, new Attribute_Pair(0, 0));
			Characteristics.Add(AttributeName.Speed, new Attribute_Pair(0, 0));
			Characteristics.Add(AttributeName.Strength, new Attribute_Pair(0, 0));
		}

		public int getPermanentAttribute(AttributeName name) {
			if (Characteristics.ContainsKey(name)) {
				return Characteristics[name].permanent;
			}
			return 0;
		}

		public int getTemporaryAttribute(AttributeName name) {
			if (Characteristics.ContainsKey(name)) {
				return Characteristics[name].temporary;
			}
			return 0;
		}

		public void setPermanentAttribute(AttributeName name, int value) {
			if (Characteristics.ContainsKey(name)) {
				Characteristics[name].permanent = value;
			}
		}

		public void setTemporaryAttribute(AttributeName name, int value) {
			if (Characteristics.ContainsKey(name)) {

				Characteristics[name].temporary = value;
			}
		}

		public void clearAllTemporaryAttributes() {
			foreach (KeyValuePair<AttributeName, Attribute_Pair> pairing in Characteristics) {
				pairing.Value.temporary = 0;
			}
		}

		public int getRating() {
			int rating = Characteristics[AttributeName.Health].permanent + 
				Characteristics[AttributeName.Defense].permanent +
				Characteristics[AttributeName.Luck].permanent + 
				Characteristics[AttributeName.Magic].permanent +
				Characteristics[AttributeName.Resistance].permanent +
				Characteristics[AttributeName.Skill].permanent +
				Characteristics[AttributeName.Speed].permanent +
				Characteristics[AttributeName.Strength].permanent;
			return rating;
		}

		private Dictionary<AttributeName, Attribute_Pair> Characteristics = new Dictionary<AttributeName, Attribute_Pair>();
	}
}

