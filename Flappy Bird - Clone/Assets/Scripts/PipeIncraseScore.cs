using UnityEngine;

public class PipeIncraseScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    { 
        if(col.gameObject.CompareTag("Player")) 
        {
                Debug.Log("score");
             Score.Instance.UpdateScore();
        }
    }
}
