using UnityEngine;

public class PlayerController : MonoBehaviour
{
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
}
