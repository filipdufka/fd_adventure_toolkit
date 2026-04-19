using UnityEditor;
using UnityEngine;

namespace FD.AdventureToolkit.Editor {
    public static class EditorUtils {

        public static void ColorMessage(string message, Color color) {
            GUI.color = color;
            EditorGUILayout.LabelField(message);
            EditorGUILayout.Space();
            GUI.color = Color.white;
        }

        public static void EditorWarning(bool condition, string message) {
            if (condition) {
                ColorMessage(message, Color.orangeRed);
            }
        }

        public static void EditorError(bool condition, string message) {
            if (condition) {
                ColorMessage(message, Color.red);
            }
        }
    }
}
