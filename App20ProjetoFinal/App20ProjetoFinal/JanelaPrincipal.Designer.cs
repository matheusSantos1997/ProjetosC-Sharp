namespace App20ProjetoFinal
{
    partial class JanelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tb_Sobrenome = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.lv_Relatorio = new System.Windows.Forms.ListView();
            this.cl_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Sobrenome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_CEP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_NovoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Anotacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.mtb_CEP = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Valor = new System.Windows.Forms.MaskedTextBox();
            this.gb_novoCliente = new System.Windows.Forms.GroupBox();
            this.rb_Nao = new System.Windows.Forms.RadioButton();
            this.rb_Sim = new System.Windows.Forms.RadioButton();
            this.gb_Anotacao = new System.Windows.Forms.GroupBox();
            this.cb_AvisoPrevio = new System.Windows.Forms.CheckBox();
            this.cb_Condominio = new System.Windows.Forms.CheckBox();
            this.cb_HComercial = new System.Windows.Forms.CheckBox();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opçao1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_novoCliente.SuspendLayout();
            this.gb_Anotacao.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório de Vendas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(104, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(543, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(48, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(48, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(48, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sobrenome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(48, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(48, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "CEP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(527, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(527, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Novo Cliente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(527, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Valor:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(527, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "Data:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(527, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 21);
            this.label13.TabIndex = 12;
            this.label13.Text = "Anotações:";
            // 
            // tb_ID
            // 
            this.tb_ID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_ID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_ID.Location = new System.Drawing.Point(159, 92);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(100, 22);
            this.tb_ID.TabIndex = 0;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ID_KeyPress);
            // 
            // tb_Nome
            // 
            this.tb_Nome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Nome.Location = new System.Drawing.Point(159, 125);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(100, 22);
            this.tb_Nome.TabIndex = 1;
            // 
            // tb_Sobrenome
            // 
            this.tb_Sobrenome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Sobrenome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Sobrenome.Location = new System.Drawing.Point(159, 156);
            this.tb_Sobrenome.Name = "tb_Sobrenome";
            this.tb_Sobrenome.Size = new System.Drawing.Size(100, 22);
            this.tb_Sobrenome.TabIndex = 2;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Adicionar.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.btn_Adicionar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Adicionar.Location = new System.Drawing.Point(312, 249);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(172, 48);
            this.btn_Adicionar.TabIndex = 23;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // lv_Relatorio
            // 
            this.lv_Relatorio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lv_Relatorio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_ID,
            this.cl_Nome,
            this.cl_Sobrenome,
            this.cl_Telefone,
            this.cl_CEP,
            this.cl_Status,
            this.cl_NovoCliente,
            this.cl_Valor,
            this.cl_Data,
            this.cl_Anotacao});
            this.lv_Relatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lv_Relatorio.GridLines = true;
            this.lv_Relatorio.Location = new System.Drawing.Point(9, 311);
            this.lv_Relatorio.Name = "lv_Relatorio";
            this.lv_Relatorio.Size = new System.Drawing.Size(764, 175);
            this.lv_Relatorio.TabIndex = 24;
            this.lv_Relatorio.UseCompatibleStateImageBehavior = false;
            this.lv_Relatorio.View = System.Windows.Forms.View.Details;
            // 
            // cl_ID
            // 
            this.cl_ID.Text = "ID";
            this.cl_ID.Width = 43;
            // 
            // cl_Nome
            // 
            this.cl_Nome.Text = "Nome";
            this.cl_Nome.Width = 81;
            // 
            // cl_Sobrenome
            // 
            this.cl_Sobrenome.Text = "Sobrenome";
            this.cl_Sobrenome.Width = 74;
            // 
            // cl_Telefone
            // 
            this.cl_Telefone.Text = "Telefone";
            this.cl_Telefone.Width = 91;
            // 
            // cl_CEP
            // 
            this.cl_CEP.Text = "CEP";
            this.cl_CEP.Width = 75;
            // 
            // cl_Status
            // 
            this.cl_Status.Text = "Status";
            this.cl_Status.Width = 78;
            // 
            // cl_NovoCliente
            // 
            this.cl_NovoCliente.Text = "Novo Cliente";
            this.cl_NovoCliente.Width = 79;
            // 
            // cl_Valor
            // 
            this.cl_Valor.Text = "Valor";
            this.cl_Valor.Width = 82;
            // 
            // cl_Data
            // 
            this.cl_Data.Text = "Data";
            this.cl_Data.Width = 81;
            // 
            // cl_Anotacao
            // 
            this.cl_Anotacao.Text = "Anotações";
            this.cl_Anotacao.Width = 84;
            // 
            // mtb_Telefone
            // 
            this.mtb_Telefone.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mtb_Telefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtb_Telefone.Location = new System.Drawing.Point(159, 187);
            this.mtb_Telefone.Mask = "(00)00000-0000";
            this.mtb_Telefone.Name = "mtb_Telefone";
            this.mtb_Telefone.Size = new System.Drawing.Size(100, 22);
            this.mtb_Telefone.TabIndex = 3;
            // 
            // mtb_CEP
            // 
            this.mtb_CEP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mtb_CEP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtb_CEP.Location = new System.Drawing.Point(159, 223);
            this.mtb_CEP.Mask = "00000-000";
            this.mtb_CEP.Name = "mtb_CEP";
            this.mtb_CEP.Size = new System.Drawing.Size(100, 22);
            this.mtb_CEP.TabIndex = 4;
            // 
            // mtb_Valor
            // 
            this.mtb_Valor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mtb_Valor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtb_Valor.Location = new System.Drawing.Point(652, 160);
            this.mtb_Valor.Mask = "$ 00.00";
            this.mtb_Valor.Name = "mtb_Valor";
            this.mtb_Valor.Size = new System.Drawing.Size(100, 22);
            this.mtb_Valor.TabIndex = 7;
            // 
            // gb_novoCliente
            // 
            this.gb_novoCliente.Controls.Add(this.rb_Nao);
            this.gb_novoCliente.Controls.Add(this.rb_Sim);
            this.gb_novoCliente.Location = new System.Drawing.Point(652, 119);
            this.gb_novoCliente.Name = "gb_novoCliente";
            this.gb_novoCliente.Size = new System.Drawing.Size(100, 35);
            this.gb_novoCliente.TabIndex = 6;
            this.gb_novoCliente.TabStop = false;
            // 
            // rb_Nao
            // 
            this.rb_Nao.AutoSize = true;
            this.rb_Nao.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nao.Location = new System.Drawing.Point(47, 12);
            this.rb_Nao.Name = "rb_Nao";
            this.rb_Nao.Size = new System.Drawing.Size(47, 17);
            this.rb_Nao.TabIndex = 6;
            this.rb_Nao.Text = "Não";
            this.rb_Nao.UseVisualStyleBackColor = true;
            // 
            // rb_Sim
            // 
            this.rb_Sim.AutoSize = true;
            this.rb_Sim.Checked = true;
            this.rb_Sim.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Sim.Location = new System.Drawing.Point(6, 12);
            this.rb_Sim.Name = "rb_Sim";
            this.rb_Sim.Size = new System.Drawing.Size(43, 17);
            this.rb_Sim.TabIndex = 6;
            this.rb_Sim.TabStop = true;
            this.rb_Sim.Text = "Sim";
            this.rb_Sim.UseVisualStyleBackColor = true;
            // 
            // gb_Anotacao
            // 
            this.gb_Anotacao.Controls.Add(this.cb_AvisoPrevio);
            this.gb_Anotacao.Controls.Add(this.cb_Condominio);
            this.gb_Anotacao.Controls.Add(this.cb_HComercial);
            this.gb_Anotacao.Location = new System.Drawing.Point(652, 224);
            this.gb_Anotacao.Name = "gb_Anotacao";
            this.gb_Anotacao.Size = new System.Drawing.Size(100, 73);
            this.gb_Anotacao.TabIndex = 29;
            this.gb_Anotacao.TabStop = false;
            // 
            // cb_AvisoPrevio
            // 
            this.cb_AvisoPrevio.AutoSize = true;
            this.cb_AvisoPrevio.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AvisoPrevio.Location = new System.Drawing.Point(9, 49);
            this.cb_AvisoPrevio.Name = "cb_AvisoPrevio";
            this.cb_AvisoPrevio.Size = new System.Drawing.Size(86, 17);
            this.cb_AvisoPrevio.TabIndex = 11;
            this.cb_AvisoPrevio.Text = "Aviso Prévio";
            this.cb_AvisoPrevio.UseVisualStyleBackColor = true;
            // 
            // cb_Condominio
            // 
            this.cb_Condominio.AutoSize = true;
            this.cb_Condominio.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Condominio.Location = new System.Drawing.Point(9, 31);
            this.cb_Condominio.Name = "cb_Condominio";
            this.cb_Condominio.Size = new System.Drawing.Size(85, 17);
            this.cb_Condominio.TabIndex = 10;
            this.cb_Condominio.Text = "Condomínio";
            this.cb_Condominio.UseVisualStyleBackColor = true;
            // 
            // cb_HComercial
            // 
            this.cb_HComercial.AutoSize = true;
            this.cb_HComercial.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_HComercial.Location = new System.Drawing.Point(9, 14);
            this.cb_HComercial.Name = "cb_HComercial";
            this.cb_HComercial.Size = new System.Drawing.Size(90, 17);
            this.cb_HComercial.TabIndex = 9;
            this.cb_HComercial.Text = "H. Comercial";
            this.cb_HComercial.UseVisualStyleBackColor = true;
            // 
            // cb_Status
            // 
            this.cb_Status.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cb_Status.ForeColor = System.Drawing.SystemColors.Window;
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Ag Pagamento",
            "Pago",
            "Ag Envio",
            "Enviado",
            "Finalizado"});
            this.cb_Status.Location = new System.Drawing.Point(652, 90);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(100, 23);
            this.cb_Status.TabIndex = 5;
            // 
            // dtp_Data
            // 
            this.dtp_Data.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Data.Location = new System.Drawing.Point(652, 196);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(100, 22);
            this.dtp_Data.TabIndex = 8;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Aplicação Cliente";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçao1ToolStripMenuItem,
            this.configuraçãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 70);
            this.contextMenuStrip1.Text = "Menu";
            // 
            // opçao1ToolStripMenuItem
            // 
            this.opçao1ToolStripMenuItem.Name = "opçao1ToolStripMenuItem";
            this.opçao1ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.opçao1ToolStripMenuItem.Text = "Opção 1";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.config1ToolStripMenuItem,
            this.config2ToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // config1ToolStripMenuItem
            // 
            this.config1ToolStripMenuItem.Name = "config1ToolStripMenuItem";
            this.config1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.config1ToolStripMenuItem.Text = "config 1";
            // 
            // config2ToolStripMenuItem
            // 
            this.config2ToolStripMenuItem.Name = "config2ToolStripMenuItem";
            this.config2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.config2ToolStripMenuItem.Text = "config 2";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(788, 488);
            this.Controls.Add(this.dtp_Data);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.gb_Anotacao);
            this.Controls.Add(this.gb_novoCliente);
            this.Controls.Add(this.mtb_Valor);
            this.Controls.Add(this.mtb_CEP);
            this.Controls.Add(this.mtb_Telefone);
            this.Controls.Add(this.lv_Relatorio);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.tb_Sobrenome);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JanelaPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.JanelaPrincipal_Load);
            this.gb_novoCliente.ResumeLayout(false);
            this.gb_novoCliente.PerformLayout();
            this.gb_Anotacao.ResumeLayout(false);
            this.gb_Anotacao.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TextBox tb_Sobrenome;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.ListView lv_Relatorio;
        private System.Windows.Forms.ColumnHeader cl_ID;
        private System.Windows.Forms.ColumnHeader cl_Nome;
        private System.Windows.Forms.ColumnHeader cl_Sobrenome;
        private System.Windows.Forms.ColumnHeader cl_Telefone;
        private System.Windows.Forms.ColumnHeader cl_CEP;
        private System.Windows.Forms.ColumnHeader cl_Status;
        private System.Windows.Forms.ColumnHeader cl_NovoCliente;
        private System.Windows.Forms.ColumnHeader cl_Valor;
        private System.Windows.Forms.ColumnHeader cl_Data;
        private System.Windows.Forms.ColumnHeader cl_Anotacao;
        private System.Windows.Forms.MaskedTextBox mtb_Telefone;
        private System.Windows.Forms.MaskedTextBox mtb_CEP;
        private System.Windows.Forms.MaskedTextBox mtb_Valor;
        private System.Windows.Forms.GroupBox gb_novoCliente;
        private System.Windows.Forms.RadioButton rb_Nao;
        private System.Windows.Forms.RadioButton rb_Sim;
        private System.Windows.Forms.GroupBox gb_Anotacao;
        private System.Windows.Forms.CheckBox cb_AvisoPrevio;
        private System.Windows.Forms.CheckBox cb_Condominio;
        private System.Windows.Forms.CheckBox cb_HComercial;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.DateTimePicker dtp_Data;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçao1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem config1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem config2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

