﻿using MW5.Tools.Properties;
using MW5.Tools.Views.Controls;

namespace MW5.Tools.Views
{
    partial class GisToolView
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
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panelRequired = new System.Windows.Forms.Panel();
            this.stringParameterControl6 = new MW5.Tools.Views.Controls.StringParameterControl();
            this.stringParameterControl5 = new MW5.Tools.Views.Controls.StringParameterControl();
            this.stringParameterControl4 = new MW5.Tools.Views.Controls.StringParameterControl();
            this.stringParameterControl3 = new MW5.Tools.Views.Controls.StringParameterControl();
            this.stringParameterControl2 = new MW5.Tools.Views.Controls.StringParameterControl();
            this.stringParameterControl1 = new MW5.Tools.Views.Controls.StringParameterControl();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.panelRequired.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BeforeTouchSize = new System.Drawing.Size(282, 21);
            this.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAdv2.Location = new System.Drawing.Point(70, 32);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(282, 21);
            this.comboBoxAdv2.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IsBackStageButton = false;
            this.btnCancel.Location = new System.Drawing.Point(469, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 26);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            // 
            // btnOk
            // 
            this.btnOk.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.IsBackStageButton = false;
            this.btnOk.Location = new System.Drawing.Point(378, 389);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 26);
            this.btnOk.TabIndex = 33;
            this.btnOk.Text = "Ok";
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(550, 373);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv4);
            this.tabControlAdv1.ItemSize = new System.Drawing.Size(120, 40);
            this.tabControlAdv1.Location = new System.Drawing.Point(6, 12);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.RotateTextWhenVertical = true;
            this.tabControlAdv1.Size = new System.Drawing.Size(550, 373);
            this.tabControlAdv1.TabIndex = 35;
            this.tabControlAdv1.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.panelRequired);
            this.tabPageAdv1.Image = global::MW5.Tools.Properties.Resources.img_tools24;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(24, 24);
            this.tabPageAdv1.Location = new System.Drawing.Point(123, 1);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(425, 370);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Required";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // panelRequired
            // 
            this.panelRequired.AutoScroll = true;
            this.panelRequired.Controls.Add(this.stringParameterControl6);
            this.panelRequired.Controls.Add(this.stringParameterControl5);
            this.panelRequired.Controls.Add(this.stringParameterControl4);
            this.panelRequired.Controls.Add(this.stringParameterControl3);
            this.panelRequired.Controls.Add(this.stringParameterControl2);
            this.panelRequired.Controls.Add(this.stringParameterControl1);
            this.panelRequired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRequired.Location = new System.Drawing.Point(0, 0);
            this.panelRequired.Name = "panelRequired";
            this.panelRequired.Padding = new System.Windows.Forms.Padding(20, 25, 20, 25);
            this.panelRequired.Size = new System.Drawing.Size(425, 370);
            this.panelRequired.TabIndex = 0;
            // 
            // stringParameterControl6
            // 
            this.stringParameterControl6.Caption = "label1";
            this.stringParameterControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringParameterControl6.Location = new System.Drawing.Point(20, 275);
            this.stringParameterControl6.Name = "stringParameterControl6";
            this.stringParameterControl6.Size = new System.Drawing.Size(385, 50);
            this.stringParameterControl6.TabIndex = 5;
            // 
            // stringParameterControl5
            // 
            this.stringParameterControl5.Caption = "label1";
            this.stringParameterControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringParameterControl5.Location = new System.Drawing.Point(20, 225);
            this.stringParameterControl5.Name = "stringParameterControl5";
            this.stringParameterControl5.Size = new System.Drawing.Size(385, 50);
            this.stringParameterControl5.TabIndex = 4;
            // 
            // stringParameterControl4
            // 
            this.stringParameterControl4.Caption = "label1";
            this.stringParameterControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringParameterControl4.Location = new System.Drawing.Point(20, 175);
            this.stringParameterControl4.Name = "stringParameterControl4";
            this.stringParameterControl4.Size = new System.Drawing.Size(385, 50);
            this.stringParameterControl4.TabIndex = 3;
            // 
            // stringParameterControl3
            // 
            this.stringParameterControl3.Caption = "label1";
            this.stringParameterControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringParameterControl3.Location = new System.Drawing.Point(20, 125);
            this.stringParameterControl3.Name = "stringParameterControl3";
            this.stringParameterControl3.Size = new System.Drawing.Size(385, 50);
            this.stringParameterControl3.TabIndex = 2;
            // 
            // stringParameterControl2
            // 
            this.stringParameterControl2.Caption = "label1";
            this.stringParameterControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringParameterControl2.Location = new System.Drawing.Point(20, 75);
            this.stringParameterControl2.Name = "stringParameterControl2";
            this.stringParameterControl2.Size = new System.Drawing.Size(385, 50);
            this.stringParameterControl2.TabIndex = 1;
            // 
            // stringParameterControl1
            // 
            this.stringParameterControl1.Caption = "label1";
            this.stringParameterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringParameterControl1.Location = new System.Drawing.Point(20, 25);
            this.stringParameterControl1.Name = "stringParameterControl1";
            this.stringParameterControl1.Size = new System.Drawing.Size(385, 50);
            this.stringParameterControl1.TabIndex = 0;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Image = global::MW5.Tools.Properties.Resources.img_options24;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(24, 24);
            this.tabPageAdv2.Location = new System.Drawing.Point(123, 1);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(425, 370);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "Optional";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.Image = global::MW5.Tools.Properties.Resources.img_log24;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(24, 24);
            this.tabPageAdv3.Location = new System.Drawing.Point(123, 1);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(425, 370);
            this.tabPageAdv3.TabIndex = 3;
            this.tabPageAdv3.Text = "Log";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.Image = global::MW5.Tools.Properties.Resources.img_help24;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(24, 24);
            this.tabPageAdv4.Location = new System.Drawing.Point(123, 1);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(425, 370);
            this.tabPageAdv4.TabIndex = 4;
            this.tabPageAdv4.Text = "Help";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // GisToolView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(565, 418);
            this.Controls.Add(this.tabControlAdv1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "GisToolView";
            this.Text = "Import layer";
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.panelRequired.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv4;
        private System.Windows.Forms.Panel panelRequired;
        private Controls.StringParameterControl stringParameterControl6;
        private Controls.StringParameterControl stringParameterControl5;
        private Controls.StringParameterControl stringParameterControl4;
        private Controls.StringParameterControl stringParameterControl3;
        private Controls.StringParameterControl stringParameterControl2;
        private Controls.StringParameterControl stringParameterControl1;
    }
}