using UnityEngine;

public class CicloVida : MonoBehaviour
{

    [SerializeField, Range(10, 300)] private int targetFPS = 60;

    void Awake()

    {
        Application.targetFrameRate = targetFPS;
        Debug.Log($"Awake{gameObject.name}: El objeto está inicializado en memoria.");
        Destroy(this, 5f);

    }


    void OnEnable()

    {

        Debug.Log($"OnEnable{gameObject.name}: El objeto ha sido activado.");

    }


    void Start()

    {

        Debug.Log($"Start{gameObject.name}: El objeto está listo justo antes del primer frame.");

    }


    void FixedUpdate()

    {

        Debug.Log($"FixedUpdate{gameObject.name}: Se llama en intervalos fijos, para cálculos físicos.");

    }


    void Update()

    {

        Debug.Log($"Update{gameObject.name}: Se llama cada frame.");

    }


    void OnDisable()

    {

        Debug.Log($"OnDisable{gameObject.name}: El objeto ha sido desactivado.");

    }


    void OnDestroy()

    {

        Debug.Log($"OnDestroy{gameObject.name}: El objeto está siendo destruido y liberado de memoria.");

    }
}