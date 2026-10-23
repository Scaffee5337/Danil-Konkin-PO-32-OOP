namespace SupplierCatalogAnalitics
{
    partial class FormMain
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
            dgvCatalog = new DataGridView();
            btnExcept = new Button();
            btnIntersect = new Button();
            btnUnionSorted = new Button();
            btnConcatDistinct = new Button();
            rdbAsc = new RadioButton();
            rdbDesc = new RadioButton();
            btnSort = new Button();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip2 = new StatusStrip();
            ((System.ComponentModel.ISupportInitialize)dgvCatalog).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCatalog
            // 
            dgvCatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatalog.Location = new Point(0, 0);
            dgvCatalog.Name = "dgvCatalog";
            dgvCatalog.Size = new Size(788, 162);
            dgvCatalog.TabIndex = 0;
            dgvCatalog.CellContentClick += dgvCatalog_CellContentClick;
            // 
            // btnExcept
            // 
            btnExcept.Location = new Point(12, 168);
            btnExcept.Name = "btnExcept";
            btnExcept.Size = new Size(163, 37);
            btnExcept.TabIndex = 1;
            btnExcept.Text = "Только поставщик A";
            btnExcept.UseVisualStyleBackColor = true;
            btnExcept.Click += btnExcept_Click;
            // 
            // btnIntersect
            // 
            btnIntersect.Location = new Point(12, 236);
            btnIntersect.Name = "btnIntersect";
            btnIntersect.Size = new Size(163, 41);
            btnIntersect.TabIndex = 2;
            btnIntersect.Text = "Общие товары";
            btnIntersect.UseVisualStyleBackColor = true;
            btnIntersect.Click += btnIntersect_Click;
            // 
            // btnUnionSorted
            // 
            btnUnionSorted.Location = new Point(12, 294);
            btnUnionSorted.Name = "btnUnionSorted";
            btnUnionSorted.Size = new Size(163, 45);
            btnUnionSorted.TabIndex = 3;
            btnUnionSorted.Text = "Объединённый каталог";
            btnUnionSorted.UseVisualStyleBackColor = true;
            btnUnionSorted.Click += btnUnionSorted_Click;
            // 
            // btnConcatDistinct
            // 
            btnConcatDistinct.Location = new Point(12, 362);
            btnConcatDistinct.Name = "btnConcatDistinct";
            btnConcatDistinct.Size = new Size(163, 32);
            btnConcatDistinct.TabIndex = 4;
            btnConcatDistinct.Text = "Полный реестр";
            btnConcatDistinct.UseVisualStyleBackColor = true;
            btnConcatDistinct.Click += btnConcatDistinct_Click;
            // 
            // rdbAsc
            // 
            rdbAsc.AutoSize = true;
            rdbAsc.Location = new Point(309, 168);
            rdbAsc.Name = "rdbAsc";
            rdbAsc.Size = new Size(116, 19);
            rdbAsc.TabIndex = 5;
            rdbAsc.TabStop = true;
            rdbAsc.Text = "По возрастанию";
            rdbAsc.UseVisualStyleBackColor = true;
            // 
            // rdbDesc
            // 
            rdbDesc.AutoSize = true;
            rdbDesc.Location = new Point(309, 211);
            rdbDesc.Name = "rdbDesc";
            rdbDesc.Size = new Size(102, 19);
            rdbDesc.TabIndex = 6;
            rdbDesc.TabStop = true;
            rdbDesc.Text = "По убыванию";
            rdbDesc.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(309, 254);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(150, 44);
            btnSort.TabIndex = 7;
            btnSort.Text = "Применить сортировку";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 17);
            lblStatus.Text = "Готово";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // statusStrip2
            // 
            statusStrip2.Location = new Point(0, 406);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(800, 22);
            statusStrip2.TabIndex = 9;
            statusStrip2.Text = "statusStrip2";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip2);
            Controls.Add(statusStrip1);
            Controls.Add(btnSort);
            Controls.Add(rdbDesc);
            Controls.Add(rdbAsc);
            Controls.Add(btnConcatDistinct);
            Controls.Add(btnUnionSorted);
            Controls.Add(btnIntersect);
            Controls.Add(btnExcept);
            Controls.Add(dgvCatalog);
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)dgvCatalog).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCatalog;
        private Button btnExcept;
        private Button btnIntersect;
        private Button btnUnionSorted;
        private Button btnConcatDistinct;
        private RadioButton rdbAsc;
        private RadioButton rdbDesc;
        private Button btnSort;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}