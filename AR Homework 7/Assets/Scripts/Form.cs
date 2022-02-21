using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Form : MonoBehaviour
{
    public GameObject nameTextField;
    public GameObject ageTextField;
    public GameObject submitButton;
    public UserData userData;

    public void Submit() {
        var nameText = nameTextField.GetComponent<InputField>().text;
        var ageText = ageTextField.GetComponent<InputField>().text;
        userData.userName = nameText;
        userData.age = int.Parse(ageText);
    }
}
