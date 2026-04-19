using UnityEngine;

namespace FD.AdventureToolkit {
    public class EnableDisableGameObject : MonoBehaviour {
        public void EnableGameObject(MonoBehaviour behaviour) {
            behaviour.gameObject.SetActive(true);
        }
        public void DisableGameObject(MonoBehaviour behaviour) {
            behaviour.gameObject.SetActive(false);
        }
    }
}
