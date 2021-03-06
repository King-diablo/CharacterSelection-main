using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;

    private Rigidbody rb;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);
        rb = tankView.GetRigidbody();

        tankView.SetColor(tankModel.color);

        tankModel.SetTankController(this);
        tankView.SetTankController(this);

    }

    public void HandleForwardMovement(float moveInput, float moveSpeed)
    {
        rb.velocity = tankView.transform.forward * moveInput * moveSpeed * Time.deltaTime;
    }

    public GameObject FireBullet(GameObject bullet, Vector3 direction)
    {
        return GameObject.Instantiate(bullet, direction, Quaternion.identity);
    }

    public void HandleRotation(float rotationInput, float rotationSpeed)
    {
        Vector3 rotationVector = new Vector3(0.0f, rotationInput * rotationSpeed, 0.0f);
        Quaternion newRotation = Quaternion.Euler(rotationVector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * newRotation);
        tankView.SetRotation(newRotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
