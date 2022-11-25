using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


public class MainMenuController : MonoBehaviour
{

    [SerializeField] private ButtonRevealDuration buttonRevealDuration;
    [Header("LEFT")]
    public RectTransform playButton;
    public RectTransform guitarSelect;
    public RectTransform achievements;
    
    [Header("RİGHT")]
    public RectTransform howToPlay;
    public RectTransform options;
    public RectTransform credits;
    void Start()
    {
        //Left Button
        playButton.DOAnchorPosX(-1255f, buttonRevealDuration.revealDuration1).From().SetEase(Ease.OutExpo);
        guitarSelect.DOAnchorPosX(-1255f,  buttonRevealDuration.revealDuration2).From().SetEase(Ease.OutExpo);
        achievements.DOAnchorPosX(-1255f,  buttonRevealDuration.revealDuration3).From().SetEase(Ease.OutExpo);
        //Right Button
        howToPlay.DOAnchorPosX(1400f, buttonRevealDuration.revealDuration1).From().SetEase(Ease.OutExpo);
        options.DOAnchorPosX(1400f, buttonRevealDuration.revealDuration2).From().SetEase(Ease.OutExpo);
        credits.DOAnchorPosX(1400f, buttonRevealDuration.revealDuration3).From().SetEase(Ease.OutExpo);
        //Logo
        //logo.DOAnchorPosY(750, buttonRevealDuration.logoSpeed).From().SetEase(Ease.InElastic);
    }
    
}
