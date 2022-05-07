
using Unity.VisualScripting;
using UnityEngine;

public class SaveData: MonoBehaviour
{
    private static SaveData instance;
    public static SaveData Instance { get { return instance; } set { instance = value; } }

    public static bool saveValue;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveValue(bool value)
    {
        saveValue = value;
    }

    public bool SaveValue()
    {
        return saveValue;
    }
}
