namespace sistemaOrcamento
{
    partial class Form1
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
            label1 = new Label();
            txtLargura = new TextBox();
            label2 = new Label();
            txtComprimento = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtValorChapa = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnCalcular = new Button();
            txtValor = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtM2 = new TextBox();
            btnGerarOrcamento = new Button();
            rbRouter = new RadioButton();
            rbLaser = new RadioButton();
            cbMaterial = new ComboBox();
            txtQuantidade = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtFator = new TextBox();
            label11 = new Label();
            txtCliente = new TextBox();
            dtpData = new DateTimePicker();
            label12 = new Label();
            btnAdicionarItem = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 127);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "MATERIAL";
            // 
            // txtLargura
            // 
            txtLargura.Location = new Point(283, 150);
            txtLargura.Name = "txtLargura";
            txtLargura.Size = new Size(125, 27);
            txtLargura.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 127);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 3;
            label2.Text = "LARGURA";
            // 
            // txtComprimento
            // 
            txtComprimento.Location = new Point(419, 150);
            txtComprimento.Name = "txtComprimento";
            txtComprimento.Size = new Size(125, 27);
            txtComprimento.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 127);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 5;
            label3.Text = "COMPRIMENTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(419, 197);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 6;
            label4.Text = "VALOR DA CHAPA";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtValorChapa
            // 
            txtValorChapa.Location = new Point(419, 220);
            txtValorChapa.Name = "txtValorChapa";
            txtValorChapa.Size = new Size(125, 27);
            txtValorChapa.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(599, 147);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 9;
            label5.Text = "FATOR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 127);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 11;
            label6.Text = "MAQUINA";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(234, 374);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(211, 64);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "CALCULAR ORÇAMENTO";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(23, 336);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(117, 27);
            txtValor.TabIndex = 13;
            txtValor.Text = "R$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 313);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 14;
            label7.Text = "VALOR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 377);
            label8.Name = "label8";
            label8.Size = new Size(145, 20);
            label8.TabIndex = 16;
            label8.Text = "METRO QUADRADO";
            // 
            // txtM2
            // 
            txtM2.Location = new Point(23, 400);
            txtM2.Name = "txtM2";
            txtM2.Size = new Size(117, 27);
            txtM2.TabIndex = 15;
            txtM2.Text = "M²";
            // 
            // btnGerarOrcamento
            // 
            btnGerarOrcamento.Location = new Point(481, 374);
            btnGerarOrcamento.Name = "btnGerarOrcamento";
            btnGerarOrcamento.Size = new Size(211, 64);
            btnGerarOrcamento.TabIndex = 17;
            btnGerarOrcamento.Text = "GERAR ORÇAMENTO";
            btnGerarOrcamento.UseVisualStyleBackColor = true;
            btnGerarOrcamento.Click += btnGerarOrcamento_Click;
            // 
            // rbRouter
            // 
            rbRouter.AutoSize = true;
            rbRouter.Location = new Point(30, 151);
            rbRouter.Name = "rbRouter";
            rbRouter.Size = new Size(74, 24);
            rbRouter.TabIndex = 18;
            rbRouter.TabStop = true;
            rbRouter.Text = "Router";
            rbRouter.UseVisualStyleBackColor = true;
            // 
            // rbLaser
            // 
            rbLaser.AutoSize = true;
            rbLaser.Location = new Point(30, 181);
            rbLaser.Name = "rbLaser";
            rbLaser.Size = new Size(64, 24);
            rbLaser.TabIndex = 19;
            rbLaser.TabStop = true;
            rbLaser.Text = "Laser";
            rbLaser.UseVisualStyleBackColor = true;
            // 
            // cbMaterial
            // 
            cbMaterial.FormattingEnabled = true;
            cbMaterial.Items.AddRange(new object[] { "Madeira/MDF", "Polimeros", "Formicas", "Acm" });
            cbMaterial.Location = new Point(116, 150);
            cbMaterial.Name = "cbMaterial";
            cbMaterial.Size = new Size(151, 28);
            cbMaterial.TabIndex = 20;
            cbMaterial.Text = "Selecione Material";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(283, 217);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(125, 27);
            txtQuantidade.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(293, 194);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 22;
            label9.Text = "QUANTIDADE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 276);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 24;
            label10.Text = "RESULTADO";
            // 
            // txtFator
            // 
            txtFator.Location = new Point(565, 170);
            txtFator.Name = "txtFator";
            txtFator.Size = new Size(125, 27);
            txtFator.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(77, 31);
            label11.Name = "label11";
            label11.Size = new Size(64, 20);
            label11.TabIndex = 27;
            label11.Text = "CLIENTE";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(23, 54);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(171, 27);
            txtCliente.TabIndex = 26;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(234, 54);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(304, 27);
            dtpData.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(280, 31);
            label12.Name = "label12";
            label12.Size = new Size(165, 20);
            label12.TabIndex = 29;
            label12.Text = "DATA DO ORÇAMENTO";
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Location = new Point(246, 291);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(211, 64);
            btnAdicionarItem.TabIndex = 30;
            btnAdicionarItem.Text = "ADICIONAR ITENS";
            btnAdicionarItem.UseVisualStyleBackColor = true;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 450);
            Controls.Add(btnAdicionarItem);
            Controls.Add(label12);
            Controls.Add(dtpData);
            Controls.Add(label11);
            Controls.Add(txtCliente);
            Controls.Add(txtFator);
            Controls.Add(label10);
            Controls.Add(txtQuantidade);
            Controls.Add(label9);
            Controls.Add(cbMaterial);
            Controls.Add(rbLaser);
            Controls.Add(rbRouter);
            Controls.Add(btnGerarOrcamento);
            Controls.Add(label8);
            Controls.Add(txtM2);
            Controls.Add(label7);
            Controls.Add(txtValor);
            Controls.Add(btnCalcular);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtValorChapa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtComprimento);
            Controls.Add(label2);
            Controls.Add(txtLargura);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtLargura;
        private Label label2;
        private TextBox txtComprimento;
        private Label label3;
        private Label label4;
        private TextBox txtValorChapa;
        private Label label5;
        private Label label6;
        private Button btnCalcular;
        private TextBox txtValor;
        private Label label7;
        private Label label8;
        private TextBox txtM2;
        private Button btnGerarOrcamento;
        private RadioButton rbRouter;
        private RadioButton rbLaser;
        private ComboBox cbMaterial;
        private TextBox txtQuantidade;
        private Label label9;
        private Label label10;
        private TextBox txtFator;
        private Label label11;
        private TextBox txtCliente;
        private DateTimePicker dtpData;
        private Label label12;
        private Button btnAdicionarItem;
    }
}
