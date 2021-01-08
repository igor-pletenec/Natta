using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class PauseMenu : MonoBehaviour
{
    int checkWifi;

    public GameObject pauseMenu;
    public AudioSource audioSourceMainCamera;
    public AudioSource audioSourcePlayer;

    public Button pauseButton;
    public Button shieldButton;
    public Button reviveButton;

    private int bunnerShow;
    private GameObject player;

    private RewardedAd rewardedAd;
    private BannerView bannerView;

    private void Start()
    {
        audioSourcePlayer = GameObject.FindGameObjectWithTag("Shield").GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player");

        checkWifi = PlayerPrefs.GetInt("CheckWifi");
        if (checkWifi == 0)
        {
            reviveButton.gameObject.SetActive(true);
        }

        if (checkWifi == 1)
        {
            reviveButton.gameObject.SetActive(false);
        }

        string adUnitId = "ca-app-pub-5442177896212042/9322561952"; // идентификатор рекламы награждение
        this.rewardedAd = new RewardedAd(adUnitId);

        // Called when an ad request has successfully loaded.
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });
    }

    public void Pause()
    {
        if (audioSourcePlayer != null)
        {
            pauseButton.enabled = false;
            shieldButton.enabled = false;
            audioSourceMainCamera.Pause();
            audioSourcePlayer.Pause();
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
            player.GetComponent<PlayerController>().enabled = false;
            this.RequestBanner();
        }
        else
        {
            pauseButton.enabled = false;
            shieldButton.enabled = false;
            audioSourceMainCamera.Pause();
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
            player.GetComponent<PlayerController>().enabled = false;
            this.RequestBanner();
        }
    }

    public void Play()
    {

        if (audioSourcePlayer != null)
        {
            pauseButton.enabled = true;
            shieldButton.enabled = true;
            audioSourceMainCamera.UnPause();
            audioSourcePlayer.UnPause();
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
            player.GetComponent<PlayerController>().enabled = true;
        }
        else
        {
            pauseButton.enabled = true;
            shieldButton.enabled = true;
            audioSourceMainCamera.UnPause();
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
            player.GetComponent<PlayerController>().enabled = true;
        }
        bannerView.Destroy();
    }

    public void Revive() //здесь проигрывание видео за одно сердечко
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
    }

    public void RestartOfHome2()
    {
        bannerView.Destroy();
    }

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdLoaded event received");
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToLoad event received with message: "
                             + args.Message);
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdOpening event received");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToShow event received with message: "
                             + args.Message);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdClosed event received");
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        // увеличение жизни на одно сердчеко
        if (audioSourcePlayer != null)
        {
            pauseButton.enabled = true;
            shieldButton.enabled = true;
            audioSourceMainCamera.UnPause();
            audioSourcePlayer.UnPause();
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
            player.GetComponent<PlayerController>().enabled = true;
            player.GetComponent<PlayerController>().health += 1;
            player.GetComponent<PlayerController>().numOfHearts += 1;
            reviveButton.gameObject.SetActive(false);
        }
        else
        {
            pauseButton.enabled = true;
            shieldButton.enabled = true;
            audioSourceMainCamera.UnPause();
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
            player.GetComponent<PlayerController>().enabled = true; // добавил эти три строки
            player.GetComponent<PlayerController>().health += 1;
            player.GetComponent<PlayerController>().numOfHearts += 1;
        }
        bannerView.Destroy();
    }

    private void RequestBanner()
    {
            string adUnitId = "ca-app-pub-5442177896212042/8828857499"; // идентификатор баннера

            // Create a 320x50 banner at the top of the screen.
            this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

            // Create a 320x50 banner ad at coordinate (0,50) on screen.
            BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, 0, -80);

            // Called when an ad request has successfully loaded.
            this.bannerView.OnAdLoaded += this.HandleOnAdLoaded;
            // Called when an ad request failed to load.
            this.bannerView.OnAdFailedToLoad += this.HandleOnAdFailedToLoad;
            // Called when an ad is clicked.
            this.bannerView.OnAdOpening += this.HandleOnAdOpened;
            // Called when the user returned from the app after an ad click.
            this.bannerView.OnAdClosed += this.HandleOnAdClosed;
            // Called when the ad click caused the user to leave the application.
            this.bannerView.OnAdLeavingApplication += this.HandleOnAdLeavingApplication;


            // Create an empty ad request.
            AdRequest request = new AdRequest.Builder().Build();

            // Load the banner with the request.
            this.bannerView.LoadAd(request);
    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLoaded event received");
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("HandleFailedToReceiveAd event received with message: "
                            + args.Message);
    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }
}
