# PoiPoiTooltip

PoiPoiTooltip は簡易ツールチップアセットです。  
ツールチップのデザインは自由にカスタマイズする事ができます。 ( RectTransformのみ)  
全部で10種類のアニメーションがあります。

アセットを使用するにはDOTweenが必要です。

## Animations
- TO_TOP

![1](https://user-images.githubusercontent.com/398736/55278540-f38b6a00-5350-11e9-8ffc-55344518d15a.gif)

- TO_TOP_FADE

![2](https://user-images.githubusercontent.com/398736/55278557-2afa1680-5351-11e9-857c-a9f2eb51096f.gif)

- TO_TOP_EXPAND

![3](https://user-images.githubusercontent.com/398736/55278642-75c85e00-5352-11e9-9075-3646d152952b.gif)

- TO_TOP_ATTACHED

![4](https://user-images.githubusercontent.com/398736/55278644-82e54d00-5352-11e9-84e6-55706908709c.gif)

- TO_TOP_FUN

![5](https://user-images.githubusercontent.com/398736/55278647-8bd61e80-5352-11e9-9137-d9563b686c31.gif)

- TO_BOTTOM

![6](https://user-images.githubusercontent.com/398736/55278650-942e5980-5352-11e9-8051-69df94afc3ad.gif)

- TO_BOTTOM_FADE

![7](https://user-images.githubusercontent.com/398736/55278654-a27c7580-5352-11e9-8dfd-67d0259807c1.gif)

- TO_BOTTOM_EXPAND

![8](https://user-images.githubusercontent.com/398736/55278657-aad4b080-5352-11e9-9234-f7f8b1020f2f.gif)

- TO_BOTTOM_ATTACHED

![9](https://user-images.githubusercontent.com/398736/55278659-b32ceb80-5352-11e9-889b-ede76ff8fd3e.gif)

- TO_BOTTOM_FUN

![10](https://user-images.githubusercontent.com/398736/55278663-baec9000-5352-11e9-97c9-d52af9408ad6.gif)


## Install
1. プロジェクトに[DOTween](http://dotween.demigiant.com/)をインポートします。
2. PoiPoiTooltip.unitypackage を [latest releases](https://github.com/arket/PoiPoiTooltip/releases/)からインポートします。

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