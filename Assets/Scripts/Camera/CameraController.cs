using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 initialPosition;
    [SerializeField] private Vector3 maxPosition;
    [SerializeField, Range(0,1)] private float progress;

    private void Update()
    {
        transform.position = Vector3.Lerp(initialPosition, maxPosition, progress);
    }
}
