# PoiPoiTooltip

PoiPoiTooltip は簡易ツールチップアセットです。  
ツールチップのデザインは自由にカスタマイズする事ができます。 ( RectTransformのみ)  
アセットを使用するにはDOTweenが必要です。

## Animations
- TO_TOP
- TO_TOP_FADE
- TO_TOP_EXPAND
- TO_TOP_ATTACHED
- TO_TOP_FUN
- TO_BOTTOM
- TO_BOTTOM_FADE
- TO_BOTTOM_EXPAND
- TO_BOTTOM_ATTACHED
- TO_BOTTOM_FUN

## Install
1. プロジェクトに[DOTween](http://dotween.demigiant.com/)をインポートします。
2. PoiPoiTooltip.unitypackage を [latest releases](/PoiPoiTooltip/releases/)からインポートします。

## 使い方

### 静的利用
1. ツールチップを表示させたいRectTransformにPoiPoiTooltipコンポーネントを追加します。
2. `Tool Tip Rect`に表示させたいツールチップをセットします。
3. `Play Animation Type`から表示アニメーションを選択します。

(デモ: Assets/PoiPoiTooltip/Example/Scenes/StaticDemo.unity)

### スクリプトから生成
1. ツールチップを表示させたいRectTransformにPoiPoiTooltipコンポーネントを追加します。
```
[Target RectTransform].gameobject.AddComponent<PoiPoiTooltip>();
```
2. 初期化用のメソッドを叩きます。
```
[Target RectTransform].InitTooltip([tooltip object], [animation type]);
```

 (デモ: Assets/PoiPoiTooltip/Example/Scenes/DynamicDemo.unity)

## Version
- Unity 2018.2.5f1
- DOTween v1.2.235

## License
- MIT License