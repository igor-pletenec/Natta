using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
using System;

public class DeathMenu : MonoBehaviour
{
    public Button pauseButton;
    public Button shieldButton;

    public Text score;
    public Text moneyScore;
    public string scoreLevel;

    public GameObject MoneyManager;
    public GameObject player;

    private int playVideo;

    private InterstitialAd interstitial;
    private BannerView bannerView;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Start()
    {
        playVideo = PlayerPrefs.GetInt("DeathMenu");

        if (playVideo <= 2) // видос после 4 смертей
        {
            playVideo += 1;
            PlayerPrefs.SetInt("DeathMenu", playVideo);
        }
        else if (playVideo > 2)
        {
            playVideo = 0;
            PlayerPrefs.SetInt("DeathMenu", playVideo);
        }

        pauseButton.enabled = false;
        shieldButton.enabled = false;
        Invoke("Restart", 10); // Если ничего не нажимать - рестарт уровня через 10 секунд
        MoneyManager.GetComponent<GameMoney>().RestartOrHome();

        score.text = (PlayerPrefs.GetInt(scoreLevel)).ToString();
        moneyScore.text = ((PlayerPrefs.GetInt(scoreLevel) / 10)).ToString();
        GameMoney.moneyGold += int.Parse(moneyScore.text);

        RequestInterstitial();

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });

        this.RequestBanner();
    }

    public void Update()
    {
        if (playVideo > 2)
        {
            if (this.interstitial.IsLoaded())
            {
                this.interstitial.Show();
            }
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        pauseButton.enabled = true;
        shieldButton.enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        bannerView.Destroy();
    }

    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        bannerView.Destroy();
    }

    private void RequestInterstitial()
    {
        string adUnitId = "ca-app-pub-5442177896212042/6389755786"; // идентификатор межстрочный после 5 смертей

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);

        // Called when an ad request has successfully loaded.
        this.interstitial.OnAdLoaded += HandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.interstitial.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        // Called when an ad is shown.
        this.interstitial.OnAdOpening += HandleOnAdOpened;
        // Called when the ad is closed.
        this.interstitial.OnAdClosed += HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        this.interstitial.OnAdLeavingApplication += HandleOnAdLeavingApplication;


        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);

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

    private void RequestBanner()
    {
        string adUnitId = "ca-app-pub-5442177896212042/8828857499"; // идентификатор баннера

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        // Create a 320x50 banner ad at coordinate (0,50) on screen.
        BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, 0, -80); // заменить на -935???

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
}
