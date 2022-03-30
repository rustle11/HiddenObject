using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Del73 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI objectText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(objectText);
    }
}
