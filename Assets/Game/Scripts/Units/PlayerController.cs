using UnityEngine;

[RequireComponent(typeof(Unit))]
public class PlayerController : MonoBehaviour {
    Unit unit;

    void Start () {
        unit = GetComponent<Unit>();
    }
	
	void FixedUpdate() {
        bool down  = Input.GetKey(KeyCode.DownArrow);
        bool up    = Input.GetKey(KeyCode.UpArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left  = Input.GetKey(KeyCode.LeftArrow);

        unit.Move(left, right, up, down);
	}
}
