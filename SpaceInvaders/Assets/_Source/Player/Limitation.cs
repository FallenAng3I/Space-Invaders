using UnityEngine;

public class Limitation : MonoBehaviour
{
    [SerializeField] private float boundaryX;

    private void Update()
    {
        var newPosition = transform.position.x;
        newPosition = Mathf.Clamp(newPosition, -boundaryX, boundaryX);
        transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);
    }
}
