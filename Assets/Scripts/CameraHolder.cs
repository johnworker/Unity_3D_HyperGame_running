using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    [SerializeField]private Transform playerTransform;

    private void Update()
    {
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y,
            playerTransform.position.z);
        transform.eulerAngles = new Vector3(playerTransform.eulerAngles.x, transform.eulerAngles.y, 0);
    }
}
