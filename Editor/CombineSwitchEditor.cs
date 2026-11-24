#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

namespace FD.AdventureToolkit.Editor {

    [CustomEditor(typeof(CombineSwitch))]
    [CanEditMultipleObjects]
    public class CombineSwitchEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {
            var sw = (CombineSwitch)target;

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
