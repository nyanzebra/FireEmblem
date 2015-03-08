using System;
using System.Collections.Generic;
using UnityEngine;

namespace FireEmblem {
	public abstract class Item 	{
		public Item() {
		}

		public string getName() {
			return Name;
		}

		public string getDescriptions() {
			return Description;
		}

		public int getDurability() {
			return Durability;
		}

		public bool isStackable() {
			return Is_Stackable;
		}

		public List<Profession> getNecessaryProfessions() {
			return Necessary_Professions;
		}

		protected string Description;
		protected int Durability;
		protected string Name;
		protected int Cost;
		protected bool Is_Stackable;
		protected List<Profession> Necessary_Professions;
		protected Sprite[] Sprites;
	}
}

