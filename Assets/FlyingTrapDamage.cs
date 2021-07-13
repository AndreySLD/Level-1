using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingTrapDamage : MonoBehaviour
{
	[SerializeField] private float _damage;
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			other.GetComponent<HP>().Adjust(-_damage);
		}
	}
}
