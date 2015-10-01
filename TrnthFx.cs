﻿using UnityEngine;
using TRNTH;
public class TrnthFx:MonoBehaviour{
	public string findIt{get;set;}
	public float noise{get;set;}
	public TrnthHVSCondition onEnd{get;set;}
	public virtual void start(){
		enabled=true;		
		_timeStart=Time.time;
	}
	protected virtual void update(){
	}
	protected virtual void end(){
		enabled=false;
		if(onEnd)onEnd.send();
	}
	protected float _timeStart;
	protected void OnEnable(){
		start();
	}
	protected void OnDisable(){
		CancelInvoke();
		end();
	}
	protected void Update(){
		update();
	}
}