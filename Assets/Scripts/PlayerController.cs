using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
	public class PlayerController : MonoBehaviour
	{
		public Spawner Spawner;
		public CloudController CloudController;

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.X))
			{
				Spawner.Spawn();
				Debug.Log("X pressed");
			}
			if (Input.GetKeyDown(KeyCode.Z))
			{
				CloudController.Action();
				Debug.Log("Z pressed");
			}
			if (Input.GetKeyDown(KeyCode.Space))
			{
				Debug.Log("Space pressed");
			}
		}
	}

}