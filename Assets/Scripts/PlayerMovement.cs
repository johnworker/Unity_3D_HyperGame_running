using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private Transform playerTransform;
    [SerializeField]private float limitValue;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MovePlayer();
        }
    }

    private void MovePlayer()
    {
        // 計算 X 的位置和修改它
        float halfScreen = Screen.width / 2; // width:540
        float xPos = (Input.mousePosition.x - halfScreen) / halfScreen;
        // width:540-540/540 = 0        螢幕的中間
        // width:0-540/540 = -1        螢幕的左邊緣
        // width:1080-540/540 = 1        螢幕的右邊緣
        float finalXPos = Mathf.Clamp(xPos * limitValue, -limitValue, limitValue);

        playerTransform.localPosition = new Vector3(finalXPos, 1, 0);
    }
}
