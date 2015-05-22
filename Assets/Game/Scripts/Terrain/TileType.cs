using UnityEngine;

//[System.Serializable]
public class TileType : ScriptableObject {
    [SerializeField]
    private bool walkable;

    [SerializeField]
    private float movementModifier;
}
