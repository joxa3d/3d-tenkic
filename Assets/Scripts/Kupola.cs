using UnityEngine;
using System.Collections;

public class Kupola : MonoBehaviour {
	
	public float skretanje = 1;

	void Update () {
         if(Input.GetKey(KeyCode.LeftArrow)){
			 transform.Rotate(0, -skretanje, 0);
         }

         if(Input.GetKey(KeyCode.RightArrow)){
			 transform.Rotate(0, skretanje, 0);
         }
	}
}
