﻿using UnityEngine;

namespace FPS
{
	public class PlayerHandController : BaseController
	{
		public PlayerHand PlayerHand
		{
			get; private set;
		}
		public PlayerHandController()
		{
			PlayerHand = MonoBehaviour.FindObjectOfType<PlayerHand>();
		}
		public override void OnUpdate()
		{
			PlayerHand.GetRaycastHit();
		}
	}
}