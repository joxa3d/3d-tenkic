using UnityEngine;
using System.Collections;

public class Cev : MonoBehaviour {
	
	public float skretanje = 1;
	
	// podignutija cev
	void Update () {
         if(Input.GetKey(KeyCode.UpArrow)){
			 transform.Rotate(-skretanje, 0, 0);
         }

         if(Input.GetKey(KeyCode.DownArrow)){
			 transform.Rotate(skretanje, 0, 0);
         }
	}
}
