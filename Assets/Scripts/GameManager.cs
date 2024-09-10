using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager _Instance;

    public GameObject _Square;
    public GameObject _EndPanel;
    public Text _TimeText;
    public Text _NowScore;

    bool _IsPlay = true;

    float _Time = 0.0f;

    private void Awake()
    {
        if (_Instance == null)
            _Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        InvokeRepeating("MakeSquare", 0f, 1f);    
    }

    // Update is called once per frame
    void Update()
    {
        if (_IsPlay)
        {
            _Time += Time.deltaTime;
            _TimeText.text = _Time.ToString("N2");
        }
    }

    void MakeSquare()
    {
        Instantiate(_Square);
    }

    public void GameOver()
    {
        _IsPlay = false;
        Time.timeScale = 0.0f;
        _NowScore.text = _Time.ToString("N2");
        _EndPanel.SetActive(true);
    }
}
