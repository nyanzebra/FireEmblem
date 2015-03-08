using System;
using System.Collections.Generic;

namespace FireEmblem {
	public struct MapTile {
		public Terrain Terrain;
		public Character Character;
		public Item Item;
		public bool Is_Traversable;
	}

	public class Map {
		private static Map instance;

		private Map() {
		}

		public static Map Instance() {
			if (instance == null) {
				instance = new Map();
			}
			return instance;
		}

		public MapTile getSelectedTile(int x_coordinate, int y_coordinate) {
			return Tiles[x_coordinate, y_coordinate];
		}

		public void setObjective(Objective objective) {
			Map_Objective = objective;
		}

		public void setDimensions(int width, int height) {
			Tiles = new MapTile[width, height];

			Domain_Boundary = width;
			Range_Boundary = height;
		}

		public void setMaxAmountOfCharacters(int number_of_characters) {

		}

		public void update(MapTile[,] tiles) {
			Tiles = tiles;
		}

		public MapTile[,] getTiles() {
			return Tiles;
		}

		public int getDomainBoundary() {
			return Domain_Boundary;
		}

		public int getRangeBoundary() {
			return Range_Boundary;
		}

		private int Domain_Boundary = 0;
		private int Range_Boundary = 0;
		private int Max_Number_Of_Characters = 0;
		private MapTile[,] Tiles;
		private Objective Map_Objective;
	}
}

