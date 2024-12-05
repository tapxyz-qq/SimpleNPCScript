using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public int health = 3;
    public float speed = 1.2f;


    // Start is called before the first frame update
    void Start()
    {
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = this.transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
