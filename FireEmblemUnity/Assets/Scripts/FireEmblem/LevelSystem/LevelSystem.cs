using System;

namespace FireEmblem {
	public class LevelSystem {
		public LevelSystem() {
		}

		public int getExperience() {
			return Experience;
		}

		public void addExperience(int experience) {
			Experience += experience;
			if (Experience >= 100) {
				Displayed_Level++;
				Experience -= 100;
			}
		}
		
		public void resetExperienceBar() {
			Experience = 0;
		}
		
		public void setExperience(int experience) {
			Experience = experience;
		}

		public int getLevel() {
			return Cumulative_Level;
		}

		public void levelUp() {
			Cumulative_Level += (getDisplayedLevel() + getPromotionBonus() - 1) / 2;
			Displayed_Level = 1;
		}
		
		public void setLevel(int level) {
			Cumulative_Level = level;
		}
		
		public int getInnerLevel() {
			return Displayed_Level + getPromotionBonus() + Cumulative_Level;
		}
		
		public int getDisplayedLevel() {
			return Displayed_Level;
		}
		
		public void setDisplayedLevel(int level) {
			Displayed_Level = level;		
		}

		public int getPromotionBonus() {
			return (Is_Promoted_Class) ? 20 : 0;
		}

		public void setPromotionBonus(bool status) {
			Is_Promoted_Class = status;
		}

		protected bool Is_Promoted_Class = false;
		protected int Cumulative_Level = 0;
		protected int Displayed_Level = 1;
		protected int Experience = 0;
	}
}

