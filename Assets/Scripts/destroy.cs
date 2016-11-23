using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {

    void OnCollisionEnter(Collision collision) {
        Destroy(gameObject, 1.0f);
    }
}
