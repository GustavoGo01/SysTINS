namespace SysTINSApp
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            novoInserirToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem1 = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem1 = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            niveisToolStripMenuItem = new ToolStripMenuItem();
            movimentoToolStripMenuItem = new ToolStripMenuItem();
            pedidoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem2 = new ToolStripMenuItem();
            fechamentoToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            orçamentoToolStripMenuItem = new ToolStripMenuItem();
            trocasEDevoluçõesToolStripMenuItem = new ToolStripMenuItem();
            operaToolStripMenuItem = new ToolStripMenuItem();
            caixaToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem1 = new ToolStripMenuItem();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem1 = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            manutençãoToolStripMenuItem = new ToolStripMenuItem();
            sairLogoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, movimentoToolStripMenuItem, operaToolStripMenuItem, manutençãoToolStripMenuItem, sairLogoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtosToolStripMenuItem, usuariosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(71, 20);
            cadastroToolStripMenuItem.Text = "&Cadastros";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, buscarToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(122, 22);
            clientesToolStripMenuItem.Text = "&Clientes";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(109, 22);
            novoToolStripMenuItem.Text = "&Novo";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(109, 22);
            buscarToolStripMenuItem.Text = "&Buscar";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoInserirToolStripMenuItem, buscarToolStripMenuItem1 });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(122, 22);
            produtosToolStripMenuItem.Text = "&Produtos";
            // 
            // novoInserirToolStripMenuItem
            // 
            novoInserirToolStripMenuItem.Name = "novoInserirToolStripMenuItem";
            novoInserirToolStripMenuItem.Size = new Size(143, 22);
            novoInserirToolStripMenuItem.Text = "&Novo(Inserir)";
            // 
            // buscarToolStripMenuItem1
            // 
            buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            buscarToolStripMenuItem1.Size = new Size(143, 22);
            buscarToolStripMenuItem1.Text = "&Buscar";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem1, consultarToolStripMenuItem, niveisToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(122, 22);
            usuariosToolStripMenuItem.Text = "&Usuarios";
            // 
            // novoToolStripMenuItem1
            // 
            novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            novoToolStripMenuItem1.Size = new Size(125, 22);
            novoToolStripMenuItem1.Text = "&Novo";
            novoToolStripMenuItem1.Click += novoToolStripMenuItem1_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(125, 22);
            consultarToolStripMenuItem.Text = "&Consultar";
            // 
            // niveisToolStripMenuItem
            // 
            niveisToolStripMenuItem.Name = "niveisToolStripMenuItem";
            niveisToolStripMenuItem.Size = new Size(125, 22);
            niveisToolStripMenuItem.Text = "&Niveis";
            // 
            // movimentoToolStripMenuItem
            // 
            movimentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pedidoToolStripMenuItem, orçamentoToolStripMenuItem, trocasEDevoluçõesToolStripMenuItem });
            movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            movimentoToolStripMenuItem.Size = new Size(81, 20);
            movimentoToolStripMenuItem.Text = "&Movimento";
            // 
            // pedidoToolStripMenuItem
            // 
            pedidoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem2, fechamentoToolStripMenuItem, listarToolStripMenuItem });
            pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            pedidoToolStripMenuItem.Size = new Size(180, 22);
            pedidoToolStripMenuItem.Text = "&Pedido";
            // 
            // novoToolStripMenuItem2
            // 
            novoToolStripMenuItem2.Name = "novoToolStripMenuItem2";
            novoToolStripMenuItem2.Size = new Size(125, 22);
            novoToolStripMenuItem2.Text = "&Novo";
            // 
            // fechamentoToolStripMenuItem
            // 
            fechamentoToolStripMenuItem.Name = "fechamentoToolStripMenuItem";
            fechamentoToolStripMenuItem.Size = new Size(125, 22);
            fechamentoToolStripMenuItem.Text = "&Consultar";
            fechamentoToolStripMenuItem.Click += fechamentoToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(125, 22);
            listarToolStripMenuItem.Text = "&Listar";
            // 
            // orçamentoToolStripMenuItem
            // 
            orçamentoToolStripMenuItem.Name = "orçamentoToolStripMenuItem";
            orçamentoToolStripMenuItem.Size = new Size(180, 22);
            orçamentoToolStripMenuItem.Text = "&Orçamento";
            // 
            // trocasEDevoluçõesToolStripMenuItem
            // 
            trocasEDevoluçõesToolStripMenuItem.Name = "trocasEDevoluçõesToolStripMenuItem";
            trocasEDevoluçõesToolStripMenuItem.Size = new Size(180, 22);
            trocasEDevoluçõesToolStripMenuItem.Text = "&Trocas e Devoluções";
            // 
            // operaToolStripMenuItem
            // 
            operaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caixaToolStripMenuItem, vendaToolStripMenuItem });
            operaToolStripMenuItem.Name = "operaToolStripMenuItem";
            operaToolStripMenuItem.Size = new Size(70, 20);
            operaToolStripMenuItem.Text = "&Operação";
            // 
            // caixaToolStripMenuItem
            // 
            caixaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, consultarToolStripMenuItem1, encerrarToolStripMenuItem, listarToolStripMenuItem1 });
            caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            caixaToolStripMenuItem.Size = new Size(106, 22);
            caixaToolStripMenuItem.Text = "&Caixa";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(125, 22);
            abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // consultarToolStripMenuItem1
            // 
            consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            consultarToolStripMenuItem1.Size = new Size(125, 22);
            consultarToolStripMenuItem1.Text = "&Consultar";
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(125, 22);
            encerrarToolStripMenuItem.Text = "&Encerrar";
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new Size(125, 22);
            listarToolStripMenuItem1.Text = "&Listar";
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(106, 22);
            vendaToolStripMenuItem.Text = "&Venda";
            // 
            // manutençãoToolStripMenuItem
            // 
            manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            manutençãoToolStripMenuItem.Size = new Size(86, 20);
            manutençãoToolStripMenuItem.Text = "M&anutenção";
            // 
            // sairLogoutToolStripMenuItem
            // 
            sairLogoutToolStripMenuItem.Name = "sairLogoutToolStripMenuItem";
            sairLogoutToolStripMenuItem.Size = new Size(84, 20);
            sairLogoutToolStripMenuItem.Text = "&Sair(Logout)";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "SysTINS -Syspeças TI97- ver0.0.1";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem novoInserirToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem1;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem niveisToolStripMenuItem;
        private ToolStripMenuItem movimentoToolStripMenuItem;
        private ToolStripMenuItem pedidoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem2;
        private ToolStripMenuItem fechamentoToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem orçamentoToolStripMenuItem;
        private ToolStripMenuItem trocasEDevoluçõesToolStripMenuItem;
        private ToolStripMenuItem operaToolStripMenuItem;
        private ToolStripMenuItem caixaToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem1;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem1;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem manutençãoToolStripMenuItem;
        private ToolStripMenuItem sairLogoutToolStripMenuItem;
    }
}