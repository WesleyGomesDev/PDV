namespace PDV
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFluxoCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLancarVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradasSaidas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentosRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradaSaidaRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuProdutos,
            this.MenuMovimentacoes,
            this.MenuRelatorio,
            this.MenuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(914, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFuncionario,
            this.MenuUsuario,
            this.MenuCargos,
            this.MenuFornecedor});
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(66, 20);
            this.MenuCadastro.Text = "Cadastro";
            // 
            // MenuFuncionario
            // 
            this.MenuFuncionario.Name = "MenuFuncionario";
            this.MenuFuncionario.Size = new System.Drawing.Size(142, 22);
            this.MenuFuncionario.Text = "Funcionários";
            this.MenuFuncionario.Click += new System.EventHandler(this.MenuFuncionario_Click);
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.Size = new System.Drawing.Size(142, 22);
            this.MenuUsuario.Text = "Usuários";
            // 
            // MenuCargos
            // 
            this.MenuCargos.Name = "MenuCargos";
            this.MenuCargos.Size = new System.Drawing.Size(142, 22);
            this.MenuCargos.Text = "Cargos";
            // 
            // MenuFornecedor
            // 
            this.MenuFornecedor.Name = "MenuFornecedor";
            this.MenuFornecedor.Size = new System.Drawing.Size(142, 22);
            this.MenuFornecedor.Text = "Fornecedor";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastros,
            this.MenuEstoque});
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(67, 20);
            this.MenuProdutos.Text = "Produtos";
            // 
            // MenuCadastros
            // 
            this.MenuCadastros.Name = "MenuCadastros";
            this.MenuCadastros.Size = new System.Drawing.Size(121, 22);
            this.MenuCadastros.Text = "Cadastro";
            // 
            // MenuEstoque
            // 
            this.MenuEstoque.Name = "MenuEstoque";
            this.MenuEstoque.Size = new System.Drawing.Size(121, 22);
            this.MenuEstoque.Text = "Estoque";
            // 
            // MenuMovimentacoes
            // 
            this.MenuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFluxoCaixa,
            this.MenuLancarVendas,
            this.MenuEntradasSaidas,
            this.MenuDespesas});
            this.MenuMovimentacoes.Name = "MenuMovimentacoes";
            this.MenuMovimentacoes.Size = new System.Drawing.Size(104, 20);
            this.MenuMovimentacoes.Text = "Movimentações";
            // 
            // MenuFluxoCaixa
            // 
            this.MenuFluxoCaixa.Name = "MenuFluxoCaixa";
            this.MenuFluxoCaixa.Size = new System.Drawing.Size(163, 22);
            this.MenuFluxoCaixa.Text = "Fluxo de caixa";
            // 
            // MenuLancarVendas
            // 
            this.MenuLancarVendas.Name = "MenuLancarVendas";
            this.MenuLancarVendas.Size = new System.Drawing.Size(163, 22);
            this.MenuLancarVendas.Text = "Lançar Vendas";
            // 
            // MenuEntradasSaidas
            // 
            this.MenuEntradasSaidas.Name = "MenuEntradasSaidas";
            this.MenuEntradasSaidas.Size = new System.Drawing.Size(163, 22);
            this.MenuEntradasSaidas.Text = "Entradas / Saídas";
            // 
            // MenuDespesas
            // 
            this.MenuDespesas.Name = "MenuDespesas";
            this.MenuDespesas.Size = new System.Drawing.Size(163, 22);
            this.MenuDespesas.Text = "Despesas";
            // 
            // MenuRelatorio
            // 
            this.MenuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProduto,
            this.MenuVendas,
            this.MenuMovimentosRel,
            this.MenuEntradaSaidaRel,
            this.MenuDespesasRel});
            this.MenuRelatorio.Name = "MenuRelatorio";
            this.MenuRelatorio.Size = new System.Drawing.Size(66, 20);
            this.MenuRelatorio.Text = "Relatório";
            // 
            // MenuProduto
            // 
            this.MenuProduto.Name = "MenuProduto";
            this.MenuProduto.Size = new System.Drawing.Size(163, 22);
            this.MenuProduto.Text = "Produtos";
            // 
            // MenuVendas
            // 
            this.MenuVendas.Name = "MenuVendas";
            this.MenuVendas.Size = new System.Drawing.Size(163, 22);
            this.MenuVendas.Text = "Vendas";
            // 
            // MenuMovimentosRel
            // 
            this.MenuMovimentosRel.Name = "MenuMovimentosRel";
            this.MenuMovimentosRel.Size = new System.Drawing.Size(163, 22);
            this.MenuMovimentosRel.Text = "Movimento";
            // 
            // MenuEntradaSaidaRel
            // 
            this.MenuEntradaSaidaRel.Name = "MenuEntradaSaidaRel";
            this.MenuEntradaSaidaRel.Size = new System.Drawing.Size(163, 22);
            this.MenuEntradaSaidaRel.Text = "Entradas / Saidas";
            // 
            // MenuDespesasRel
            // 
            this.MenuDespesasRel.Name = "MenuDespesasRel";
            this.MenuDespesasRel.Size = new System.Drawing.Size(163, 22);
            this.MenuDespesasRel.Text = "Despesas";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // img04
            // 
            this.img04.Image = global::PDV.Properties.Resources.loja_online;
            this.img04.Location = new System.Drawing.Point(464, 270);
            this.img04.Name = "img04";
            this.img04.Size = new System.Drawing.Size(179, 177);
            this.img04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img04.TabIndex = 1;
            this.img04.TabStop = false;
            // 
            // img03
            // 
            this.img03.Image = global::PDV.Properties.Resources.recepcionista;
            this.img03.Location = new System.Drawing.Point(185, 228);
            this.img03.Name = "img03";
            this.img03.Size = new System.Drawing.Size(179, 177);
            this.img03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img03.TabIndex = 1;
            this.img03.TabStop = false;
            // 
            // img02
            // 
            this.img02.Image = global::PDV.Properties.Resources.bolsa_de_dinheiro1;
            this.img02.Location = new System.Drawing.Point(464, 87);
            this.img02.Name = "img02";
            this.img02.Size = new System.Drawing.Size(179, 177);
            this.img02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img02.TabIndex = 1;
            this.img02.TabStop = false;
            // 
            // img01
            // 
            this.img01.Image = global::PDV.Properties.Resources.carrinho_de_compras;
            this.img01.Location = new System.Drawing.Point(186, 45);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(179, 177);
            this.img01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img01.TabIndex = 1;
            this.img01.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(914, 462);
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.PictureBox img04;
        private System.Windows.Forms.ToolStripMenuItem MenuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuario;
        private System.Windows.Forms.ToolStripMenuItem MenuCargos;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem MenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuFluxoCaixa;
        private System.Windows.Forms.ToolStripMenuItem MenuLancarVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradasSaidas;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuProduto;
        private System.Windows.Forms.ToolStripMenuItem MenuVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentosRel;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradaSaidaRel;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesasRel;
    }
}

