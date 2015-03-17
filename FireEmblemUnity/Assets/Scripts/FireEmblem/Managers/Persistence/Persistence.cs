using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

namespace FireEmblem {
	public class Persistence {
		public Persistence() {
		}

		public void save() {
			BinaryFormatter bf = new BinaryFormatter();
			FileStream fs = File.Open(Application.persistentDataPath + "/savedData.dat", FileMode.OpenOrCreate);
			// this is where all data needs to be saved
			bf.Serialize(fs, GameSave.Instance());
			fs.Close();
		}

		public void load() {
			if (File.Exists(Application.persistentDataPath + "/savedData.dat")) {
				BinaryFormatter bf = new BinaryFormatter();
				FileStream fs = File.Open(Application.persistentDataPath + "/savedData.dat", FileMode.Open);

				GameSave data = (GameSave)bf.Deserialize(fs);
				Inventory.Instance().loadItems(data.inventory.getCurrentInventory());
				Troops.Instance().loadCharacters(data.troops.getCurrentTroops());
				MapData.Instance().loadTiles(data.map.getTiles());
			}
		}
	}

	[Serializable]
	public class GameSave {
		private static GameSave instance;

		private GameSave() {
		}

		public static GameSave Instance() {
			if (instance == null) {
				instance = new GameSave();
			}
			return instance;
		}

		public Inventory inventory = Inventory.Instance();
		public Troops troops = Troops.Instance();
		public MapData map = MapData.Instance();
	}
}

