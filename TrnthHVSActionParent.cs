﻿using UnityEngine;
using System.Collections;

public class TrnthHVSActionParent : TrnthHVSAction {
	public Transform target;
	public Transform parentTo;
	public TrnthFSM fsm;
	public bool keepOffset;
	protected override void _execute(){
		base._execute();
		if(fsm){
			parentTo=(fsm.state as Transform);
		}
		target.parent=parentTo;
		if(!keepOffset)target.localPosition=Vector3.zero;
	}
}