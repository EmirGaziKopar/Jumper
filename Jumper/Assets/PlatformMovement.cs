using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float posX;
    public float posX2;

    Vector3 pointA = new Vector3(1, (float)-2.51, 0);
    Vector3 pointB = new Vector3(14, (float)-2.51, 0);
    static int x = -10;
    /*int sayac = 0;*/

    public float hiz = 0.3f;
    public float konum_ayarlayici;
    public float zaman;
    public static int sayac;





    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

        pointA = new Vector3(posX, transform.position.y, 0);
        pointB = new Vector3(posX2, transform.position.y, 0);

        rb = GetComponent<Rigidbody2D>();

        /*Invoke("FixedUpdate", 2);*/
    }

    // Update is called once per frame
    void Update()
    {

    }


    void yuru()
    {
        /* if (sayac < 1)
       {
           sayac++;
           System.Threading.Thread.Sleep(3000);
       } */



        konum_ayarlayici += Time.deltaTime * hiz; // her update �a�r�m�nda topla ile de�eri art�r�yorum e�er topla de�eri i�eride tan�mlanm�� olsayd� her seferinde ilk de�erinden ba�layacakt� 

        transform.position = Vector3.Lerp(pointA, pointB, konum_ayarlayici); //noktaya kadar gitme i�lemi
        if (konum_ayarlayici >= 1)// a + (b -a) * konum_ayarlayici e�er konum_ayarlayici == 1 ise a'lar birbirini g�t�r�r ve sonu� b ye yani varaca��m�z noktaya e�itlenmi� olur dikkat ederseniz zaten konum_ayarlayici de�eri zaman 0.10 olsa 0.10*1'den ba�layarak yava� yava� artacak ve bu de�er 1 oldu�unda b'ye ula�m�� olacak 
        {
            //x = x * -1;
            //transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
            

            var tmp = pointB; // pointB bir nesne oldu�u i�in bu de�i�kenin i�indeki de�erleri de nesne tipinde bir de�i�ken olan var'a at�yoruz 
            pointB = pointA;
            pointA = tmp;
            konum_ayarlayici = 0;
        }
    }
    private void FixedUpdate()
    {
        zaman += Time.deltaTime;
        if (zaman >= 0.5)
        {
            yuru();
        }

    }
}
