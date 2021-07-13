using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineScript : MonoBehaviour
{
    [SerializeField] private SphereCollider _ExlosionCollider;
    [SerializeField] private float _distance;
    [SerializeField] private float _damage;
    void Start()
    {
        _distance = _ExlosionCollider.radius;
    }
    private void OnTriggerEnter(Collider other)
    {   
        if (other.tag == "Player")
        {
            other.GetComponent<HP>().Adjust(-_damage);
            Destroy(gameObject);
        }
    }
}

