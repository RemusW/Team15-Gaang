using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour
{

    [SerializeField]
    private Text _text;
    ElapsedTime timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("TimerObject").GetComponent<ElapsedTime>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = Time.time.ToString("0.0");
        print(_text.text);
    }
}
