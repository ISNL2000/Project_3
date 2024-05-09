using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SoundData))]
public class SoundSystemEditor : Editor
{
    public override void OnInspectorGUI()
    {
        SoundData data = (SoundData)target;

        EditorGUILayout.LabelField(data.name.ToUpper(),
            EditorStyles.boldLabel);
        EditorGUILayout.Space(10);
        base.OnInspectorGUI();

        EditorGUILayout.HelpBox("Testing Warnings", MessageType.Info);
        //EditorGUILayout.LabelField("sdadadadda");
    }
}
