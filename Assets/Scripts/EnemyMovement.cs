///
/// Permite que el gameObject patrulle entre dos puntos
/// 


using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    #region Variables
    /// Posicion a la que se dirige el game object
    private Transform currentTarget;
    /// <summary>Velocidad de desplazamiento
    /// 
    /// </summary>
    private float speed;
    [SerializeField]private Transform pointA;
    [SerializeField]private Transform pointB;
    #endregion

    #region Unity life circle
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTarget = pointA;
        speed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    #endregion

    #region nethods
    /// <summary>
    /// Actualiza la posicion del enemigo hacia le objetivoActual
    /// </summary>
    public void Move()
    {
        //cambio de posicion
        transform.position = Vector3.MoveTowards(
            transform.position,
            currentTarget.position,
            speed * Time.deltaTime
        );
        //evaluar ejecutar cambio de objetivo
        if (Vector3.Distance(transform.position, currentTarget.position) < 0.05f)
        {
            ChangeTarger();
        }
    }
    /// <summary>
    /// Cambiar la posicion objetivo
    /// </summary>
    public void ChangeTarger()
    {
        if (currentTarget == pointA)
        {
            currentTarget = pointB;
        }
        else
        {
            currentTarget = pointA;
        }
    } 
    
    #endregion
}
