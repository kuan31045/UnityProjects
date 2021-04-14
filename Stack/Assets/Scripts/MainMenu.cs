using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using AudienceNetwork;

public class MainMenu : MonoBehaviour
{

    public Text scoreText;

    private AdView adView;

    private void Start()
    {
        LoadBanner();
        scoreText.text = "High : " + PlayerPrefs.GetInt("score").ToString();
    }

    public void ToGame()
    {
        this.adView.Dispose();
        SceneManager.LoadScene("Game");        
    }

    public void LoadBanner()
    {
        if (this.adView)
        {
            this.adView.Dispose();
        }

        this.adView = new AdView("206422780049976_206424250049829", AdSize.BANNER_HEIGHT_50);
        this.adView.Register(this.gameObject);

        // Set delegates to get notified on changes or when the user interacts with the ad.
        this.adView.AdViewDidLoad = (delegate ()
        {
            Debug.Log("Banner loaded.");
            this.adView.Show(100);
            this.adView.Show(AdPosition.TOP);
        });
        adView.AdViewDidFailWithError = (delegate (string error)
        {
            Debug.Log("Banner failed to load with error: " + error);
        });
        adView.AdViewWillLogImpression = (delegate ()
        {
            Debug.Log("Banner logged impression.");
        });
        adView.AdViewDidClick = (delegate ()
        {
            Debug.Log("Banner clicked.");
        });

        // Initiate a request to load an ad.
        adView.LoadAd();
    }
}
