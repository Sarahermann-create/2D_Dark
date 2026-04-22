using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;
    public float speed = 5f;
    
    void Start()
    {
        
        
    }

    void Update()
    
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); 
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(moveHorizontal, moveVertical, 0);
        transform.Translate(direction * speed * Time.deltaTime); 
        
    }  

    void OnTriggerEnter2D(Collider2D col)
{
    if (col.CompareTag("Light"))
    {
        gameManager.MostrarMuerte();
    }
}

 


    
}
