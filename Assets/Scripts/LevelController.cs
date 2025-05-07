using System.Collections;
using System.Collections.Generic;
using TZ;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace Golf
{
	public class LevelController : MonoBehaviour
	{
		public SpawnerStone Spawner;
		public float DelayMax = 2f;
		public float DelayMin = 0.5f;
		public float DelayStep = 0.1f;
		public int Score = 0;
		public int HightScore = 0;

		private float delay = 0.5f;
		private bool isGameOver = false;
		private float lastSpawnerTime = 0;
		private List<GameObject> stones = new List<GameObject>(16);

		public void Start()
		{
			//StartCoroutine(StartStoneProc());
			//StartCoroutine(SpawnStone());
			lastSpawnerTime = Time.time;
			RefreshDelay();
		}
		private void OnEnable()
		{
			GameEvents.OnStickHit += OnStickHit;
			Score = 0;

		}

		private void OnDisable()
		{
			GameEvents.OnStickHit -= OnStickHit;

		}
		public void RefreshDelay()
		{
			delay = UnityEngine.Random.Range(DelayMin, DelayMax);
			DelayMax = Mathf.Max(DelayMin, DelayMax - DelayStep);
		}

		private void OnStickHit()
		{
			Score++;
			HightScore = Mathf.Max(HightScore, Score);

			Debug.Log($"score: {Score} - hightScore: {HightScore}");
		}

		private void Update()
		{
			if (Time.time >= lastSpawnerTime + delay)
			{
				var stone = Spawner.Spawn();
				stones.Add(stone);
				lastSpawnerTime = Time.time;

				RefreshDelay();
			}
		}

		void GameOver()
		{
			Debug.Log("GAME OVER!");
			enabled = true;
		}

		public void ClearStones()
		{
			foreach (var stone in stones)
			{
				Destroy(stone);
			}
			stones.Clear();
		}

		/*

		IEnumerator WaitEvent(System.Action callback)
		{
			yield return new WaitForSeconds(delayStep);
			callback?.Invoke();
		}*/
	}
}