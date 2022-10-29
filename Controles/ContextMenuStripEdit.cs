using System.Drawing;
using System.Windows.Forms;

namespace Controles
{
  public class ContextMenuStripEdit : ContextMenuStrip
  {

    public ContextMenuStripEdit()
    {
      //deixei definido como padrão poderá ser alterado depois via codigo
      //this.Font = new System.Drawing.Font("Lucida Fax", 9.75F);
     // this.ForeColorExt();
      this.FontExtPadrao();

    }
    /// <summary>
    /// Metodo Adiciona um item ao ContextMenuStripEdit
    /// </summary>
    /// <param name="descricao">Descrição que será mostrada (Text)</param>
    /// <param name="imagem">Defina uma imagem para o item (Image)</param>
    /// <param name="indice">defina um indice, será usado para identificar a ação, pode repetir (MergeIndex)</param>
    /// <param name="teclaAtalho">Defina uma tecla de atalho para o item (ShortcutKeys)</param>
    /// <param name="altura">defina a altura da caixa do Item (Height)</param>
    /// <param name="largura">defina a largura da caixa do Item (Width)</param>
    public void AddItem(string descricao, Image imagem, int indice, Keys teclaAtalho = Keys.None, int altura = 40, int largura = 200)
    {
      try
      {
        ToolStripMenuItem item = new ToolStripMenuItem();
       // item.AutoSize = false;
       // item.Height = altura;
       // item.Width = largura;
        item.Text = descricao;
        item.Image = imagem;
        item.ShortcutKeys = teclaAtalho;
        item.MergeIndex = indice;
        this.Items.Add(item);

      }
      catch
      {

        throw;
      }
    }

    /// <summary>
    /// Metodo possibilita personalizar nosso ContextMenuStrip alterando fonte e mantendo as imagens no tamanho original.
    /// </summary>
    /// <param name="fontFamily">parametro do tipo FontFamily</param>
    /// <param name="tamanhoFont">parametro define o tamanho da font</param>
    public void PersonalizarContextMenu(FontFamily fontFamily, float tamanhoFont)
    {
      this.Font = new Font(fontFamily, tamanhoFont);
      for (int i = 0; i < this.Items.Count; i++)
      {
       // this.Items[i].AutoSize = false;
        this.Items[i].ImageScaling = ToolStripItemImageScaling.None;
      }
    }

    /* COMENTEI METODO, PORQUE NO MOMENTO NÃO ESTOU USANDO MAIS, ELE NÃO MANTIA CORRETAMENTE A SELEÇÃO DO ITEM
     * NOVO METODO ACIMA FUNCIONOU BEM, FICANDO DA FORMA QUE EU GOSTARIA.
    /// <summary>
    /// Método personaliza os itens permitindo ajustar tamanho da imagem e seleção do item
    /// </summary>
    /// <param name="fator_SelecionaItem">fator que será multiplicado pela maior descrição para achar tamanho da seleção</param>
    /// <returns>retorna um contextMenuStrip formatado</returns>
    public bool PersonalizarItens(double fator_SelecionaItem = 11.47619)
    {
      try
      {
        int selItemMaxLength = 0;
        //vamos pegar a quantidade de caracteres do maior texto
        for (int i = 0; i < this.Items.Count; i++)
        {
          if (selItemMaxLength < this.Items[i].Text.Length)
            selItemMaxLength = this.Items[i].Text.Length;
        }
        int _width = (int)(double)(selItemMaxLength * fator_SelecionaItem);

        for (int i = 0; i < this.Items.Count; i++)
        {

          this.Items[i].AutoSize = false;
          this.Items[i].ImageScaling = ToolStripItemImageScaling.None;
          this.Items[i].Width = _width; //11.47619
          this.Items[i].Height = 40;
        }
        this.Invalidate();
        return true;
      }
      catch
      {

        throw;
      }
    }
    */
  }
}
