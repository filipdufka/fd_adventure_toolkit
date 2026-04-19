using UnityEngine;
using UnityEngine.InputSystem;

namespace FD.AdventureToolkit {
    [RequireComponent(typeof(Collider2D))]

    public class Hover : Switch {

        Collider2D coll;

        private void Awake() => Init();

        protected virtual void Init() {
            coll = GetComponent<Collider2D>();
        }

        private void Update() {
            var newHovered = CheckPosition();
            Set(newHovered); // Using inherited function from Switch
        }

        bool CheckPosition() {
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Vector3 mousePosWS = Camera.main.ScreenToWorldPoint(mousePos);

            return coll.OverlapPoint(mousePosWS);
        }
    }
}
