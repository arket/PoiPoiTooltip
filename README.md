# PoiPoiTooltip

PoiPoiTooltip is a simple tooltip asset.  
Tooltip design is freely customizable. (Only RectTransform)  
This asset requires DOTween.

[Japanese Readme](/PoiPoiTooltip/blob/master/README_JP.md)

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
1. Import [DOTween](http://dotween.demigiant.com/) into your project.
2. Import PoiPoiTooltip.unitypackage from [latest releases](/PoiPoiTooltip/releases/).

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