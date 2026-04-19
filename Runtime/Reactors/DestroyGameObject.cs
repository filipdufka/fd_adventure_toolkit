using UnityEngine;

namespace FD.AdventureToolkit {
    public class DestroyGameObject : MonoBehaviour {
        public void DestroyGO(MonoBehaviour behaviour) {
            Destroy(behaviour.gameObject);
        }
    }
}
