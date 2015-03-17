using System;

namespace FireEmblem {
	public class EnemyFactory {
		public EnemyFactory() {
		}

		public Enemy createEnemy(Profession profession) {
			Enemy enemy = new Enemy();
			enemy.setProfession(profession);
			return enemy;
		}

		//
		//Archer archer = EnemyFactory.createEnemy(new Archer());
		//
		//
		//
	}
}

