using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {
    public Rigidbody wall;

	// Use this for initialization
	void Start () {
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                for (int z = 0; z < 8; z++)
                {
                    Rigidbody instantiateProjectile = Instantiate(wall, transform.position, transform.rotation) as Rigidbody;
                    instantiateProjectile.position = transform.TransformDirection(new Vector3(10 + x * 10f, 10 + y * 10f, 10 + z * 10f));
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
