using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBrain : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Bullet bulletManager;

    private void Awake()
    {
        bulletManager.tankView = FindObjectOfType<TankView>();
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(bulletManager.tankView.transform.forward * bulletManager.bulletSpeed, ForceMode.Impulse);
    }
}
