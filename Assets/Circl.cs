using UnityEngine;
using System.Collections;

public class Circl : MonoBehaviour
{

    public float Radius; //Радиус траектории 
    public float TimePeriod; //Период
    private float CornerSpeed; //Угловая скорость
    private float Sector; //Угол, в радианах, на который сфера смещена от начальной позиции
    private float Rad = 6.28f; //Радиан в окружности
    private float X = 0.0f;
    private float Y = 0.0f; //Не изменяется, перемещение идет по осям X и Z
    private float Z = 0.0f;

    void Start()
    {
        CornerSpeed = Rad / TimePeriod;
        Sector = CornerSpeed;
    }
    void Update()
    {

        X = Mathf.Cos(Sector);
        Z = Mathf.Sin(Sector);

        transform.Translate(new Vector3(X, Y, Z) * Time.deltaTime * Radius);

        Sector += CornerSpeed;

    }
}
