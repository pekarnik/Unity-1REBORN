using UnityEngine;

namespace FPS
{
	public class InputController:BaseController
	{
		private KeyCode _codeFlashlight = KeyCode.F;
		public override void OnUpdate()
		{
			if (!IsActive) return;
			if(Input.GetKeyDown(_codeFlashlight))
			{
				Main.Instance.FlashlightController.Switch();
			}
		}
	}
}
