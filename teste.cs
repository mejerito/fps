using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera CameraP;
    float velocidadeRCorpo;
    float velocidadeRCamera;
    float Rcam;
    float velocidadeAndar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rcam = CameraP.transform.eulerAngles.x;
        velocidadeRCorpo = 45;
        velocidadeRCamera = 45;
        velocidadeAndar = 30;
        velocidadeRCorpo=  Input.GetAxis("Mouse X")*velocidadeRCorpo*Time.deltaTime;
        transform.Rotate(0, velocidadeRCorpo, 0);

        velocidadeRCamera = Input.GetAxis("Mouse Y") * velocidadeRCamera * Time.deltaTime;
        if (Rcam >= 200) {
            Rcam = Rcam - 360;
        }
        if (Rcam <30 && Rcam > -30)
        {
            CameraP.transform.Rotate(-velocidadeRCamera, 0, 0);
        }else 
        {
            if(Rcam > 30)
            {
                if(-velocidadeRCamera < 0)
                    CameraP.transform.Rotate(-velocidadeRCamera, 0, 0);
            }
            if(Rcam < -30)
            {
                if (-velocidadeRCamera > 0)
                    CameraP.transform.Rotate(-velocidadeRCamera, 0, 0);
            }
        }
        float frente = Input.GetAxis("Horizontal") * Time.deltaTime*velocidadeAndar;
        float lado = Input.GetAxis("Vertical") * Time.deltaTime * velocidadeAndar;
        transform.Translate(frente, 0, lado);
        
    }
}
