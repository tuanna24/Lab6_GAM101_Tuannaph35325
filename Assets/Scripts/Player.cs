using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panelEndGame;
    public Rigidbody2D rigidbody2D;
    
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    public void Jump()
    {
        Debug.Log("Vao ham Jump");
        rigidbody2D.AddForce(Vector2.up * 6, ForceMode2D.Impulse);
    }
    public void Left()
    {
        Debug.Log("Vao ham Left");
        rigidbody2D.AddForce(Vector2.left * 3, ForceMode2D.Impulse);
    }
    public void Right()
    {
        Debug.Log("Vao ham Right");
        rigidbody2D.AddForce(Vector2.right * 3, ForceMode2D.Impulse);

    }
    public void ReStarGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("obstacles")) {
            Debug.Log("Va Vao Lua");
            panelEndGame.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
