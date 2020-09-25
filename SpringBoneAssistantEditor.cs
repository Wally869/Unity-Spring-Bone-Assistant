using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(SpringBoneAssistant))]
public class SpringBoneAssistantEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        SpringBoneAssistant obj = (SpringBoneAssistant)target;

        if (GUILayout.Button("Mark Children"))
        {
            obj.MarkChildren();
        }

        if (GUILayout.Button("Clean Up"))
        {
            obj.CleanUp();
        }

    }
}
