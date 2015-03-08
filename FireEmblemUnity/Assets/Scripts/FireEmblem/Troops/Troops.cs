using System;
using System.Collections.Generic;

namespace FireEmblem {
	public class Troops {
		private static Troops instance;

		private Troops() {
		}

		public static Troops Instance() {
			if (instance == null) {
				instance = new Troops();
			}
			return instance;
		}

		public void update(List<Character> characters) {
			Characters = characters;
		}

		public List<Character> getCurrentTroops() {
			return Characters;
		}

		public void add(Character character) {
			Characters.Add(character);
		}

		public void remove(Character character) {
			Characters.Remove(character);
		}

		public Character retrieve(String character) {
			return Characters.Find(x => x.getName().Equals(character));
		}

		private List<Character> Characters;
	}
}

