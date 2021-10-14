using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace AS
{
    public class EnemySpawner : EditorWindow
    {
        public GameObject[] enemyPrefabs;
        int _selectedPrefab;
        int _countObject;

        void OnGUI()
        {
            ScriptableObject target = this;
            SerializedObject so = new SerializedObject(target);
            SerializedProperty Objects = so.FindProperty("enemyPrefabs");

            EditorGUILayout.PropertyField(Objects, true);

            if (enemyPrefabs != null)
            {
                _selectedPrefab = EditorGUILayout.IntSlider("Номер префаба",
                _selectedPrefab, 0, enemyPrefabs.Length - 1);
            }

            _countObject = EditorGUILayout.IntSlider("Количество объектов",
            _countObject, 1, 10);

            var button = GUILayout.Button("Создать объекты");
            if (button)
            {
                if (enemyPrefabs[_selectedPrefab])
                {
                    for (int i = 0; i < _countObject; i++)
                    {
                        Vector3 pos = new Vector3(0, 0, 0);
                        GameObject go = Instantiate(enemyPrefabs[_selectedPrefab], pos, Quaternion.identity);
                    }
                }
            }
        }
    }
}
