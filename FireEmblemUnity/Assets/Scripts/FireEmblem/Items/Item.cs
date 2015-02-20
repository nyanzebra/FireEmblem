using System;
using System.Collections.Generic;
using UnityEngine;

namespace FireEmblem
{
	public abstract class Item
	{
		public Item ()
		{
		}

		public string Name {
			get { return m_Name; }
		}

		public string Descriptions {
			get { return m_Description; }
		}

		public int Durability {
			get { return m_Durability; }
		}

		public bool Stackable {
			get { return m_Is_Stackable; }
		}

		public List<Profession> Necessary_Professions {
			get { return m_Necessary_Professions; }
		}

		protected string m_Description;
		protected int m_Durability;
		protected string m_Name;
		protected int m_Cost;
		protected bool m_Is_Stackable;
		protected List<Profession> m_Necessary_Professions;
		protected Sprite[] m_Sprites;
	}
}

