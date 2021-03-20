using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollow : MonoBehaviour
{
    public GameObject[] waypoints;           //metodo usado para englobar os pontos
    int currentWP= 0;                        //waypoint que ele começa

    public float speed= 1.0f;
    float accuracy= 1.0f;
    float rotSpeed= 0.4f;

    private void Start()
    {
        waypoints = GameObject.FindGameObjectsWithTag("waypoint");         //achar as tags do obj em cena
    }

    private void LateUpdate()
    {
        if(waypoints.Length == 0) return;   //se não tiver mais waypoints, retorna pra cá
        
        Vector3 lookAtGoal = new Vector3(waypoints[currentWP].transform.position.x, this.transform.position.y, waypoints[currentWP].transform.position.z);  //Faz olhar para o proximo WP que esta no caminho

        Vector3 direction = lookAtGoal - this.transform.position; this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed); //faz observar outros WP´para realizar a curva com antecedencia

        if(direction.magnitude < accuracy)  //adiciona um WP toda vez que passa por um WP
        { 
            currentWP++;
            if (currentWP >= waypoints.Length) 
            {
                currentWP = 0;
            } 
        }
        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}

