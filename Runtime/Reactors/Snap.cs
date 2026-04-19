using UnityEngine;

namespace FD.AdventureToolkit {
    public class Snap : MonoBehaviour {
        public void SnapToMe(Transform objectToSnap) {
            objectToSnap.transform.position = transform.position;
        }
        public void SnapToMe(MonoBehaviour behaviourToSnap) {
            SnapToMe(behaviourToSnap.transform);
        }
    }
}
