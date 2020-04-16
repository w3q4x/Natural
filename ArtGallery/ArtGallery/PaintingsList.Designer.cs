﻿namespace ArtGallery
{
	partial class PaintingsList
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
			this.paintingDataGridView = new System.Windows.Forms.DataGridView();
			this.AddPaintingButton = new System.Windows.Forms.Button();
			this.RefreshListButton = new System.Windows.Forms.Button();
			this.DeletePaintingsButton = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.EditPainting = new System.Windows.Forms.Button();
			this.PropertiesComboBox = new System.Windows.Forms.ComboBox();
			this.ValuesComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SearchTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.paintingDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// paintingDataGridView
			// 
			this.paintingDataGridView.AllowUserToAddRows = false;
			this.paintingDataGridView.AllowUserToDeleteRows = false;
			this.paintingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.paintingDataGridView.Location = new System.Drawing.Point(15, 119);
			this.paintingDataGridView.Name = "paintingDataGridView";
			this.paintingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.paintingDataGridView.Size = new System.Drawing.Size(1281, 418);
			this.paintingDataGridView.TabIndex = 0;
			// 
			// AddPaintingButton
			// 
			this.AddPaintingButton.Location = new System.Drawing.Point(1124, 613);
			this.AddPaintingButton.Name = "AddPaintingButton";
			this.AddPaintingButton.Size = new System.Drawing.Size(194, 23);
			this.AddPaintingButton.TabIndex = 2;
			this.AddPaintingButton.Text = "Добавить картину";
			this.AddPaintingButton.UseVisualStyleBackColor = true;
			this.AddPaintingButton.Click += new System.EventHandler(this.AddPainting_Click);
			// 
			// RefreshListButton
			// 
			this.RefreshListButton.Location = new System.Drawing.Point(934, 613);
			this.RefreshListButton.Name = "RefreshListButton";
			this.RefreshListButton.Size = new System.Drawing.Size(184, 23);
			this.RefreshListButton.TabIndex = 3;
			this.RefreshListButton.Text = "Обновить список картин";
			this.RefreshListButton.UseVisualStyleBackColor = true;
			this.RefreshListButton.Click += new System.EventHandler(this.RefreshListButton_Click);
			// 
			// DeletePaintingsButton
			// 
			this.DeletePaintingsButton.Location = new System.Drawing.Point(564, 613);
			this.DeletePaintingsButton.Name = "DeletePaintingsButton";
			this.DeletePaintingsButton.Size = new System.Drawing.Size(193, 23);
			this.DeletePaintingsButton.TabIndex = 4;
			this.DeletePaintingsButton.Text = "Выбрать картины для удаления";
			this.DeletePaintingsButton.UseVisualStyleBackColor = true;
			this.DeletePaintingsButton.Click += new System.EventHandler(this.DeletePaintingsButton_Click);
			// 
			// Delete
			// 
			this.Delete.Location = new System.Drawing.Point(578, 543);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(167, 40);
			this.Delete.TabIndex = 5;
			this.Delete.Text = "УДАЛИТЬ";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// EditPainting
			// 
			this.EditPainting.Location = new System.Drawing.Point(763, 613);
			this.EditPainting.Name = "EditPainting";
			this.EditPainting.Size = new System.Drawing.Size(165, 23);
			this.EditPainting.TabIndex = 6;
			this.EditPainting.Text = "Редактировать картину";
			this.EditPainting.UseVisualStyleBackColor = true;
			this.EditPainting.Click += new System.EventHandler(this.EditPainting_Click);
			// 
			// PropertiesComboBox
			// 
			this.PropertiesComboBox.FormattingEnabled = true;
			this.PropertiesComboBox.Location = new System.Drawing.Point(248, 29);
			this.PropertiesComboBox.Name = "PropertiesComboBox";
			this.PropertiesComboBox.Size = new System.Drawing.Size(212, 21);
			this.PropertiesComboBox.TabIndex = 7;
			this.PropertiesComboBox.SelectedIndexChanged += new System.EventHandler(this.ValuesComboBoxFill);
			// 
			// ValuesComboBox
			// 
			this.ValuesComboBox.FormattingEnabled = true;
			this.ValuesComboBox.Location = new System.Drawing.Point(627, 29);
			this.ValuesComboBox.Name = "ValuesComboBox";
			this.ValuesComboBox.Size = new System.Drawing.Size(197, 21);
			this.ValuesComboBox.TabIndex = 8;
			this.ValuesComboBox.SelectedIndexChanged += new System.EventHandler(this.ValuesComboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(186, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Найти по ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(501, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Возможные варианты";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(543, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Или по тексту";
			// 
			// SearchTextBox
			// 
			this.SearchTextBox.Location = new System.Drawing.Point(627, 68);
			this.SearchTextBox.Name = "SearchTextBox";
			this.SearchTextBox.Size = new System.Drawing.Size(204, 20);
			this.SearchTextBox.TabIndex = 12;
			this.SearchTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchTextBox_MouseClick);
			this.SearchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyUp);
			// 
			// PaintingsList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1330, 648);
			this.Controls.Add(this.SearchTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ValuesComboBox);
			this.Controls.Add(this.PropertiesComboBox);
			this.Controls.Add(this.EditPainting);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.DeletePaintingsButton);
			this.Controls.Add(this.RefreshListButton);
			this.Controls.Add(this.AddPaintingButton);
			this.Controls.Add(this.paintingDataGridView);
			this.Name = "PaintingsList";
			this.Text = "PaintingsList";
			((System.ComponentModel.ISupportInitialize)(this.paintingDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView paintingDataGridView;
		private System.Windows.Forms.Button AddPaintingButton;
		private System.Windows.Forms.Button RefreshListButton;
		private System.Windows.Forms.Button DeletePaintingsButton;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.Button EditPainting;
		private System.Windows.Forms.ComboBox PropertiesComboBox;
		private System.Windows.Forms.ComboBox ValuesComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox SearchTextBox;
	}
}