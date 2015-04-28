﻿using UnityEngine;
using System.Collections;
using TRNTH;
public class TrnthAttack : MonoBehaviour {
	public TrnthHVSCondition conditionReact;
	[HideInInspector]public GameObject onReact; // obsolute
	public float damageBase=30;
	public bool knockback;
	public bool showDamage=false;
	public virtual void react(float damage){
		this.send(conditionReact);
		if(onReact){
			onReact.SetActive(true);
			onReact.SetActive(false);			
		}
	}
	public virtual float damage{get{
		// var damage=damageBase;
		return damageBase;
	}}
}
