using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    [SerializeField] TankSpawner tankSpawner;

    void Start()
    {
    }

    public void SpawnBlueTank()
    {
        Debug.Log("1");
        tankSpawner.SpawnTank(TankType.BlueTank);
        Debug.Log("2");
        gameObject.SetActive(false);
        Debug.Log("3");
    }

    public void SpawnGreenTank()
    {
        tankSpawner.SpawnTank(TankType.GreenTank);
        gameObject.SetActive(false);
    }

    public void SpawnRedTank()
    {
        tankSpawner.SpawnTank(TankType.RedTank);
        gameObject.SetActive(false);
    }
}
