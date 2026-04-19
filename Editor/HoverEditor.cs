#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

namespace FD.AdventureToolkit.Editor {

    [CustomEditor(typeof(Hover))]
    [CanEditMultipleObjects]
    public class HoverEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {
            var sp = (Hover)target;

            var coll = sp.GetComponent<Collider2D>();
            EditorUtils.EditorError(
                coll == null,
                "There must be Collider2D component on this GameObject");

            EditorUtils.EditorWarning(
                Camera.main == null,
                "Main camera is not set, hover will not work.");

            if (Camera.main != null) {
                EditorUtils.EditorWarning(
                    !Camera.main.orthographic,
                    "Main camera is not orthographic, hover will not work.");
            }

            base.OnInspectorGUI();
        }
    }
}

#endif
