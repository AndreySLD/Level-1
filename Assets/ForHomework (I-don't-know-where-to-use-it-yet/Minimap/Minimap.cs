using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS 
{
    public sealed class Minimap : MonoBehaviour
    {
        PlayerStats playerStats;
        private Transform _playerCamera;
        void Start()
        {
            playerStats = FindObjectOfType<PlayerStats>();
            _playerCamera = Camera.main.transform;
            //var RenderTexture = Resources.Load<RenderTexture>("Minimap/MinimapTexture");
            //GetComponent<Camera>().targetTexture = RenderTexture;
        }

        void LateUpdate()
        {
            Vector3 newPosition = playerStats.transform.position;
            newPosition.y = transform.position.y;
            transform.position = newPosition;

            transform.rotation = Quaternion.Euler(90f, _playerCamera.eulerAngles.y, 0f);
        }
    }
}
