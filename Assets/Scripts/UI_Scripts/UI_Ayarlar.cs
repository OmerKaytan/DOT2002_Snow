using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Ayarlar : MonoBehaviour
{
    public Transform AyarButonlariTab;
    public GameObject GameSettingsTab;
    public GameObject GraphicsTab;
    public GameObject AudioSettingsTab;
    public Color tiklanilmayanRenk;

    public void GameSettingsButtonMethod()
    {
        GameSettingsTab.SetActive(true);
        GraphicsTab.SetActive(false);
        AudioSettingsTab.SetActive(false);

        foreach (Transform child in AyarButonlariTab)
        {
            child.GetComponent<Image>().color = tiklanilmayanRenk;
        }

        EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = Color.white;
    }
    public void GraphicsButtonMethod()
    {
        GameSettingsTab.SetActive(false);
        GraphicsTab.SetActive(true);
        AudioSettingsTab.SetActive(false);

        foreach (Transform child in AyarButonlariTab)
        {
            child.GetComponent<Image>().color = tiklanilmayanRenk;
        }

        EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = Color.white;
    }

    public void AudioSettingsButtonMethod()
    {
        GameSettingsTab.SetActive(false);
        GraphicsTab.SetActive(false);
        AudioSettingsTab.SetActive(true);

        foreach (Transform child in AyarButonlariTab)
        {
            child.GetComponent<Image>().color = tiklanilmayanRenk;
        }

        EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = Color.white;
    }


}
