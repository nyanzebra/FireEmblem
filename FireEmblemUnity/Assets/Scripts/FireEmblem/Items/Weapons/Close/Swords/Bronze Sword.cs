using System;

namespace FireEmblem {
	public class Bronze_Sword : Sword {
		public Bronze_Sword() {
			Required_Skill = SkillLevel.E;
			Might = 3;
			Hit_Rate = 100;
			Critical_Hit_Rate = 0;
			Range = 1;
			Durability = 50;
			Cost = 350;
		}
	}
}

