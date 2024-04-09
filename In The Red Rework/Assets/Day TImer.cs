using System;
using UnityEngine;
using TMPro;

public class DayTImer : MonoBehaviour
{
    private TMP_Text _Timer;
    enum TimerType {Countdown, Stopwatch }
    [SerializeField] private TimerType timerType;

[SerializeField] private float timeToDisplay = 60.00f;

    private bool _isRunning;

    private void Awake()
    {
        _Timer = GetComponent<TMP_Text>();

    }

    private void OnEnable()
    {
        EventManager.TimerStart += EventManager_TimerStart;
        EventManager.TimerStop += EventManager_TimerStop;
        EventManager.TimerUpdate += EventManager_TimerUpdate;
    }

    private void OnDisable()
    {
        EventManager.TimerStart -= EventManager_TimerStart;
        EventManager.TimerStop -= EventManager_TimerStop;
        EventManager.TimerUpdate -= EventManager_TimerUpdate;
    }


    private void EventManager_TimerUpdate(float value) => timeToDisplay += value;
   


    private void EventManager_TimerStop() => _isRunning = false;
    


    private void EventManager_TimerStart() => _isRunning = true;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
