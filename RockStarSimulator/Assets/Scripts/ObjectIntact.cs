using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectIntact : MonoBehaviour {
    public bool objectTrashed;
    public float objectValue = 100;
    GameManager gm;

    private void Start() {
        gm = FindObjectOfType<GameManager>();
    }

    public void TrashObject() {
        if (!objectTrashed)
            gm.ObjectTrashed(objectValue);
        objectTrashed = true;
    }

    private void OnJointBreak(float breakForce) {
        TrashObject();
    }
}
