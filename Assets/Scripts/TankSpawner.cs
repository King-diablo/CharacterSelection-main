using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] GameObject tank;
    [SerializeField] bool useKey;
    [SerializeField] KeyCode keyCode;
    private bool isSpawned;
    private GameObject cachedTank;

    // Start is called before the first frame update
    void Start()
    {
        if (useKey) return;
        SpawnTank();
    }

    private void SpawnTank()
    {
        cachedTank = Instantiate(tank, tank.transform.position, Quaternion.identity);
        isSpawned = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(useKey)
        {
            if(Input.GetKeyUp(keyCode))
            {
                if(!isSpawned)
                {
                    SpawnTank();
                }
                else
                {
                    isSpawned = false;
                    Destroy(cachedTank);
                }
            }
        }
    }
}
