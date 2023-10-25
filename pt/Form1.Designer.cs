namespace pt
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.cmdCrear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdQuickSort = new System.Windows.Forms.Button();
            this.cmdBubbleSort = new System.Windows.Forms.Button();
            this.cmdMergeSort = new System.Windows.Forms.Button();
            this.cmdCocktail = new System.Windows.Forms.Button();
            this.cmdSelection = new System.Windows.Forms.Button();
            this.cmdASel = new System.Windows.Forms.Button();
            this.cmdACoc = new System.Windows.Forms.Button();
            this.cmdAMerge = new System.Windows.Forms.Button();
            this.cmdABubble = new System.Windows.Forms.Button();
            this.cmdAQuick = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbQuickSort = new System.Windows.Forms.ListBox();
            this.lbBubbleSort = new System.Windows.Forms.ListBox();
            this.lbMergeSort = new System.Windows.Forms.ListBox();
            this.lbCocktailSort = new System.Windows.Forms.ListBox();
            this.lbSelectionSort = new System.Windows.Forms.ListBox();
            this.pbGrafico = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdCrear);
            this.groupBox1.Controls.Add(this.txtLimite);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Vector";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tamaño";
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(95, 40);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(97, 20);
            this.txtLimite.TabIndex = 1;
            this.txtLimite.Text = "100";
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(70, 83);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(75, 23);
            this.cmdCrear.TabIndex = 1;
            this.cmdCrear.Text = "Crear";
            this.cmdCrear.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdASel);
            this.groupBox2.Controls.Add(this.cmdACoc);
            this.groupBox2.Controls.Add(this.cmdAMerge);
            this.groupBox2.Controls.Add(this.cmdABubble);
            this.groupBox2.Controls.Add(this.cmdAQuick);
            this.groupBox2.Controls.Add(this.cmdSelection);
            this.groupBox2.Controls.Add(this.cmdCocktail);
            this.groupBox2.Controls.Add(this.cmdMergeSort);
            this.groupBox2.Controls.Add(this.cmdBubbleSort);
            this.groupBox2.Controls.Add(this.cmdQuickSort);
            this.groupBox2.Location = new System.Drawing.Point(251, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 130);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metodos";
            // 
            // cmdQuickSort
            // 
            this.cmdQuickSort.Location = new System.Drawing.Point(90, 33);
            this.cmdQuickSort.Name = "cmdQuickSort";
            this.cmdQuickSort.Size = new System.Drawing.Size(75, 23);
            this.cmdQuickSort.TabIndex = 1;
            this.cmdQuickSort.Text = "QuickSort";
            this.cmdQuickSort.UseVisualStyleBackColor = true;
            // 
            // cmdBubbleSort
            // 
            this.cmdBubbleSort.Location = new System.Drawing.Point(218, 33);
            this.cmdBubbleSort.Name = "cmdBubbleSort";
            this.cmdBubbleSort.Size = new System.Drawing.Size(75, 23);
            this.cmdBubbleSort.TabIndex = 2;
            this.cmdBubbleSort.Text = "BubbleSort";
            this.cmdBubbleSort.UseVisualStyleBackColor = true;
            // 
            // cmdMergeSort
            // 
            this.cmdMergeSort.Location = new System.Drawing.Point(350, 33);
            this.cmdMergeSort.Name = "cmdMergeSort";
            this.cmdMergeSort.Size = new System.Drawing.Size(75, 23);
            this.cmdMergeSort.TabIndex = 3;
            this.cmdMergeSort.Text = "MergeSort";
            this.cmdMergeSort.UseVisualStyleBackColor = true;
            // 
            // cmdCocktail
            // 
            this.cmdCocktail.Location = new System.Drawing.Point(475, 33);
            this.cmdCocktail.Name = "cmdCocktail";
            this.cmdCocktail.Size = new System.Drawing.Size(75, 23);
            this.cmdCocktail.TabIndex = 4;
            this.cmdCocktail.Text = "CocktailSort";
            this.cmdCocktail.UseVisualStyleBackColor = true;
            // 
            // cmdSelection
            // 
            this.cmdSelection.Location = new System.Drawing.Point(601, 33);
            this.cmdSelection.Name = "cmdSelection";
            this.cmdSelection.Size = new System.Drawing.Size(83, 23);
            this.cmdSelection.TabIndex = 5;
            this.cmdSelection.Text = "SelectionSort";
            this.cmdSelection.UseVisualStyleBackColor = true;
            // 
            // cmdASel
            // 
            this.cmdASel.Location = new System.Drawing.Point(601, 74);
            this.cmdASel.Name = "cmdASel";
            this.cmdASel.Size = new System.Drawing.Size(83, 23);
            this.cmdASel.TabIndex = 10;
            this.cmdASel.Text = "Animacion";
            this.cmdASel.UseVisualStyleBackColor = true;
            // 
            // cmdACoc
            // 
            this.cmdACoc.Location = new System.Drawing.Point(475, 74);
            this.cmdACoc.Name = "cmdACoc";
            this.cmdACoc.Size = new System.Drawing.Size(75, 23);
            this.cmdACoc.TabIndex = 9;
            this.cmdACoc.Text = "Animacion";
            this.cmdACoc.UseVisualStyleBackColor = true;
            // 
            // cmdAMerge
            // 
            this.cmdAMerge.Location = new System.Drawing.Point(350, 74);
            this.cmdAMerge.Name = "cmdAMerge";
            this.cmdAMerge.Size = new System.Drawing.Size(75, 23);
            this.cmdAMerge.TabIndex = 8;
            this.cmdAMerge.Text = "Animacion";
            this.cmdAMerge.UseVisualStyleBackColor = true;
            // 
            // cmdABubble
            // 
            this.cmdABubble.Location = new System.Drawing.Point(218, 74);
            this.cmdABubble.Name = "cmdABubble";
            this.cmdABubble.Size = new System.Drawing.Size(75, 23);
            this.cmdABubble.TabIndex = 7;
            this.cmdABubble.Text = "Animacion";
            this.cmdABubble.UseVisualStyleBackColor = true;
            // 
            // cmdAQuick
            // 
            this.cmdAQuick.Location = new System.Drawing.Point(90, 74);
            this.cmdAQuick.Name = "cmdAQuick";
            this.cmdAQuick.Size = new System.Drawing.Size(75, 23);
            this.cmdAQuick.TabIndex = 6;
            this.cmdAQuick.Text = "Animacion";
            this.cmdAQuick.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lbSelectionSort);
            this.groupBox3.Controls.Add(this.lbCocktailSort);
            this.groupBox3.Controls.Add(this.lbMergeSort);
            this.groupBox3.Controls.Add(this.lbBubbleSort);
            this.groupBox3.Controls.Add(this.lbQuickSort);
            this.groupBox3.Location = new System.Drawing.Point(12, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1015, 142);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // lbQuickSort
            // 
            this.lbQuickSort.FormattingEnabled = true;
            this.lbQuickSort.Items.AddRange(new object[] {
            "Tiempo: --",
            "Iteraciones: --"});
            this.lbQuickSort.Location = new System.Drawing.Point(63, 38);
            this.lbQuickSort.Name = "lbQuickSort";
            this.lbQuickSort.Size = new System.Drawing.Size(120, 95);
            this.lbQuickSort.TabIndex = 0;
            // 
            // lbBubbleSort
            // 
            this.lbBubbleSort.FormattingEnabled = true;
            this.lbBubbleSort.Items.AddRange(new object[] {
            "Tiempo: --",
            "Iteraciones: --"});
            this.lbBubbleSort.Location = new System.Drawing.Point(251, 38);
            this.lbBubbleSort.Name = "lbBubbleSort";
            this.lbBubbleSort.Size = new System.Drawing.Size(120, 95);
            this.lbBubbleSort.TabIndex = 1;
            // 
            // lbMergeSort
            // 
            this.lbMergeSort.FormattingEnabled = true;
            this.lbMergeSort.Items.AddRange(new object[] {
            "Tiempo: --",
            "Iteraciones: --"});
            this.lbMergeSort.Location = new System.Drawing.Point(444, 38);
            this.lbMergeSort.Name = "lbMergeSort";
            this.lbMergeSort.Size = new System.Drawing.Size(120, 95);
            this.lbMergeSort.TabIndex = 2;
            // 
            // lbCocktailSort
            // 
            this.lbCocktailSort.FormattingEnabled = true;
            this.lbCocktailSort.Items.AddRange(new object[] {
            "Tiempo: --",
            "Iteraciones: --"});
            this.lbCocktailSort.Location = new System.Drawing.Point(635, 38);
            this.lbCocktailSort.Name = "lbCocktailSort";
            this.lbCocktailSort.Size = new System.Drawing.Size(120, 95);
            this.lbCocktailSort.TabIndex = 3;
            // 
            // lbSelectionSort
            // 
            this.lbSelectionSort.FormattingEnabled = true;
            this.lbSelectionSort.Items.AddRange(new object[] {
            "Tiempo: --",
            "Iteraciones: --"});
            this.lbSelectionSort.Location = new System.Drawing.Point(835, 38);
            this.lbSelectionSort.Name = "lbSelectionSort";
            this.lbSelectionSort.Size = new System.Drawing.Size(120, 95);
            this.lbSelectionSort.TabIndex = 4;
            // 
            // pbGrafico
            // 
            this.pbGrafico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGrafico.Location = new System.Drawing.Point(12, 310);
            this.pbGrafico.Name = "pbGrafico";
            this.pbGrafico.Size = new System.Drawing.Size(1015, 453);
            this.pbGrafico.TabIndex = 12;
            this.pbGrafico.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "QuickSort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "BubbleSort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "MergeSort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "CocktailSort";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(832, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "SelectionSort";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Grafica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 775);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbGrafico);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajo Practico - Metodos de Ordenamiento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdASel;
        private System.Windows.Forms.Button cmdACoc;
        private System.Windows.Forms.Button cmdAMerge;
        private System.Windows.Forms.Button cmdABubble;
        private System.Windows.Forms.Button cmdAQuick;
        private System.Windows.Forms.Button cmdSelection;
        private System.Windows.Forms.Button cmdCocktail;
        private System.Windows.Forms.Button cmdMergeSort;
        private System.Windows.Forms.Button cmdBubbleSort;
        private System.Windows.Forms.Button cmdQuickSort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSelectionSort;
        private System.Windows.Forms.ListBox lbCocktailSort;
        private System.Windows.Forms.ListBox lbMergeSort;
        private System.Windows.Forms.ListBox lbBubbleSort;
        private System.Windows.Forms.ListBox lbQuickSort;
        private System.Windows.Forms.PictureBox pbGrafico;
        private System.Windows.Forms.Label label7;
    }
}

