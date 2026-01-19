using UnityEngine;

public class ShowLog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World Pham Nhu Thang");
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World Pham Nhu Thang" + Time.frameCount);
    }
}
