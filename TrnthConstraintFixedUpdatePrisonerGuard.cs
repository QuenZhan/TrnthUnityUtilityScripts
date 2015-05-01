﻿using UnityEngine;
using System.Collections;

public class TrnthConstraintFixedUpdatePrisonerGuard : MonoBehaviour {
	public enum Border{left,right}
	public TrnthConstraintFixedUpdatePrisoner prisoner;
	public string find="CameraFoot";
	public Border border;
	void OnEnable(){
		if(!prisoner){
			var go=GameObject.Find(find);
			if(!go){
				Invoke("OnEnable",0.1f);
				return;
			}
			prisoner=go.GetComponent<TrnthConstraintFixedUpdatePrisoner>();			
		}
		switch(border){
		case Border.left	:prisoner.left	=transform.position.x;break;
		case Border.right	:prisoner.right	=transform.position.x;break;
		}
		
	}
	void OnDisable(){
		CancelInvoke();
	}
}
