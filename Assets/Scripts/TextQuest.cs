using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    #region Variables

    public Text ContentLabel;
    public Text LocationLabel;
    
    public Image LocationImage;
    
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
        int nextStepNumber = GetStepNumber();

        if (nextStepNumber == -1)
            return;
        SetStep(nextStepNumber);
    }

    #endregion

    #region Private methods

    private void SetStep(Step nextStep)
    {
        if (nextStep == null)
            return;
           
        _currentStep = nextStep;
        ContentLabel.text = _currentStep.Content;
        LocationLabel.text = _currentStep.LocationName;
        LocationImage.sprite = _currentStep.LocationImage;
    }

    private void SetStep(int nextStepNumberIndex)
    {
        if (IsInvalidIndex(nextStepNumberIndex))
            return;
        
        Step nextStep = _currentStep.Steps[nextStepNumberIndex];
        SetStep(nextStep);
    }

    private bool IsInvalidIndex(int nextStepNumberIndex)
    {
        return nextStepNumberIndex < 0 || nextStepNumberIndex > _currentStep.Steps.Length - 1;
    }
    // private void UpdateCurrentLocation(string currentLocation)
    // {
    //     LocationLabel.text = currentLocation;
    // }

    private int GetStepNumber()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            return 0;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            return 1;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            return 2;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            return 3;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            return 4;
        }

        return -1;
    }

    #endregion
}