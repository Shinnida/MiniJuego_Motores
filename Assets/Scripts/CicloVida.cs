using UnityEngine;

public class CicloVida : MonoBehaviour
{

    [SerializeField, Range(10, 300)] private int targetFPS = 60;

    void Awake()

    {
        Application.targetFrameRate = targetFPS;
        Debug.Log($"Awake{gameObject.name}: El objeto est� inicializado en memoria.");
        Destroy(this, 5f);

    }


    void OnEnable()

    {

        Debug.Log($"OnEnable{gameObject.name}: El objeto ha sido activado.");

    }


    void Start()

    {

        Debug.Log($"Start{gameObject.name}: El objeto est� listo justo antes del primer frame.");

    }


    void FixedUpdate()

    {

        Debug.Log($"FixedUpdate{gameObject.name}: Se llama en intervalos fijos, para c�lculos f�sicos.");

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

        Debug.Log($"OnDestroy{gameObject.name}: El objeto est� siendo destruido y liberado de memoria.");

    }
}