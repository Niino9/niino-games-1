using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{

	[SerializeField]
	private int stepCount = 10;
	[SerializeField]
	private int stepAmount = -5;

	// Use this for initialization
	void Start()
	{
		StartCoroutine(CoMove());
	}

	private IEnumerator CoMove()
	{
		for(int i = 0; i <= stepCount; i++)
		{
			yield return new WaitForSeconds(1.0f);

			transform.position += new Vector3(0, 0, stepAmount);
		}

		Destroy(gameObject);
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
