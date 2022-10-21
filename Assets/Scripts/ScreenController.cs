using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ScreenController : MonoBehaviour
{
    [SerializeField]
    GameObject screenGame, screenIntro, Player;

    [SerializeField]
    TextMeshPro usuario;

    [SerializeField]
    TextMeshPro imputUser;
    void Start()
    {
        screenGame.SetActive(false);
        Player.SetActive(false);
        screenIntro.SetActive(true);
    }

  public void StartGame()
    {
       
        screenGame.SetActive(true);
        Player.SetActive(true);
        screenIntro.SetActive(false);
        usuario.text = imputUser.text;
    }
}
