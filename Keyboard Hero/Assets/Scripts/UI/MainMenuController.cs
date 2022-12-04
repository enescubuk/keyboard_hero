using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public RectTransform quit;

    [Header("CANVAS")]
    public GameObject MainMenuCanvas;
    public GameObject OptionsCanvas;
    public GameObject CreditsCanvas;
    public GameObject GuitarSelectCanvas;
    public GameObject AchievementsCanvas;
    public GameObject HotToPlayCanvas;
    public GameObject SongSelectCanvas;
    
    [Header("SOUND SELECT")]
    public RectTransform SoundScreenPlayButton;
    public GameObject Sound1Text;
    public GameObject ButtonChild;
    void Start()
    {
        ButtonStart();
    }
    public void play()
    {
        SceneManager.LoadScene("SampleScene");
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
        quit.DOAnchorPosX(1400f, buttonRevealDuration.revealDuration1).From().SetEase(Ease.OutExpo);
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
        quit.DOAnchorPosX(1400f, buttonRevealDuration.revealDuration1-0.5f).SetEase(Ease.OutExpo);
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
        quit.DOAnchorPosX(600f, buttonRevealDuration.revealDuration1).SetEase(Ease.OutExpo);

    }

    
    public void PlayButton()
    {
        StartCoroutine(SongSelectIE());
    }

    public void Sound1()
    {
        StartCoroutine(Sound1IE());
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
    
    public void QuitButton()
    {
        Application.Quit();
    }
    public void BackButton()
    {
        OptionsCanvas.SetActive(false);
        CreditsCanvas.SetActive(false);
        GuitarSelectCanvas.SetActive(false);
        AchievementsCanvas.SetActive(false);
        HotToPlayCanvas.SetActive(false);
        SongSelectCanvas.SetActive(false);
        MainMenuCanvas.SetActive(true);
        Sound1Text.SetActive(false);
        ButtonChild.SetActive(false);
        BackClose();
    }

    IEnumerator Sound1IE()
    {
        Sound1Text.SetActive(true);
        ButtonChild.SetActive(true);
        SoundScreenPlayButton.DOAnchorPosY(-34f, 1f).SetEase(Ease.OutExpo);
        yield return new WaitForSeconds(2f);
    }
    IEnumerator SongSelectIE()
    {
        ButtonClose();
        yield return new WaitForSeconds(0.7f);
        MainMenuCanvas.SetActive(false);
        SongSelectCanvas.SetActive(true);
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
        AchievementsCanvas.SetActive(true);
        yield return new WaitForSeconds(3f);
        AchievementsCanvas.SetActive(false);
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
