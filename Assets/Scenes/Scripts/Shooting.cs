using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public new Transform camera;
    public GameObject explotion;
    public AudioSource popSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit))
        {
            Destroy(hit.transform.gameObject);
            Instantiate(explotion, hit.transform.position, Quaternion.identity);
            popSound.Play();
            GameMamager.instance.count--;
        }
    }
}
