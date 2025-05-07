using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace TZ.Assets.Scripts.States
{
	public abstract class GameState : MonoBehaviour
	{
		public List<GameObject> views;

		public virtual void Enter()
		{
			gameObject.SetActive(true);
		}

		public virtual void Exit()
		{
			gameObject.SetActive(false);
		}

		protected virtual void OnEnable()
		{
			foreach (var item in views)
			{
				item.SetActive(true);
			}
		}


		protected virtual void OnDisable()
		{
			foreach (var item in views)
			{
				if (item)
				{
					item.SetActive(false);
				}
			}
		}
	}
}