using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround : MonoBehaviour
{
	public GameObject platformPrefab;
	public int numberOfSegments = 20;
	// Start is called before the first frame update

	private GameObject[] platforms;
	void Start()
	{
		platforms = new GameObject[numberOfSegments];
		float width = platformPrefab.transform.localScale.x;
		for (int i = 0; i < platforms.Length; ++i)
		{
			Vector3 pos = new Vector3((float)i * width, 0);
			platforms[i] = Instantiate(platformPrefab, pos, Quaternion.identity);
			platforms[i].transform.SetParent(transform);
			platforms[i].GetComponent<SpriteRenderer>().color = (i % 2 == 0) ? Color.green : Color.gray;
		}
	}

    // Update is called once per frame
    void Update()
	{
		transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.left * 200, Time.deltaTime);
    }
}
