using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Player Player;
    public Transform Transform;
    public float CameraMoveSpeed;

    void Update()
    {
        if(Player.CurrentPlatform == null)
        {
            return;
        }
        Vector3 TargetPosition = Player.CurrentPlatform.transform.position;
        Transform.position = Vector3.MoveTowards(Transform.position, TargetPosition, CameraMoveSpeed * Time.deltaTime);

    }
}
