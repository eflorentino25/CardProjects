namespace CardProjects
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
            PB_background = new PictureBox();
            BT_PedeCarta = new Button();
            BT_Parar = new Button();
            BT_restart = new Button();
            ((System.ComponentModel.ISupportInitialize)PB_background).BeginInit();
            SuspendLayout();
            // 
            // PB_background
            // 
            PB_background.BackColor = Color.Lime;
            PB_background.Location = new Point(3, 1);
            PB_background.Name = "PB_background";
            PB_background.Size = new Size(1332, 644);
            PB_background.TabIndex = 0;
            PB_background.TabStop = false;
            // 
            // BT_PedeCarta
            // 
            BT_PedeCarta.Location = new Point(308, 530);
            BT_PedeCarta.Name = "BT_PedeCarta";
            BT_PedeCarta.Size = new Size(75, 23);
            BT_PedeCarta.TabIndex = 1;
            BT_PedeCarta.Text = "+ Carta";
            BT_PedeCarta.UseVisualStyleBackColor = true;
            BT_PedeCarta.Click += BT_PedeCarta_Click;
            // 
            // BT_Parar
            // 
            BT_Parar.Location = new Point(434, 530);
            BT_Parar.Name = "BT_Parar";
            BT_Parar.Size = new Size(75, 23);
            BT_Parar.TabIndex = 2;
            BT_Parar.Text = "Parar";
            BT_Parar.UseVisualStyleBackColor = true;
            BT_Parar.Click += BT_Parar_Click;
            // 
            // BT_restart
            // 
            BT_restart.Location = new Point(556, 530);
            BT_restart.Name = "BT_restart";
            BT_restart.Size = new Size(75, 23);
            BT_restart.TabIndex = 3;
            BT_restart.Text = "Reiniciar";
            BT_restart.UseVisualStyleBackColor = true;
            BT_restart.Click += BT_restart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 643);
            Controls.Add(BT_restart);
            Controls.Add(BT_Parar);
            Controls.Add(BT_PedeCarta);
            Controls.Add(PB_background);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PB_background).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PB_background;
        private Button BT_PedeCarta;
        private Button BT_Parar;
        private Button BT_restart;
    }
}
