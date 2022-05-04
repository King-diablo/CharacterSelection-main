using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{

    [SerializeField] TankView tank;
    [SerializeField] int currentTank = 0;
    [System.Serializable]
    public class Tank
    {
        public TankType type;
        public float movementSpeed;
        public float rotationSpeed;
        public Material tankColor;
    }
    public Tank[] tankTypes;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTank();
    }

    private void SpawnTank()
    {
        TankModel tankModel = new TankModel(tankTypes[currentTank].movementSpeed, tankTypes[currentTank].rotationSpeed, tankTypes[currentTank].type, tankTypes[currentTank].tankColor);
        TankController tankController = new TankController(tankModel, tank);
    }
}
