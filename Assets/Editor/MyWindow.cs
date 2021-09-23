using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MyWindow : EditorWindow
{
    [MenuItem("Windows/Moje okienko")]
    public static void OpenWindow()
    {
        GetWindow<MyWindow>();
    }

    void OnGUI()
    {
        if(GUILayout.Button("Moj button"))
        {
            Debug.Log("Leokadia <3");
        }
    }

}
