using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    [SerializeField] Rigidbody rb;
    [SerializeField] Transform firePoint;
    [SerializeField] Bullet bulletManager;
    [SerializeField] MeshRenderer[] tankRenderer;

    private float horizontalValue;
    private float rotationValue;
    private Quaternion rotValue;

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
        HandleShooting();

        if (horizontalValue != 0) tankController.HandleForwardMovement(horizontalValue, tankModel.moveSpeed);

        if(rotationValue != 0) tankController.HandleRotation(rotationValue, tankModel.rotationSpeed);
    }

    private void HandleShooting()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject go = tankController.FireBullet(bulletManager.bullet, firePoint.position);
        }
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

    public void SetColor(Material _color)
    {
        for (int i = 0; i < tankRenderer.Length; i++)
        {
            tankRenderer[i].material = _color;
        }
    }

    public void SetRotation(Quaternion value)
    {
        rotValue = value;
    }

    public Quaternion GetRotation()
    {
        return rotValue;
    }
}
