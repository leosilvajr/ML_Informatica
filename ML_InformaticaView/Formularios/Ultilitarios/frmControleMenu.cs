using Controles;
using Funcionarios.Formularios;
using ML_InformaticaView.Formularios.Principal;
using ML_InformaticaView.Funcoes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ML_InformaticaView.Formularios.Ultilitarios
{
  public partial class frmControleMenu : frmBase
  {
    ImageList _images;
    frmPrincipal p;
    public frmControleMenu()
    {
      InitializeComponent();
      this.TopLevel = false;
      lblTituloForm.Text = "Controle de Acessos do Usuário";
      p = new frmPrincipal();
      _images = new ImageList();
      _images.Images.Add("liberado", Image.FromFile(@"C:\WorkspaceGit\ML_Informatica\Design\img\Menu\true.png"));
      _images.Images.Add("bloqueado", Image.FromFile(@"C:\WorkspaceGit\ML_Informatica\Design\img\Menu\false.png"));
      _images.Images.Add("menu", Image.FromFile(@"C:\WorkspaceGit\ML_Informatica\Design\img\Menu\folder.png"));
      _images.Images.Add("btn", Image.FromFile(@"C:\WorkspaceGit\ML_Informatica\Design\img\Menu\btn.png"));

      treeView1.ImageList = _images;

      //MontaMenuContext();
    }

    private void btnCarregar_Click(object sender, EventArgs e)
    {

      ////////////////////////////// CADASTROS \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

      treeView1.Nodes.Clear();
      p = new frmPrincipal();
      List<TreeNode> nodeCadastro = new List<TreeNode>();
      TreeNode rootCadastro = new TreeNode(p.btnCadastros.Tag.ToString());

      if (p.btnCadastros.Tag.ToString() != null)

      rootCadastro.Name = p.btnCadastros.Text.ToString();
      rootCadastro.ImageIndex = _images.Images.IndexOfKey("btn");
      rootCadastro.SelectedImageIndex = _images.Images.IndexOfKey("btn");
      rootCadastro.Tag = "btn";

      nodeCadastro.Add(rootCadastro);
      treeView1.Nodes.AddRange(nodeCadastro.ToArray());

      foreach (ToolStripMenuItem item in p.menuStripCadastros.Items)
      {

        List<TreeNode> nodes = new List<TreeNode>();
        TreeNode root = new TreeNode(item.Text);

        if (item.Tag != null)
        root.Name = item.Tag.ToString();
        root.ImageIndex = _images.Images.IndexOfKey("menu");
        root.SelectedImageIndex = _images.Images.IndexOfKey("menu");
        root.Tag = "menu";

        root.Nodes.AddRange(CreateTreeNodesMenuItens(item));
        rootCadastro.Nodes.Add(root);
        nodes.Add(root);


      }

      ////////////////////////////// RELATORIOS \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
      List<TreeNode> nodeRelatorio = new List<TreeNode>();
      TreeNode rootRelatorio = new TreeNode(p.btnRelatorios.Tag.ToString());

      if (p.btnRelatorios.Tag.ToString() != null)
      rootRelatorio.Name = p.btnRelatorios.Text.ToString();
      rootRelatorio.ImageIndex = _images.Images.IndexOfKey("btn");
      rootRelatorio.SelectedImageIndex = _images.Images.IndexOfKey("btn");
      rootRelatorio.Tag = "btn";

      nodeRelatorio.Add(rootRelatorio);
      treeView1.Nodes.AddRange(nodeRelatorio.ToArray());

      foreach (ToolStripMenuItem item in p.menuStripRelatorios.Items)
      {
        List<TreeNode> nodes = new List<TreeNode>();
        TreeNode root = new TreeNode(item.Text);

        if (item.Tag != null)
        root.Name = item.Tag.ToString();
        root.ImageIndex = _images.Images.IndexOfKey("menu");
        root.SelectedImageIndex = _images.Images.IndexOfKey("menu");
        root.Tag = "menu";

        root.Nodes.AddRange(CreateTreeNodesMenuItens(item));
        rootRelatorio.Nodes.Add(root);
        nodes.Add(root);

      }

      ////////////////////////////// CONFIGURAÇÕES \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
      List<TreeNode> nodeConfiguracao = new List<TreeNode>();
      TreeNode rootConfiguracao = new TreeNode(p.btnConfiguracoes.Tag.ToString());

      if (p.btnConfiguracoes.Tag.ToString() != null)
      rootConfiguracao.Name = p.btnConfiguracoes.Text.ToString();
      rootConfiguracao.ImageIndex = _images.Images.IndexOfKey("btn");
      rootConfiguracao.SelectedImageIndex = _images.Images.IndexOfKey("btn");
      rootConfiguracao.Tag = "btn";

      nodeConfiguracao.Add(rootConfiguracao);
      treeView1.Nodes.AddRange(nodeConfiguracao.ToArray());

      foreach (ToolStripMenuItem item in p.menuStripConfiguracoes.Items)
      {
        List<TreeNode> nodes = new List<TreeNode>();
        TreeNode root = new TreeNode(item.Text);

        if (item.Tag != null)
          root.Name = item.Tag.ToString();
        root.ImageIndex = _images.Images.IndexOfKey("menu");
        root.SelectedImageIndex = _images.Images.IndexOfKey("menu");
        root.Tag = "menu";

        root.Nodes.AddRange(CreateTreeNodesMenuItens(item));
        rootConfiguracao.Nodes.Add(root);
        nodes.Add(root);

      }

      ////////////////////////////// ULTILITARIOS \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\K
      ////////////////////////////// ULTILITARIOS \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\K
      List<TreeNode> nodeUltilitarios = new List<TreeNode>();
      TreeNode rootUltilitarios = new TreeNode(p.btnUltilitarios.Tag.ToString());

      if (p.btnUltilitarios.Tag.ToString() != null)
        rootUltilitarios.Name = p.btnUltilitarios.Text.ToString();
      rootUltilitarios.ImageIndex = _images.Images.IndexOfKey("btn");
      rootUltilitarios.SelectedImageIndex = _images.Images.IndexOfKey("btn");
      rootUltilitarios.Tag = "btn";

      nodeUltilitarios.Add(rootUltilitarios);
      treeView1.Nodes.AddRange(nodeUltilitarios.ToArray());
      foreach (ToolStripMenuItem item in p.menuStripUltilitarios.Items)
      {
        List<TreeNode> nodes = new List<TreeNode>();
        TreeNode root = new TreeNode(item.Text);

        if (item.Tag != null)
          root.Name = item.Tag.ToString();
        root.ImageIndex = _images.Images.IndexOfKey("menu");
        root.SelectedImageIndex = _images.Images.IndexOfKey("menu");
        root.Tag = "menu";

        root.Nodes.AddRange(CreateTreeNodesMenuItens(item));
        rootUltilitarios.Nodes.Add(root);
        nodes.Add(root);

      }

    }
    private TreeNode[] CreateTreeNodesMenuItens(ToolStripMenuItem menuItem)
    {
      List<TreeNode> nodes = new List<TreeNode>();

      foreach (ToolStripMenuItem item in menuItem.DropDownItems)
      {
        TreeNode node = new TreeNode(item.Text);
        if (item.Tag != null)
          node.Name = item.Tag.ToString();
        if (item.DropDownItems.Count > 0) // ´e um submenu 
        {
          node.ImageIndex = _images.Images.IndexOfKey("menu");
          node.SelectedImageIndex = _images.Images.IndexOfKey("menu");
          node.Tag = "submenu";

        }
        else
        {
          node.ImageIndex = _images.Images.IndexOfKey("liberado");
          node.SelectedImageIndex = _images.Images.IndexOfKey("liberado");
          node.Tag = "item";
        }
        node.Checked = true; //para teste vou inicializar com essa propriedade igual a true (signfica liberado)
        node.Nodes.AddRange(CreateTreeNodesMenuItens(item));
        nodes.Add(node);
      }
      return nodes.ToArray();
    }

    private void treeView1_DoubleClick(object sender, EventArgs e)
    {
      try
      {
      if (sender is TreeViewEdit tr)
      {
        //se foi identificado como item então altera 
        if (tr.SelectedNode.Tag == "item")
        {
          if (tr.SelectedNode.Checked == true)
          {
            tr.SelectedNode.Checked = false;
            tr.SelectedNode.ImageIndex = _images.Images.IndexOfKey("bloqueado");
            tr.SelectedNode.SelectedImageIndex = _images.Images.IndexOfKey("bloqueado");
          }
          else
          {
            tr.SelectedNode.Checked = true;
            tr.SelectedNode.ImageIndex = _images.Images.IndexOfKey("liberado");
            tr.SelectedNode.SelectedImageIndex = _images.Images.IndexOfKey("liberado");

          }
        }
      }
      }
      catch (Exception ex)
      {
        Mensagem.MostraErro(ex.Message);
      }
    }


  }
}
