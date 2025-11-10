using UnityEngine;
using UnityEditor;

namespace DefaultNamespace
{
    /// <summary>
    /// Кастомный PropertyDrawer для атрибута ReadOnly
    /// </summary>
    [CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
    public class ReadOnlyPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GUI.enabled = false;
            
            EditorGUI.PropertyField(position, property, label, true);
            
            GUI.enabled = true;
        }
    }
}
