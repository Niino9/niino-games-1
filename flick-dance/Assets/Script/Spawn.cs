using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> cloneObjectList;
 
	private bool _isCloning = false;

	// Use this for initialization
	void Start()
	{
		_isCloning = true;
		StartCoroutine(CoCloning());
	}

	private IEnumerator CoCloning()
	{

		while(_isCloning)
		{
			GameObject cloneObject = cloneObjectList[new System.Random().Next(cloneObjectList.Count)];

			yield return new WaitForSeconds(1.0f);

			Instantiate(cloneObject,
						new Vector3(transform.position.x, transform.position.y, transform.position.z),
						cloneObject.transform.rotation
			);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
