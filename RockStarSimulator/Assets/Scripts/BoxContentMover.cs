using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxContentMover : MonoBehaviour
{
    Vector3 lastpos;
    public Vector3 Inside;

    private void Awake() {
        lastpos = transform.position;
    }

    private void FixedUpdate() {
        if (lastpos != transform.position) {
            var movementAmount = transform.position - lastpos;
            var colliders = Physics.OverlapBox(transform.position, Inside * .5f, transform.rotation);
            foreach (var c in colliders) {
                print(c);
                var rb = c.GetComponent<Rigidbody>();
                if(rb != null)
                rb.position += movementAmount;
            }
        }
        lastpos = transform.position;
    }

    private void OnDrawGizmosSelected() {
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Vector3.zero, Inside);
    }
}
