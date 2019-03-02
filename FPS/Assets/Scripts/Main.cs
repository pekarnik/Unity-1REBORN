using UnityEngine;

namespace FPS
{
	public class Main:MonoBehaviour
	{
		public FlashlightController FlashlightController { get; private set; }
		public InputController InputController { get; private set; }
		public PlayerController PlayerController { get; private set; }

		private BaseController[] Controllers;
		public static Main Instance { get; private set; }
		private void Awake()
		{
			Instance = this;
			PlayerController = new PlayerController(new UnitMotor(GameObject.FindObjectOfType<CharacterController>().transform));
			PlayerController.On();
			Controllers = new BaseController[3];
			FlashlightController = new FlashlightController();
			InputController = new InputController();
			InputController.On();
			Controllers[0] = FlashlightController;
			Controllers[1] = InputController;
			Controllers[2] = PlayerController;
		}

		private void Update()
		{
			for(int i=0;i<Controllers.Length;i++)
			{
				Controllers[i].OnUpdate();
			}
		}
	}
}
