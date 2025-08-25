using UnityEngine;
using UnityEngine.UI;

public class BarraVidaUI : MonoBehaviour
{
    public Image barra;

    public void Actualizar(float porcentaje)
    {
        barra.fillAmount = porcentaje;
    }


}
