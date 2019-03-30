using UnityEngine;
using UnityEngine.EventSystems;

namespace PPTooltip {
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	public class PoiPoiTooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler {
		// ツールチップとして表示したい要素
		[SerializeField]
		private RectTransform toolTipRect;
		// ツールチップの表示アニメーションタイプ
		[SerializeField]
		private TooltipAnimation.ANIMATION_TYPE playAnimationType;

		private RectTransform tooltipInstance;
		private TooltipAnimation tooltipAnimation;
		private Vector2 parentSize;

		private void Awake() {
			InitTooltip();
		}

		private void Start() {
		}

		/// <summary>
		/// ツールチップ静的生成時初期化
		/// </summary>
		private void InitTooltip() {
			// マウスイベントを受けないように停止
			enabled = false;

			if (ValidateInspectorSettings() == false) {
				return;
			}

			CreateTooltip();
		}

		/// <summary>
		/// ツールチップ動的生成時初期化
		/// </summary>
		public void InitTooltip(RectTransform setTooltipRect, TooltipAnimation.ANIMATION_TYPE type) {
			// マウスイベントを受けないように停止
			enabled = false;

			// 既に生成済みの為スキップ
			if (tooltipInstance != null) {
				return;
			}

			toolTipRect = setTooltipRect;
			playAnimationType = type;

			CreateTooltip();
		}

		/// <summary>
		/// 起動に必要な要素が設定済みか確認
		/// </summary>
		/// <returns></returns>
		private bool ValidateInspectorSettings() {
			if (toolTipRect == null) {
				return false;
			}

			return true;
		}

		/// <summary>
		/// ツールチップの実体化
		/// </summary>
		private void CreateTooltip() {
			tooltipInstance = Instantiate(toolTipRect, Vector3.zero, Quaternion.identity);
			tooltipInstance.transform.SetParent(gameObject.transform, false);
			tooltipInstance.gameObject.SetActive(false);

			// 必要なコンポーネントを追加
			CanvasGroup cg = tooltipInstance.gameObject.GetComponent<CanvasGroup>();
			if (cg == null) {
				cg = tooltipInstance.gameObject.AddComponent<CanvasGroup>();
			}

			parentSize = GetComponent<RectTransform>().sizeDelta;
			tooltipAnimation = new TooltipAnimation(tooltipInstance, cg, parentSize, playAnimationType);

			// マウスイベントを受け付けるようにする
			enabled = true;
		}

		/// <summary>
		/// Mouse Event
		/// </summary>
		public void OnPointerEnter(PointerEventData e) {
			ActiveTooltip();
		}
		public void OnSelect(BaseEventData e) {
			ActiveTooltip();
		}
		public void OnPointerExit(PointerEventData e) {
			InactiveTooltip();
		}
		public void OnDeselect(BaseEventData e) {
			InactiveTooltip();
		}

		/// <summary>
		/// ツールチップを表示
		/// </summary>
		private void ActiveTooltip() {
			tooltipInstance.gameObject.SetActive(true);
			tooltipAnimation.PlayTooltip();
		}

		/// <summary>
		/// ツールチップを非表示
		/// </summary>
		private void InactiveTooltip() {
			tooltipAnimation.StopTooltip();
			tooltipInstance.gameObject.SetActive(false);
		}
	}
}