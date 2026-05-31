namespace App
{
    partial class sortTeamsForm
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
            this.IDSort = new System.Windows.Forms.Button();
            this.teamSort = new System.Windows.Forms.Button();
            this.yearSort = new System.Windows.Forms.Button();
            this.coachSort = new System.Windows.Forms.Button();
            this.teamTableDataGridView = new System.Windows.Forms.DataGridView();
            this.teamTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new App.Database1DataSet();
            this.mainFormBtn = new System.Windows.Forms.Button();
            this.teamTableTableAdapter = new App.Database1DataSetTableAdapters.TeamTableTableAdapter();
            this.tableAdapterManager = new App.Database1DataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teamTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // IDSort
            // 
            this.IDSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDSort.Location = new System.Drawing.Point(45, 33);
            this.IDSort.Name = "IDSort";
            this.IDSort.Size = new System.Drawing.Size(165, 42);
            this.IDSort.TabIndex = 0;
            this.IDSort.Text = "Sort By ID";
            this.IDSort.UseVisualStyleBackColor = true;
            this.IDSort.Click += new System.EventHandler(this.IDSort_Click);
            // 
            // teamSort
            // 
            this.teamSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamSort.Location = new System.Drawing.Point(333, 33);
            this.teamSort.Name = "teamSort";
            this.teamSort.Size = new System.Drawing.Size(165, 42);
            this.teamSort.TabIndex = 1;
            this.teamSort.Text = "Sort By Team";
            this.teamSort.UseVisualStyleBackColor = true;
            this.teamSort.Click += new System.EventHandler(this.teamSort_Click);
            // 
            // yearSort
            // 
            this.yearSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearSort.Location = new System.Drawing.Point(876, 33);
            this.yearSort.Name = "yearSort";
            this.yearSort.Size = new System.Drawing.Size(165, 42);
            this.yearSort.TabIndex = 3;
            this.yearSort.Text = "Sort By Year";
            this.yearSort.UseVisualStyleBackColor = true;
            this.yearSort.Click += new System.EventHandler(this.yearSort_Click);
            // 
            // coachSort
            // 
            this.coachSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coachSort.Location = new System.Drawing.Point(606, 33);
            this.coachSort.Name = "coachSort";
            this.coachSort.Size = new System.Drawing.Size(165, 42);
            this.coachSort.TabIndex = 2;
            this.coachSort.Text = "Sort By Coach";
            this.coachSort.UseVisualStyleBackColor = true;
            this.coachSort.Click += new System.EventHandler(this.coachSort_Click);
            // 
            // teamTableDataGridView
            // 
            this.teamTableDataGridView.AllowUserToAddRows = false;
            this.teamTableDataGridView.AllowUserToDeleteRows = false;
            this.teamTableDataGridView.AutoGenerateColumns = false;
            this.teamTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.teamTableDataGridView.DataSource = this.teamTableBindingSource;
            this.teamTableDataGridView.Location = new System.Drawing.Point(45, 113);
            this.teamTableDataGridView.Name = "teamTableDataGridView";
            this.teamTableDataGridView.ReadOnly = true;
            this.teamTableDataGridView.RowHeadersWidth = 62;
            this.teamTableDataGridView.RowTemplate.Height = 28;
            this.teamTableDataGridView.Size = new System.Drawing.Size(996, 290);
            this.teamTableDataGridView.TabIndex = 5;
            // 
            // teamTableBindingSource
            // 
            this.teamTableBindingSource.DataMember = "TeamTable";
            this.teamTableBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainFormBtn
            // 
            this.mainFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormBtn.Location = new System.Drawing.Point(441, 448);
            this.mainFormBtn.Name = "mainFormBtn";
            this.mainFormBtn.Size = new System.Drawing.Size(259, 42);
            this.mainFormBtn.TabIndex = 6;
            this.mainFormBtn.Text = "Main Form";
            this.mainFormBtn.UseVisualStyleBackColor = true;
            this.mainFormBtn.Click += new System.EventHandler(this.mainFormBtn_Click);
            // 
            // teamTableTableAdapter
            // 
            this.teamTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlayerTableTableAdapter = null;
            this.tableAdapterManager.TeamTableTableAdapter = this.teamTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = App.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Team Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Team Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Coach";
            this.dataGridViewTextBoxColumn3.HeaderText = "Coach";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn4.HeaderText = "Year";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // sortTeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 527);
            this.Controls.Add(this.mainFormBtn);
            this.Controls.Add(this.teamTableDataGridView);
            this.Controls.Add(this.yearSort);
            this.Controls.Add(this.coachSort);
            this.Controls.Add(this.teamSort);
            this.Controls.Add(this.IDSort);
            this.Name = "sortTeamsForm";
            this.Text = "Sort Teams";
            this.Load += new System.EventHandler(this.sortTeamsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IDSort;
        private System.Windows.Forms.Button teamSort;
        private System.Windows.Forms.Button yearSort;
        private System.Windows.Forms.Button coachSort;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource teamTableBindingSource;
        private Database1DataSetTableAdapters.TeamTableTableAdapter teamTableTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView teamTableDataGridView;
        private System.Windows.Forms.Button mainFormBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}