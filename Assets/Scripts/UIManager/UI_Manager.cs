using TMPro;
using UnityEditor;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    private static UI_Manager instance;
    public static UI_Manager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindAnyObjectByType<UI_Manager>();
            }
            return instance;
        }
    }
    public GameObject EImage;

    public void ActivateEImage(bool isActivating, string objectName)
    {
        EImage.SetActive(isActivating);
        EImage.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = objectName;
    }

}
