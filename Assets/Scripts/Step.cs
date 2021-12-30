using System;
using UnityEngine;

public class Step: MonoBehaviour
{
        [TextArea(6,10)]
        public string Content;
        public Step FirstStep;
        public Step SecondStep;
}