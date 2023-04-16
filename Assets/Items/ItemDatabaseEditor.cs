// using System.Collections;
// using System.Collections.Generic;
// using UnityEditor;
// using UnityEngine;

// [CustomEditor(typeof(ItemDatabase))]
// public class ItemDatabaseEditor : Editor
// {
//     private SerializedProperty itemsProperty;

//     public void OnEnable()
//     {
//         // Find the 'items' property by name
//         itemsProperty = serializedObject.FindProperty("items");
//     }

//     public override void OnInspectorGUI()
//     {
//         serializedObject.Update();

//         // Draw the 'items' property using a custom layout
//         EditorGUILayout.LabelField("Items");
//         EditorGUI.indentLevel++;
//         EditorGUILayout.PropertyField(itemsProperty, GUIContent.none, true);
//         EditorGUI.indentLevel--;

//         serializedObject.ApplyModifiedProperties();
//     }
// }