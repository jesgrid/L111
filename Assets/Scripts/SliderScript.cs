using UnityEngine;


public class SliderScript : MonoBehaviour
{
    public Transform FinishPlatform;
    public Player Player;
    public UnityEngine.UI.Slider slider;
    private float StartPosition;
    private float CurrentPosition;
    private float LastPosition;

    private void Start()
    {
        StartPosition = Player.transform.position.y;
        LastPosition = FinishPlatform.position.y;
    }
    private void Update()
    {
        CurrentPosition = Player.transform.position.y;
        if(slider.value < Mathf.InverseLerp(StartPosition, LastPosition + 1f, CurrentPosition))
        {
            slider.value = Mathf.InverseLerp(StartPosition, LastPosition + 1f, CurrentPosition);
        }
    }
}
