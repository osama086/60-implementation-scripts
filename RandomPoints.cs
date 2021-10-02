using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPoints : MonoBehaviour
{
	public GameObject things;
	public float delayTimer = 0.5f;
	float timer;


	// Use this for initialization
	void Start()
	{
		timer = delayTimer;


	}

	// Update is called once per frame
	void Update()
	{

		timer -= Time.deltaTime;

		if (timer <= 0)
		{
			Vector3 thingsPos = new Vector3(Random.Range(2.5f, -2.5f), transform.position.y, transform.position.z);

			Instantiate(things, thingsPos, transform.rotation);
			timer = delayTimer;
		}
	}
}
