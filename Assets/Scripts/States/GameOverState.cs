using Golf;
using System.Collections;
using System.Collections.Generic;
using TZ.Assets.Scripts.States;
using UnityEngine;

namespace TZ
{
	public class GameOverState : GameState
	{
		public GameState mainMenuState;
		public LevelController LevelController;

		public void Restart()
		{
			LevelController.ClearStones();

			Exit();
			mainMenuState.Enter();
		}
	}
}