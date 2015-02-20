using System;
using System.Collections.Generic;

namespace FireEmblem
{
	public class Map
	{
		private static Map instance;
		private Map ()
		{
		}

		public static Map Instance() {
			if (instance == null) {
				instance = new Map();
			}
			return instance;
		}

		private List<Character> m_Characters;
		private List<Character> m_Friendlies;
		private List<Character> m_Enemies;
	}
}

