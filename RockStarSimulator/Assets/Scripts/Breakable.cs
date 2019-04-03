using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour {
    public GameObject okVer;
    public GameObject badVer;
    ObjectIntact oi;
    CapsuleCollider cc;
    Rigidbody rb;

    Vector3 pos;
    Vector3 prevFramePos;
    Vector3 storedPos;
    public float currentVel;
    public float prevVel;

    private void Awake() {
        cc = FindObjectOfType<CapsuleCollider>();
        oi = FindObjectOfType<ObjectIntact>();
        rb = FindObjectOfType<Rigidbody>();
    }


    private void FixedUpdate() {
        
        pos = transform.position;

        currentVel = Vector3.Distance(pos, prevFramePos);
        prevVel = Vector3.Distance(storedPos, prevFramePos);

        if (currentVel < 0.1f * prevVel && storedPos != Vector3.zero) {
            Breakshit();
            //oi.TrashObject();
        }

        storedPos = prevFramePos;
        prevFramePos = pos;
        
    }

    void Breakshit() {
        if (badVer = null) {
            
        }
        oi.TrashObject();
    }
}
