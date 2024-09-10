using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GecisAds : MonoBehaviour
{
    private string _adsUnitGcs = "ca-app-pub-3940256099942544/1033173712";
    InterstitialAd _InterstitialAd;
    private void Start()
    {
        MobileAds.Initialize(initStatus => { LoadInterstitialAd(); });
    }
    public void LoadInterstitialAd()
    {
        if (_InterstitialAd != null)
        {
            CreateInterstitialView();
        }

        var adRequest = new AdRequest();

        InterstitialAd.Load(_adsUnitGcs, adRequest, (InterstitialAd ad, LoadAdError error) =>
        {
            if (error != null || ad == null)
            {
                Debug.Log("Geçiþ reklamý yüklenmesi durumunda hata oluþtu." + error);
                return;
            }
            _InterstitialAd = ad;
        });
    }

    public void CreateInterstitialView()
    {
        if (_InterstitialAd != null && _InterstitialAd.CanShowAd())
        {
            _InterstitialAd.Show();
        }
        else
        {
            Debug.Log("Geçiþ reklamý hazýr deðil");
        }
    }
}
