//  ImageNo.cs
//  http://kan-kikuchi.hatenablog.com/entry/SpriteNo
//
//  Created by kan.kikuchi on 2019.09.09.

using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// uGUIのImageで数字を表現するクラス
/// </summary>
public class ImageNo : SpriteNo<Image>
{

    [SerializeField]
    private bool _raycastTarget = false;

    //新しく作ったImageの初期化
    protected override void InitComponent(Image image)
    {
        image.raycastTarget = _raycastTarget;
    }

    //Spriteを更新
//    protected override void UpdateComponent(Image image, Sprite sprite, Color color)
    protected override void UpdateComponent(Image image, Sprite sprite, float textSize)
    {

        image.sprite = sprite;
        //image.color  = color;
        image.SetNativeSize();
//        image.GetComponent<RectTransform>().sizeDelta = new Vector2(image.rectTransform.rect.width, image.rectTransform.rect.width);
        image.GetComponent<RectTransform>().sizeDelta = new Vector2(image.rectTransform.sizeDelta.x * textSize, image.rectTransform.sizeDelta.y * textSize);
//        image.sprite = sprite;
    }

    /// RaycastTargetの設定を変更する
    public void ChangeRaycastTarget(bool raycastTarget)
    {
        _raycastTarget = raycastTarget;
        InitComponents();
    }
}