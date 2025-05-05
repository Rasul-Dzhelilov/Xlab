using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
	public class PlayerController : MonoBehaviour
	{
		public Spawner Spawner;



		void Update()
		{
			if (Input.GetKeyDown(KeyCode.X))
			{
				Spawner.Spawn();
				Debug.Log("X pressed");
			}
			if (Input.GetKeyDown(KeyCode.Z))
			{
				Debug.Log("Z pressed");
			}
			if (Input.GetKeyDown(KeyCode.Space))
			{
				Debug.Log("Space pressed");
			}
		}
	}

}