using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
	public class CloudController : MonoBehaviour
	{
		public Transform[] Targets;
		public Cloud Cloud;
		public float MoveSpeed = 15f;
		private int targetIndex = 0;
		private bool isMoved;

		public void Action()
		{
			Debug.Log("Cloud", this);

			if (isMoved)
			{
				return;
			}

			isMoved = true;
			Cloud.StopFX();
			targetIndex++;

			if (targetIndex >= Targets.Length)
			{
				targetIndex = 0;
			}
		}

		private void Update()
		{
			if (!isMoved)
			{
				return;
			}
			//Transform target = targets[m_targetIndex];
			//Vector3 targetPosition = new Vector3(target.position.x, cloud.transform.position.y, target.position.z);
			//Vector3 offset = (targetPosition - cloud.transform.position).normalized * Time.deltaTime * moveSpeed;


			Transform target = Targets[targetIndex];
			Vector3 targetPos = new Vector3(target.position.x, Cloud.transform.position.y, target.position.z);
			Vector3 offset = (targetPos - Cloud.transform.position).normalized * Time.deltaTime * MoveSpeed;
			//Cloud.position = Vector3.Lerp(Cloud.position, targetPos, Time.deltaTime * MoveSpeed);

			if (Vector3.Distance(Cloud.transform.position, targetPos) < offset.magnitude)
			{
				Cloud.transform.position = targetPos;
				isMoved = false;
				Cloud.PlayFX();
			}
			else
			{
				Cloud.transform.Translate(offset);
			}
		}
	}
}