namespace Examen_Rentar_Manuel
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
            txtCliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            chkCorporativo = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtVehiculo = new TextBox();
            txtTarifa = new TextBox();
            chkGps = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            nudDias = new NumericUpDown();
            btnAgregar = new Button();
            label8 = new Label();
            label9 = new Label();
            lblSubtotal = new TextBox();
            lblDescuento = new TextBox();
            lblDomicilio = new TextBox();
            lblItbis = new TextBox();
            label10 = new Label();
            lstAlquileres = new ListBox();
            lblTotal = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            rbtCompleto = new RadioButton();
            rbtDomicilio = new RadioButton();
            rbtSucursal = new RadioButton();
            rbtBasico = new RadioButton();
            Entrega = new ListBox();
            Seguro = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            label15 = new Label();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(85, 9);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(246, 31);
            txtCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 2;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 99);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 3;
            label2.Text = "Salida:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 148);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 4;
            label3.Text = "Vehiculo:";
            // 
            // chkCorporativo
            // 
            chkCorporativo.AutoSize = true;
            chkCorporativo.Location = new Point(10, 46);
            chkCorporativo.Name = "chkCorporativo";
            chkCorporativo.Size = new Size(188, 29);
            chkCorporativo.TabIndex = 5;
            chkCorporativo.Text = "Cliente corporativo";
            chkCorporativo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 203);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 6;
            label4.Text = "Tarifa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 259);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 7;
            label5.Text = "Dias:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(495, 319);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 8;
            label6.Text = "Subtotal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(495, 356);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 9;
            label7.Text = "Descuento";
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(98, 142);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(246, 31);
            txtVehiculo.TabIndex = 10;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(98, 197);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(246, 31);
            txtTarifa.TabIndex = 12;
            // 
            // chkGps
            // 
            chkGps.AutoSize = true;
            chkGps.Location = new Point(12, 454);
            chkGps.Name = "chkGps";
            chkGps.Size = new Size(223, 29);
            chkGps.TabIndex = 14;
            chkGps.Text = "GPS (+RD$100 por dia)";
            chkGps.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(11, 489);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(128, 34);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(145, 489);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(141, 34);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Nuevo alquiler";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(292, 489);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(128, 34);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // nudDias
            // 
            nudDias.Location = new Point(98, 257);
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(180, 31);
            nudDias.TabIndex = 19;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(389, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(383, 60);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar al alquiler";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(495, 387);
            label8.Name = "label8";
            label8.Size = new Size(87, 25);
            label8.TabIndex = 23;
            label8.Text = "Domicilio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(495, 423);
            label9.Name = "label9";
            label9.Size = new Size(106, 25);
            label9.TabIndex = 24;
            label9.Text = "ITBIS (18 %)";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Location = new Point(607, 313);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(150, 31);
            lblSubtotal.TabIndex = 25;
            // 
            // lblDescuento
            // 
            lblDescuento.Location = new Point(607, 350);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(150, 31);
            lblDescuento.TabIndex = 26;
            // 
            // lblDomicilio
            // 
            lblDomicilio.Location = new Point(607, 389);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(150, 31);
            lblDomicilio.TabIndex = 27;
            // 
            // lblItbis
            // 
            lblItbis.Location = new Point(607, 423);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(150, 31);
            lblItbis.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(462, 494);
            label10.Name = "label10";
            label10.Size = new Size(139, 25);
            label10.TabIndex = 29;
            label10.Text = "TOTAL A PAGAR";
            // 
            // lstAlquileres
            // 
            lstAlquileres.FormattingEnabled = true;
            lstAlquileres.Location = new Point(389, 120);
            lstAlquileres.Name = "lstAlquileres";
            lstAlquileres.Size = new Size(383, 129);
            lstAlquileres.TabIndex = 30;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(622, 494);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(150, 31);
            lblTotal.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(389, 91);
            label11.Name = "label11";
            label11.Size = new Size(46, 25);
            label11.TabIndex = 36;
            label11.Text = "Dias";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(441, 94);
            label12.Name = "label12";
            label12.Size = new Size(78, 25);
            label12.TabIndex = 37;
            label12.Text = "Vehiculo";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(607, 91);
            label13.Name = "label13";
            label13.Size = new Size(53, 25);
            label13.TabIndex = 38;
            label13.Text = "Tarifa";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(685, 91);
            label14.Name = "label14";
            label14.Size = new Size(49, 25);
            label14.TabIndex = 39;
            label14.Text = "Total";
            // 
            // rbtCompleto
            // 
            rbtCompleto.AutoSize = true;
            rbtCompleto.BackColor = SystemColors.ButtonHighlight;
            rbtCompleto.Location = new Point(12, 405);
            rbtCompleto.Name = "rbtCompleto";
            rbtCompleto.Size = new Size(207, 29);
            rbtCompleto.TabIndex = 33;
            rbtCompleto.TabStop = true;
            rbtCompleto.Text = "Completo (+RD$300)";
            rbtCompleto.UseVisualStyleBackColor = false;
            // 
            // rbtDomicilio
            // 
            rbtDomicilio.AutoSize = true;
            rbtDomicilio.BackColor = SystemColors.ButtonHighlight;
            rbtDomicilio.Location = new Point(251, 405);
            rbtDomicilio.Name = "rbtDomicilio";
            rbtDomicilio.Size = new Size(203, 29);
            rbtDomicilio.TabIndex = 35;
            rbtDomicilio.TabStop = true;
            rbtDomicilio.Text = "Domicilio (+RD$500)";
            rbtDomicilio.UseVisualStyleBackColor = false;
            // 
            // rbtSucursal
            // 
            rbtSucursal.AutoSize = true;
            rbtSucursal.BackColor = SystemColors.ButtonHighlight;
            rbtSucursal.Location = new Point(251, 356);
            rbtSucursal.Name = "rbtSucursal";
            rbtSucursal.Size = new Size(114, 29);
            rbtSucursal.TabIndex = 34;
            rbtSucursal.TabStop = true;
            rbtSucursal.Text = "En sucrsal";
            rbtSucursal.UseVisualStyleBackColor = false;
            // 
            // rbtBasico
            // 
            rbtBasico.AutoSize = true;
            rbtBasico.BackColor = SystemColors.ButtonHighlight;
            rbtBasico.Location = new Point(12, 356);
            rbtBasico.Name = "rbtBasico";
            rbtBasico.Size = new Size(87, 29);
            rbtBasico.TabIndex = 32;
            rbtBasico.TabStop = true;
            rbtBasico.Text = "Basico";
            rbtBasico.UseVisualStyleBackColor = false;
            // 
            // Entrega
            // 
            Entrega.FormattingEnabled = true;
            Entrega.Location = new Point(235, 319);
            Entrega.Name = "Entrega";
            Entrega.Size = new Size(231, 129);
            Entrega.TabIndex = 22;
            // 
            // Seguro
            // 
            Seguro.FormattingEnabled = true;
            Seguro.Location = new Point(4, 319);
            Seguro.Name = "Seguro";
            Seguro.Size = new Size(225, 129);
            Seguro.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(80, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 42;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(4, 319);
            label15.Name = "label15";
            label15.Size = new Size(69, 25);
            label15.TabIndex = 43;
            label15.Text = "Seguro";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(235, 319);
            label16.Name = "label16";
            label16.Size = new Size(72, 25);
            label16.TabIndex = 44;
            label16.Text = "Entrega";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(dateTimePicker1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(rbtDomicilio);
            Controls.Add(rbtSucursal);
            Controls.Add(rbtCompleto);
            Controls.Add(rbtBasico);
            Controls.Add(lblTotal);
            Controls.Add(lstAlquileres);
            Controls.Add(label10);
            Controls.Add(lblItbis);
            Controls.Add(lblDomicilio);
            Controls.Add(lblDescuento);
            Controls.Add(lblSubtotal);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(Entrega);
            Controls.Add(Seguro);
            Controls.Add(btnAgregar);
            Controls.Add(nudDias);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(chkGps);
            Controls.Add(txtTarifa);
            Controls.Add(txtVehiculo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(chkCorporativo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCliente);
            Name = "Form1";
            Text = "RentaCar Express - Alquileres";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox chkCorporativo;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtVehiculo;
        private TextBox txtTarifa;
        private CheckBox chkGps;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private NumericUpDown nudDias;
        private Button btnAgregar;
        private Label label8;
        private Label label9;
        private TextBox lblSubtotal;
        private TextBox lblDescuento;
        private TextBox lblDomicilio;
        private TextBox lblItbis;
        private Label label10;
        private ListBox lstAlquileres;
        private TextBox lblTotal;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private RadioButton rbtCompleto;
        private RadioButton rbtDomicilio;
        private RadioButton rbtSucursal;
        private RadioButton rbtBasico;
        private ListBox Entrega;
        private ListBox Seguro;
        private DateTimePicker dateTimePicker1;
        private Label label15;
        private Label label16;
    }
}
