using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TZ
{
	public class Refresh : MonoBehaviour
	{
		public List<GameObject> Tools;

		private void Start()
		{
			ChangeTool();
		}
		public void ChangeTool()
		{
			var index = Random.Range(0, Tools.Count);
			SetActiveTool(index);
		}
		private void SetActiveTool(int index)
		{
			for (int i = 0; i < Tools.Count; i++)
			{
				Tools[i].SetActive(i == index);
			}
		}
	}
}