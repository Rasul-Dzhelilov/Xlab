using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
	public class Spawner : MonoBehaviour
	{
		public GameObject Prefab;

		public void Spawn()
		{
			if (Prefab == null)
			{
				Debug.LogError("Spawner.Prefab == null");
				return;
			}

			Instantiate(Prefab, transform.position, Quaternion.identity);
		}

		void Update()
		{

		}
	}
}