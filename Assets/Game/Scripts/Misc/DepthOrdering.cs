using UnityEngine;

public class DepthOrdering : MonoBehaviour {
	void Update() {
        Vector3 ordered = transform.position;
        ordered.z = ordered.y;
        transform.position = ordered;
    }
}
