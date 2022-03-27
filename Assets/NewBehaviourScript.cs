using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TMP_InputField login, password;
    public void SignIn()
    {
        Debug.Log(login.text + "\n" + password.text);
    }
}
