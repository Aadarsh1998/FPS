using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)|| Input.GetMouseButtonDown(0) )
        {
            GameObject bulletReference = Instantiate(bullet);
            bulletReference.transform.position = transform.position;
            Rigidbody rb = bulletReference.GetComponent<Rigidbody>();
            rb.velocity = transform.rotation * Vector3.forward *bulletSpeed;
            if(audio.isPlaying == false)
            {
                audio.Play();
            }
            else
            {
                audio.Stop();
            }
        }
        
    }
}
