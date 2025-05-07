using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
	public class GameController : MonoBehaviour
	{
		public MainMenuState MainMenuState;

		void Start()
		{
			MainMenuState.gameObject.SetActive(true);
		}
	}
}