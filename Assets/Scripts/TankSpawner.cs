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

    }

    public void SpawnTank(TankType _tankType)
    {
        if (_tankType == TankType.GreenTank)
        {
            currentTank = 0;
            BuildTank(currentTank);
        }
        if (_tankType == TankType.RedTank)
        {
            currentTank = 1;
            BuildTank(currentTank);
        }
        if (_tankType == TankType.BlueTank)
        {
            currentTank = 2;
            BuildTank(currentTank);
        }
    }

    private void BuildTank(int _currentTank)
    {
        TankModel tankModel = new TankModel(tankTypes[_currentTank].movementSpeed, tankTypes[_currentTank].rotationSpeed, tankTypes[_currentTank].type, tankTypes[_currentTank].tankColor);
        TankController tankController = new TankController(tankModel, tank);
    }
}
