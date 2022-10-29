using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Controles
{
  //OBS: NÃO IMPLEMENTEI AINDA ROTINAS, VOU VER DEPOIS COM CALMA, O QUE VOU APROVEITAR.

  public class DataGridViewEdit : DataGridView
  {
    bool desabilitarControle = false;
    private bool iniciarFocusControle = false;

    public DataGridViewEdit()
    {
      this.PrtTipoSelecaoLinha = DataGridViewSelectionMode.FullRowSelect;
      this.SelectionMode = PrtTipoSelecaoLinha;
      //permite que o texto maior que célula não seja truncado
      this.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
      this.AllowUserToOrderColumns = true; //habilita para usuarios moverem coluna com o mouse para uma nova posição
      this.AllowUserToResizeColumns = true; //habilitar para os usuarios redimensionar as colunas
      this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

      this.BackgroundColorExt();
      this.ForeColorExt();
      this.FontExtPadrao();

    }

    #region METODOS OVERRIDE

    protected override void InitLayout()
    {
      base.InitLayout();
      this.Refresh();
    }

    public override void Refresh()
    {
      base.Refresh();

    }
    protected override void OnValidated(EventArgs e)
    {
      base.OnValidated(e);
      this.ClearSelection();
    }

    protected override void OnColumnHeaderMouseClick(DataGridViewCellMouseEventArgs e)
    {
      base.OnColumnHeaderMouseClick(e);
      //NÃO FUNCIONOU, DEU ERRO, VOU COMENTAR POR ENQUANTO.
      //Rotina criada para ordenar pela coluna header clicada no grid
      //this.Sort(this.Columns[e.ColumnIndex], this.SortOrder== SortOrder.Descending ? ListSortDirection.Ascending: ListSortDirection.Descending);
    }

    protected override void OnRowEnter(DataGridViewCellEventArgs e)
    {
      //base.OnRowEnter(e);
      ////quando grid recebe o foco pela seta do teclado não estava selecionando a linha então fiz isso
      //this.ClearSelection();
      //this.Rows[e.RowIndex].Selected = true;

    }

    #endregion

    #region PROPRIEDADES CRIADAS NO CONTROLE

    [Description("Define o tipo de seleção da linha do grid).")]//  (opcional)
    [TypeConverter(typeof(DataGridViewSelectionMode)), Category("EditControls")]
    public DataGridViewSelectionMode PrtTipoSelecaoLinha { get; set; }

    [Description("Defina apenas um controle que vai iniciar com o foco quando tela for carregada).")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtIniciaFocusControle
    {
      get { return iniciarFocusControle; }
      set { iniciarFocusControle = value; }
    }

    [Description("Se propriedade igual a True, campo não poderá ser editado).")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtDesabilitarControle
    {
      get { return desabilitarControle; }
      set { desabilitarControle = value; }
    }

    #endregion

  }
}
