using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public GameObject startPanel;
    public int playerScore = 0;
    public Text hitungTeks;
    public Text hitungNyawa;
    public int ronde = 1;
    public GameObject rondeTeks;
    public Text jmlRonde;
    public Text teksJmlRonde;
    public Text targetTeks;
    public int tembakPerRonde = 3;
    public int nyawa = 2;
    public GameObject[] peluru;

    public GameObject GUITeksSkor;
    public GameObject GUITeksNyawa;
    public GameObject GUITargetBidikan;
    public GameObject GUITembak;
    public GameObject GUIAnjing;
    public GameObject GUITeksRonde;
    public GameObject GUIGameOverPanel;
    public GameObject GUIStartPanel;
    public GameObject Terrain;
    public GameObject GUIGun;
    
    //aturan ronde
    private int roundTargetScore = 3;
    public int roundScore = 0;
    private int scoreIncrement = 2;
    public bool playerStarted = false;

    AudioSource audio;

    public AudioClip[] clips;

    void Start() {
        playerScore = int.Parse(hitungTeks.text);
        showStartPanel();
        audio = GetComponent<AudioSource>();
        hitungNyawa.text = nyawa.ToString();    
    }

    private void showStartPanel()
    {
        startPanel.SetActive(true);
    }

    private void hideStartPanel()
    {
        startPanel.SetActive(false);
    }
    
    private void Awake() {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Update() {
        if (DefaultTrackableEventHandler.trueFalse == true)
        {
            hideStartPanel();
            showItems();
            if (playerStarted == false)
            {
                StartCoroutine(playRound());
            }
            playerStarted = true;
        }
        else
        {
            showStartPanel();
            hideItems();
        }
    }

    public void showItems()
    {
        GUITeksSkor.SetActive(true);
        GUITeksNyawa.SetActive(true);
        GUITargetBidikan.SetActive(true);
        GUITembak.SetActive(true);
        GUIAnjing.SetActive(true);
        GUITeksRonde.SetActive(true);
        GUIGameOverPanel.SetActive(true);

        Terrain.SetActive(true);
        GUIGun.SetActive(true);
    }

    public void hideItems()
    {
        GUITeksSkor.SetActive(false);
        GUITeksNyawa.SetActive(false);
        GUITargetBidikan.SetActive(false);
        GUITembak.SetActive(false);
        GUIAnjing.SetActive(false);
        GUITeksRonde.SetActive(false);
        GUIGameOverPanel.SetActive(false);

        Terrain.SetActive(false);
        GUIGun.SetActive(false);
    }

    public IEnumerator playRound() {
        yield return new WaitForSeconds(2f);
        targetTeks.text = "Tembak "+tembakPerRonde+" burung";
    }
}
