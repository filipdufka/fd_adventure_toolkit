using UnityEngine;

namespace FD.AdventureToolkit {
    public class Teleport : MonoBehaviour {
        public void TeleportTo(Transform target) {
            if (target != null) {
                transform.position = target.position;
            } else {
                Debug.LogWarning("Trying to teleport to nonexisting target.");
            }
        }
    }
}
