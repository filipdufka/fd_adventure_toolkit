#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

namespace FD.AdventureToolkit.Editor
{

    [CustomEditor(typeof(Button))]
    public class ButtonEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            var sp = (Button)target;
            var coll = sp.GetComponent<Collider2D>();

            
            if (coll == null) {
                GUI.color = Color.red;
                EditorGUILayout.LabelField("There must be Collider2D on this GameObject");
                EditorGUILayout.Space();
            }
            if (!Camera.main.orthographic)
            {
                GUI.color = Color.orangeRed;
                EditorGUILayout.LabelField("Main camera is not orthographic, button will not work.");
                EditorGUILayout.Space();
            }
            

            GUI.color = Color.white;

            base.OnInspectorGUI();                       
        }
    }
}

#endif
