using System.Collections;
using System.Collections.Generic;
using TZ;
using UnityEngine;

namespace Golf
{
	public class LevelController : MonoBehaviour
	{
		public SpawnerStone Spawner;
		public float DelayMax = 2f;
		public float DelayMin = 0.5f;
		public float DelayStep = 0.1f;

		private float delay = 0.5f;
		private bool isGameOver = false;
		private float lastSpawnerTime = 0;


		//public int score = 0;

		//public int hightScore = 0;
		//private float m_delay = 0.5f;

		private List<GameObject> m_stones = new List<GameObject>(16);

		public void ClearStone()
		{
			foreach (var stone in m_stones)
			{
				Destroy(stone);
			}
			m_stones.Clear();
		}

		public void Start()
		{
			//StartCoroutine(StartStoneProc());
			//StartCoroutine(SpawnStone());
			lastSpawnerTime = Time.time;
			RefreshDelay();
		}
		private void OnEnable()
		{
			Stone.OnCollisionStone += GameOver;
			//GameEvents.onStickHit += OnStickHit;
			//score = 0;

		}

		private void OnDisable()
		{
			Stone.OnCollisionStone -= GameOver;
			//GameEvents.onStickHit -= OnStickHit;

		}
		public void RefreshDelay()
		{
			delay = UnityEngine.Random.Range(DelayMin, DelayMax);
			DelayMax = Mathf.Max(DelayMin, DelayMax - DelayStep);
		}

		private void Update()
		{
			if (Time.time >= lastSpawnerTime + delay)
			{
				Spawner.Spawn();
				lastSpawnerTime = Time.time;

				RefreshDelay();
			}
		}

		void GameOver()
		{
			Debug.Log("GAME OVER!");
			enabled = true;
		}



		/*private void OnStickHit()
		{
			score++;
			hightScore = Mathf.Max(hightScore, score);

			Debug.Log($"score: {score} - hightScore: {hightScore}");
		}*/



		/*

		IEnumerator WaitEvent(System.Action callback)
		{
			yield return new WaitForSeconds(delayStep);
			callback?.Invoke();
		}*/
	}
}