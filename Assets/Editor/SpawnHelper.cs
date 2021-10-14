using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace AS
{
    public class SpawnHelper : MonoBehaviour
    {
        [MenuItem("SpawnHelper/EnemySpawner")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(EnemySpawner), false, "EnemySpawner");
        }
    }
}
