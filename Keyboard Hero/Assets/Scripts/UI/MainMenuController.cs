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
    
    [Header("CANVAS")]
    public GameObject MainMenuCanvas;
    public GameObject OptionsCanvas;
    public GameObject CreditsCanvas;
    public GameObject GuitarSelectCanvas;
    public GameObject AchievementsCanvas;
    public GameObject HotToPlayCanvas;
    void Start()
    {
        ButtonStart();
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
        playButton.DOAnchorPosX(-1255f, buttonRevealDuration.revealDuration1-0.5f).SetEase(Ease.OutExpo);
        guitarSelect.DOAnchorPosX(-1255f,  buttonRevealDuration.revealDuration2-0.5f).SetEase(Ease.OutExpo);
        achievements.DOAnchorPosX(-1255f,  buttonRevealDuration.revealDuration3-0.5f).SetEase(Ease.OutExpo);
        //Right Button
        howToPlay.DOAnchorPosX(1400f, buttonRevealDuration.revealDuration3-0.5f).SetEase(Ease.OutExpo);
        options.DOAnchorPosX(1400f, buttonRevealDuration.revealDuration2-0.5f).SetEase(Ease.OutExpo);
        credits.DOAnchorPosX(1400f, buttonRevealDuration.revealDuration1-0.5f).SetEase(Ease.OutExpo);
    }

    public void BackClose()
    {
        //Left Button
        playButton.DOAnchorPosX(-600f, buttonRevealDuration.revealDuration1).SetEase(Ease.OutExpo);
        guitarSelect.DOAnchorPosX(-600f,  buttonRevealDuration.revealDuration2).SetEase(Ease.OutExpo);
        achievements.DOAnchorPosX(-600f,  buttonRevealDuration.revealDuration3).SetEase(Ease.OutExpo);
        //Right Button
        howToPlay.DOAnchorPosX(600f, buttonRevealDuration.revealDuration3).SetEase(Ease.OutExpo);
        options.DOAnchorPosX(600f, buttonRevealDuration.revealDuration2).SetEase(Ease.OutExpo);
        credits.DOAnchorPosX(600f, buttonRevealDuration.revealDuration1).SetEase(Ease.OutExpo);
    }

    public void GuitarSelectButton()
    {
        StartCoroutine(GuitarSelectIE());
    }
    public void AchievementsButton()
    {
        StartCoroutine(AchievementsIE());
    }
    public void HowToPlayButton()
    {
        StartCoroutine(HowToPlayIE());
    }
    public void OptionsButton()
    {
        StartCoroutine(OptionsIE());
    }
    public void CreditsButton()
    {
        StartCoroutine(CreditsIE());
    }

    
    public void BackButton()
    {
        OptionsCanvas.SetActive(false);
        CreditsCanvas.SetActive(false);
        GuitarSelectCanvas.SetActive(false);
        AchievementsCanvas.SetActive(false);
        HotToPlayCanvas.SetActive(false);
        MainMenuCanvas.SetActive(true);
        BackClose();
    }

    IEnumerator GuitarSelectIE()
    {
        ButtonClose();
        yield return new WaitForSeconds(0.7f);
        MainMenuCanvas.SetActive(false);
        GuitarSelectCanvas.SetActive(true);
    }
    IEnumerator AchievementsIE()
    {
        ButtonClose();
        yield return new WaitForSeconds(0.7f);
        MainMenuCanvas.SetActive(false);
        AchievementsCanvas.SetActive(true);
    }
    IEnumerator HowToPlayIE()
    {
        ButtonClose();
        yield return new WaitForSeconds(0.7f);
        MainMenuCanvas.SetActive(false);
        HotToPlayCanvas.SetActive(true);
    }
    IEnumerator OptionsIE()
    {
        ButtonClose();
        yield return new WaitForSeconds(0.7f);
        MainMenuCanvas.SetActive(false);
        OptionsCanvas.SetActive(true);
    }
    IEnumerator CreditsIE()
    {
        ButtonClose();
        yield return new WaitForSeconds(0.7f);
        MainMenuCanvas.SetActive(false);
        CreditsCanvas.SetActive(true);
    }
    
}
