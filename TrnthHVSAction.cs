﻿using UnityEngine;
using System.Collections;
[RequireComponent(typeof(TrnthHVSCondition))]
public class TrnthHVSAction : TrnthHVS {
	protected TrnthVariable variable;
	public float delay=0;
	[HideInInspector]
	[SerializeField]
	protected float _delayNoise=0;
	[ContextMenu("set noise as delay")]
	public void setNoise(){
		_delayNoise=delay;
	}
	[ContextMenu("execute")]
	public void execute(){
		if(!enabled)return;
		if(delay==0){
			_execute();
		}else {
			CancelInvoke();
			Invoke("_execute",delay);
		}
	}
	public override string extraMsg{get{return "Action";}}
	protected virtual void _execute(){
		if(!variable)variable=GetComponent<TrnthVariable>();
		log();
	}
	protected void send(TrnthHVSCondition condition){
		if(condition)condition.send();
	}
	void Start(){
		// for show enabled / disabled checkbox on inspector
	}
}
