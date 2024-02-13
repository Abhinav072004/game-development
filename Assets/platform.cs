using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class platform : MonoBehaviour
{
    public int scenename;
    public int nextscene;
   
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.left, ForceMode.VelocityChange);

    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CANDY"))
            
        SceneManager.LoadScene(nextscene);
        if (collision.gameObject.CompareTag("Respawn"))
            
        SceneManager.LoadScene(scenename);
    }
}
