using UnityEngine;
using UnityEngine.UI;   

public class Player : MonoBehaviour
{
    
    public GameObject final;
    public Text textCount;
    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Door")
        {
            print("123");
            final.SetActive(true);  
        }

        
        if (collision.tag == "橡果")
        {          
            Destroy(collision.gameObject);           
            count++;
            textCount.text = "Count：" + count;
        }
    }
}
