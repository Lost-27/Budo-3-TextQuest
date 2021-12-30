using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    #region Variables

    public Text ContentLabel;
    public Step InitStep;

    private Step _currentStep;

    #endregion


    #region Unity lifecycle

    private void Start()
    {
        SetStep(InitStep);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetStep(_currentStep.FirstStep);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetStep(_currentStep.SecondStep);
        }
    }

    #endregion

    #region Private methods

    private void SetStep(Step nextStep)
    {
        if(nextStep==null)
            return;
        _currentStep = nextStep;
        ContentLabel.text = _currentStep.Content;
    }

    #endregion
}