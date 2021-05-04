using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class SettingsManager : MonoBehaviour
{

    private AudioSource audioSrc;


    private bool isMuted;

    [SerializeField] private GameObject achievementsMenu;
    [SerializeField] private GameObject settingsMenu;
    [SerializeField] private GameObject friendsMenu;
    [SerializeField] private GameObject shopMenu;
    [SerializeField] private GameObject upgradesMenu;
    [SerializeField] private GameObject characterMenu;
    [SerializeField] private GameObject soundMenu;
    [SerializeField] private GameObject moneyMenu;
    [SerializeField] private GameObject MainMenu;
    private List<GameObject> menuList = new List<GameObject>();
    [SerializeField] private Button freindsButton;
    [SerializeField] private Button CharacterButton;
    [SerializeField] private Button UpgradesButton;
    [SerializeField] private Button SettingsButton;
    [SerializeField] private Button moneyButton;
    [SerializeField] private Button shopButton;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        isMuted = PlayerPrefs.GetInt("MUTED") == 1;
        AudioListener.pause = isMuted;
        menuList.Add(settingsMenu);
        menuList.Add(soundMenu);
        menuList.Add(friendsMenu);
        menuList.Add(shopMenu);
        menuList.Add(upgradesMenu);
        menuList.Add(moneyMenu);
        menuList.Add(characterMenu);
        menuList.Add(achievementsMenu);

    }

    //-------============Mute Audio Functionality==============--------
    public void MutePressed()
    {
        if (isMuted = !isMuted)
            AudioListener.pause = isMuted;
        //the playerprefs is going to ask the program if its true or false
        PlayerPrefs.SetInt("Muted", isMuted ? 1 : 0);
    }
    //-------=======Music Volume ======-------


    public void OpenSettingsMenu() => settingsMenu.SetActive(true);
    public void OpenaudioMenu() => soundMenu.SetActive(true);
    public void OpenfreindsMenu() => friendsMenu.SetActive(true);
    public void OpenshopMenu() => shopMenu.SetActive(true);
    public void OpenupgradesMenu() => upgradesMenu.SetActive(true);
    public void OpenmoneyMenu() => moneyMenu.SetActive(true);
    public void OpenCharacterMenu() => characterMenu.SetActive(true);
    public void OpenAchievementMenu() => achievementsMenu.SetActive(true);
    public void OpenMainMenu() => MainMenu.SetActive(true);

    public void Backbutton()
    {


        foreach (GameObject menu in menuList)
        {
            if (menu != true)
            {

                continue;

            }
            menu.SetActive(false);
        }

    }

    public void BackButtonNew()
    {

        foreach (GameObject menu in menuList)
        {
           if (menu.activeInHierarchy == false)
                {

                continue;
            }
            menu.SetActive(false);
        }

        

    }
}









