namespace App.Forms
{
    partial class SortPlayers
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
            this.mainFormBtn = new System.Windows.Forms.Button();
            this.positionSort = new System.Windows.Forms.Button();
            this.numberSort = new System.Windows.Forms.Button();
            this.playerSort = new System.Windows.Forms.Button();
            this.IDSort = new System.Windows.Forms.Button();
            this.database1DataSet = new App.Database1DataSet();
            this.playerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerTableTableAdapter = new App.Database1DataSetTableAdapters.PlayerTableTableAdapter();
            this.tableAdapterManager = new App.Database1DataSetTableAdapters.TableAdapterManager();
            this.playerTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIDSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormBtn
            // 
            this.mainFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormBtn.Location = new System.Drawing.Point(502, 496);
            this.mainFormBtn.Name = "mainFormBtn";
            this.mainFormBtn.Size = new System.Drawing.Size(259, 42);
            this.mainFormBtn.TabIndex = 12;
            this.mainFormBtn.Text = "Main Form";
            this.mainFormBtn.UseVisualStyleBackColor = true;
            this.mainFormBtn.Click += new System.EventHandler(this.mainFormBtn_Click);
            // 
            // positionSort
            // 
            this.positionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionSort.Location = new System.Drawing.Point(780, 29);
            this.positionSort.Name = "positionSort";
            this.positionSort.Size = new System.Drawing.Size(204, 42);
            this.positionSort.TabIndex = 10;
            this.positionSort.Text = "Sort By Position";
            this.positionSort.UseVisualStyleBackColor = true;
            this.positionSort.Click += new System.EventHandler(this.positionSort_Click);
            // 
            // numberSort
            // 
            this.numberSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSort.Location = new System.Drawing.Point(533, 29);
            this.numberSort.Name = "numberSort";
            this.numberSort.Size = new System.Drawing.Size(204, 42);
            this.numberSort.TabIndex = 9;
            this.numberSort.Text = "Sort By Number";
            this.numberSort.UseVisualStyleBackColor = true;
            this.numberSort.Click += new System.EventHandler(this.numberSort_Click);
            // 
            // playerSort
            // 
            this.playerSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerSort.Location = new System.Drawing.Point(281, 29);
            this.playerSort.Name = "playerSort";
            this.playerSort.Size = new System.Drawing.Size(204, 42);
            this.playerSort.TabIndex = 8;
            this.playerSort.Text = "Sort By Player";
            this.playerSort.UseVisualStyleBackColor = true;
            this.playerSort.Click += new System.EventHandler(this.playerSort_Click);
            // 
            // IDSort
            // 
            this.IDSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDSort.Location = new System.Drawing.Point(30, 29);
            this.IDSort.Name = "IDSort";
            this.IDSort.Size = new System.Drawing.Size(204, 42);
            this.IDSort.TabIndex = 7;
            this.IDSort.Text = "Sort By ID";
            this.IDSort.UseVisualStyleBackColor = true;
            this.IDSort.Click += new System.EventHandler(this.IDSort_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerTableBindingSource
            // 
            this.playerTableBindingSource.DataMember = "PlayerTable";
            this.playerTableBindingSource.DataSource = this.database1DataSet;
            // 
            // playerTableTableAdapter
            // 
            this.playerTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlayerTableTableAdapter = this.playerTableTableAdapter;
            this.tableAdapterManager.TeamTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = App.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // playerTableDataGridView
            // 
            this.playerTableDataGridView.AllowUserToAddRows = false;
            this.playerTableDataGridView.AllowUserToDeleteRows = false;
            this.playerTableDataGridView.AutoGenerateColumns = false;
            this.playerTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.playerTableDataGridView.DataSource = this.playerTableBindingSource;
            this.playerTableDataGridView.Location = new System.Drawing.Point(30, 133);
            this.playerTableDataGridView.Name = "playerTableDataGridView";
            this.playerTableDataGridView.ReadOnly = true;
            this.playerTableDataGridView.RowHeadersWidth = 62;
            this.playerTableDataGridView.RowTemplate.Height = 28;
            this.playerTableDataGridView.Size = new System.Drawing.Size(1203, 327);
            this.playerTableDataGridView.TabIndex = 13;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Player\'s Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Player\'s Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Player\'s Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Player\'s Number";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn4.HeaderText = "Position";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Team ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Team ID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // teamIDSort
            // 
            this.teamIDSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamIDSort.Location = new System.Drawing.Point(1029, 29);
            this.teamIDSort.Name = "teamIDSort";
            this.teamIDSort.Size = new System.Drawing.Size(204, 42);
            this.teamIDSort.TabIndex = 14;
            this.teamIDSort.Text = "Sort By TeamID";
            this.teamIDSort.UseVisualStyleBackColor = true;
            this.teamIDSort.Click += new System.EventHandler(this.teamIDSort_Click);
            // 
            // SortPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 581);
            this.Controls.Add(this.teamIDSort);
            this.Controls.Add(this.playerTableDataGridView);
            this.Controls.Add(this.mainFormBtn);
            this.Controls.Add(this.positionSort);
            this.Controls.Add(this.numberSort);
            this.Controls.Add(this.playerSort);
            this.Controls.Add(this.IDSort);
            this.Name = "SortPlayers";
            this.Text = "SortPlayers";
            this.Load += new System.EventHandler(this.SortPlayers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainFormBtn;
        private System.Windows.Forms.Button positionSort;
        private System.Windows.Forms.Button numberSort;
        private System.Windows.Forms.Button playerSort;
        private System.Windows.Forms.Button IDSort;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource playerTableBindingSource;
        private Database1DataSetTableAdapters.PlayerTableTableAdapter playerTableTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView playerTableDataGridView;
        private System.Windows.Forms.Button teamIDSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}