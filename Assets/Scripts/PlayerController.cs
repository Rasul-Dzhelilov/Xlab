using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
	public class PlayerController : MonoBehaviour
	{
		[SerializeField] private Player player;
		
		private void Start()
		{
			if(player==null)
			{
				Debug.LogError("Player = null");
			}
		}
		
		void Update()
		{
			//player.SetDown(Input.GetMouseButton(0));
		}

		public void OnDown()
		{
			player.SetDown(true);
		}

		public void OnUp()
		{
			player.SetDown(false);
		}
	}
}