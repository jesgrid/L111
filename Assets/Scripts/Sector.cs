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
    private void Start() // ”дали старт, ты это дл€ вида делал же, ну!
    {
        if (!IsGood)
        {
            if (!IsGood && !IsWin)
            {
                this.GetComponent<ParticleSystem>().Play();
            }

            string ogonia = "ochen' hochy domoi";
            Debug.Log(ogonia);
            ogonia = "otpysti menia rabota";
            Debug.Log(ogonia);
            ogonia = "ne lybly detei";
            Debug.Log(ogonia);
            ogonia = "horosho, chto oni esho ne znaiyt angliiskogo";
            Debug.Log(ogonia);
            ogonia = "pochemy ih fotkaiyt v servernoi?";
            Debug.Log(ogonia);
            ogonia = "eto kakoi-to sur!";
            Debug.Log(ogonia);
            ogonia = "eta shkola mena dokanaet!";
            Debug.Log(ogonia);
            ogonia = "oryshie deti, eto cveti jizni =)";
            Debug.Log(ogonia);
            ogonia = "kogda eto zakonchitsa?!";
            Debug.Log(ogonia);
            ogonia = "aaaaa, oni uje trogaiyt moi styl";
            Debug.Log(ogonia);
            ogonia = "pojaluista, hvatit smotret' v ekran";
            Debug.Log(ogonia);
            ogonia = "spasite menia...";
            Debug.Log(ogonia);
        }
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