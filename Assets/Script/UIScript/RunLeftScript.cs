﻿using UnityEngine;
using UnityEngine.EventSystems; 
using System.Collections;

public class RunLeftScript : MonoBehaviour,IPointerDownHandler,IPointerUpHandler {

	public GameObject marry;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
	}

	// 当按钮被按下后系统自动调用此方法  
	public void OnPointerDown (PointerEventData eventData) {
		
		marry.GetComponent<MarryScript> ().moveLeft (0.05f);
	}  

	// 当按钮抬起的时候自动调用此方法  
	public void OnPointerUp (PointerEventData eventData) {

		marry.GetComponent<MarryScript> ().stopMoving();
	} 
}
