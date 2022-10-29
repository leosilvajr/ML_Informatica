using ML_InformaticaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ML_InformaticaView.Funcoes
{
    public class Util
    {
        /// <summary>
        /// delegate criado para retornar um objeto com resultado da consulta para a tela de origem que chamou 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="retorno"></param>
        public delegate void DelegateRetornoConsulta<T>(T retorno);

        /// <summary>
        /// Metodo para carregar formularios, ex: util.AbreForm(panel, typeof(frmConsulta))
        /// </summary>
        /// <param name="mdi">utilizar this, é o formulario que já está aberto </param>
        /// <param name="frmType"> passar o formulario que será aberto</param>
        public static void AbreForm(Panel pnl, Form frmInstancia)
        {
            bool bolCtl = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Equals(frmInstancia))
                {
                    form.Show();
                    form.BringToFront();
                    bolCtl = true;
                    break;
                }
            }

            if (!bolCtl) //se não encontrou então cria uma instancia e abre o form
            {
                Form frm = frmInstancia;
                pnl.Controls.Add(frm);
                pnl.CentralizaForm(frm);
                frm.Parent = pnl;
                frm.Show();
                frm.BringToFront();
            }

        }

        /// <summary>
        /// Metodo para carregar formularios, ex: util.AbreForm(this, typeof(frmConsulta))
        /// </summary>
        /// <param name="mdi">utilizar this, é o formulario que já está aberto </param>
        /// <param name="frmType"> passar o formulario que será aberto</param>
        public static void AbreForm(Form mdi, Type frmType)
        {
            bool bolCtl = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Equals(frmType))
                {
                    form.Show();
                    bolCtl = true;
                    break;
                }
            }

            if (!bolCtl) //se não encontrou então cria uma instancia e abre o form
            {
                Form frm = (Form)Activator.CreateInstance(frmType);
                if (frm.Name != mdi.Name)
                {
                    if (mdi.IsMdiContainer)
                    {
                        frm.MdiParent = mdi;
                        frm.Show();
                    }
                    else
                        frm.ShowDialog();
                }
            }
        }


        /// <summary>
        /// Metodo já recebe uma instancia da class form, para utilizarmos Delegates ex: util.AbreForm(this, frm)
        /// </summary>
        /// <param name="mdi">utilizar this, é o formulario que já está aberto </param>
        /// <param name="frmInstancia"> passar instancia da class form</param>
        public static void AbreForm(Form mdi, Form frmInstancia)
        {
            try
            {

                bool bolCtl = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType().Equals(frmInstancia))
                    {
                        form.Show();
                        form.BringToFront();
                        bolCtl = true;
                        break;
                    }
                }

                if (!bolCtl) //se não encontrou então cria uma instancia e abre o form
                {
                    Form frm = frmInstancia; //(Form)Activator.CreateInstance(frmType);
                    if (frm.Name != mdi.Name)
                    {
                        if (mdi.IsMdiContainer)
                        {
                            frm.MdiParent = mdi;
                            frm.Show();
                            frm.BringToFront();
                        }
                        else
                            frm.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {
                throw;
                // Mensagem.MostraErro(ex.Message);
            }


        }

        public static string TestarConexaoBanco()
        {
            ConfiguracaoBancoNegocio config = new ConfiguracaoBancoNegocio();
            return config.TestarConexaoBanco();
        }

        public static void AbrirSitePratic()
        {
            System.Diagnostics.Process pStart = new System.Diagnostics.Process();
            pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.site.praticsistemas.com.br/");
            pStart.Start();
        }

        public static void HorarioAtual()
        {
            string horario = DateTime.Now.ToString("hh:mm:ss tt");

        }

        /// <summary>
        /// Método retorna o nome do computador
        /// </summary>
        /// <returns></returns>
        public static string GetNomeComputador()
        {
            return Environment.MachineName;
        }

        /// <summary>
        /// Método retorna o nome completo do computador
        /// </summary>
        /// <returns></returns>
        public static string GetNomeCompletoComputador()
        {
            var nome = GetNomeComputador();
            return Dns.GetHostEntry(nome).HostName;

        }
    }
}
