using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
	public class Stone : MonoBehaviour
	{
		public bool IsAffect = false;
		public static Action OnCollisionStone;

		private void OnCollisionEnter(Collision collision)
		{
			if (collision.transform.TryGetComponent(out Stone other))
			{
				if(!other.IsAffect)
				{
					GameEvents.CollisionStonesInvoke(collision);
				}
			}
		}
	}
}