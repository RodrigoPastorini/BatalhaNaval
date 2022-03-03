using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class PosCubo : MonoBehaviour
{

  public Material barco, agua,erro,mouseSobre;
  private MeshRenderer _materialCube;
  public bool isBarco;
  private bool _testado =false;
  [HideInInspector] public ControladorJogo control;
  private int _porcentagem = 100;
  private void Awake()
  {
      control = GameObject.FindWithTag("GameController").GetComponent<ControladorJogo>();
      PodeDestruir();
  }

  private void Start()
  { 
      MeshRenderer materialCube= GetComponent<MeshRenderer>();
      materialCube.material = agua;
  }

  void PodeDestruir()
  {
      float rando = Random.Range(0, _porcentagem);
      if (control.nBarcos > 0 && rando >= 85)
      {
          rando = Random.Range(0, _porcentagem);
          if (control.nBarcos > 0 && rando >= 50)
          {
              isBarco = true;
              control.nBarcos--;
              _porcentagem = 50;
              control.barcos += 1;
          }
      }
      else
      {
          isBarco = false;
          _porcentagem += 15;
      }
  }  

  void OnMouseDown()
  {
      if (!_testado)
      {
          if (isBarco)
          {
              MeshRenderer materialCube = GetComponent<MeshRenderer>();
              materialCube.material = barco;
              control.barcos--;
              _testado = true;
          }
          else
          {
              MeshRenderer materialCube = GetComponent<MeshRenderer>();
              materialCube.material = erro;
              _testado = true;
          }
      }
  }

  private void OnMouseOver()
  {
      if (!_testado)
      {
          MeshRenderer materialCube = GetComponent<MeshRenderer>();
          materialCube.material = mouseSobre;
      }
  }

  private void OnMouseExit()
  {
      if (!_testado)
      {
          MeshRenderer materialCube = GetComponent<MeshRenderer>();
          materialCube.material = agua;
      }
  }
}
