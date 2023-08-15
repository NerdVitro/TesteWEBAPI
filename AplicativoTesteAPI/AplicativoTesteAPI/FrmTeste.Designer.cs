namespace AplicativoTesteAPI
{
    partial class FrmTeste
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxbEnviar = new TextBox();
            BtnEnviarParaApi = new Button();
            TxtRecebido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxbRestClient = new TextBox();
            label4 = new Label();
            TxbRestRequest = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            CheckBoxGet = new CheckBox();
            CheckBoxPost = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // TxbEnviar
            // 
            TxbEnviar.Location = new Point(15, 46);
            TxbEnviar.Name = "TxbEnviar";
            TxbEnviar.Size = new Size(301, 23);
            TxbEnviar.TabIndex = 1;
            // 
            // BtnEnviarParaApi
            // 
            BtnEnviarParaApi.Location = new Point(85, 82);
            BtnEnviarParaApi.Name = "BtnEnviarParaApi";
            BtnEnviarParaApi.Size = new Size(156, 23);
            BtnEnviarParaApi.TabIndex = 2;
            BtnEnviarParaApi.Text = "Enviar";
            BtnEnviarParaApi.UseVisualStyleBackColor = true;
            BtnEnviarParaApi.Click += BtnEnviarParaApi_Click;
            // 
            // TxtRecebido
            // 
            TxtRecebido.Enabled = false;
            TxtRecebido.Location = new Point(15, 129);
            TxtRecebido.Name = "TxtRecebido";
            TxtRecebido.Size = new Size(301, 23);
            TxtRecebido.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 6;
            label1.Text = "Texto Enviar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 110);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 7;
            label2.Text = "Texto Recebido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 9;
            label3.Text = "RestClient";
            // 
            // TxbRestClient
            // 
            TxbRestClient.Location = new Point(6, 38);
            TxbRestClient.Name = "TxbRestClient";
            TxbRestClient.Size = new Size(564, 23);
            TxbRestClient.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 66);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 11;
            label4.Text = "RestRequest";
            // 
            // TxbRestRequest
            // 
            TxbRestRequest.Location = new Point(6, 85);
            TxbRestRequest.Name = "TxbRestRequest";
            TxbRestRequest.Size = new Size(564, 23);
            TxbRestRequest.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxbRestClient);
            groupBox1.Controls.Add(TxbRestRequest);
            groupBox1.Location = new Point(18, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(583, 124);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Métodos API";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CheckBoxGet);
            groupBox2.Controls.Add(CheckBoxPost);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(TxbEnviar);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(BtnEnviarParaApi);
            groupBox2.Controls.Add(TxtRecebido);
            groupBox2.Location = new Point(142, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 233);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "API Envio e Recebimento";
            // 
            // CheckBoxGet
            // 
            CheckBoxGet.AutoSize = true;
            CheckBoxGet.Location = new Point(15, 200);
            CheckBoxGet.Name = "CheckBoxGet";
            CheckBoxGet.Size = new Size(44, 19);
            CheckBoxGet.TabIndex = 9;
            CheckBoxGet.Text = "Get";
            CheckBoxGet.UseVisualStyleBackColor = true;
            CheckBoxGet.CheckedChanged += CheckBoxPost_CheckedChanged;
            // 
            // CheckBoxPost
            // 
            CheckBoxPost.AutoSize = true;
            CheckBoxPost.Location = new Point(15, 175);
            CheckBoxPost.Name = "CheckBoxPost";
            CheckBoxPost.Size = new Size(49, 19);
            CheckBoxPost.TabIndex = 8;
            CheckBoxPost.Text = "Post";
            CheckBoxPost.UseVisualStyleBackColor = true;
            CheckBoxPost.CheckedChanged += CheckBoxGet_CheckedChanged;
            // 
            // FrmTeste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 399);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(638, 438);
            MinimumSize = new Size(638, 438);
            Name = "FrmTeste";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teste de Envio e Recebimento de dados utilizando API";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TxbEnviar;
        private Button BtnEnviarParaApi;
        private TextBox TxtRecebido;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxbRestClient;
        private Label label4;
        private TextBox TxbRestRequest;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox CheckBoxGet;
        private CheckBox CheckBoxPost;
    }
}