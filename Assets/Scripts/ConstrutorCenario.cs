using System.Collections.Generic;
using UnityEngine;


public class ConstrutorCenario: MonoBehaviour
{
    public GameObject construtor;
    public PosCubo cubo;
    public int largura, altura;
    [HideInInspector]
    public float x, y;
    public Vector3 central;
    [HideInInspector]
    public int item;
    private void Awake()
    {
        item=largura * altura / 2;
        ConstroiMapa(largura,altura,cubo,construtor);
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void  ConstroiMapa(int largura, int altura, PosCubo cubo,GameObject construtor)
    {
        int contador = 0;
        Vector3 posMapa = new Vector3(-1, -1, 0);
            int[,] mapa = new int[largura, altura];
            for (int i = 0; i <= largura; i++)
            {
                posMapa = new Vector3(posMapa.x + 1, 0, 0);
                for (int j = 0; j < altura; j++)
                {    
                    posMapa = new Vector3(posMapa.x, posMapa.y + 1, 0);
                    x = posMapa.x;
                    y = posMapa.y;
                    Instantiate(cubo, posMapa, transform.rotation,construtor.transform);
                    if (item == contador)
                    {
                        central = posMapa;
                    }

                    contador++;
                }
            }
    }
}

