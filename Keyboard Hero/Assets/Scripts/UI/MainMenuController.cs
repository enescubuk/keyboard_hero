using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


public class MainMenuController : MonoBehaviour
{

    [SerializeField] private ButtonRevealDuration buttonRevealDuration;
    [Header("LEFT BUTTON")]
    public RectTransform playButton;
    public RectTransform guitarSelect;
    public RectTransform achievements;
    
    [Header("RİGHT BUTTON")]
    public RectTransform howToPlay;
    public RectTransform options;
    public RectTransform credits;
    void Start()
    {
        ButtonStart();
    }

    private void Update()
    {
        if (ButtonTransitions.CloseControl)
        {
            ButtonClose();
        }
    }
    
    public void ButtonStart()
    {
        //Left Button
        playButton.DOAnchorPosX(-1255f, buttonRevealDuration.revealDuration1).From().SetEase(Ease.OutExpo);
        guitarSelect.DOAnchorPosX(-1255f,  buttonRevealDuration.revealDuration2).From().SetEase(Ease.OutExpo);
        achievements.DOAnchorPosX(-1255f,  buttonRevealDuration.revealDuration3).From().SetEase(Ease.OutExpo);
        //Right Button
        howToPlay.DOAnchorPosX(1400f, buttonRevealDuration.revealDuration3).From().SetEase(Ease.OutExpo);
        options.DOAnchorPosX(1400f, buttonRevealDuration.revealDuration2).From().SetEase(Ease.OutExpo);
        credits.DOAnchorPosX(1400f, buttonRevealDuration.revealDuration1).From().SetEase(Ease.OutExpo);
    }
    public void ButtonClose()
    {
        //Left Button
        playButton.DOAnchorPosX(-1255f, buttonRevealDuration.revealDuration1).SetEase(Ease.OutExpo);
        guitarSelect.DOAnchorPosX(-1255f,  buttonRevealDuration.revealDuration2).SetEase(Ease.OutExpo);
        achievements.DOAnchorPosX(-1255f,  buttonRevealDuration.revealDuration3).SetEase(Ease.OutExpo);
        //Right Button
        howToPlay.DOAnchorPosX(1400f, buttonRevealDuration.revealDuration3).SetEase(Ease.OutExpo);
        options.DOAnchorPosX(1400f, buttonRevealDuration.revealDuration2).SetEase(Ease.OutExpo);
        credits.DOAnchorPosX(1400f, buttonRevealDuration.revealDuration1).SetEase(Ease.OutExpo);
    }

}
