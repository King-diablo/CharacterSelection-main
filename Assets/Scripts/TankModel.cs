using UnityEngine;

public class TankModel
{
    private TankController tankController;
    public float moveSpeed;
    public float rotationSpeed;

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    public TankModel(float _moveSpeed, float _rotationSpeed)
    {
        moveSpeed = _moveSpeed;
        rotationSpeed = _rotationSpeed;
    }
}
