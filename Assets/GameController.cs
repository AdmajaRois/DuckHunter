using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    AudioSource audio;

    public AudioClip[] clips;
    
    private void Awake() {
        if (instance == null)
        {
            instance = this;
        }
    }
}
