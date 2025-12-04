using UnityEngine;

public class TestPoints : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScoreManager.Instance.AddScore(10);
        }
    }
}
