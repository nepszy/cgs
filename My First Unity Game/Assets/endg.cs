
using UnityEngine;

public class endg : MonoBehaviour
{
    public gamestate gamestate;
     void OnTriggerEnter()
    {
        gamestate.level();

    }

}
