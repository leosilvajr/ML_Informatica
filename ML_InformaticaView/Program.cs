using ML_InformaticaView.Formularios.Configuracoes;
using ML_InformaticaView.Formularios.Principal;
using ML_InformaticaView.Funcoes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios
{
  internal static class Program
  {
    static long? retornoLogin;
    public static int? codigoEmpresaAtiva;
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);


      //se o sistema já estiver aberto então aborta 
      if (SistemaEstaAberto())
        Mensagem.MostraErro("O programa já está em execução !");

      //VAMOS VALIDAR CONFIGURAÇÃO DO BANCO DE DADOS
      string result = Util.TestarConexaoBanco();
      if (result.ToUpper() != "OK")
      {
        Mensagem.MostraAviso(result);
        // frmSplash.Close(); //esconde tela de splash

        //se não existe vamos chamar a tela de configuração
        frmConfigBanco frmConfig = new frmConfigBanco();
        frmConfig.TopLevel = true;
        frmConfig.ShowDialog();
        FecharAplicativo();
      }

      ///ABRE TELA DE LOGIN
      retornoLogin = 0;
      //carrega a tela de login para entrar no sistema
      frmLogin frmlogin = new frmLogin();
      //aqui estou usando delegate para pegar o retorno da tela de login
      frmlogin.SetRetornoLoginCallback = new Util.DelegateRetornoConsulta<long?>(RetornoLoginCallbackFn);
      Util.AbreForm(new Form(), frmlogin);

      Application.Run(new frmPrincipal());
    }
    private static void RetornoLoginCallbackFn(long? retorno)
    {
      retornoLogin = retorno;
      return;
    }
    private static bool SistemaEstaAberto()
    {
      try
      {
        //verifica se a aplicação já está aberta
        Process aProcess = Process.GetCurrentProcess();
        string aProcName = aProcess.ProcessName;

        if (Process.GetProcessesByName(aProcName).Length > 1)
          return true;
        else
          return false;
      }
      catch (Exception)
      {

        throw;
      }
      throw new NotImplementedException();
    }

    /// <summary>
    /// Fecha a conexão e sai do sistema
    /// </summary>
    public static void FecharAplicativo()
    {
      //_procedure.GetConn.Active(false); //fecha conexão ao sair do sistema
      Application.Exit();
      Process.GetCurrentProcess().Kill(); //comando corrigi erro ao compilar sistema prendendo o exe (unable to copy file... bin\debug\gerenciadorsic.exe)

    }
  }
}
