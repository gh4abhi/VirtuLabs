using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{

    [SerializeField] private string str;

    public void LoadLink()
    {
        Application.OpenURL(str);
    }


}
