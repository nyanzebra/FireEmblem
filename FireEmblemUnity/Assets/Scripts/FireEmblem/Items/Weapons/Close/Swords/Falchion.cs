using System;

namespace FireEmblem {
	public class Falchion : Sword {
		public Falchion() {
			Name = "Falchion";
			Required_Skill = SkillLevel.E;
			Might = 5;
			Hit_Rate = 80;
			Critical_Hit_Rate = 0;
			Range = 1;
			Description = "Chrom and Marth only";
		}

		public override int damageMultiplier(BeastType type) {
			if (type == BeastType.Wyvern) {
				return 3;
			}
			return base.damageMultiplier(type);
		}
	}
}

