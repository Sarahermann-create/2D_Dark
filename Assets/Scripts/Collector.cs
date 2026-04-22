using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; 

public class Collector : MonoBehaviour
{
    public int score = 0;
    public int score2 = 0;
    public int keyCount = 0;

    public bool hasKey = false;
    public bool hasLight = false;

    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textScore2;
    public TextMeshProUGUI notificationText;
    public TextMeshProUGUI keyText; 

    public GameObject loseScreen; 

    void Start()
    {
        UpdateTextScore();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Collectable"))
        {
            score = score + 1; 
            Destroy(other.gameObject);
            UpdateTextScore();
            ShowNotification("Collected shirt!");
        }

        if(other.CompareTag("Collectable2"))
        {
            score2 = score2 + 1; 
            Destroy(other.gameObject);
            UpdateTextScore();
            ShowNotification("Collected socks!");
        }

        if(other.CompareTag("Key"))
        {
            keyCount = keyCount + 1;
            hasKey = true;
            Destroy(other.gameObject);
            UpdateTextScore();
            ShowNotification("Key Collected!");
        }

        if (score >= 8 && score2 >= 8 && keyCount >= 1) 
        {
            Debug.Log("You Won!");
            ShowNotification("You Won!");
            gameObject.SetActive(false); 
        }

        if(other.CompareTag("Light"))
        {
            hasLight = true;
            Destroy(gameObject);
            ShowNotification("Demasiado cerca, la luz disolvió la sombra ");
            Debug.Log("You Lost!");
            loseScreen.SetActive(true); 
        }
    }

    void UpdateTextScore()
    {
        textScore.text = "Shirt: " + score + "/8";
        textScore2.text = "Socks: " + score2 + "/8";
        keyText.text = "Key: " + keyCount + "/1"; 
    }

    void ShowNotification(string message)
{
    StopAllCoroutines(); 
    notificationText.text = message;
    StartCoroutine(ClearNotification());
}
  //botón para reiniciar el juego:
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
System.Collections.IEnumerator ClearNotification()
{
    yield return new WaitForSeconds(1f);
    notificationText.text = "";
}

}

