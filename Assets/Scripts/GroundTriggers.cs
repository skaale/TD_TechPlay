using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class GroundTriggers : MonoBehaviour, IPointerClickHandler 
{
	public CreateTowerOnClick player;

	void Start()
	{

		player = GetComponent<CreateTowerOnClick>();
	}

	// Will work for clicks and Cardboard trigger presses
	public void OnPointerClick(PointerEventData eventData)
	{
		player.Clicked(eventData.pointerCurrentRaycast.worldPosition);
	}
}
