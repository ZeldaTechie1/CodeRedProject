using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

    float input_x;
    float input_z;
    public float velocity;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        input_x = Input.GetAxisRaw("Horizontal");
        input_z = Input.GetAxisRaw("Vertical");
        if (input_x != 0 || input_z != 0)
        {
            transform.position += new Vector3(input_x, 0, input_z).normalized * Time.deltaTime * velocity;
        }
	}
}
