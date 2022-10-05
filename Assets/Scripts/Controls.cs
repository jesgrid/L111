using UnityEngine;

public class Controls : MonoBehaviour
{
    public Transform Level;
    private Vector3 _PreviousMousePosition;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _PreviousMousePosition;
            Level.Rotate(0, -delta.x * 0.18f, 0);
        }
        _PreviousMousePosition = Input.mousePosition;
    }
}
