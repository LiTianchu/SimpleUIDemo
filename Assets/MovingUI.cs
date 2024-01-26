using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class MovingUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UIManager.Instance.UISlide(GetComponent<CanvasGroup>(), 10f, new Vector3(-500, 0, 0), new Vector3(0, 0, 0));
    }

}
