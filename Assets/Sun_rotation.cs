using System;
using System.Threading;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Sun_rotation : MonoBehaviour
{
    
    [SerializeField] Transform transform; 
    [SerializeField] float time_rortaion; // в секундах
    float local_rotation = 0;
   

    void Update()
    {
        
        float speed_rortaion = 180/time_rortaion/1000;
        local_rotation += speed_rortaion;
        float  abs_degree = local_rotation * Time.deltaTime;
        transform.Rotate(abs_degree, 0, 0);
        if (transform.eulerAngles.x > 155)
        {
            transform.rotation = Quaternion.Euler( 0, -90, 0);
        }
   
    }
}
