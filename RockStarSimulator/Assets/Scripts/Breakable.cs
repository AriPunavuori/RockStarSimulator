using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour {
    public GameObject okVer;
    public GameObject badVer;
    ObjectIntact oi;
    public CapsuleCollider cc;
    Rigidbody rb;

    Vector3 pos;
    Vector3 prevFramePos;
    Vector3 storedPos;
    public float currentVel;
    public float prevVel;
    public float factor = 0.1f;
    public float minVel;

    private void Awake() {
        oi = FindObjectOfType<ObjectIntact>();
        rb = FindObjectOfType<Rigidbody>();
    }


    private void Update() {
        
        pos = transform.position;

        currentVel = Vector3.Distance(pos, prevFramePos);
        prevVel = Vector3.Distance(storedPos, prevFramePos);

        if (currentVel < factor * prevVel && storedPos != Vector3.zero && prevVel > minVel) {
            Breakshit();
            //oi.TrashObject();
        }

        storedPos = prevFramePos;
        prevFramePos = pos;
        
    }

    void Breakshit() {
        if (badVer != null) {
            badVer.gameObject.SetActive(true);
            okVer.gameObject.SetActive(false);
            cc.enabled = false;
            oi.TrashObject();
        }
    }
}
