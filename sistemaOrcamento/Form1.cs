namespace sistemaOrcamento
{
    public partial class Form1 : Form
    {
        List<ItemOrcamento> itens = new List<ItemOrcamento>();
        double valorCalculado = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private bool ValidarCampos()
        {
            if (!rbRouter.Checked && !rbLaser.Checked)
            {
                MessageBox.Show("Selecione um tipo de maquina");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLargura.Text))
            {
                MessageBox.Show("Campo Largura vazio");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtComprimento.Text))
            {
                MessageBox.Show("Campo Comprimento vazio");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                MessageBox.Show("Campo Quantidade vazio");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtValorChapa.Text))
            {
                MessageBox.Show("Campo Valor da Chapa vazio");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFator.Text))
            {
                MessageBox.Show("Campo Fator vazio");
                return false;
            }
            return true;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            double valor = CalcularValor(out double m2);
            valorCalculado = valor;
            txtValor.Text = valor.ToString("C");
            txtM2.Text = m2.ToString("F2");
        }
        private void btnGerarOrcamento_Click(object sender, EventArgs e)
        {
            if (itens.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um item!");
                return;
            }
            PdfService pdf = new PdfService();
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string caminho = Path.Combine(desktop, "orcamento.pdf");
            string cliente = txtCliente.Text;
            string data = dtpData.Value.ToString("dd/MM/yyyy");
            pdf.GerarPdf(
                caminho,
                cliente,
                data,
                itens
            );
            MessageBox.Show("Orçamento gerado com sucesso!");
        }
        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            double valor = CalcularValor(out double m2);
            ItemOrcamento item = new ItemOrcamento
            {
                Material = cbMaterial.Text,
                Maquina = rbRouter.Checked ? "Router" : "Laser",
                Largura = Convert.ToDouble(txtLargura.Text),
                Comprimento = Convert.ToDouble(txtComprimento.Text),
                M2 = m2,
                Quantidade = int.Parse(txtQuantidade.Text),
                Valor = valor
            };
            itens.Add(item);
            MessageBox.Show("Item Adicionado");
        }
        private double CalcularValor(out double m2)
        {
            double largura = Convert.ToDouble(txtLargura.Text);
            double comprimento = Convert.ToDouble(txtComprimento.Text);
            int quantidade = int.Parse(txtQuantidade.Text);
            double fator = Convert.ToDouble(txtFator.Text);
            m2 = largura * comprimento;
            double areaCm2 = m2 * 10000;
            double valorChapa = Convert.ToDouble(txtValorChapa.Text);
            double valorBaseCm2 = 0;
            switch (cbMaterial.Text)
            {
                case "Madeira/MDF": valorBaseCm2 = 0.0364; break;
                case "Polimeros": valorBaseCm2 = 0.0725; break;
                case "Formicas": valorBaseCm2 = 0.0462; break;
                case "Acm": valorBaseCm2 = 0.0928; break;
            }
            double valorChapaPadrao = 180;
            double valorChapaAtual = Convert.ToDouble(txtValorChapa.Text);
            double ajuste = valorChapaAtual / valorChapaPadrao;
            double valorCm2 = valorBaseCm2 * ajuste;
            double valorBase = areaCm2 * valorCm2 * quantidade * fator;
            valorBase /= 10;
            if (rbLaser.Checked)
                valorBase *= 2;
            return valorBase;
        }
    }
}
