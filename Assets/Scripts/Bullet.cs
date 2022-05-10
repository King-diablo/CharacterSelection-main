using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CustomBullet")]
public class Bullet : ScriptableObject
{
    public GameObject bullet;
    public TankView tankView;
    public float bulletSpeed;
    public float bulletDamage;
}
