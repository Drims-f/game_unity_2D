using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Traps : MonoBehaviour
{
    public GameObject spawn;
    public GameObject player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            /*player.transform.position = new Vector3(
            spawn.transform.position.x,
            spawn.transform.position.y,
            spawn.transform.position.z);*/
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
