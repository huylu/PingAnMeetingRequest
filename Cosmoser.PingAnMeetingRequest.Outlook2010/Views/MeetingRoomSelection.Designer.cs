﻿namespace Cosmoser.PingAnMeetingRequest.Outlook2010.Views
{
    partial class MeetingRoomSelection
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
            this.listBoxMeetingRoom = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxLevel = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxAvailableRoom = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxSelectedRooms = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelectAllOnSecondLevel = new System.Windows.Forms.Button();
            this.btnSelectAllOnCountry = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMainRoomSetting = new System.Windows.Forms.Button();
            this.lblMainRoom = new System.Windows.Forms.Label();
            this.txtAvailableSearch = new System.Windows.Forms.TextBox();
            this.txtSelectSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxMeetingRoom
            // 
            this.listBoxMeetingRoom.FormattingEnabled = true;
            this.listBoxMeetingRoom.ItemHeight = 12;
            this.listBoxMeetingRoom.Location = new System.Drawing.Point(51, 60);
            this.listBoxMeetingRoom.Name = "listBoxMeetingRoom";
            this.listBoxMeetingRoom.Size = new System.Drawing.Size(219, 88);
            this.listBoxMeetingRoom.TabIndex = 0;
            this.listBoxMeetingRoom.SelectedIndexChanged += new System.EventHandler(this.listBoxMeetingRoom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "会议室分组";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "级别";
            // 
            // listBoxLevel
            // 
            this.listBoxLevel.FormattingEnabled = true;
            this.listBoxLevel.ItemHeight = 12;
            this.listBoxLevel.Location = new System.Drawing.Point(51, 202);
            this.listBoxLevel.Name = "listBoxLevel";
            this.listBoxLevel.Size = new System.Drawing.Size(219, 52);
            this.listBoxLevel.TabIndex = 2;
            this.listBoxLevel.SelectedIndexChanged += new System.EventHandler(this.listBoxLevel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "待选会议室";
            // 
            // listBoxAvailableRoom
            // 
            this.listBoxAvailableRoom.FormattingEnabled = true;
            this.listBoxAvailableRoom.ItemHeight = 12;
            this.listBoxAvailableRoom.Location = new System.Drawing.Point(53, 335);
            this.listBoxAvailableRoom.Name = "listBoxAvailableRoom";
            this.listBoxAvailableRoom.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAvailableRoom.Size = new System.Drawing.Size(219, 124);
            this.listBoxAvailableRoom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "参会会议室";
            // 
            // listBoxSelectedRooms
            // 
            this.listBoxSelectedRooms.FormattingEnabled = true;
            this.listBoxSelectedRooms.ItemHeight = 12;
            this.listBoxSelectedRooms.Location = new System.Drawing.Point(470, 87);
            this.listBoxSelectedRooms.Name = "listBoxSelectedRooms";
            this.listBoxSelectedRooms.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSelectedRooms.Size = new System.Drawing.Size(219, 268);
            this.listBoxSelectedRooms.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(334, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = ">>添加>>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(334, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "<<去除<<";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelectAllOnSecondLevel
            // 
            this.btnSelectAllOnSecondLevel.Location = new System.Drawing.Point(313, 190);
            this.btnSelectAllOnSecondLevel.Name = "btnSelectAllOnSecondLevel";
            this.btnSelectAllOnSecondLevel.Size = new System.Drawing.Size(121, 23);
            this.btnSelectAllOnSecondLevel.TabIndex = 10;
            this.btnSelectAllOnSecondLevel.Text = "某系列二级全选";
            this.btnSelectAllOnSecondLevel.UseVisualStyleBackColor = true;
            this.btnSelectAllOnSecondLevel.Click += new System.EventHandler(this.btnSelectAllOnSecondLevel_Click);
            // 
            // btnSelectAllOnCountry
            // 
            this.btnSelectAllOnCountry.Location = new System.Drawing.Point(313, 236);
            this.btnSelectAllOnCountry.Name = "btnSelectAllOnCountry";
            this.btnSelectAllOnCountry.Size = new System.Drawing.Size(121, 23);
            this.btnSelectAllOnCountry.TabIndex = 11;
            this.btnSelectAllOnCountry.Text = "某系列全国全选";
            this.btnSelectAllOnCountry.UseVisualStyleBackColor = true;
            this.btnSelectAllOnCountry.Click += new System.EventHandler(this.btnSelectAllOnCountry_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(283, 468);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(388, 468);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMainRoomSetting
            // 
            this.btnMainRoomSetting.Location = new System.Drawing.Point(515, 400);
            this.btnMainRoomSetting.Name = "btnMainRoomSetting";
            this.btnMainRoomSetting.Size = new System.Drawing.Size(118, 23);
            this.btnMainRoomSetting.TabIndex = 14;
            this.btnMainRoomSetting.Text = "设定主会场";
            this.btnMainRoomSetting.UseVisualStyleBackColor = true;
            this.btnMainRoomSetting.Click += new System.EventHandler(this.btnMainRoomSetting_Click);
            // 
            // lblMainRoom
            // 
            this.lblMainRoom.AutoSize = true;
            this.lblMainRoom.ForeColor = System.Drawing.Color.Red;
            this.lblMainRoom.Location = new System.Drawing.Point(472, 372);
            this.lblMainRoom.Name = "lblMainRoom";
            this.lblMainRoom.Size = new System.Drawing.Size(0, 12);
            this.lblMainRoom.TabIndex = 15;
            // 
            // txtAvailableSearch
            // 
            this.txtAvailableSearch.Location = new System.Drawing.Point(98, 305);
            this.txtAvailableSearch.Name = "txtAvailableSearch";
            this.txtAvailableSearch.Size = new System.Drawing.Size(172, 21);
            this.txtAvailableSearch.TabIndex = 16;
            this.txtAvailableSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAvailableSearch_KeyDown);
            // 
            // txtSelectSearch
            // 
            this.txtSelectSearch.Location = new System.Drawing.Point(515, 60);
            this.txtSelectSearch.Name = "txtSelectSearch";
            this.txtSelectSearch.Size = new System.Drawing.Size(174, 21);
            this.txtSelectSearch.TabIndex = 17;
            this.txtSelectSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSelectSearch_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "搜索：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "搜索：";
            // 
            // MeetingRoomSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 503);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSelectSearch);
            this.Controls.Add(this.txtAvailableSearch);
            this.Controls.Add(this.lblMainRoom);
            this.Controls.Add(this.btnMainRoomSetting);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSelectAllOnCountry);
            this.Controls.Add(this.btnSelectAllOnSecondLevel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxSelectedRooms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxAvailableRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMeetingRoom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MeetingRoomSelection";
            this.Text = "会议室选择";
            this.Load += new System.EventHandler(this.MeetingRoomSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMeetingRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxAvailableRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxSelectedRooms;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelectAllOnSecondLevel;
        private System.Windows.Forms.Button btnSelectAllOnCountry;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMainRoomSetting;
        private System.Windows.Forms.Label lblMainRoom;
        private System.Windows.Forms.TextBox txtAvailableSearch;
        private System.Windows.Forms.TextBox txtSelectSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}