using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Resize_Script : MonoBehaviour {
	public int margin;
	public int duration;
	public UIWidget widget;
	private int width;
	private int height;

	public void Resize()
	{
		height = widget.height;
		width = widget.width;
		Debug.Log ("Resize was called");
		if(height> 0 && width >0)
		{
			Debug.Log ("Sprite has size");
			if (height !=width) 
			{
				Debug.Log ("Going Square");
				width = height;
			}
			else 
			{
				Debug.Log ("Going Rectangular");
				width = height + margin;
			}
			TweenWidth.Begin (widget,duration,width);
		}
	}
}
