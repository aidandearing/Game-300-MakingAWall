using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    public float speed = 20;
    public Rigidbody proj;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (Input.GetButton("Fire1"))
        {
            Rigidbody instantiateProjectile = Instantiate(proj, transform.position, transform.rotation) as Rigidbody;
            instantiateProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            Destroy(instantiateProjectile.gameObject, 10);
            Debug.Log("Firing");
        }
	}
}
