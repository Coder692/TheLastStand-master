using UnityEngine;
using System.Collections;
public GameObject BulletPrefab;

public class ArrowScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
	if (Input.GetKeyDown(KeyCode.Space))
	{
		Instantiate(BulletPrefab, transform.position, transform.rotation);
	}
	
	}
}
