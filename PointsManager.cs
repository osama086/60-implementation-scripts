using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    public static int numberOfPoints;
    public Text PointsText;

    // Start is called before the first frame update
    void Start()
    {
        numberOfPoints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PointsText.text = " " + numberOfPoints;
    }
}
