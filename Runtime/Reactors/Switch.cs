using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

namespace FD.AdventureToolkit {
    public class Switch : MonoBehaviour {
        public bool on { get; protected set; }
        public bool defaultState = false;

        public UnityEvent whenOn;
        public UnityEvent whenOff;

        private void Start() {
            on = !defaultState; // Forcing Change
            Set(defaultState);
        }

        public void Set(bool newSwitched) {
            ChangeCheck(newSwitched);
            on = newSwitched;
            RepaintEditor();
        }

        public void Toggle() => Set(!on);

        void ChangeCheck(bool newState) {
            if (newState != on) {
                if (newState) {
                    whenOn.Invoke();
                } else {
                    whenOff.Invoke();
                }
            }
        }

        void RepaintEditor() {
#if UNITY_EDITOR
            Editor.CreateEditor(this).Repaint();
#endif
        }

    }
}
