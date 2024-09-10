using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject _Square;
    public Text _TimeText;

    float _Time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeSquare", 0f, 1f);    
    }

    // Update is called once per frame
    void Update()
    {
        _Time += Time.deltaTime;
        _TimeText.text = _Time.ToString("N2");
    }

    void MakeSquare()
    {
        Instantiate(_Square);
    }
}
