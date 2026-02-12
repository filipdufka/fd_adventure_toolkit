using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace FD.AdventureToolkit
{
    public class Button : MonoBehaviour
    {
        public InputAction clickAction;
        public UnityEvent onClick;

        void Awake()
        {
            clickAction.performed += ClickResponse;
        }

        private void OnEnable() => clickAction.Enable();
        private void OnDisable() => clickAction.Disable();

        void ClickResponse(InputAction.CallbackContext context)
        {
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Vector3 mousePosWS = Camera.main.ScreenToWorldPoint(mousePos);
            Collider2D coll = GetComponent<Collider2D>();
            if (coll != null)
            {
                if (coll.OverlapPoint(mousePosWS))
                {
                    onClick.Invoke();
                }
            }
            else
            {
                Debug.LogWarning("No Collider2D on this button " +name);
            }
        }

    }
}