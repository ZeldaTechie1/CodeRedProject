using UnityEngine;
using System.Collections;

public class MakingFruit : MonoBehaviour {

    public GameObject[] array;
    public GameObject fruit;
    private float timer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer > 1)
        {
            Instantiate(fruit, array[Random.Range(0, array.Length)].transform.position, Quaternion.identity);
            timer = 0;
        }

	
	}
}
