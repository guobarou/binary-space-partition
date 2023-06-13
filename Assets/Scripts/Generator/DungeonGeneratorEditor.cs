using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DungeonGenerator))]
public class DungeonGeneratorEditor : Editor
{

    DungeonGenerator generator;

    private void Awake()
    {
        generator = target as DungeonGenerator;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("Generator"))
        {
            generator.CreateDungeon();
        }
    }
}
