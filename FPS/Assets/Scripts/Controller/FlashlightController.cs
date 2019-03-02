using UnityEngine;
namespace FPS
{
	public class FlashlightController : BaseController
	{
		private Flashlight _flashLight;
		private FlashLightUIText _flashLightUi;

		public FlashlightController()
		{
			_flashLight = MonoBehaviour.FindObjectOfType<Flashlight>();
			_flashLightUi = MonoBehaviour.FindObjectOfType<FlashLightUIText>();
			Off();
		}

		public override void OnUpdate()
		{
			if (!IsActive)
			{
				_flashLight.RechargeBattery();
				return;
			}

			if (_flashLight == null) return;
			_flashLight.Rotation();
			if (_flashLight.EditBatteryCharge())
			{
				_flashLightUi.Text = _flashLight.BatteryChargeCurrent;
			}
			else
			{
				Off();
			}
		}

		public override void On()
		{
			if (IsActive) return;
			base.On();
			_flashLight.Switch(true);
			_flashLightUi.SetActive(true);
		}

		public sealed override void Off()
		{
			if (!IsActive) return;
			base.Off();
			_flashLight.Switch(false);

			_flashLightUi.SetActive(false);
		}
	}
}
