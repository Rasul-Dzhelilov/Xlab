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
		public List<Refresh> Villagers;

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.X))
			{
				Debug.Log("X pressed");
				Spawner.Spawn();
			}
			if (Input.GetKeyDown(KeyCode.Z))
			{
				Debug.Log("Z pressed");
				CloudController.Action();
			}
			if (Input.GetKeyDown(KeyCode.Space))
			{
				Debug.Log("Space pressed");
				foreach (var item in Villagers)
				{
					item.ChangeTool();
				}
			}
		}
	}

}