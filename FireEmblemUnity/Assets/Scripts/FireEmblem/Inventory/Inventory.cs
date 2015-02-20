using System;
using System.Collections.Generic;

namespace FireEmblem
{
	public class Inventory
	{
		private static Inventory instance;

		private Inventory ()
		{
			init ();
		}

		public static Inventory Instance() {
			if (instance == null) {
				instance = new Inventory();
			}

			return instance;
		}

		public Dictionary<ItemType, List<Item>> CurrentInventory {
			get { return m_Inventory; }
		}

		public void update (Dictionary<ItemType, List<Item>> inventory) {
			m_Inventory = inventory;
		}

		public void add(ItemType type, Item item) {
			m_Inventory [type].Add (item);
		}

		public void remove(ItemType type, Item item) {
			m_Inventory [type].Remove (item);
		}

		public List<Item> selectCategory(ItemType type) {
			return m_Inventory [type];
		}

		private void init() {
			List<Item> axes = new List<Item> ();
			m_Inventory.Add (ItemType.Axes, axes);

			List<Item> bows = new List<Item> ();
			m_Inventory.Add (ItemType.Bows, bows);

			List<Item> items = new List<Item> ();
			m_Inventory.Add (ItemType.Items, items);

			List<Item> lances = new List<Item> ();
			m_Inventory.Add (ItemType.Lances, lances);

			List<Item> staves = new List<Item> ();
			m_Inventory.Add (ItemType.Staves, staves);

			List<Item> stones = new List<Item> ();
			m_Inventory.Add (ItemType.StonesAndMisc, stones);

			List<Item> swords = new List<Item> ();
			m_Inventory.Add (ItemType.Swords, swords);

			List<Item> tomes = new List<Item> ();
			m_Inventory.Add (ItemType.Tomes, tomes);
		}


		private Dictionary<ItemType, List<Item>> m_Inventory;
	}
}

