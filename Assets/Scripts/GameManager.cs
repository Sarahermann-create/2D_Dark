using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject muerte, victoria, reinicio;

    public void MostrarMuerte(){
        muerte.SetActive(true);
        Time.timeScale = 0;
    }

    public void MostrarVictoria(){
        victoria.SetActive(true);
        Time.timeScale = 0;
    }
}
