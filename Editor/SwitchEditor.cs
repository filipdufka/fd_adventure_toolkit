#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

namespace FD.AdventureToolkit.Editor {

    [CustomEditor(typeof(Switch))]
    [CanEditMultipleObjects]
    public class SwitchEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {
            var sw = (Switch)target;

            if (sw.on) {
                GUI.color = Color.greenYellow;
                EditorGUILayout.LabelField("Switch is ON.");
            } else {
                GUI.color = Color.darkGray;
                EditorGUILayout.LabelField("Switch is OFF.");
            }
            EditorGUILayout.Space();
            GUI.color = Color.white;

            base.OnInspectorGUI();
        }
    }
}

#endif
