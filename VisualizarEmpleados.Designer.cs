namespace Empleado_L5_
{
    partial class VisualizarEmpleados
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
            this.btnSueldoEmpleado = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSueldoEmpleado
            // 
            this.btnSueldoEmpleado.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSueldoEmpleado.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSueldoEmpleado.Location = new System.Drawing.Point(304, 373);
            this.btnSueldoEmpleado.Name = "btnSueldoEmpleado";
            this.btnSueldoEmpleado.Size = new System.Drawing.Size(182, 56);
            this.btnSueldoEmpleado.TabIndex = 0;
            this.btnSueldoEmpleado.Text = "Verificar Sueldo";
            this.btnSueldoEmpleado.UseVisualStyleBackColor = false;
            this.btnSueldoEmpleado.Click += new System.EventHandler(this.btnVisualizarEmpleados_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 355);
            this.dataGridView1.TabIndex = 1;
            // 
            // VisualizarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 441);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSueldoEmpleado);
            this.Name = "VisualizarEmpleados";
            this.Text = "VisualizarEmpleados";
            this.Load += new System.EventHandler(this.VisualizarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSueldoEmpleado;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}