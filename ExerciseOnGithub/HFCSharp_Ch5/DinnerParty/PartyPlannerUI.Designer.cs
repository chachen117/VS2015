namespace HFCSharp_Ch5
{
    partial class PartyPlannerUI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chk_HealthyOption = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_NumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.chk_FancyDecoration = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Cost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_NumberOfPeople)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chk_HealthyOption, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nud_NumberOfPeople, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chk_FancyDecoration, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.64627F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.26071F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.03672F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.791922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.49572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.76866F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 348);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chk_HealthyOption
            // 
            this.chk_HealthyOption.AutoSize = true;
            this.chk_HealthyOption.Location = new System.Drawing.Point(28, 133);
            this.chk_HealthyOption.Name = "chk_HealthyOption";
            this.chk_HealthyOption.Size = new System.Drawing.Size(169, 28);
            this.chk_HealthyOption.TabIndex = 3;
            this.chk_HealthyOption.Text = "Healthy Option";
            this.chk_HealthyOption.UseVisualStyleBackColor = true;
            this.chk_HealthyOption.CheckedChanged += new System.EventHandler(this.chk_HealthyOption_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // nud_NumberOfPeople
            // 
            this.nud_NumberOfPeople.Location = new System.Drawing.Point(28, 60);
            this.nud_NumberOfPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_NumberOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_NumberOfPeople.Name = "nud_NumberOfPeople";
            this.nud_NumberOfPeople.Size = new System.Drawing.Size(169, 31);
            this.nud_NumberOfPeople.TabIndex = 1;
            this.nud_NumberOfPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_NumberOfPeople.ValueChanged += new System.EventHandler(this.nud_NumberOfPeople_ValueChanged);
            // 
            // chk_FancyDecoration
            // 
            this.chk_FancyDecoration.AutoSize = true;
            this.chk_FancyDecoration.Location = new System.Drawing.Point(28, 99);
            this.chk_FancyDecoration.Name = "chk_FancyDecoration";
            this.chk_FancyDecoration.Size = new System.Drawing.Size(194, 28);
            this.chk_FancyDecoration.TabIndex = 2;
            this.chk_FancyDecoration.Text = "Fancy decorations";
            this.chk_FancyDecoration.UseVisualStyleBackColor = true;
            this.chk_FancyDecoration.CheckedChanged += new System.EventHandler(this.chk_FancyDecoration_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Cost, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(28, 167);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(249, 117);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lbl_Cost
            // 
            this.lbl_Cost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Cost.Location = new System.Drawing.Point(63, 39);
            this.lbl_Cost.Name = "lbl_Cost";
            this.lbl_Cost.Size = new System.Drawing.Size(179, 38);
            this.lbl_Cost.TabIndex = 1;
            this.lbl_Cost.Text = "$";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cost";
            // 
            // PartyPlannerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 348);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartyPlannerUI";
            this.Text = "Party Planner";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_NumberOfPeople)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chk_HealthyOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_NumberOfPeople;
        private System.Windows.Forms.CheckBox chk_FancyDecoration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Cost;
        private System.Windows.Forms.Label label2;
    }
}

