namespace Sebo
{
    partial class GerenciadorEditora
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
            this.button1 = new System.Windows.Forms.Button();
            this.Editoras = new System.Windows.Forms.DataGridView();
            this.seboDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seboDataSet = new Sebo.SeboDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new Sebo.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Editoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Criar Editora Aleph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Editoras
            // 
            this.Editoras.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.Editoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Editoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editoras.Location = new System.Drawing.Point(13, 13);
            this.Editoras.Name = "Editoras";
            this.Editoras.Size = new System.Drawing.Size(259, 150);
            this.Editoras.TabIndex = 1;
            this.Editoras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // seboDataSetBindingSource
            // 
            this.seboDataSetBindingSource.DataSource = this.seboDataSet;
            this.seboDataSetBindingSource.Position = 0;
            // 
            // seboDataSet
            // 
            this.seboDataSet.DataSetName = "SeboDataSet";
            this.seboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.dataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // GerenciadorEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 455);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Editoras);
            this.Controls.Add(this.button1);
            this.Name = "GerenciadorEditora";
            this.Text = "Criar Editora";
            this.Load += new System.EventHandler(this.GerenciadorEditora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Editoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Editoras;
        private System.Windows.Forms.BindingSource seboDataSetBindingSource;
        private SeboDataSet seboDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
    }
}

