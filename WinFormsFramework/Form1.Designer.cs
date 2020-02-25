namespace WinFormsFramework
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iterationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accuracyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generationNetworkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porosityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minElementSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxElementSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgElementSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сohesionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cavernsVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chanelsVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permeabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voxelArrayDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.scaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isArchivedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.generatedSampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.imageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_delete = new System.Windows.Forms.Button();
            this.numericUpDown_id = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedSampleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iterationDataGridViewTextBoxColumn,
            this.accuracyDataGridViewTextBoxColumn,
            this.lossDataGridViewTextBoxColumn,
            this.generationNetworkDataGridViewTextBoxColumn,
            this.porosityDataGridViewTextBoxColumn,
            this.elementsCountDataGridViewTextBoxColumn,
            this.minElementSizeDataGridViewTextBoxColumn,
            this.maxElementSizeDataGridViewTextBoxColumn,
            this.avgElementSizeDataGridViewTextBoxColumn,
            this.сohesionDataGridViewTextBoxColumn,
            this.cavernsVolumeDataGridViewTextBoxColumn,
            this.chanelsVolumeDataGridViewTextBoxColumn,
            this.permeabilityDataGridViewTextBoxColumn,
            this.voxelArrayDataGridViewImageColumn,
            this.scaleDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.isArchivedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.generatedSampleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(951, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // iterationDataGridViewTextBoxColumn
            // 
            this.iterationDataGridViewTextBoxColumn.DataPropertyName = "Iteration";
            this.iterationDataGridViewTextBoxColumn.HeaderText = "Iteration";
            this.iterationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iterationDataGridViewTextBoxColumn.Name = "iterationDataGridViewTextBoxColumn";
            this.iterationDataGridViewTextBoxColumn.Width = 125;
            // 
            // accuracyDataGridViewTextBoxColumn
            // 
            this.accuracyDataGridViewTextBoxColumn.DataPropertyName = "Accuracy";
            this.accuracyDataGridViewTextBoxColumn.HeaderText = "Accuracy";
            this.accuracyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accuracyDataGridViewTextBoxColumn.Name = "accuracyDataGridViewTextBoxColumn";
            this.accuracyDataGridViewTextBoxColumn.Width = 125;
            // 
            // lossDataGridViewTextBoxColumn
            // 
            this.lossDataGridViewTextBoxColumn.DataPropertyName = "Loss";
            this.lossDataGridViewTextBoxColumn.HeaderText = "Loss";
            this.lossDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lossDataGridViewTextBoxColumn.Name = "lossDataGridViewTextBoxColumn";
            this.lossDataGridViewTextBoxColumn.Width = 125;
            // 
            // generationNetworkDataGridViewTextBoxColumn
            // 
            this.generationNetworkDataGridViewTextBoxColumn.DataPropertyName = "GenerationNetwork";
            this.generationNetworkDataGridViewTextBoxColumn.HeaderText = "GenerationNetwork";
            this.generationNetworkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generationNetworkDataGridViewTextBoxColumn.Name = "generationNetworkDataGridViewTextBoxColumn";
            this.generationNetworkDataGridViewTextBoxColumn.Width = 125;
            // 
            // porosityDataGridViewTextBoxColumn
            // 
            this.porosityDataGridViewTextBoxColumn.DataPropertyName = "Porosity";
            this.porosityDataGridViewTextBoxColumn.HeaderText = "Porosity";
            this.porosityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.porosityDataGridViewTextBoxColumn.Name = "porosityDataGridViewTextBoxColumn";
            this.porosityDataGridViewTextBoxColumn.Width = 125;
            // 
            // elementsCountDataGridViewTextBoxColumn
            // 
            this.elementsCountDataGridViewTextBoxColumn.DataPropertyName = "ElementsCount";
            this.elementsCountDataGridViewTextBoxColumn.HeaderText = "ElementsCount";
            this.elementsCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elementsCountDataGridViewTextBoxColumn.Name = "elementsCountDataGridViewTextBoxColumn";
            this.elementsCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // minElementSizeDataGridViewTextBoxColumn
            // 
            this.minElementSizeDataGridViewTextBoxColumn.DataPropertyName = "MinElementSize";
            this.minElementSizeDataGridViewTextBoxColumn.HeaderText = "MinElementSize";
            this.minElementSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minElementSizeDataGridViewTextBoxColumn.Name = "minElementSizeDataGridViewTextBoxColumn";
            this.minElementSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxElementSizeDataGridViewTextBoxColumn
            // 
            this.maxElementSizeDataGridViewTextBoxColumn.DataPropertyName = "MaxElementSize";
            this.maxElementSizeDataGridViewTextBoxColumn.HeaderText = "MaxElementSize";
            this.maxElementSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxElementSizeDataGridViewTextBoxColumn.Name = "maxElementSizeDataGridViewTextBoxColumn";
            this.maxElementSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // avgElementSizeDataGridViewTextBoxColumn
            // 
            this.avgElementSizeDataGridViewTextBoxColumn.DataPropertyName = "AvgElementSize";
            this.avgElementSizeDataGridViewTextBoxColumn.HeaderText = "AvgElementSize";
            this.avgElementSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.avgElementSizeDataGridViewTextBoxColumn.Name = "avgElementSizeDataGridViewTextBoxColumn";
            this.avgElementSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // сohesionDataGridViewTextBoxColumn
            // 
            this.сohesionDataGridViewTextBoxColumn.DataPropertyName = "Сohesion";
            this.сohesionDataGridViewTextBoxColumn.HeaderText = "Сohesion";
            this.сohesionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.сohesionDataGridViewTextBoxColumn.Name = "сohesionDataGridViewTextBoxColumn";
            this.сohesionDataGridViewTextBoxColumn.Width = 125;
            // 
            // cavernsVolumeDataGridViewTextBoxColumn
            // 
            this.cavernsVolumeDataGridViewTextBoxColumn.DataPropertyName = "CavernsVolume";
            this.cavernsVolumeDataGridViewTextBoxColumn.HeaderText = "CavernsVolume";
            this.cavernsVolumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cavernsVolumeDataGridViewTextBoxColumn.Name = "cavernsVolumeDataGridViewTextBoxColumn";
            this.cavernsVolumeDataGridViewTextBoxColumn.Width = 125;
            // 
            // chanelsVolumeDataGridViewTextBoxColumn
            // 
            this.chanelsVolumeDataGridViewTextBoxColumn.DataPropertyName = "ChanelsVolume";
            this.chanelsVolumeDataGridViewTextBoxColumn.HeaderText = "ChanelsVolume";
            this.chanelsVolumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chanelsVolumeDataGridViewTextBoxColumn.Name = "chanelsVolumeDataGridViewTextBoxColumn";
            this.chanelsVolumeDataGridViewTextBoxColumn.Width = 125;
            // 
            // permeabilityDataGridViewTextBoxColumn
            // 
            this.permeabilityDataGridViewTextBoxColumn.DataPropertyName = "Permeability";
            this.permeabilityDataGridViewTextBoxColumn.HeaderText = "Permeability";
            this.permeabilityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.permeabilityDataGridViewTextBoxColumn.Name = "permeabilityDataGridViewTextBoxColumn";
            this.permeabilityDataGridViewTextBoxColumn.Width = 125;
            // 
            // voxelArrayDataGridViewImageColumn
            // 
            this.voxelArrayDataGridViewImageColumn.DataPropertyName = "VoxelArray";
            this.voxelArrayDataGridViewImageColumn.HeaderText = "VoxelArray";
            this.voxelArrayDataGridViewImageColumn.MinimumWidth = 6;
            this.voxelArrayDataGridViewImageColumn.Name = "voxelArrayDataGridViewImageColumn";
            this.voxelArrayDataGridViewImageColumn.Width = 125;
            // 
            // scaleDataGridViewTextBoxColumn
            // 
            this.scaleDataGridViewTextBoxColumn.DataPropertyName = "Scale";
            this.scaleDataGridViewTextBoxColumn.HeaderText = "Scale";
            this.scaleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scaleDataGridViewTextBoxColumn.Name = "scaleDataGridViewTextBoxColumn";
            this.scaleDataGridViewTextBoxColumn.Width = 125;
            // 
            // resolutionDataGridViewTextBoxColumn
            // 
            this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "Resolution";
            this.resolutionDataGridViewTextBoxColumn.HeaderText = "Resolution";
            this.resolutionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
            this.resolutionDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // isArchivedDataGridViewCheckBoxColumn
            // 
            this.isArchivedDataGridViewCheckBoxColumn.DataPropertyName = "IsArchived";
            this.isArchivedDataGridViewCheckBoxColumn.HeaderText = "IsArchived";
            this.isArchivedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isArchivedDataGridViewCheckBoxColumn.Name = "isArchivedDataGridViewCheckBoxColumn";
            this.isArchivedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // generatedSampleBindingSource
            // 
            this.generatedSampleBindingSource.DataSource = typeof(DAL.Entities.GeneratedSample);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DAL.Entities.User);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(986, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(986, 129);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // imageBindingSource
            // 
            this.imageBindingSource.DataSource = typeof(DAL.Entities.Image);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(986, 214);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // numericUpDown_id
            // 
            this.numericUpDown_id.Location = new System.Drawing.Point(965, 243);
            this.numericUpDown_id.Name = "numericUpDown_id";
            this.numericUpDown_id.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_id.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 450);
            this.Controls.Add(this.numericUpDown_id);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedSampleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.BindingSource generatedSampleBindingSource;
        private System.Windows.Forms.BindingSource imageBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iterationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accuracyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lossDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generationNetworkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porosityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minElementSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxElementSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgElementSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сohesionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cavernsVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chanelsVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permeabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn voxelArrayDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isArchivedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.NumericUpDown numericUpDown_id;
    }
}

