using System;
using System.Collections.Generic;

namespace FireEmblem
{
	public class Troops
	{
		private static Troops instance;
		private Troops ()
		{
		}

		public static Troops Instance() {
			if (instance == null) {
				instance = new Troops();
			}
			return instance;
		}

		public void update(List<Character> characters) {
			m_Characters = characters;
		}

		public List<Character> CurrentTroops {
			get { return m_Characters; }
		}

		public void add(Character character) {
			m_Characters.Add (character);
		}

		public void remove(Character character) {
			m_Characters.Remove (character);
		}

		public Character retrieve(String character) {
			return m_Characters.Find (x => x.Name.Equals(character));
		}

		private List<Character> m_Characters;
	}
}

