using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class SceneSpeedChangerEditor : Editor
{
    static GUIStyle style;
    static SceneSpeedChangerEditor()
    {
        SceneView.duringSceneGui -= OnDuringSceneGui;
        SceneView.duringSceneGui += OnDuringSceneGui;
        style = new GUIStyle();
        style.normal.textColor = Color.black;
    }

  

    private static void OnDuringSceneGui(SceneView obj)
    {
        Handles.BeginGUI();
        {
            GUILayout.BeginArea(new Rect(Screen.width / 2, 0, 200, 200));
            {
                GUILayout.BeginVertical(EditorStyles.helpBox);
                GUILayout.BeginHorizontal("box");

                if (GUILayout.Button("<<<"))
                {
                    Time.timeScale = .33F;

                }
                if (GUILayout.Button("<<"))
                {
                    Time.timeScale = .5F;

                }
                if (GUILayout.Button("|"))
                {
                    Time.timeScale = 1F;

                }
                if (GUILayout.Button(">>"))
                {
                    Time.timeScale = 2F;

                }
                if (GUILayout.Button(">>>"))
                {
                    Time.timeScale = 3F;

                }

                GUILayout.EndHorizontal();

                GUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                GUILayout.Label("Time Scale: " + Time.timeScale,style);
                GUILayout.FlexibleSpace();
                GUILayout.EndHorizontal();

                GUILayout.EndVertical();
            }
            GUILayout.EndArea();
        }
        Handles.EndGUI();


    }

}
