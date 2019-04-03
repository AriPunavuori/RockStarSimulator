using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trasher : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        var oi = other.GetComponent<ObjectIntact>();
        if(oi != null)
        oi.TrashObject();
    }

}
