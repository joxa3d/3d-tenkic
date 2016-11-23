using UnityEngine;
using System.Collections;

public class Pucanje : MonoBehaviour {

	public GameObject Okidac;
	public GameObject Granata;
	public float potisak;
	public float kolicina;
	public float pauza;
	bool spreman;

	void Start() {
		kolicina = 30;
		potisak = 1000;
		pauza = 1000;
	}
	
	// time delay

	void Update () {
		spreman = Input.GetKeyDown(KeyCode.Space) && kolicina > 0;
         if(spreman){
			GameObject intanca = Instantiate(Granata, Okidac.transform.position, Okidac.transform.rotation) as GameObject;
			intanca.GetComponent<Rigidbody>().AddForce(transform.forward * potisak);
			Destroy(intanca, 5.0f);
			kolicina--;
         }
	}

}
