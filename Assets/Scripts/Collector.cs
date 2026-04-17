using UnityEngine;
using TMPro;
public class Collector : MonoBehaviour
{
    public int score= 0;
    public bool hasKey = true;
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI notificationText;
    void Start()
    {
        UpdateTextScore();
    }
   
   public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Collectable"))
        {
            score= score + 1; 
            Destroy(other.gameObject);
            UpdateTextScore();
            ShowNotification("Collected!");
            Debug.Log("Collected!");
            Debug.Log("Score: " + score);
        }

        if(other.CompareTag("Key"))
            {
                hasKey = true;
                score= score + 6;
                UpdateTextScore();
                ShowNotification("Key Collected!");

                Destroy(other.gameObject);
                Debug.Log("Key Collected!");  
            }
        if (score >=3 && hasKey) 
            {
                Debug.Log("You Won!");
                ShowNotification("You Won!");
            }
        }
    
    void UpdateTextScore()
{
    textScore.text = "Score:" + score;
}
    void ShowNotification(string message)
    {
        notificationText.text = message;
    }

}
