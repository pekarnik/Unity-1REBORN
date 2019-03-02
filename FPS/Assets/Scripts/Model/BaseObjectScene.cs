﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
	public abstract class BaseObjectScene : MonoBehaviour
	{
		private int _layer;
		public Rigidbody Rigidbody { get; private set; }
		public Transform Transform { get; private set; }
		public int Layer
		{
			get => _layer;
			set
			{
				_layer = value;
				AskLayer(Transform, _layer);
			}
		}

		private void AskLayer(Transform obj, int layer)
		{
			obj.gameObject.layer = layer;
			if (obj.childCount <= 0) return;

			foreach(Transform child in obj)
			{
				AskLayer(child, layer);
			}
		}

		protected virtual void Awake()
		{
			if (GetComponent<Rigidbody>())
			{
				Rigidbody = GetComponent<Rigidbody>();
			}
			Transform = transform;
		}
	}
}
