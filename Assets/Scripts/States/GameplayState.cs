using Golf;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TZ.Assets.Scripts.States;
using UnityEngine;

namespace TZ
{
	public class GameplayState : GameState
	{
		public LevelController LevelController;
		public PlayerController PlayerController;
		public GameState GameOverState;
		public TMP_Text scoreText;

		protected override void OnEnable()
		{
			base.OnEnable();

			LevelController.enabled = true;
			PlayerController.enabled = true;

			GameEvents.OnCollisionStone += OnGameOver;
			GameEvents.OnStickHit += OnStickHit;
		}

		void OnStickHit()
		{
			scoreText.text = $"Очки: {LevelController.Score}";
		}

		protected override void OnDisable()
		{
			base.OnDisable();

			LevelController.enabled = false;
			PlayerController.enabled = false;

			GameEvents.OnCollisionStone -= OnGameOver;
		}

		void OnGameOver()
		{
			Exit();
			GameOverState.Enter();
		}
	}
}