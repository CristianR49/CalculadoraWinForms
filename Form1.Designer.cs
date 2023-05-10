namespace CalculadoraWinForms
{
    partial class Calculadora
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            virgula = new Button();
            buttonSoma = new Button();
            buttonSubtracao = new Button();
            buttonMultiplicacao = new Button();
            buttonDivisao = new Button();
            buttonIgual = new Button();
            buttonC = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 15);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "Calculadora";
            // 
            // button1
            // 
            button1.Location = new Point(69, 106);
            button1.Name = "button1";
            button1.Size = new Size(52, 50);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(127, 106);
            button2.Name = "button2";
            button2.Size = new Size(52, 50);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(185, 106);
            button3.Name = "button3";
            button3.Size = new Size(52, 50);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(69, 162);
            button4.Name = "button4";
            button4.Size = new Size(52, 50);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(127, 162);
            button5.Name = "button5";
            button5.Size = new Size(52, 50);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(185, 162);
            button6.Name = "button6";
            button6.Size = new Size(52, 50);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(69, 218);
            button7.Name = "button7";
            button7.Size = new Size(52, 50);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(127, 218);
            button8.Name = "button8";
            button8.Size = new Size(52, 50);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(185, 218);
            button9.Name = "button9";
            button9.Size = new Size(52, 50);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(127, 274);
            button0.Name = "button0";
            button0.Size = new Size(52, 50);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // virgula
            // 
            virgula.Location = new Point(185, 274);
            virgula.Name = "virgula";
            virgula.Size = new Size(52, 50);
            virgula.TabIndex = 12;
            virgula.Text = ",";
            virgula.UseVisualStyleBackColor = true;
            virgula.Click += virgula_Click;
            // 
            // buttonSoma
            // 
            buttonSoma.Location = new Point(256, 106);
            buttonSoma.Name = "buttonSoma";
            buttonSoma.Size = new Size(52, 50);
            buttonSoma.TabIndex = 13;
            buttonSoma.Text = "+";
            buttonSoma.UseVisualStyleBackColor = true;
            buttonSoma.Click += buttonSoma_Click;
            // 
            // buttonSubtracao
            // 
            buttonSubtracao.Location = new Point(256, 162);
            buttonSubtracao.Name = "buttonSubtracao";
            buttonSubtracao.Size = new Size(52, 50);
            buttonSubtracao.TabIndex = 14;
            buttonSubtracao.Text = "-";
            buttonSubtracao.UseVisualStyleBackColor = true;
            buttonSubtracao.Click += buttonSubtracao_Click;
            // 
            // buttonMultiplicacao
            // 
            buttonMultiplicacao.Location = new Point(256, 218);
            buttonMultiplicacao.Name = "buttonMultiplicacao";
            buttonMultiplicacao.Size = new Size(52, 50);
            buttonMultiplicacao.TabIndex = 15;
            buttonMultiplicacao.Text = "*";
            buttonMultiplicacao.UseVisualStyleBackColor = true;
            buttonMultiplicacao.Click += buttonMultiplicacao_Click;
            // 
            // buttonDivisao
            // 
            buttonDivisao.Location = new Point(256, 274);
            buttonDivisao.Name = "buttonDivisao";
            buttonDivisao.Size = new Size(52, 50);
            buttonDivisao.TabIndex = 16;
            buttonDivisao.Text = "/";
            buttonDivisao.UseVisualStyleBackColor = true;
            buttonDivisao.Click += buttonDivisao_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.Location = new Point(208, 330);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(100, 50);
            buttonIgual.TabIndex = 17;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = true;
            buttonIgual.Click += buttonigual_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(69, 274);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(52, 50);
            buttonC.TabIndex = 18;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 31);
            textBox1.TabIndex = 19;
            textBox1.Text = "0";
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 414);
            Controls.Add(textBox1);
            Controls.Add(buttonC);
            Controls.Add(buttonIgual);
            Controls.Add(buttonDivisao);
            Controls.Add(buttonMultiplicacao);
            Controls.Add(buttonSubtracao);
            Controls.Add(buttonSoma);
            Controls.Add(virgula);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Calculadora";
            Text = "CalculadoraWinForms";
            Load += Calculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button virgula;
        private Button buttonSoma;
        private Button buttonSubtracao;
        private Button buttonMultiplicacao;
        private Button buttonDivisao;
        private Button buttonIgual;
        private Button buttonC;
        private TextBox textBox1;
    }
}