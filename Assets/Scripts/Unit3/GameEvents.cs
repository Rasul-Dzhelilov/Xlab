using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
	public static class GameEvents
	{
		public static Action OnCollisionStone;
		public static Action OnStickHit;

		public static void CollisionStonesInvoke(Collision collision)
		{
			OnCollisionStone?.Invoke();
		}
		public static void StickHit()
		{
			OnStickHit?.Invoke();
		}
	}
}