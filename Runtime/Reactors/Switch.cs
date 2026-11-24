using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

namespace FD.AdventureToolkit {
    public class Switch : MonoBehaviour {
        public bool on { get; protected set; }
        public bool defaultState = false;

        public UnityEvent whenOn;
        public UnityEvent whenOff;

        protected virtual void Awake() {
            on = !defaultState; // Forcing Change
            Set(defaultState);
        }

        protected virtual void Start() { }

        public virtual void Set(bool newSwitched) {
            bool old = on;
            on = newSwitched;
            ChangeCheck(newSwitched, old);
            RepaintEditor();
        }

        public virtual void Toggle() => Set(!on);

        protected void ChangeCheck(bool newState, bool oldState) {
            if (newState != oldState) {
                if (newState) {
                    whenOn.Invoke();
                } else {
                    whenOff.Invoke();
                }
            }
        }

        protected void RepaintEditor() {
#if UNITY_EDITOR
            Editor.CreateEditor(this).Repaint();
#endif
        }

    }
}
