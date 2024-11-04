using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    public string HelloMessage;
    // Start is called before the first frame update
    void Start()
    {
        print(HelloMessage);
    }

    // Update is called once per frame
    void Update()
    {
        print("Coucou");
    }
}
