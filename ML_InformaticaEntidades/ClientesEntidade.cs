﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_InformaticaEntidades
{
  public class ClientesEntidade
  {
    public int? CodigoCliente { get; set; }
    public string Nome { get; set; }
    public string Apelido { get; set; }
    public string Endereco { get; set; }
    public string Numero { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public int? CodigoMunicipio { get; set; }
    public string NomeMunicipio { get; set; }
    public string Uf { get; set; }
    public string Cep { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Celular { get; set; }
  }
}
