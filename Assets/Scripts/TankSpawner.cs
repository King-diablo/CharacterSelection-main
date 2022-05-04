using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] TankView tank;

    // Start is called before the first frame update
    void Start()
    {
        SpawnTank();
    }

    private void SpawnTank()
    {
        TankModel tankModel = new TankModel(150, 30);
        TankController tankController = new TankController(tankModel, tank);
    }
}
