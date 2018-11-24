using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround : MonoBehaviour
{
	static int initialNumberOfSegments = 20;

	public GameObject platformPrefab;
	public int numberOfSegments = initialNumberOfSegments;

	GameObject[] platforms;

	void Start()
	{
		platforms = new GameObject[numberOfSegments];
		float width = platformPrefab.transform.localScale.x;
		for (int i = 0; i < platforms.Length; ++i)
		{
			Vector3 pos = new Vector3(i * width, 0);
			platforms[i] = Instantiate(platformPrefab, pos, Quaternion.identity);
			platforms[i].transform.SetParent(transform);
			platforms[i].GetComponent<SpriteRenderer>().color = new Color(i * 10.0f, 0, 0);//(i % 2 == 0) ? Color.green : Color.gray;
		}
	}

	void Update()
	{
		transform.Translate(Vector3.left * 100.0f * Time.deltaTime);
	}
}
