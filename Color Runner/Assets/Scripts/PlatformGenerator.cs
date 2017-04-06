using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

	public GameObject thePlatform;
	public Transform generationPoint;
	public float distanceBetween;

	private float platformWidth;

	public float distanceBetweenMin;
	public float distanceBetweenMax;

	//public GameObject[] thePlatforms;
	private int platformsSelector;
	private float[] platformWidths;



	public ObjectPooler[] theObjectPools;

	// Use this for initialization
	void Start () {
		//platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
	
		platformWidths = new float[theObjectPools.Length];

		for (int i = 0; i < theObjectPools.Length; i++) 
		{
			platformWidths [i] = theObjectPools [i].pooledObject.GetComponent<BoxCollider2D> ().size.x;
		}
	}

	// Update is called once per frame
	void Update () {
		 
		if (transform.position.x < generationPoint.position.x)
		{
			distanceBetween = Random.Range (distanceBetweenMin, distanceBetweenMax);

			platformsSelector = Random.Range(0, theObjectPools.Length);
					
			transform.position = new Vector3(transform.position.x + (platformWidths[platformsSelector] / 2) + distanceBetween, transform.position.y, transform.position.z);

			

			//Instantiate (thePlatform, transform.position, transform.rotation);


			GameObject newPlatform = theObjectPools[platformsSelector].GetPooledObject();
			
			newPlatform.transform.position = transform.position;
			newPlatform.transform.rotation = transform.rotation;
			newPlatform.SetActive (true);
	  
		
			transform.position = new Vector3(transform.position.x + (platformWidths[platformsSelector] / 2), transform.position.y, transform.position.z);

		
		}
}
				}
