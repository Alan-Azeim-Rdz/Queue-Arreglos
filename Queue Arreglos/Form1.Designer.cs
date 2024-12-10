namespace Queue_Arreglos
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
            label7 = new Label();
            BtnSizeIn = new Button();
            LisboxQueue = new ListBox();
            TxtNumberAdd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnPeek = new Button();
            BtnDequeue = new Button();
            BtnEnqueue = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(115, 253);
            label7.Name = "label7";
            label7.Size = new Size(172, 15);
            label7.TabIndex = 26;
            label7.Text = "verificar espacio numeros inpar";
            // 
            // BtnSizeIn
            // 
            BtnSizeIn.Location = new Point(321, 245);
            BtnSizeIn.Name = "BtnSizeIn";
            BtnSizeIn.Size = new Size(75, 23);
            BtnSizeIn.TabIndex = 25;
            BtnSizeIn.Text = "size";
            BtnSizeIn.UseVisualStyleBackColor = true;
            BtnSizeIn.Click += BtnSizeIn_Click;
            // 
            // LisboxQueue
            // 
            LisboxQueue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LisboxQueue.FormattingEnabled = true;
            LisboxQueue.ItemHeight = 45;
            LisboxQueue.Location = new Point(551, 21);
            LisboxQueue.Name = "LisboxQueue";
            LisboxQueue.Size = new Size(135, 409);
            LisboxQueue.TabIndex = 24;
            // 
            // TxtNumberAdd
            // 
            TxtNumberAdd.Location = new Point(425, 35);
            TxtNumberAdd.Name = "TxtNumberAdd";
            TxtNumberAdd.Size = new Size(100, 23);
            TxtNumberAdd.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 142);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 21;
            label3.Text = "mostrar dato mas antiguo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 88);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 20;
            label2.Text = "Quitar datos (Dato mas antiguo)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 39);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 19;
            label1.Text = "Agrega un numero";
            // 
            // BtnPeek
            // 
            BtnPeek.Location = new Point(321, 142);
            BtnPeek.Name = "BtnPeek";
            BtnPeek.Size = new Size(75, 23);
            BtnPeek.TabIndex = 17;
            BtnPeek.Text = "Mostrar";
            BtnPeek.UseVisualStyleBackColor = true;
            BtnPeek.Click += BtnPeek_Click;
            // 
            // BtnDequeue
            // 
            BtnDequeue.Location = new Point(321, 88);
            BtnDequeue.Name = "BtnDequeue";
            BtnDequeue.Size = new Size(75, 23);
            BtnDequeue.TabIndex = 16;
            BtnDequeue.Text = "Remove";
            BtnDequeue.UseVisualStyleBackColor = true;
            BtnDequeue.Click += BtnDequeue_Click;
            // 
            // BtnEnqueue
            // 
            BtnEnqueue.Location = new Point(321, 35);
            BtnEnqueue.Name = "BtnEnqueue";
            BtnEnqueue.Size = new Size(75, 23);
            BtnEnqueue.TabIndex = 15;
            BtnEnqueue.Text = "Add";
            BtnEnqueue.UseVisualStyleBackColor = true;
            BtnEnqueue.Click += BtnEnqueue_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(BtnSizeIn);
            Controls.Add(LisboxQueue);
            Controls.Add(TxtNumberAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnPeek);
            Controls.Add(BtnDequeue);
            Controls.Add(BtnEnqueue);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button BtnSizeIn;
        private ListBox LisboxQueue;
        private TextBox TxtNumberAdd;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnPeek;
        private Button BtnDequeue;
        private Button BtnEnqueue;
    }
}
