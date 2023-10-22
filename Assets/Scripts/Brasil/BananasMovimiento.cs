using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BananasMovimiento : MonoBehaviour
{
<<<<<<< Updated upstream
    public int id;
=======
>>>>>>> Stashed changes
    private bool siendoArrastrado = false;
    private Vector3 posicionInicialDelRaton;
    private Vector3 desplazamiento;
    private Vector3 posicionInicialDelObjeto;
<<<<<<< Updated upstream
    Camera Cam;
    [SerializeField] Sprite[] Sprites;
    SpriteRenderer SR;

    private void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }
=======
    [SerializeField]Camera cam;
>>>>>>> Stashed changes
    void Update()
    {
        if (siendoArrastrado)
        {
<<<<<<< Updated upstream
            Vector3 direccionDelDesplazamiento = (Cam.ScreenToWorldPoint(Input.mousePosition) + desplazamiento) - posicionInicialDelRaton;
=======
            Vector3 direccionDelDesplazamiento = (cam.ScreenToWorldPoint(Input.mousePosition) + desplazamiento) - posicionInicialDelRaton;
>>>>>>> Stashed changes
            transform.position = posicionInicialDelObjeto + new Vector3(direccionDelDesplazamiento.x, direccionDelDesplazamiento.y, 0);
        }

        if (Input.GetMouseButtonDown(0))
        {
<<<<<<< Updated upstream
            RaycastHit2D hit = Physics2D.Raycast(Cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == this.gameObject)
            {
                siendoArrastrado = true;
                posicionInicialDelRaton = Cam.ScreenToWorldPoint(Input.mousePosition);
=======
            RaycastHit2D hit = Physics2D.Raycast(cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == this.gameObject)
            {
                siendoArrastrado = true;
                posicionInicialDelRaton = cam.ScreenToWorldPoint(Input.mousePosition);
>>>>>>> Stashed changes
                posicionInicialDelObjeto = transform.position;
                desplazamiento = posicionInicialDelObjeto - posicionInicialDelRaton;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            siendoArrastrado = false;
        }
    }
<<<<<<< Updated upstream

    public void SetNum(int BananaNum, Camera cam)
    {
        id = BananaNum;
        SR.sprite = Sprites[BananaNum];
        Cam = cam;
    }

    public void Delete()
    {
        Destroy(this.gameObject);
    }
=======
>>>>>>> Stashed changes
}
