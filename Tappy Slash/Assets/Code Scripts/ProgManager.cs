using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProgManager : MonoBehaviour
{

    public Image progressBar;
    public float progressAmt = 3f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Progress()
    {
        progressAmt = Mathf.Clamp(progressAmt, 0, 3);
        progressBar.fillAmount = progressAmt / 3f;

        
    }

}
