using UnityEngine;

public class ShipShoot : MonoBehaviour
{
    public GameObject lazerPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public float fireRate = 0.2f;

    private float nextFireTime = 0f;

    void Start(){
        InvokeRepeating("Shoot", 0.2f, fireRate);
    }

    private void Update()
    {
        if(Time.time >= nextFireTime){
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
        {
        if (lazerPrefab == null)
        {
        Debug.LogError("Chưa gán Lazer Prefab (Player_short_Lazer) trong Inspector!");
        return;
        }


        if (firePoint == null)
        {
        Debug.LogError("Chưa gán FirePoint trong Inspector!");
        return;
        }


        GameObject lazer = Instantiate(lazerPrefab, firePoint.position, firePoint.rotation);


        Rigidbody2D rb = lazer.GetComponent<Rigidbody2D>();
        if (rb != null)
        rb.linearVelocity = firePoint.up * bulletSpeed;


        Destroy(lazer, 2f);
}
}
