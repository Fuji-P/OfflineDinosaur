//  SpriteRendererNo.cs
//  http://kan-kikuchi.hatenablog.com/entry/SpriteNo
//
//  Created by kan.kikuchi on 2019.09.09.

using UnityEngine;

/// <summary>
/// SpriteRendererで数字を表現するクラス
/// </summary>
public class SpriteRendererNo : SpriteNo<SpriteRenderer>
{

    [SerializeField]
    private string _sortingLayerName = "Default";

    [SerializeField]
    private int _sortingOrder = 0;
    //新しく作ったSpriteRendererの初期化
    protected override void InitComponent(SpriteRenderer spriteRenderer)
    {
        spriteRenderer.sortingLayerName = _sortingLayerName;
        spriteRenderer.sortingOrder     = _sortingOrder;
    }

    //Spriteを更新
//    protected override void UpdateComponent(SpriteRenderer spriteRenderer, Sprite sprite, Color color)
    protected override void UpdateComponent(SpriteRenderer spriteRenderer, Sprite sprite, float textSize)
    {
        spriteRenderer.sprite = sprite;
//        spriteRenderer.color  = color;
    }

    // sortingLayerNameの設定を変更する
    public void ChangeSortingLayerName(string sortingLayerName)
    {
        _sortingLayerName = sortingLayerName;
        InitComponents();
    }
    // sortingOrderの設定を変更する
    public void ChangeSortingOrder(int sortingOrder)
    {
        _sortingOrder = sortingOrder;
        InitComponents();
    }
}