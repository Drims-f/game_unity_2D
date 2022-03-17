using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FINISH : MonoBehaviour
{
    // Start is called before the first frame update
    public string SceneName;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" )
        {
            SceneManager.LoadScene(SceneName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
