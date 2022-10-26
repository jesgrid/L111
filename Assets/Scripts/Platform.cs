using UnityEngine;

namespace Assets.Scripts
{
    public class Platform : MonoBehaviour
    {
        private ParticleSystem _system;
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Player player))
            {
                player.CurrentPlatform = this;
            }
        }
    }
}