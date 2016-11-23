using UnityEngine;
using System.Collections;

public class Tenk : MonoBehaviour {

    public Rigidbody tenk;
    public float potisak;
	public float skretanje = 0.7f;

    void Start() 
    {
		potisak = 53;
        tenk = GetComponent<Rigidbody>();
		tenk.mass = 2;
		tenk.drag = 3;
    }
	
	void Update () {
	
		 if(Input.GetKey("w")){
			 tenk.AddForce(transform.forward * potisak);
         }

         if(Input.GetKey("s")){
			 tenk.AddForce(transform.forward * -potisak/2);
         }

         if(Input.GetKey("a")){
			 transform.Rotate(0, -skretanje, 0);
         }

         if(Input.GetKey("d")){
			 transform.Rotate(0, skretanje, 0);
         }

	}

}
