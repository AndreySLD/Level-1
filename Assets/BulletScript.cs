using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class BulletScript : MonoBehaviour
{

	[SerializeField] private float damage = 10;
	[SerializeField] private float bulletSpeed = 5;
	private LayerMask layer;

	public void SetBullet(LayerMask layerMask, Vector3 direction)
	{
		layer = layerMask;
		Rigidbody body = GetComponent<Rigidbody>();
		body.useGravity = false;
		body.velocity = direction * bulletSpeed;
		transform.forward = direction;
	}

	void OnTriggerEnter(Collider other)
	{
		if (!other.isTrigger)
		{
			if (((1 << other.gameObject.layer) & layer) != 0)
			{
                other.GetComponent<HP>().Adjust(-damage);
			}

			Destroy(gameObject);
		}
	}
}