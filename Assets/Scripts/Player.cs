using System.Collections;
using System.Collections.Generic;
using TZ;
using UnityEngine;
using UnityEngine.Networking;

public class Player : MonoBehaviour
{
	public Transform Stick;
	public Transform Helper;
	public float RangeStickRot = -40f;
	public float SpeedStickRot = 500f;
	public float KickPower = 200f;

	private Vector3 lastPos;
	private bool isDown = false;

	private void Update()
	{
		lastPos = Helper.position;

		if (Stick == null)
		{
			Debug.LogError($"Stick ref = null");
			return;
		}

		Quaternion rot = Stick.localRotation;

		Quaternion toRot = Quaternion.Euler(0, 0, isDown ? RangeStickRot : -RangeStickRot);

		rot = Quaternion.RotateTowards(rot, toRot, SpeedStickRot * Time.deltaTime);

		Stick.localRotation = rot;
	}

	public void SetDown(bool value)
	{
		isDown = value;
	}

	public void OnCollisionStick(Collider collider)
	{
		if(collider.TryGetComponent(out Rigidbody body))
		{
			//var dir = isDown ? Stick.right : -Stick.right;
			var dir = (Helper.position - lastPos).normalized;
			body.AddForce(Vector3.left * KickPower, ForceMode.Impulse);

			if(collider.TryGetComponent(out Stone stone) && !stone.IsAffect)
			{
				stone.IsAffect = true;
				GameEvents.StickHit();
			}
		}

		Debug.Log(collider, this);
	}
}