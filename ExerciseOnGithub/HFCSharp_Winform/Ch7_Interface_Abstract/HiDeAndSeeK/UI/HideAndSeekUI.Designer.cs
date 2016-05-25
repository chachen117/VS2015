namespace HFCSharp_Winform
{
    partial class HideAndSeekUI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_GoThroughDoor = new System.Windows.Forms.Button();
            this.btn_GoHere = new System.Windows.Forms.Button();
            this.cbx_Exists = new System.Windows.Forms.ComboBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GoThroughDoor
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_GoThroughDoor, 2);
            this.btn_GoThroughDoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_GoThroughDoor.Location = new System.Drawing.Point(3, 384);
            this.btn_GoThroughDoor.Name = "btn_GoThroughDoor";
            this.btn_GoThroughDoor.Size = new System.Drawing.Size(475, 34);
            this.btn_GoThroughDoor.TabIndex = 0;
            this.btn_GoThroughDoor.Text = "Go through the door";
            this.btn_GoThroughDoor.UseVisualStyleBackColor = true;
            this.btn_GoThroughDoor.Click += new System.EventHandler(this.btn_GoThroughDoor_Click);
            // 
            // btn_GoHere
            // 
            this.btn_GoHere.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_GoHere.Location = new System.Drawing.Point(3, 344);
            this.btn_GoHere.Name = "btn_GoHere";
            this.btn_GoHere.Size = new System.Drawing.Size(114, 34);
            this.btn_GoHere.TabIndex = 1;
            this.btn_GoHere.Text = "Go here:";
            this.btn_GoHere.UseVisualStyleBackColor = true;
            this.btn_GoHere.Click += new System.EventHandler(this.btn_GoHere_Click);
            // 
            // cbx_Exists
            // 
            this.cbx_Exists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_Exists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Exists.FormattingEnabled = true;
            this.cbx_Exists.Location = new System.Drawing.Point(123, 344);
            this.cbx_Exists.Name = "cbx_Exists";
            this.cbx_Exists.Size = new System.Drawing.Size(355, 31);
            this.cbx_Exists.TabIndex = 2;
            // 
            // txt_Description
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Description, 2);
            this.txt_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Description.Location = new System.Drawing.Point(3, 3);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(475, 335);
            this.txt_Description.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Check, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Hide, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_GoHere, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Description, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbx_Exists, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_GoThroughDoor, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 501);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btn_Hide
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_Hide, 2);
            this.btn_Hide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Hide.Location = new System.Drawing.Point(3, 464);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(475, 34);
            this.btn_Hide.TabIndex = 4;
            this.btn_Hide.Text = "Hide!";
            this.btn_Hide.UseVisualStyleBackColor = true;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // btn_Check
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_Check, 2);
            this.btn_Check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Check.Location = new System.Drawing.Point(3, 424);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(475, 34);
            this.btn_Check.TabIndex = 5;
            this.btn_Check.Text = " ";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Hide and Seek";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GoThroughDoor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_GoHere;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.ComboBox cbx_Exists;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_Hide;
    }
}

