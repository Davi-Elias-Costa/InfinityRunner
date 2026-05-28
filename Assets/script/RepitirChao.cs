using UnityEngine;
using UnityEngine.Rendering;

public class RepitirChao : MonoBehaviour
{
    private GameController gameControler;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameControler = FindAnyObjectByType<GameController>() as GameController;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {

    }
    void MoveChao()
    {
        transform.Translate(Vector3.left + GameController._ChaoVelocidade * Time.deltaTime);
    }
}
