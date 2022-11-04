using Controles;
using ML_InformaticaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ML_InformaticaView.Funcoes
{
  public static class MetodosExtensao
  {
    public static void CentralizaForm(this Panel pnl, Form frm)
    {
      pnl.Controls.Add(frm);
      frm.Parent = pnl;
      frm.StartPosition = FormStartPosition.CenterParent;
      int x = (pnl.Width / 2) - (frm.Width / 2);
      int y = (pnl.Height / 2) - (frm.Height / 2);
      frm.Location = new Point(x, y);
    }

    /// <summary>
    /// Retorna string com o valor de um objeto 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static string ToStringExt(this object obj)
    {
      string valor = Convert.ToString(obj);
      return valor;
    }

    /// <summary>
    /// retorna a quantidade de caracteres
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int LengthExt(this string value)
    {
      string valor = Convert.ToString(value) ?? "";
      return valor.ToString().Length;
    }

    /// <summary>
    /// Metodo de Extensão:  trata valor de um objeto e retorna um char
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static char GetToChartExt(this string value)
    {
      char.TryParse(value, out char result);
      return result;
    }


    /// <summary>
    /// Metodo de Extensão:  trata valor de um objeto e retorna um short
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static short GetToShortExt(this string value)
    {
      short.TryParse(value, out short result);
      return result;
    }

    /// <summary>
    /// Metodo de Extensão:  trata valor de um objeto e retorna um int?, permitindo retorno de valor Nulo.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int? GetToIntExt(this string value)
    {
      int result;
      if (!string.IsNullOrEmpty(value))
      {
        int.TryParse(value, out result);
        return result;
      }
      else
        return null;
    }

    /// <summary>
    /// Metodo de Extensão:  trata valor de um objeto e retorna um long
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static long? GetToLongExt(this string value)
    {
      long.TryParse(value, out long result);
      return result;
    }


    /// <summary>
    /// Metodo de Extensão:  trata valor de um objeto e retorna um DateTime
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static DateTime GetToDateTimeExt(this string value)
    {
      DateTime.TryParse(value, out DateTime result);
      return result;
    }

    /// <summary>
    /// Metodo de Extensão:  trata valor de um objeto e retorna um decimal
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static decimal GetToDecimalExt(this string value)
    {
      //aqui por enquando não uso opcao de devolver nulo, se acontecer alterar metodo
      decimal.TryParse(value, out decimal result);
      return result;

    }

    public static decimal GetToDecimalNFeExt(this string value)
    {
      var valor = value.Replace('.', ',');
      return GetToDecimalExt(valor);
    }

    /// <summary>
    /// Metodo de Extensão:  devolve o valor decimal formatado em uma string
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string GetToStringFormatadoExt(this string value, int numeroCasasDecimais = 2)
    {
      //aqui por enquando não uso opcao de devolver nulo, se acontecer alterar metodo
      decimal.TryParse(value, out decimal result);
      return result.ToString("N" + numeroCasasDecimais);

    }

    /// <summary>
    /// Metodo de Extensão: Formata o valor decimal (Específico para controle MaskedTextBoxEdit)
    /// </summary>
    /// <param name="ctrl"> recebe um MaskedTextBoxEdit como parametro automaticamente</param>
    /// <returns></returns>
    public static void TextFormatDecimalExt(this MaskedTextBoxEdit ctrl)
    {
      //aqui por enquando não uso opcao de devolver nulo, se acontecer alterar metodo
      decimal.TryParse(ctrl.Text, out decimal result);
      ctrl.Text = result.ToString("N" + ctrl.PrtQtdCasaDecimal);

    }


    /// <summary>
    /// Metodo de Extensão: Retorna o valor do MaskedTextBoxEdit sem a mascara
    /// </summary>
    /// <param name="ctrl"></param>
    public static string GetTextSemMascara(this MaskedTextBoxEdit ctrl)
    {
      string valor = null;
      string newValue;
      if (!string.IsNullOrEmpty(ctrl.Mask))
      {
        ctrl.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        newValue = ctrl.Text;
        ctrl.TextMaskFormat = MaskFormat.IncludeLiterals;

      }
      else
        newValue = new string(ctrl.Text.Where(c => Char.IsLetterOrDigit(c)).ToArray());

      valor = newValue; //ctrl.Text;
      return valor;
    }


    /// <summary>
    /// Metodo Extensão : retorna apenas os numeros de uma string
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string GetSoNumerosExt(this string value)
    {
      string newValue = new string(value.Where(c => Char.IsDigit(c)).ToArray());
      return newValue;
    }

    public static string GetValueItemComboBoxExt(this Control obj)
    {
      if (obj is ComboBoxEdit combo)
      {
        string result = null;
        if (combo.SelectedItem != null)
          result = (combo.SelectedItem as ItensComboBoxEntidade).Value.ToString();
        return result;
      }
      else
        return null;
    }


    /// <summary>
    /// Metodo de Extensão: Devolve a Descrição de um determinado Enum
    /// </summary>
    /// <typeparam name="T">tipo generico</typeparam>
    /// <param name="value">enumerador que vamos localizar a descrição</param>
    /// <returns></returns>
    public static string GetValueDescriptionEnum<T>(this T value)
    {
      return
        value
            .GetType()
            .GetMember(value.ToString())
            .FirstOrDefault()
            ?.GetCustomAttribute<DescriptionAttribute>()
            ?.Description
        ?? value.ToString();
    }

    public static void EnableTabExt(this TabControl page, bool enable)
    {
      if (page == null) return;
      foreach (Control ctl in page.Controls) ctl.Enabled = enable;
    }

  }
  public static class MetodoExtensaoGrid
  {
    /// <summary>
    /// Metodo de Extensão: largura das colunas irão se ajustar de acordo com o tamanho do conteudo
    /// </summary>
    /// <param name="obj"></param>
    public static void AjustaColunaTamanhoConteudoExt(this DataGridViewEdit obj)
    {
      obj.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
      obj.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
    }

    /// <summary>
    /// Metodo de Extensão: altera AutoSizeColumnsMode = DisplayedCells, para que as colunas sejam alteradas para o tamanho 
    /// do conteudo da celula, e depois altera novamente AutoSizeColumnsMode = None mantendo Width das colunas, permitindo
    /// assim que seu tamanho seja editado depois.
    /// </summary>
    /// <param name="obj"></param>
    public static void AutosizeModePersonalizadoExt(this DataGridViewEdit obj)
    {
      //foreach (DataGridView linha in obj.Rows)
      //{
      //  linha.Height = 100;
      //}

      //coloquei para teste, mas não vi diferença se comporta igual linhas abaixo, por enquanto não vou usar
      //obj.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
      //obj.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

      //ajustando todas as colunas de acordo com o conteudo da coluna
      obj.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
      obj.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
      obj.Refresh();

      List<int> cols = new List<int>();
      foreach (var coluna in obj.Columns)
      {
        var col = coluna as DataGridViewColumn;
        cols.Add(col.Width);
      }
      obj.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
      foreach (var coluna in obj.Columns)
      {
        var col = coluna as DataGridViewColumn;
        col.Width = cols[col.Index];
      }

    }

    /// <summary>
    /// Metodo de Extensão: verifica se o grid tem linhas, seleciona a primeira linha e joga o focus para ela.
    /// </summary>
    /// <param name="obj"></param>
    public static void FocusNaPrimeiraLinhaDoGridExt(this DataGridViewEdit obj)
    {
      if (obj.Rows.Count > 0)
      {
        obj.Focus();
        obj.Rows[0].Selected = true;
      }

    }

    public static void AlturaLinhaGrid(this DataGridViewEdit obj)
    {
      foreach (DataGridView linha in obj.Rows)
      {
        linha.Height = 100;
      }
    }

    /// <summary>
    /// Metodo de Extensão: remove a seleção da linha após popular grid.
    /// </summary>
    /// <param name="obj"></param>
    public static void RemoverSelecaoLinhaExt(this DataGridViewEdit obj)
    {
      if (obj.Rows.Count > 0)
      {
        obj.Rows[0].Selected = false;
      }

    }

    /// <summary>
    /// Metodo renomeia as colunas do grid, obedecendo a seguintes regras: 
    /// Underline => troca por espaço (ex: Nome_Sobrenome => Nome Sobrenome)
    /// _or_ => troca por barra (ex: E_or_S => E/S)
    /// </summary>

    public static void FormatarColunasGrid(this DataGridViewEdit obj)
    {
      foreach (DataGridViewColumn col in obj.Columns)
      {
        col.HeaderText = col.HeaderText.Replace("_or_", "/").Replace("_", " ");
        if (col.ValueType == typeof(Decimal))
        {
          col.DefaultCellStyle.Format = "N2";
          col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        else if (col.ValueType == typeof(char))
        {
          col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
      }

    }


  }
  public static class MetodoExtensaoKeyEventArgs
  {
    /// <summary>
    /// Metodo de Extensão: usado para bloquear algumas teclas quando usamos o campo para pesquisa,
    /// deve ser usado em alguns lugares específicos. (ex: campo Pesquisa nas Telas de Pesquisa)
    /// </summary>
    /// <param name="e"></param>
    /// <returns></returns>
    public static bool IsDigitoValidoCampoDePesquisa(this KeyEventArgs e)
    {
      bool valido = false;
      switch (e.KeyCode)
      {
        case Keys.F1:
        case Keys.F2:
        case Keys.F3:
        case Keys.F4:
        case Keys.F5:
        case Keys.F6:
        case Keys.F7:
        case Keys.F8:
        case Keys.F9:
        case Keys.F10:
        case Keys.F11:
        case Keys.F12:
        case Keys.SelectMedia:
        case Keys.Shift:
        case Keys.ControlKey:
        case Keys.Control:
        case Keys.Up:
        case Keys.Down:
        case Keys.PageDown:
        case Keys.PageUp:
        case Keys.Left:
        case Keys.Right:
        case Keys.CapsLock:
        case Keys.Home:
        case Keys.End:
        case Keys.Insert:
        case Keys.Print:
        case Keys.PrintScreen:
        case Keys.Scroll:
        case Keys.Pause:
        case Keys.LWin:
        case Keys.RWin:
        case Keys.Menu:
        case Keys.LMenu:
        case Keys.Apps:
        case Keys.Tab:
          valido = false;
          break;
        default:
          valido = true;
          break;
      }
      return valido;

    }
    public static void PreencheComboEstadosBrasil(this ComboBoxEdit obj)
    {
      IList<ItensComboBoxEntidade> lista = new List<ItensComboBoxEntidade>
              {
                new ItensComboBoxEntidade {Value = 11, Descricao = "RO"},
                new ItensComboBoxEntidade {Value = 12, Descricao = "AC"},
                new ItensComboBoxEntidade {Value = 13, Descricao = "AM"},
                new ItensComboBoxEntidade {Value = 14, Descricao = "RR"},
                new ItensComboBoxEntidade {Value = 15, Descricao = "PA"},
                new ItensComboBoxEntidade {Value = 16, Descricao = "AP"},
                new ItensComboBoxEntidade {Value = 17, Descricao = "TO"},
                new ItensComboBoxEntidade {Value = 21, Descricao = "MA"},
                new ItensComboBoxEntidade {Value = 22, Descricao = "PI"},
                new ItensComboBoxEntidade {Value = 23, Descricao = "CE"},
                new ItensComboBoxEntidade {Value = 24, Descricao = "RN"},
                new ItensComboBoxEntidade {Value = 25, Descricao = "PB"},
                new ItensComboBoxEntidade {Value = 26, Descricao = "PE"},
                new ItensComboBoxEntidade {Value = 27, Descricao = "AL"},
                new ItensComboBoxEntidade {Value = 28, Descricao = "SE"},
                new ItensComboBoxEntidade {Value = 29, Descricao = "BA"},
                new ItensComboBoxEntidade {Value = 31, Descricao = "MG"},
                new ItensComboBoxEntidade {Value = 32, Descricao = "ES"},
                new ItensComboBoxEntidade {Value = 33, Descricao = "RJ"},
                new ItensComboBoxEntidade {Value = 35, Descricao = "SP"},
                new ItensComboBoxEntidade {Value = 41, Descricao = "PR"},
                new ItensComboBoxEntidade {Value = 42, Descricao = "SC"},
                new ItensComboBoxEntidade {Value = 43, Descricao = "RS"},
                new ItensComboBoxEntidade {Value = 50, Descricao = "MS"},
                new ItensComboBoxEntidade {Value = 51, Descricao = "MT"},
                new ItensComboBoxEntidade {Value = 52, Descricao = "GO"},
                new ItensComboBoxEntidade {Value = 53, Descricao = "DF"},
              };

      obj.DataSource = lista;
    }

  }
}
