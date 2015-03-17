using System;
namespace FireEmblem {
	public abstract class Skill	{
		public Skill() {
		}

		protected string Name;
		protected int NecessaryLevel;
		protected string Description;
		protected bool Is_Active;
		protected System.Random Random_Number_Generator;
	}
}

