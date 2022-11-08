using Controles;
using Funcionarios.Formularios;
using ML_InformaticaView.Formularios.Principal;
using System;
using System.Collections.Generic;
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

      _images = new ImageList();
      _images.Images.Add("liberado", Image.FromFile(@"C:\WorkspaceGit\ML_Informatica\Design\img\Menu\true.png"));
      _images.Images.Add("bloqueado", Image.FromFile(@"C:\WorkspaceGit\ML_Informatica\Design\img\Menu\false.png"));
      _images.Images.Add("menu", Image.FromFile(@"C:\WorkspaceGit\ML_Informatica\Design\img\Menu\folder.png"));
      treeView1.ImageList = _images;

      //MontaMenuContext();
    }

    private void btnCarregar_Click(object sender, EventArgs e)
    {

      p = new frmPrincipal();
      treeView1.Nodes.Clear();
      foreach (ToolStripMenuItem item in p.menuStripCadastros.Items)
      {
        //lista de TreeNode para armazenar a estrutura de nodes e inserir no TreeView
        List<TreeNode> nodes = new List<TreeNode>();
        TreeNode root = new TreeNode(item.Text);

        if (item.Tag != null)
          root.Name = item.Tag.ToString();
        root.ImageIndex = _images.Images.IndexOfKey("menu");
        root.SelectedImageIndex = _images.Images.IndexOfKey("menu");
        root.Tag = "menu";


        //após criar Node raiz - criamos toda estrutura dele
        root.Nodes.AddRange(CreateTreeNodesMenuItens(item));

        //adicionamos ao nosso list nodes
        nodes.Add(root);

        //inserimos nossa lista de nodes ao treeview1
        treeView1.Nodes.AddRange(nodes.ToArray());
      }
      foreach (ToolStripMenuItem item in p.menuStripRelatorios.Items)
      {
        //lista de TreeNode para armazenar a estrutura de nodes e inserir no TreeView
        List<TreeNode> nodes = new List<TreeNode>();
        TreeNode root = new TreeNode(item.Text);

        if (item.Tag != null)
          root.Name = item.Tag.ToString();
        root.ImageIndex = _images.Images.IndexOfKey("menu");
        root.SelectedImageIndex = _images.Images.IndexOfKey("menu");
        root.Tag = "menu";


        //após criar Node raiz - criamos toda estrutura dele
        root.Nodes.AddRange(CreateTreeNodesMenuItens(item));

        //adicionamos ao nosso list nodes
        nodes.Add(root);

        //inserimos nossa lista de nodes ao treeview1
        treeView1.Nodes.AddRange(nodes.ToArray());
      }
      foreach (ToolStripMenuItem item in p.menuStripConfiguracoes.Items)
      {
        //lista de TreeNode para armazenar a estrutura de nodes e inserir no TreeView
        List<TreeNode> nodes = new List<TreeNode>();
        TreeNode root = new TreeNode(item.Text);

        if (item.Tag != null)
          root.Name = item.Tag.ToString();
        root.ImageIndex = _images.Images.IndexOfKey("menu");
        root.SelectedImageIndex = _images.Images.IndexOfKey("menu");
        root.Tag = "menu";


        //após criar Node raiz - criamos toda estrutura dele
        root.Nodes.AddRange(CreateTreeNodesMenuItens(item));

        //adicionamos ao nosso list nodes
        nodes.Add(root);

        //inserimos nossa lista de nodes ao treeview1
        treeView1.Nodes.AddRange(nodes.ToArray());
      }
      foreach (ToolStripMenuItem item in p.menuStripUltilitarios.Items)
      {
        //lista de TreeNode para armazenar a estrutura de nodes e inserir no TreeView
        List<TreeNode> nodes = new List<TreeNode>();
        TreeNode root = new TreeNode(item.Text);

        if (item.Tag != null)
          root.Name = item.Tag.ToString();
        root.ImageIndex = _images.Images.IndexOfKey("menu");
        root.SelectedImageIndex = _images.Images.IndexOfKey("menu");
        root.Tag = "menu";


        //após criar Node raiz - criamos toda estrutura dele
        root.Nodes.AddRange(CreateTreeNodesMenuItens(item));

        //adicionamos ao nosso list nodes
        nodes.Add(root);

        //inserimos nossa lista de nodes ao treeview1
        treeView1.Nodes.AddRange(nodes.ToArray());
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
  }
}
