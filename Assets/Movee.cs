using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Movee : MonoBehaviour {

    private List<Tile> MyCoordPath;

    void Start()
    {
        MyCoordPath = new List<Tile>();

        Tile a1 = new Tile();
        Tile a2 = new Tile();
        Tile a3 = new Tile();
        Tile a4 = new Tile();
        Tile a5 = new Tile();
        Tile a6 = new Tile();
        Tile a7 = new Tile();

        a1.PosX = 0;
        a1.PosZ = 0;

        a2.PosX = 1;
        a2.PosZ = 0;

        a3.PosX = 2;
        a3.PosZ = 0;

        a4.PosX = 3;
        a4.PosZ = 0;

        a5.PosX = 4;
        a5.PosZ = 0;

        a6.PosX = 4;
        a6.PosZ = 1;

        a7.PosX = 4;
        a7.PosZ = 2;

        MyCoordPath.Add(a1);
        MyCoordPath.Add(a2);
        MyCoordPath.Add(a3);
        MyCoordPath.Add(a4);
        MyCoordPath.Add(a5);
        MyCoordPath.Add(a6);
        MyCoordPath.Add(a7);
    }


    int i = 0;
    bool Move = false;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
            Move = true;

        if (Move)
            StartCoroutine(onCoroutine());
    }

    IEnumerator onCoroutine()
    {
        while (i < MyCoordPath.Count)
        {
            Vector3 endPos = new Vector3(MyCoordPath[i].PosX, 0, MyCoordPath[i].PosZ);
            transform.position = Vector3.MoveTowards(transform.position, endPos, 0.9f * Time.deltaTime);

            if (transform.position == endPos)
                i++;

            print(" moving ");

            yield return new WaitForSeconds(0.5f);
        }

        if (i >= MyCoordPath.Count)
            Move = false;
    }
}
*/