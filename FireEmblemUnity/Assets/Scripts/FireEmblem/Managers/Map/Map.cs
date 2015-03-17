using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace FireEmblem {
	public class Map : MonoBehaviour {
		void Start() {

		}

		void Update() {

		}

		public Map() {
		}

		public void loadMap(MapTile[,] tiles) {
			MapData.Instance().loadTiles(tiles);
		}

		private bool isTraversableTile(int x_coordinate, int y_coordinate) {
			if (SelectedTile.Character.getProfession().getMovementType() >= MapData.Instance().getTile(x_coordinate, y_coordinate).Terrain.getHighestMovementRequirement()) {
				if (MapData.Instance().getTile(x_coordinate, y_coordinate).Terrain.isTraversable()) {
					return true;
				}
			}
			return false;
		}

		public void moveCharacter(Vector2 original_position, Vector2 new_position) {
			MapData.Instance().placeCharacter(new_position, MapData.Instance().takeCharacter(original_position));
		}

		private void calculateMovementArea(Vector2 position) {
			SelectedTile = MapData.Instance().getTile((int)position.x, (int)position.y);
			int character_movement = SelectedTile.Character.getProfession().getMovement();
			
			Vector2 upper_bounds = new Vector2();
			upper_bounds.x = position.x + character_movement;
			upper_bounds.y = position.y + character_movement;
			
			Vector2 lower_bounds = new Vector2();
			lower_bounds.x = position.x - character_movement;
			lower_bounds.y = position.y - character_movement;
			
			SelectedCharacterMovementTiles = calculateArea((int)position.x, lower_bounds, upper_bounds);
		}

		public void calculateAttackArea(Vector2 position) {
			SelectedTile = MapData.Instance().getTile((int)position.x, (int)position.y);
			int character_movement = SelectedTile.Character.getProfession().getMovement();
			
			Vector2 upper_bounds = new Vector2();
			upper_bounds.x = position.x + character_movement + 1;
			upper_bounds.y = position.y + character_movement + 1;
			
			Vector2 lower_bounds = new Vector2();
			lower_bounds.x = position.x - character_movement - 1;
			lower_bounds.y = position.y - character_movement - 1;

			SelectedCharacterAttackTiles = calculateArea((int)position.x, lower_bounds, upper_bounds).Intersect(SelectedCharacterMovementTiles).ToList();
		}

		private List<MapTile> calculateArea(int reference_point, Vector2 lower_bounds, Vector2 upper_bounds) {
			List<MapTile> calculatedArea = new List<MapTile>();

			for (int x_position = (int) lower_bounds.x; x_position < (int) upper_bounds.x; ++x_position) {
				if (x_position >= 0 && x_position <= MapData.Instance().getDomainBoundary()) {
					int new_y_lower_bound = (int)lower_bounds.y + System.Math.Abs(x_position - (int)reference_point);
					int new_y_upper_bound = (int)lower_bounds.y - System.Math.Abs(x_position - (int)reference_point);
					
					for (int y_position = new_y_lower_bound; y_position < new_y_upper_bound; ++y_position) {
						if (y_position >= 0 && y_position <= MapData.Instance().getRangeBoundary()) {
							if (isTraversableTile(x_position, y_position)) {
								calculatedArea.Add(MapData.Instance().getTile(x_position, y_position));
							}
						}
					}
				}
			}

			return calculatedArea;
		}

		public void showPossibleMoves(Vector2 coordinates) {
			if (MapData.Instance().getTile(coordinates).Character != null) {
				calculateMovementArea(coordinates);
				calculateAttackArea(coordinates);
			}
		}

		public void showPossibleMoves(int x_coordinate, int y_coordinate) {
			if (MapData.Instance().getTile(x_coordinate, y_coordinate).Character != null) {
				calculateMovementArea(new Vector2(x_coordinate, y_coordinate));
				calculateAttackArea(new Vector2(x_coordinate, y_coordinate));
			}
		}

		public void clearHighlights() {
			for (int x_position = 0; x_position < MapData.Instance().getTiles().GetLength(0); ++x_position) {
				for (int y_position = 0; y_position < MapData.Instance().getTiles().GetLength(1); ++ y_position) {
					//
				}
			}
		}
		
		public void showAllEnemiesMovementArea() {
			for (int x_position = 0; x_position < MapData.Instance().getTiles().GetLength(0); ++x_position) {
				for (int y_position = 0; y_position < MapData.Instance().getTiles().GetLength(1); ++y_position) {
					if (MapData.Instance().getTiles()[x_position, y_position].Character != null && MapData.Instance().getTiles()[x_position, y_position].Character is Enemy) {
						showPossibleMoves(x_position, y_position);
					}
				}
			}
		}

		private List<MapTile> SelectedCharacterMovementTiles = new List<MapTile>();
		private List<MapTile> SelectedCharacterAttackTiles = new List<MapTile>();
		private MapTile SelectedTile = new MapTile();
	}
}

