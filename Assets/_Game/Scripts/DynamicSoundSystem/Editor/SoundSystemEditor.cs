using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Unity.VisualScripting;

[CustomEditor(typeof(DynamicSoundSystem))]
public class SoundSystemEditor : Editor
{
    [SerializeField] private bool hasCollider;
    //private SerializedProperty

    public override void OnInspectorGUI()
    {
        DynamicSoundSystem data = (DynamicSoundSystem)target;

        EditorGUILayout.LabelField(data.name.ToUpper(), 
            EditorStyles.boldLabel);
        EditorGUILayout.Space(10);
        base.OnInspectorGUI();

        if (hasCollider)
        {
            this.AddComponent<Collider>();
            //GameObject gameObject = new GameObject();
           // gameObject.AddComponent<BoxCollider>();
        }


        EditorGUILayout.HelpBox("Testing Warnings", MessageType.Info);
        //EditorGUILayout.LabelField("sdadadadda");
    }

    public bool HasCollider => hasCollider;

}
