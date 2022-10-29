using Controles.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ML_InformaticaView.Funcoes
{
    public static class Mensagem
    {
        //Mostra Aviso para usuario
        public static void MostraAviso(string msg)
        {
            if (string.IsNullOrEmpty(msg)) return; //nao mostra mensagem se null ou vazio
            MessageBox.Show(msg, Constantes.NomeAplicacao, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MostraAviso(Exception ex)
        {
            MessageBox.Show(ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, Constantes.NomeAplicacao, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //01/11/2021 - alterei implementando opção de passar como parametro o tipo de MessageBoxButtons
        //mostra um aviso com uma pergunta sim ou não, se não passar nenhuma pergunta mostra a padrão deseja continuar
        public static DialogResult MostraPergunta(string msg, string pergunta, MessageBoxButtons boxButtons = MessageBoxButtons.YesNo)
        {
            return MessageBox.Show(msg + "\n\n" + (string.IsNullOrEmpty(pergunta) ? "Deseja continuar" : pergunta), Constantes.NomeAplicacao, boxButtons, MessageBoxIcon.Question);
        }

        //Mostra Erro para usuario
        public static void MostraErro(string msg)
        {
            MessageBox.Show(msg, Constantes.NomeAplicacao, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public static void MostraErro(Exception ex)
        {
            MessageBox.Show(ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, Constantes.NomeAplicacao, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
