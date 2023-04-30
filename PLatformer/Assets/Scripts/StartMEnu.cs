using UnityEngine;
using UnityEngine.UI;

public class StartMEnu : MonoBehaviour
{
    [SerializeField] private GameObject SetingsMenu;
    [SerializeField] private GameObject LiderMenu;
    [SerializeField] private GameObject GameManager;

    public void OnSetingsMenu()
    {
        gameObject.SetActive(false);
        SetingsMenu.SetActive(true);
    }

    public void OnLiderBord()
    {
        gameObject.SetActive(false);
        LiderMenu.SetActive(true);
    }

    public void OnPlayGame()
    {
        gameObject.SetActive(false);
        GameManager.SetActive(true);
    }
}
