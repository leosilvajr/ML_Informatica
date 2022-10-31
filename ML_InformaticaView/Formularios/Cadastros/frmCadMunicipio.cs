using ML_InformaticaView.Formularios.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ML_InformaticaView.Formularios.Cadastros
{
  public partial class frmCadMunicipio : frmBaseCadastro
  {
    public frmCadMunicipio()
    {
      InitializeComponent();
    }

    public override bool Func_AcaoCancelar()
    {
      return base.Func_AcaoCancelar();
    }

    public override bool Func_AcaoExcluir()
    {
      return base.Func_AcaoExcluir();
    }

    public override bool Func_AcaoGravar()
    {
      return base.Func_AcaoGravar();
    }

    public override bool Func_AcaoIncluir()
    {
      return base.Func_AcaoIncluir();
    }

    public override bool Func_AcaoProcurar()
    {
      return base.Func_AcaoProcurar();
    }

    public override bool Func_AcaoSair()
    {
      return base.Func_AcaoSair();
    }

    public override void Func_PesquisaById(int? codigo)
    {
      base.Func_PesquisaById(codigo);
    }

    public override void Func_PesquisaById(string codigo)
    {
      base.Func_PesquisaById(codigo);
    }
  }
}
