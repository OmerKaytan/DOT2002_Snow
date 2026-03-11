using UnityEngine;

public class UI_QuitGame : MonoBehaviour
{

    public GameObject QuitGame;

    public void QuitGameButtonMethod()
    {

        QuitGame.SetActive(true);
    }
}
