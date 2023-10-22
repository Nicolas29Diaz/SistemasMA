using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BananasMovimiento : MonoBehaviour
{
    public int id;
    private bool siendoArrastrado = false;
    private Vector3 posicionInicialDelRaton;
    private Vector3 desplazamiento;
    private Vector3 posicionInicialDelObjeto;
    Camera Cam;
    [SerializeField] Sprite[] Sprites;
    SpriteRenderer SR;

    private void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (siendoArrastrado)
        {
            Vector3 direccionDelDesplazamiento = (Cam.ScreenToWorldPoint(Input.mousePosition) + desplazamiento) - posicionInicialDelRaton;
            transform.position = posicionInicialDelObjeto + new Vector3(direccionDelDesplazamiento.x, direccionDelDesplazamiento.y, 0);
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == this.gameObject)
            {
                siendoArrastrado = true;
                posicionInicialDelRaton = Cam.ScreenToWorldPoint(Input.mousePosition);
                posicionInicialDelObjeto = transform.position;
                desplazamiento = posicionInicialDelObjeto - posicionInicialDelRaton;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            siendoArrastrado = false;
        }
    }

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
}
