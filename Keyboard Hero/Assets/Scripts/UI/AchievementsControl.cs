using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using JetBrains.Annotations;
using UnityEngine;

public class AchievementsControl : MonoBehaviour
{
    public RectTransform Guitar1;
    public RectTransform Guitar2;
    public RectTransform Guitar3;
    public RectTransform Guitar4;

    private int count = 0;
    private int PositionData;

    
    void Update()
    {
        GuitarPositionData();
        CountControl();
    }
    public void RightButton()
    {
        count += 1;
        if (count <= 3)
        {
            PositionData += 800;
        }
    }
    public void LeftButton()
    {
        count -= 1;
        if (count >= 0)
        {
            PositionData -= 800;
        }
    }
    public void GuitarPositionData()
    {
        Guitar1.DOAnchorPosX(0 + PositionData, 0.5f).SetEase(Ease.OutExpo);
        Guitar2.DOAnchorPosX(-800 + PositionData, 0.5f).SetEase(Ease.OutExpo);
        Guitar3.DOAnchorPosX(-1600 + PositionData, 0.5f).SetEase(Ease.OutExpo);
        Guitar4.DOAnchorPosX(-2400 + PositionData, 0.5f).SetEase(Ease.OutExpo);
    }
    private void CountControl()
    {
        if (count == 4)
        {
            count = 3;
        }
        if (count == -1)
        {
            count = 0;
        }
    }
}
