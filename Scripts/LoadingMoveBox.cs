using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingMoveBox : MonoBehaviour
{
    public GameObject loadingBox;
    Vector2 pushBox;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        pushBox = new Vector2(4, 0);
        loadingBox.GetComponent<Rigidbody2D>().velocity = pushBox;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+1);
    }
}
