using Golf;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TZ.Assets.Scripts.States;
using UnityEngine;

namespace TZ
{
	public class MainMenuState : GameState
	{
		public GameState gamePlayState;
		public LevelController LevelController;
		public TMP_Text scoreText;

		public void PlayGame()
		{
			Exit();
			gamePlayState.Enter();
		}

		protected override void OnEnable()
		{
			base.OnEnable();
			scoreText.text = $"Лучшие очки: {LevelController.HightScore}";
		}
	}
}