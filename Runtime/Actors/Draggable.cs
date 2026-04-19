using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace FD.AdventureToolkit {
    public class Draggable : Button {
        bool dragged = false;
        public UnityEvent onDragCancel;
        Vector3 originPosition;
        Vector3 offset;

        HashSet<DropZone> possibleTargets = new HashSet<DropZone>();

        protected override void Init() {
            base.Init();
            clickAction.canceled += ClickCancel;
            onClick.AddListener(StartDragging);
        }

        private void Update() {
            if (dragged) {
                Vector2 mousePos = Mouse.current.position.ReadValue();
                Vector3 mousePosWS = Camera.main.ScreenToWorldPoint(mousePos);
                transform.position = mousePosWS - offset;
            }
        }

        void StartDragging() {
            originPosition = transform.position;
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Vector3 mousePosWS = Camera.main.ScreenToWorldPoint(mousePos);
            offset = mousePosWS - transform.position;

            dragged = true;
        }

        void ClickCancel(InputAction.CallbackContext context) {
            if (dragged) {
                CheckDropZones();
                dragged = false;
            }
        }

        internal void AddPossibleTarget(DropZone target) {
            possibleTargets.Add(target);
        }

        void CheckDropZones() {
            foreach (var target in possibleTargets) {
                if (target.on) {
                    target.TriggerDrop(this);
                    return;
                }
                // No Drop Zones Hovered
                onDragCancel.Invoke();
            }
        }

        public void ResetPosition() {
            transform.position = originPosition;
        }
    }
}
