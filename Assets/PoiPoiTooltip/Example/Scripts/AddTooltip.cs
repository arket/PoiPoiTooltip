using UnityEngine;
using UnityEngine.UI;
using PPTooltip;

namespace ExamplePPTooltip {
	/// <summary>
	/// ツールチップ動的生成サンプル
	/// This is an example of creating a tooltip dynamically.
	/// </summary>
	public class AddTooltip : MonoBehaviour {
		public RectTransform target;
		public RectTransform tooltip;
		public TooltipAnimation.ANIMATION_TYPE animation;

		private void Start() {
			Button btn = GetComponent<Button>();
			if (btn == null ||
				target == null ||
				tooltip == null) {
				return;
			}

			btn.onClick.AddListener(SetTooltip);
		}

		public void SetTooltip() {
			try {
				// Set Component to Target UI
				target
					.gameObject
					.AddComponent<PoiPoiTooltip>()
					.InitTooltip(tooltip, animation);
			} catch {
			}
		}
	}
}