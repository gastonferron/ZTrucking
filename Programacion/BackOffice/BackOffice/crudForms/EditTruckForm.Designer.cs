﻿namespace BackOffice.crudForms
{
    partial class EditTruckForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.labelIDTruck2 = new System.Windows.Forms.Label();
            this.txtBoxTruckID = new System.Windows.Forms.TextBox();
            this.labelActivated = new System.Windows.Forms.Label();
            this.comboBoxActivated = new System.Windows.Forms.ComboBox();
            this.labelTruckVolume = new System.Windows.Forms.Label();
            this.txtBoxVolumeTruck = new System.Windows.Forms.TextBox();
            this.labelTruckWeight = new System.Windows.Forms.Label();
            this.txtBoxWeightTruck = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(92, 289);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 147;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(11, 289);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 146;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(230, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 145;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(0, 2);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(224, 37);
            this.panelSlide.TabIndex = 144;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // labelIDTruck2
            // 
            this.labelIDTruck2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIDTruck2.AutoSize = true;
            this.labelIDTruck2.Location = new System.Drawing.Point(13, 54);
            this.labelIDTruck2.Name = "labelIDTruck2";
            this.labelIDTruck2.Size = new System.Drawing.Size(73, 13);
            this.labelIDTruck2.TabIndex = 153;
            this.labelIDTruck2.Text = "ID de camion:";
            // 
            // txtBoxTruckID
            // 
            this.txtBoxTruckID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTruckID.Location = new System.Drawing.Point(16, 80);
            this.txtBoxTruckID.Name = "txtBoxTruckID";
            this.txtBoxTruckID.Size = new System.Drawing.Size(31, 20);
            this.txtBoxTruckID.TabIndex = 152;
            // 
            // labelActivated
            // 
            this.labelActivated.AutoSize = true;
            this.labelActivated.BackColor = System.Drawing.Color.Transparent;
            this.labelActivated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelActivated.Location = new System.Drawing.Point(13, 221);
            this.labelActivated.Name = "labelActivated";
            this.labelActivated.Size = new System.Drawing.Size(62, 17);
            this.labelActivated.TabIndex = 159;
            this.labelActivated.Text = "Activado";
            // 
            // comboBoxActivated
            // 
            this.comboBoxActivated.FormattingEnabled = true;
            this.comboBoxActivated.Location = new System.Drawing.Point(16, 241);
            this.comboBoxActivated.Name = "comboBoxActivated";
            this.comboBoxActivated.Size = new System.Drawing.Size(59, 21);
            this.comboBoxActivated.TabIndex = 158;
            // 
            // labelTruckVolume
            // 
            this.labelTruckVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTruckVolume.AutoSize = true;
            this.labelTruckVolume.Location = new System.Drawing.Point(13, 172);
            this.labelTruckVolume.Name = "labelTruckVolume";
            this.labelTruckVolume.Size = new System.Drawing.Size(103, 13);
            this.labelTruckVolume.TabIndex = 157;
            this.labelTruckVolume.Text = "Volumen de camion:";
            // 
            // txtBoxVolumeTruck
            // 
            this.txtBoxVolumeTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxVolumeTruck.Location = new System.Drawing.Point(16, 198);
            this.txtBoxVolumeTruck.Name = "txtBoxVolumeTruck";
            this.txtBoxVolumeTruck.Size = new System.Drawing.Size(61, 20);
            this.txtBoxVolumeTruck.TabIndex = 156;
            // 
            // labelTruckWeight
            // 
            this.labelTruckWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTruckWeight.AutoSize = true;
            this.labelTruckWeight.Location = new System.Drawing.Point(13, 113);
            this.labelTruckWeight.Name = "labelTruckWeight";
            this.labelTruckWeight.Size = new System.Drawing.Size(86, 13);
            this.labelTruckWeight.TabIndex = 155;
            this.labelTruckWeight.Text = "Peso de camion:";
            // 
            // txtBoxWeightTruck
            // 
            this.txtBoxWeightTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxWeightTruck.Location = new System.Drawing.Point(16, 139);
            this.txtBoxWeightTruck.Name = "txtBoxWeightTruck";
            this.txtBoxWeightTruck.Size = new System.Drawing.Size(61, 20);
            this.txtBoxWeightTruck.TabIndex = 154;
            // 
            // EditTruckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(268, 324);
            this.Controls.Add(this.labelActivated);
            this.Controls.Add(this.comboBoxActivated);
            this.Controls.Add(this.labelTruckVolume);
            this.Controls.Add(this.txtBoxVolumeTruck);
            this.Controls.Add(this.labelTruckWeight);
            this.Controls.Add(this.txtBoxWeightTruck);
            this.Controls.Add(this.labelIDTruck2);
            this.Controls.Add(this.txtBoxTruckID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditTruckForm";
            this.Text = "EditTruckForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Label labelIDTruck2;
        private System.Windows.Forms.TextBox txtBoxTruckID;
        private System.Windows.Forms.Label labelActivated;
        private System.Windows.Forms.ComboBox comboBoxActivated;
        private System.Windows.Forms.Label labelTruckVolume;
        private System.Windows.Forms.TextBox txtBoxVolumeTruck;
        private System.Windows.Forms.Label labelTruckWeight;
        private System.Windows.Forms.TextBox txtBoxWeightTruck;
    }
}