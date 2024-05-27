using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogInManager : MonoBehaviour
{
    // Start is called before the first frame update

    public InputField inputPassword;
    public string RightPassword = "Benjo";

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    } 

    public void CheckPassword()
    {
        if (inputPassword.text == RightPassword)
        {
            Debug.Log("Access Granted!");
        }
        else
        {
            Debug.Log("Access Denied");
        }
    }
}
