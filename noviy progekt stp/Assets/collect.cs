using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collect : MonoBehaviour
{
    // Start is called before the first frame update
    public Text apple_text;
    private int score_fruits = 0;
    void Start()
    {
        apple_text.text = "0";
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fruits")
        {
            score_fruits++;
            apple_text.text = score_fruits + "";
            Destroy(other.gameObject);
        }
    }
}
