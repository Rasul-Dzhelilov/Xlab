using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TZ
{
	public class Stick : MonoBehaviour
	{
		public UnityEvent<Collider> OnCollision;

		public void OnCollisionEnter(Collision collision)
		{
			OnCollision.Invoke(collision.collider);
		}
	}
}