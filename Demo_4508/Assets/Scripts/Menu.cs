using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIButton : MonoBehaviour
{

    public GameObject obj;
    bool isOpen = false;



    // Update is called once per frame
    public void OpenCloseUI()
    {

        if (isOpen == false)
        {
            Debug.Log(isOpen);
            obj.SetActive(true);
            isOpen = true;
        }
        else
        {
            Debug.Log(isOpen);
            obj.SetActive(false);
            isOpen = false;
        }
    }
}