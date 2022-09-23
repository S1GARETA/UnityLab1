using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateObjects : MonoBehaviour
{
    [SerializeField] private Text InputText;
    [SerializeField] private InputField inputField;
    [SerializeField] private int Nums;
    public GameObject obj;

    public void SaveText()
    {
        Nums = int.Parse(InputText.text);
        CreateCube(Nums);
    }
    public void CreateCube(int nums)
    {
        Debug.Log(nums);
        for(int i = 0; i < nums; i++)
        {
            Instantiate(obj, new Vector3(RandomNumber(), 5, RandomNumber()), Quaternion.Euler(0, 0, 0));
        } 
    }
    private float RandomNumber()
    {
        return Random.Range(-5, 5);
    }
}
