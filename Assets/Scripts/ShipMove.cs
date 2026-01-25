using UnityEngine;

public class ShipMove : MonoBehaviour
{
    public float speed = 5f;
    void Update(){
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        

        Vector3 direction = new Vector3(x,y,0).normalized;

        transform.Translate(direction*speed*Time.deltaTime);
        Debug.Log("Đã thay đổi vị trí"+ transform.position);
    }
}
