using RestSharp;

namespace AplicativoTesteAPI
{
    public partial class FrmTeste : Form
    {
        public FrmTeste()
        {
            InitializeComponent();

            TxbRestClient.Text = "https://localhost:44307/";
            TxbRestRequest.Text = "Api/ObterDadosGerais/AdicionarUsuario";
            CheckBoxGet.Checked = true;
        }

        private void BtnEnviarParaApi_Click(object sender, EventArgs e)
        {
            try
            {
                RestClient restCliente = new(TxbRestClient.Text);
                RestRequest requisicao;
                if (CheckBoxGet.Checked)
                {
                    requisicao = new RestRequest(TxbRestRequest.Text, Method.Get);
                }
                else
                {
                    requisicao = new RestRequest(TxbRestRequest.Text, Method.Post);
                    requisicao.AddParameter("parNomeUsuario", TxbEnviar.Text, ParameterType.GetOrPost);
                }

                //requisicao.AddHeader("authorization", "bearer " + AmbienteEvoDesk.Instance.TokenUsuarioLogado);

                RestResponse<string> resposta = restCliente.Execute<string>(requisicao);

                if (resposta.IsSuccessful)
                {
                    TxtRecebido.Text = resposta.Data;
                }
                else
                {
                    string ssxMensagemErro = "Content: " + resposta.Content;
                    ssxMensagemErro += (!string.IsNullOrEmpty(resposta.ErrorMessage) ? Environment.NewLine + "Error Message: " + resposta.ErrorMessage : "");
                    ssxMensagemErro += (!string.IsNullOrEmpty(resposta.ErrorException?.Message) ? Environment.NewLine + "Error Exception: " + resposta.ErrorException?.Message : "");
                    ssxMensagemErro += (!string.IsNullOrEmpty(resposta.ErrorException?.InnerException?.Message) ? Environment.NewLine + "Error Inner Exception: " + resposta.ErrorException?.InnerException?.Message : "");
                    MessageBox.Show(ssxMensagemErro, "Erro!!!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CheckBoxGet_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxGet.Checked && CheckBoxPost.Checked)
            {
                CheckBoxGet.Checked = false;
            }
        }

        private void CheckBoxPost_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxPost.Checked && CheckBoxGet.Checked)
            {
                CheckBoxPost.Checked = false;
            }
        }
    }
}