using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    [SerializeField] Rigidbody rb;

    private float horizontalValue;
    private float rotationValue;

    private GameObject cam;
    private TankModel tankModel;

    private void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0, 3, -4);

        tankModel = tankController.GetTankModel();
    }

    void Update()
    {
        HandleMovementInput();

        if (horizontalValue != 0) tankController.HandleForwardMovement(horizontalValue, tankModel.moveSpeed);

        if(rotationValue != 0) tankController.HandleRotation(rotationValue, tankModel.rotationSpeed);
    }
    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    public void HandleMovementInput()
    {
        horizontalValue = Input.GetAxis("Vertical");
        rotationValue = Input.GetAxis("Horizontal");
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}
