﻿namespace Cosmoser.PingAnMeetingRequest.Outlook2010.Views
{
    partial class MobileTermForm
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
            this.listBoxAvailable = new System.Windows.Forms.ListBox();
            this.listBoxSelected = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAvailabelSearch = new System.Windows.Forms.TextBox();
            this.txtSelectedSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxAvailable
            // 
            this.listBoxAvailable.FormattingEnabled = true;
            this.listBoxAvailable.ItemHeight = 12;
            this.listBoxAvailable.Location = new System.Drawing.Point(12, 66);
            this.listBoxAvailable.Name = "listBoxAvailable";
            this.listBoxAvailable.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAvailable.Size = new System.Drawing.Size(163, 256);
            this.listBoxAvailable.TabIndex = 0;
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.FormattingEnabled = true;
            this.listBoxSelected.ItemHeight = 12;
            this.listBoxSelected.Location = new System.Drawing.Point(296, 66);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSelected.Size = new System.Drawing.Size(167, 256);
            this.listBoxSelected.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = ">>添加>>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(197, 197);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<<去除<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(12, 9);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(119, 12);
            this.lblAvailable.TabIndex = 4;
            this.lblAvailable.Text = "待选移动终端(共1个)";
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(294, 9);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(119, 12);
            this.lblSelected.TabIndex = 5;
            this.lblSelected.Text = "已选移动终端(共1个)";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(130, 344);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(250, 344);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAvailabelSearch
            // 
            this.txtAvailabelSearch.Location = new System.Drawing.Point(54, 35);
            this.txtAvailabelSearch.Name = "txtAvailabelSearch";
            this.txtAvailabelSearch.Size = new System.Drawing.Size(121, 21);
            this.txtAvailabelSearch.TabIndex = 8;
            this.txtAvailabelSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAvailabelSearch_KeyDown);
            // 
            // txtSelectedSearch
            // 
            this.txtSelectedSearch.Location = new System.Drawing.Point(339, 35);
            this.txtSelectedSearch.Name = "txtSelectedSearch";
            this.txtSelectedSearch.Size = new System.Drawing.Size(124, 21);
            this.txtSelectedSearch.TabIndex = 9;
            this.txtSelectedSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSelectedSearch_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "搜索：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "搜索：";
            // 
            // MobileTermForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSelectedSearch);
            this.Controls.Add(this.txtAvailabelSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxSelected);
            this.Controls.Add(this.listBoxAvailable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MobileTermForm";
            this.Text = "选择移动终端";
            this.Load += new System.EventHandler(this.MobileTermForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAvailable;
        private System.Windows.Forms.ListBox listBoxSelected;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtAvailabelSearch;
        private System.Windows.Forms.TextBox txtSelectedSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}