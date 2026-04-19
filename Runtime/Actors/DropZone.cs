using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace FD.AdventureToolkit {
    /// <summary>
    /// Spot, where to place Draggables
    /// </summary>    
    public class DropZone : Hover {
        public UnityEvent<Draggable> onDrop;

        public List<Draggable> approvedDraggables;

        protected override void Init() {
            base.Init();
            NotifyApprovedDraggables();
        }

        void NotifyApprovedDraggables() {
            foreach (var draggable in approvedDraggables) {
                draggable.AddPossibleTarget(this);
            }
        }

        public void TriggerDrop(Draggable draggable) {
            Debug.Log("Triggering Drop on " + draggable.name);
            onDrop?.Invoke(draggable);
        }
    }
}
