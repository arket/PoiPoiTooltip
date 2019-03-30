using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace PPTooltip {
	public class TooltipAnimation {
		public enum ANIMATION_TYPE {
			TO_TOP,
			TO_TOP_FADE,
			TO_TOP_EXPAND,
			TO_TOP_ATTACHED,
			TO_TOP_FUN,
			TO_BOTTOM,
			TO_BOTTOM_FADE,
			TO_BOTTOM_EXPAND,
			TO_BOTTOM_ATTACHED,
			TO_BOTTOM_FUN,
		}

		public const float FAST = 0.25f;
		public const float NORMAL = 0.35f;
		public const float SLOW = 0.55f;

		private const float MARGIN_Y = 1.13f;

		// Animation Sequence
		private Sequence seq;
		// ToolTip本体
		private RectTransform tooltipRect;
		private CanvasGroup tooltipCanvasGroup;
		// ToolTipを起動させる親RectTransformのサイズ
		private Vector2 parentRectSize;
		private ANIMATION_TYPE animationType;

		/// <summary>
		/// 初期化
		/// </summary>
		/// <param name="rect"></param>
		/// <param name="cg"></param>
		/// <param name="parentSize"></param>
		/// <param name="type"></param>
		public TooltipAnimation(RectTransform rect, CanvasGroup cg, Vector2 parentSize, ANIMATION_TYPE type) {
			tooltipRect = rect;
			tooltipCanvasGroup = cg;
			parentRectSize = parentSize;
			animationType = type;

			seq = DOTween.Sequence();
			seq.SetAutoKill(false);
			seq.OnStart(() => {
				ResetTooltip();
			});

			Vector2 firstPosition = Vector2.zero;

			// アニメーションタイプによってSequenceにアニメーションを指定
			switch (animationType) {
				case ANIMATION_TYPE.TO_TOP:
					// 開始位置を設定
					firstPosition = new Vector2(0, parentRectSize.y / 2);
					seq.Append(tooltipRect.DOLocalMove(firstPosition, 0));

					seq.Append(tooltipRect.DOLocalMove(
						Vector3.up * ((parentRectSize.y / 2) + (tooltipRect.sizeDelta.y / 2)),
						NORMAL).SetEase(Ease.InOutCirc));
					seq.Join(tooltipCanvasGroup.DOFade(1.0f, FAST).SetEase(Ease.InOutCirc));
					break;
				case ANIMATION_TYPE.TO_TOP_FADE:
					// 開始位置を設定
					firstPosition = new Vector2(0, (parentRectSize.y / 2) + (tooltipRect.sizeDelta.y / 2));
					seq.Append(tooltipRect.DOLocalMove(firstPosition, 0));

					seq.Append(tooltipCanvasGroup.DOFade(1.0f, NORMAL).SetEase(Ease.OutCubic));
					break;
				case ANIMATION_TYPE.TO_TOP_EXPAND:
					// 開始位置を設定
					firstPosition = new Vector2(0, (parentRectSize.y / 2) + (tooltipRect.sizeDelta.y / 2));
					seq.Append(tooltipRect.DOLocalMove(firstPosition, 0));
					// 開始サイズを設定
					seq.Join(tooltipRect.DOScale(Vector2.one * 0.5f, 0));

					seq.Append(tooltipCanvasGroup.DOFade(1.0f, SLOW).SetEase(Ease.OutCubic));
					seq.Join(tooltipRect.DOScale(Vector2.one, NORMAL).SetEase(Ease.OutFlash));
					break;
				case ANIMATION_TYPE.TO_TOP_ATTACHED:
					// 開始位置を設定
					firstPosition = new Vector2(0, ((parentRectSize.y / 2) + (tooltipRect.sizeDelta.y / 2)) * MARGIN_Y);
					seq.Append(tooltipRect.DOLocalMove(firstPosition, 0));

					seq.Append(tooltipRect.DOLocalMove(
						Vector3.up * ((parentRectSize.y / 2) + (tooltipRect.sizeDelta.y / 2)),
						FAST).SetEase(Ease.InSine));
					seq.Join(tooltipCanvasGroup.DOFade(1.0f, FAST).SetEase(Ease.InOutCirc));
					break;
				case ANIMATION_TYPE.TO_TOP_FUN:
					// 開始位置を設定
					seq.Append(tooltipRect.DOLocalMove(firstPosition, 0));
					// 開始サイズを設定
					seq.Join(tooltipRect.DOScale(new Vector2(1f, 0.5f), 0));

					seq.Append(tooltipRect.DOLocalMove(
						Vector3.up * ((parentRectSize.y / 2) + (tooltipRect.sizeDelta.y / 2) * MARGIN_Y),
						SLOW).SetEase(Ease.OutBounce));
					seq.Join(tooltipCanvasGroup.DOFade(1.0f, FAST).SetEase(Ease.InOutCirc));
					seq.Join(tooltipRect.DOScale(Vector2.one, SLOW).SetEase(Ease.InOutCirc));
					break;
				case ANIMATION_TYPE.TO_BOTTOM:
					// 開始位置を設定
					firstPosition = new Vector2(0, (parentRectSize.y / 2) * -1f);
					seq.Append(tooltipRect.DOLocalMove(firstPosition, 0));

					seq.Append(tooltipRect.DOLocalMove(
						Vector3.down * ((parentRectSize.y / 2) + (tooltipRect.sizeDelta.y / 2)),
						NORMAL).SetEase(Ease.InOutCirc));
					seq.Join(tooltipCanvasGroup.DOFade(1.0f, FAST).SetEase(Ease.InOutCirc));
					break;
				case ANIMATION_TYPE.TO_BOTTOM_FADE:
					// 開始位置を設定
					firstPosition = new Vector2(0, ((parentRectSize.y / 2) + (tooltipRect.sizeDelta.y / 2)) * -1f);
					seq.Append(tooltipRect.DOLocalMove(firstPosition, 0));

					seq.Append(tooltipCanvasGroup.DOFade(1.0f, NORMAL).SetEase(Ease.OutCubic));
					break;
				case ANIMATION_TYPE.TO_BOTTOM_EXPAND:
					// 開始位置を設定
					firstPosition = new Vector2(0, ((parentRectSize.y / 2) + (tooltipRect.sizeDelta.y / 2)) * -1f);
					seq.Append(tooltipRect.DOLocalMove(firstPosition, 0));
					// 開始サイズを設定
					seq.Join(tooltipRect.DOScale(Vector2.one * 0.5f, 0));

					seq.Append(tooltipCanvasGroup.DOFade(1.0f, SLOW).SetEase(Ease.OutCubic));
					seq.Join(tooltipRect.DOScale(Vector2.one, NORMAL).SetEase(Ease.OutFlash));
					break;
				case ANIMATION_TYPE.TO_BOTTOM_ATTACHED:
					// 開始位置を設定
					firstPosition = new Vector2(0, ((parentRectSize.y / 2) + (tooltipRect.sizeDelta.y / 2)) * MARGIN_Y * -1f);
					seq.Append(tooltipRect.DOLocalMove(firstPosition, 0));

					seq.Append(tooltipRect.DOLocalMove(
						Vector3.down * ((parentRectSize.y / 2) + (tooltipRect.sizeDelta.y / 2)),
						FAST).SetEase(Ease.InSine));
					seq.Join(tooltipCanvasGroup.DOFade(1.0f, FAST).SetEase(Ease.InOutCirc));
					break;
				case ANIMATION_TYPE.TO_BOTTOM_FUN:
					// 開始位置を設定
					seq.Append(tooltipRect.DOLocalMove(firstPosition, 0));
					// 開始サイズを設定
					seq.Join(tooltipRect.DOScale(new Vector2(1f, 0.5f), 0));

					seq.Append(tooltipRect.DOLocalMove(
						Vector3.down * ((parentRectSize.y / 2) + (tooltipRect.sizeDelta.y / 2) * MARGIN_Y),
						SLOW).SetEase(Ease.OutBounce));
					seq.Join(tooltipCanvasGroup.DOFade(1.0f, FAST).SetEase(Ease.InOutCirc));
					seq.Join(tooltipRect.DOScale(Vector2.one, SLOW).SetEase(Ease.InOutCirc));
					break;
				default:
					break;
			}
		}

		/// <summary>
		/// ツールチップの表示アニメーションを開始
		/// </summary>
		public void PlayTooltip() {
			seq.Restart();
		}

		/// <summary>
		/// ツールチップの表示アニメーションを終了
		/// </summary>
		public void StopTooltip() {
			if (seq == null) {
				return;
			}

			seq.Pause();
		}

		/// <summary>
		/// ツールチップの状態リセット
		/// </summary>
		/// <param name="rect"></param>
		private void ResetTooltip() {
			// Position Reset
			tooltipRect.localPosition = Vector2.zero;
			// Scale Reset
			tooltipRect.localScale = Vector2.one;
			// Alpha Reset
			tooltipCanvasGroup.alpha = 0.0f;
		}
	}
}