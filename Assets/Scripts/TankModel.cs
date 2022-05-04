using UnityEngine;

public class TankModel
{
    private TankController tankController;
    public float moveSpeed;
    public float rotationSpeed;
    public TankType tankTypes;
    public Material color;

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    public TankModel(float _moveSpeed, float _rotationSpeed, TankType _tankTypes, Material _color)
    {
        moveSpeed = _moveSpeed;
        rotationSpeed = _rotationSpeed;
        tankTypes = _tankTypes;
        color = _color;
    }
}
