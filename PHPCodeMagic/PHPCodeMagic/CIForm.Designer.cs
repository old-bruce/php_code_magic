namespace PHPCodeMagic
{
    partial class CIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbxCode = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTable = new System.Windows.Forms.TextBox();
            this.btnModel = new System.Windows.Forms.Button();
            this.btnController = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnController);
            this.panel1.Controls.Add(this.btnModel);
            this.panel1.Controls.Add(this.tbxTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 75);
            this.panel1.TabIndex = 0;
            // 
            // rbxCode
            // 
            this.rbxCode.BackColor = System.Drawing.Color.Black;
            this.rbxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbxCode.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbxCode.ForeColor = System.Drawing.Color.White;
            this.rbxCode.Location = new System.Drawing.Point(0, 75);
            this.rbxCode.Name = "rbxCode";
            this.rbxCode.ReadOnly = true;
            this.rbxCode.Size = new System.Drawing.Size(624, 366);
            this.rbxCode.TabIndex = 1;
            this.rbxCode.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据表名";
            // 
            // tbxTable
            // 
            this.tbxTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTable.Location = new System.Drawing.Point(77, 23);
            this.tbxTable.Name = "tbxTable";
            this.tbxTable.Size = new System.Drawing.Size(370, 26);
            this.tbxTable.TabIndex = 3;
            this.tbxTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxTable_KeyDown);
            // 
            // btnModel
            // 
            this.btnModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModel.Location = new System.Drawing.Point(537, 22);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(75, 26);
            this.btnModel.TabIndex = 4;
            this.btnModel.Text = "Model";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // btnController
            // 
            this.btnController.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnController.Location = new System.Drawing.Point(456, 22);
            this.btnController.Name = "btnController";
            this.btnController.Size = new System.Drawing.Size(75, 26);
            this.btnController.TabIndex = 5;
            this.btnController.Text = "Controller";
            this.btnController.UseVisualStyleBackColor = true;
            this.btnController.Click += new System.EventHandler(this.btnController_Click);
            // 
            // CIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.rbxCode);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CIForm";
            this.Text = "CodeIgniter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rbxCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTable;
        private System.Windows.Forms.Button btnController;
        private System.Windows.Forms.Button btnModel;
    }
}