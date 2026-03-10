#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

namespace FD.AdventureToolkit.Editor {

    [CustomEditor(typeof(Hover))]
    [CanEditMultipleObjects]
    public class HoverEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {
            var sp = (Hover)target;

            if (!Camera.main.orthographic) {
                GUI.color = Color.orangeRed;
                EditorGUILayout.LabelField("Main camera is not orthographic, hover will not work.");
                EditorGUILayout.Space();
            }

            var coll = sp.GetComponent<Collider2D>();
            if (coll == null) {
                GUI.color = Color.red;
                EditorGUILayout.LabelField("There must be Collider2D component on this GameObject");
                EditorGUILayout.Space();
            }

            GUI.color = Color.white;

            base.OnInspectorGUI();
        }
    }
}

#endif
