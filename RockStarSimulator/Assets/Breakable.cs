using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour {

    public GameObject okVer;
    public GameObject destroyedVer;
    CapsuleCollider cc;
    Object
    public float health = 50f;


    private void Start() {
        cc = GetComponent<CapsuleCollider>();
    }

    public void TakeDamage(float amount) {
        health -= amount;
        if (health <= 0f) {
            Break();
        }
    }

    void Break() {
        if (destroyedVer != null) {
            destroyedVer.gameObject.SetActive(true);
            okVer.gameObject.SetActive(false);
            cc.enabled = false;
            Destroy(gameObject, 8);
            //Instantiate(destroyedVer, transform.position, transform.rotation);
        } else {
            Destroy(gameObject);
        }
    }
}
