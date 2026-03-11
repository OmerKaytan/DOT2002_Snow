using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_AnaMenuController : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Continue;
    public GameObject NewGame;
    public GameObject LoadGame;
    public GameObject Settings;
    public GameObject QuitGame;
    public GameObject ReturnButton;

    public void ContunieButtonMethod()
    {
        gameObject.SetActive(false);
        Continue.SetActive(true);
        NewGame.SetActive(false);
        LoadGame.SetActive(false);
        Settings.SetActive(false);
        QuitGame.SetActive(false);
    }
    public void NewGameButtonMethod()
    {
        gameObject.SetActive(false);
        Continue.SetActive(false);
        NewGame.SetActive(true);
        LoadGame.SetActive(false);
        Settings.SetActive(false);
        QuitGame.SetActive(false);
    }
    public void LoadGameButtonMethod()
    {
        gameObject.SetActive(false);
        Continue.SetActive(false);
        NewGame.SetActive(false);
        LoadGame.SetActive(true);
        Settings.SetActive(false);
        QuitGame.SetActive(false);
    }
    public void SettingsButtonMethod()
    {
        gameObject.SetActive(false);
        Continue.SetActive(false);
        NewGame.SetActive(false);
        LoadGame.SetActive(false);
        Settings.SetActive(true);
        QuitGame.SetActive(false);
    }

    public void QuitGameButtonMethod()
    {
        gameObject.SetActive(false);
        Continue.SetActive(false);
        NewGame.SetActive(false);
        LoadGame.SetActive(false);
        Settings.SetActive(false);
        QuitGame.SetActive(true);
    }

    public void ReturnButtonMethod()
    {
        gameObject.SetActive(false);
        Continue.SetActive(false);
        NewGame.SetActive(false);
        LoadGame.SetActive(false);
        Settings.SetActive(false);
        QuitGame.SetActive(false);
        Menu.SetActive(true);
    }
}
