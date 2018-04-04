using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickController : MonoBehaviour
{

	private Vector3 _touchStartPos;
	private Vector3 _touchEndPos;

	void Update()
	{
		Flick ();
	}

	private void Flick()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			_touchStartPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
		}

		if (Input.GetKeyUp(KeyCode.Mouse0))
		{
			_touchEndPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
			GetDirection();
		}
	}

	private void GetDirection()
	{
		float directionX = _touchEndPos.x - _touchStartPos.x;
		float directionY = _touchEndPos.y - _touchStartPos.y;
		string Direction = string.Empty;

		if (Mathf.Abs(directionY) < Mathf.Abs(directionX))
		{
			if (30 < directionX)
			{
				//右向きにフリック
				Direction = "right";
			}
			else if (-30 > directionX)
			{
				//左向きにフリック
				Direction = "left";
			}
		}
		else if (Mathf.Abs(directionX) < Mathf.Abs(directionY))
		{
			if (30 < directionY)
			{
				//上向きにフリック
				Direction = "up";
			}
			else if (-30 > directionY)
			{
				//下向きのフリック
				Direction = "down";
			}
		}
		else
		{
			//タッチを検出
			Direction = "touch";
		}

		switch (Direction)
		{
			case "up":
				//上フリックされた時の処理
				Debug.Log("↑");
				break;

			case "down":
				//下フリックされた時の処理
				Debug.Log("↓");
				break;

			case "right":
				//右フリックされた時の処理
				Debug.Log("→");
				break;

			case "left":
				//左フリックされた時の処理
				Debug.Log("←");
				break;

			case "touch":
				//タッチされた時の処理
				Debug.Log("touch");
				break;
		}
	}
}
