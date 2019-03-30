# PoiPoiTooltip

PoiPoiTooltip is a simple tooltip asset.  
Tooltip design is freely customizable. (Only RectTransform)  
There are 10 types of animations.

This asset requires DOTween.

[日本語 Readme](/README_JP.md)

## Animations
|TO_TOP|TO_TOP_FADE|TO_TOP_EXPAND|TO_TOP_ATTACHED|TO_TOP_FUN|
|-|-|-|-|-|
|<img src="https://user-images.githubusercontent.com/398736/55278540-f38b6a00-5350-11e9-8ffc-55344518d15a.gif" width="150">|<img src="https://user-images.githubusercontent.com/398736/55278557-2afa1680-5351-11e9-857c-a9f2eb51096f.gif" width="150">|<img src="https://user-images.githubusercontent.com/398736/55278642-75c85e00-5352-11e9-9075-3646d152952b.gif" width="150">|<img src="https://user-images.githubusercontent.com/398736/55278644-82e54d00-5352-11e9-84e6-55706908709c.gif" width="150">|<img src="https://user-images.githubusercontent.com/398736/55278647-8bd61e80-5352-11e9-9137-d9563b686c31.gif" width="150">|

|TO_BOTTOM|TO_BOTTOM_FADE|TO_BOTTOM_EXPAND|TO_BOTTOM_ATTACHED|TO_BOTTOM_FUN|
|-|-|-|-|-|
|<img src="https://user-images.githubusercontent.com/398736/55278650-942e5980-5352-11e9-8051-69df94afc3ad.gif" width="150">|<img src="https://user-images.githubusercontent.com/398736/55278654-a27c7580-5352-11e9-8dfd-67d0259807c1.gif" width="150">|<img src="https://user-images.githubusercontent.com/398736/55278657-aad4b080-5352-11e9-9234-f7f8b1020f2f.gif" width="150">|<img src="https://user-images.githubusercontent.com/398736/55278659-b32ceb80-5352-11e9-889b-ede76ff8fd3e.gif" width="150">|<img src="https://user-images.githubusercontent.com/398736/55278663-baec9000-5352-11e9-97c9-d52af9408ad6.gif" width="150">|


## Install
1. Import [DOTween](http://dotween.demigiant.com/) into your project.
2. Import PoiPoiTooltip.unitypackage from [latest releases](https://github.com/arket/PoiPoiTooltip/releases/).

## Usage

### Static generation
1. Add a PoiPoiTooltip component to the RectTransform you want to display a tooltip.
2. Set a Tooltip object that you want to display in `Tool Tip Rect`.
3. Choice a animation type from `Play Animation Type`.

(Demo: Assets/PoiPoiTooltip/Example/Scenes/StaticDemo.unity)

### Dynamic generation
1. Add a PoiPoiTooltip component to the RectTransform you want to display a tooltip.
```
[Target RectTransform].gameobject.AddComponent<PoiPoiTooltip>();
```
2. Use the initialization method.
```
[Target RectTransform].InitTooltip([tooltip object], [animation type]);
```

 (Demo: Assets/PoiPoiTooltip/Example/Scenes/DynamicDemo.unity)

## Version
- Unity 2018.2.5f1
- DOTween v1.2.235

## License
- MIT License