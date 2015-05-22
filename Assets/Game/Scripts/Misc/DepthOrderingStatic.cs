using UnityEngine;
using System.Collections;

public class DepthOrderingStatic : MonoBehaviour {
	void Start() {
        Vector3 ordered = transform.position;
        ordered.z = ordered.y;
        transform.position = ordered;
    }
}
