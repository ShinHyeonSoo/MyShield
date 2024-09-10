using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject _Square;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeSquare", 0f, 1f);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeSquare()
    {
        Instantiate(_Square);
    }
}
