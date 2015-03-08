using System;
using System.Collections.Generic;

namespace FireEmblem {
	public class Inventory {
		private static Inventory instance;

		private Inventory() {
			init();
		}

		public static Inventory Instance() {
			if (instance == null) {
				instance = new Inventory();
			}
			return instance;
		}

		public Dictionary<ItemType, List<Item>> getCurrentInventory() {
			return Caravan;
		}

		public void updateItems(Dictionary<ItemType, List<Item>> inventory) {
			Caravan = inventory;
		}

		public void addItem(ItemType type, Item item) {
			Caravan[type].Add(item);
		}

		public void removeItem(ItemType type, Item item) {
			Caravan[type].Remove(item);
		}

		public List<Item> selectCategory(ItemType type) {
			return Caravan[type];
		}

		private void init() {
			List<Item> axes = new List<Item>();
			Caravan.Add(ItemType.Axes, axes);

			List<Item> bows = new List<Item>();
			Caravan.Add(ItemType.Bows, bows);

			List<Item> items = new List<Item>();
			Caravan.Add(ItemType.Items, items);

			List<Item> lances = new List<Item>();
			Caravan.Add(ItemType.Lances, lances);

			List<Item> staves = new List<Item>();
			Caravan.Add(ItemType.Staves, staves);

			List<Item> stones = new List<Item>();
			Caravan.Add(ItemType.StonesAndMisc, stones);

			List<Item> swords = new List<Item>();
			Caravan.Add(ItemType.Swords, swords);

			List<Item> tomes = new List<Item>();
			Caravan.Add(ItemType.Tomes, tomes);
		}

		private Dictionary<ItemType, List<Item>> Caravan;
	}
}

