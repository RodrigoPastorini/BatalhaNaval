
using UnityEngine;

public class ControladorJogo : MonoBehaviour
{
    public int nBarcos;
    public int barcos = 0;
    private ConstrutorCenario _meuConstrutor;
    public Camera cameraPrincipal;
    private float _sizeCamera;
    private void Awake()
    {
        _meuConstrutor = GameObject.FindWithTag("Construtor").GetComponent<ConstrutorCenario>();
    }

    void Start()
    {
        cameraPrincipal.orthographicSize = (_meuConstrutor.altura + _meuConstrutor.largura) / 2;
        cameraPrincipal.transform.position = new Vector3(_meuConstrutor.central.x,(_meuConstrutor.altura + _meuConstrutor.largura) / 4 , -_meuConstrutor.item/0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
