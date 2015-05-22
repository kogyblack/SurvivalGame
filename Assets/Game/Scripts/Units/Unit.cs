using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class Unit : MonoBehaviour {
    // TODO(naum): See the tile the unit is on
    private Animator animator;
    private int isMovingId;

    [SerializeField]
    private float moveSpeed;

    void Start() {
        animator = GetComponent<Animator>();
        isMovingId = Animator.StringToHash("IsMoving");
    }

    public void Move(bool left, bool right, bool up, bool down) {
        Vector2 movement = new Vector2();
        if (down)  movement.y -= moveSpeed * Time.fixedDeltaTime;
        if (up)    movement.y += moveSpeed * Time.fixedDeltaTime;
        if (right) movement.x += moveSpeed * Time.fixedDeltaTime;
        if (left)  movement.x -= moveSpeed * Time.fixedDeltaTime;

        transform.position = transform.position + (Vector3)movement;

        // Animation update
        if (down != up || right != left)
            animator.SetBool(isMovingId, true);
        else
            animator.SetBool(isMovingId, false);
    }
}
