using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TocarVampiro : MonoBehaviour
{
    public int score;
    public Text txtscore;
    public Transform player;
    public float RandomPosition;




    // Start is called before the first frame update
    void Start()
    {
        ChangePosition ();
        txtscore.text = score.ToString ();
    }

    // Update is called once per frame
    

    public void OnMouseDown () {
        AddScore ();
        ChangePosition ();
    }

    void AddScore () {
         score++;
         txtscore.text = score.ToString ();

    }

    void ChangePosition () {
        transform.position =  new Vector3 ((Random.insideUnitSphere.x*RandomPosition), transform.position.y, (Random.insideUnitSphere.z*RandomPosition)  );
        Vector3 posplayer = new Vector3 (player.position.x, transform.position.y,player.position.z);
        transform.LookAt (posplayer);
    }


}
