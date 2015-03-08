using System;
using System.Collections.Generic;

namespace FireEmblem {
	public class Equipment {
		public Equipment() {
		}

		public void remove(int position) {
			Items[position] = null;
		}

		public void add(Item item) {
			for (int i = 0; i < 5; ++i) {
				if (Items[i] != null) {
					Items[i] = item;
				}
			}
		}

		public bool hasItem(int position) {
			return (Items[position] != null) ? true : false;
		}

		public Item getItem(int position) {
			return Items[position];
		}

		public void swap(int a, int b) {
			Item temp = Items[a];
			Items[a] = Items[b];
			Items[b] = temp;
		}

		public bool isFull() {
			if (Items[4] != null) {
				return true;
			}
			return false;
		}

		public void clear() {
			for (int i = 0; i < 5; ++i) {
				Items[i] = null;
			}
		}

		private Item[] Items = new Item[5];
	}
}

