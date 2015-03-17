using System;
using System.Collections.Generic;
using UnityEngine;

namespace FireEmblem {
	public struct MapTile {
		public MapTile(Terrain	terrain, Character character, Item item) {
			Terrain = terrain;
			Character = character;
			Item = item;
			Is_Traversable = true;
		}

		public Terrain Terrain;
		public Character Character;
		public Item Item;
		public bool Is_Traversable;
	}

	public class MapData {
		private static MapData instance;

		private MapData() {
		}

		public static MapData Instance() {
			if (instance == null) {
				instance = new MapData();
			}
			return instance;
		}

		public MapTile getTile(int x_coordinate, int y_coordinate) {
			return Tiles[x_coordinate, y_coordinate];
		}

		public MapTile getTile(Vector2 coordinates) {
			return Tiles[(int)coordinates.x, (int)coordinates.y];
		}

		public bool isTraversable(int x_coordinate, int y_coordinate) {
			MapTile tile = Tiles[x_coordinate, y_coordinate];
			if (tile.Is_Traversable && tile.Terrain.isTraversable()) {
				return true;
			}
			return false;
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
			Max_Number_Of_Characters = number_of_characters;
		}

		public Character takeCharacter(int x_coordinate, int y_coordinate) {
			MapTile tile = Tiles[x_coordinate, y_coordinate];
			Character character = tile.Character;
			tile.Character = null;
			tile.Is_Traversable = true;
			return character;
		}

		public void placeCharacter(int x_coordinate, int y_coordinate, Character character) {
			MapTile tile = Tiles[x_coordinate, y_coordinate];
			tile.Character = character;
			tile.Is_Traversable = false;
		}

		public Character takeCharacter(Vector2 coordinates) {
			MapTile tile = Tiles[(int)coordinates.x, (int)coordinates.y];
			Character character = tile.Character;
			tile.Character = null;
			tile.Is_Traversable = true;
			return character;
		}
		
		public void placeCharacter(Vector2 coordinates, Character character) {
			MapTile tile = Tiles[(int)coordinates.x, (int)coordinates.y];
			tile.Character = character;
			tile.Is_Traversable = false;
		}

		public void setMaxAmountOfEnemies(int number_of_enemies) {
			Max_Number_Of_Enemies = number_of_enemies;
		}

		public void loadTiles(MapTile[,] tiles) {
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
		private int Max_Number_Of_Enemies = 0;
		private MapTile[,] Tiles;
		private Objective Map_Objective;
	}
}

