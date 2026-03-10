using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace FD.AdventureToolkit {

    [RequireComponent(typeof(Hover))]
    public class Button : MonoBehaviour {
        public InputAction clickAction = new InputAction(binding: "<Mouse>/leftButton");
        public UnityEvent onClick;

        Hover hover;
        int enabledFrame;

        void Awake() {
            clickAction.started += ClickResponse;
            hover = GetComponent<Hover>();
        }

        private void OnEnable() {
            clickAction.Enable();
            enabledFrame = Time.frameCount;
        }

        private void OnDisable() {
            clickAction.Disable();
        }

        void ClickResponse(InputAction.CallbackContext context) {
            // Immidiate Button Fix
            if (Time.frameCount == enabledFrame + 1) { return; }

            // Position Check
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Vector3 mousePosWS = Camera.main.ScreenToWorldPoint(mousePos);
            if (hover.on) {
                onClick.Invoke();
            }
        }
    }
}
