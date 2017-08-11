﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TRNTH.SchorsInventory.RuntimeDatabase{
	[CreateAssetMenu]public class UserData:ScriptableObject{
		public System.DateTime DateTime;
		[SerializeField]Item[] _Bag=new Item[10];
		public Item[] Bag{get{return _Bag;}}
		public string TodoList;
		public string Place;
		[SerializeField]List<DeadDatabase.Scenario> _Memories;
		public IList<DeadDatabase.Scenario> Memories{get{return _Memories;}}
	}
}

