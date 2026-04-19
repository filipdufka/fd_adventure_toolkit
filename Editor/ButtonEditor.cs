#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

namespace FD.AdventureToolkit.Editor {

    [CustomEditor(typeof(Button))]
    [CanEditMultipleObjects]
    public class ButtonEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {
            var sp = (Button)target;



            var coll = sp.GetComponent<Collider2D>();
            EditorUtils.EditorError(
                coll == null,
                "There must be Collider2D component on this GameObject");

            var hover = sp.GetComponent<Hover>();
            EditorUtils.EditorError(
                coll == null,
                "There must be Hover component on this GameObject");

            EditorUtils.EditorWarning(
                Camera.main == null,
                "Main camera is not set, button will not work.");

            if (Camera.main != null) {
                EditorUtils.EditorWarning(
                    !Camera.main.orthographic,
                    "Main camera is not orthographic, button will not work.");
            }

            base.OnInspectorGUI();
        }
    }
}

#endif
