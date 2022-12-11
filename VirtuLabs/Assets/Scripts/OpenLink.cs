using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{

    // Start is called before the first frame update

    [SerializeField] private string str;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLink()
    {
        Application.OpenURL(str);
    }


}
