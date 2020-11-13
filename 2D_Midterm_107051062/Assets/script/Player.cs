using UnityEngine;
using UnityEngine.UI;   

public class Player : MonoBehaviour
{
    
    public GameObject final;
    public Text textCount;
    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "傳送門")
        {
            final.SetActive(true);  
        }

        // 如果碰到物件的標籤式櫻桃就吃掉她
        if (collision.tag == "櫻桃")
        {
            // 刪除(碰到的遊戲物件)
            // gameObject 此腳本的遊戲物件
            Destroy(collision.gameObject);
            // 遞增
            count++;
            // 道具數量的文字 = "櫻桃數量：" + 數量
            textCount.text = "櫻桃數量：" + count;
        }
    }
}
