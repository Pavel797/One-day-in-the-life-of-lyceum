using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed;

	void Start () {
	
	}

	void Update () {
        if (Input.GetKey(KeyCode.A) && this.transform.position.z < 3.2f)
            this.transform.position += new Vector3(0, 0, 0.2f);
        if (Input.GetKey(KeyCode.D) && this.transform.position.z > -3.2f)
            this.transform.position += new Vector3(0, 0, -0.2f);
    }
}
