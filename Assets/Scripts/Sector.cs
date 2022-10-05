using UnityEngine;

public class Sector : MonoBehaviour
{
    public bool IsGood = true;
    public bool IsWin = false;
    public Material GoodMaterial;
    public Material BadMaterial;
    public Material WinMaterial;
    private void Awake()
    {
        GetComponent<Renderer>().sharedMaterial = IsGood ? GoodMaterial : IsWin ? WinMaterial : BadMaterial;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.TryGetComponent(out Player player))
        {
            Vector3 normal = collision.contacts[0].normal.normalized;
            float dot = Vector3.Dot(normal, -Vector3.up);
            if(dot >= 0.7)
            {
                if (IsWin)
                {
                    player.Win();
                }
                if (IsGood)
                {
                    player.Bounce();
                }
                else
                {
                    player.Die();
                }
            }
        }
    }
    private void OnValidate()
    {
        GetComponent<Renderer>().sharedMaterial = IsGood ? GoodMaterial : IsWin ? WinMaterial : BadMaterial;
    }
}
