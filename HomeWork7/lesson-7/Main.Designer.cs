namespace lesson_7
{
    partial class Main
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.lbComputerNumber = new System.Windows.Forms.Label();
            this.lbUserNumber = new System.Windows.Forms.Label();
            this.lbStepsNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPlayItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMoveBack = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(244, 39);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 57);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Новая игра";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(244, 102);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(111, 57);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiply.Location = new System.Drawing.Point(244, 165);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(111, 57);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "x2";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // lbComputerNumber
            // 
            this.lbComputerNumber.AutoSize = true;
            this.lbComputerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbComputerNumber.Location = new System.Drawing.Point(12, 57);
            this.lbComputerNumber.Name = "lbComputerNumber";
            this.lbComputerNumber.Size = new System.Drawing.Size(151, 20);
            this.lbComputerNumber.TabIndex = 3;
            this.lbComputerNumber.Text = "Получите число:";
            // 
            // lbUserNumber
            // 
            this.lbUserNumber.AutoSize = true;
            this.lbUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserNumber.Location = new System.Drawing.Point(12, 157);
            this.lbUserNumber.Name = "lbUserNumber";
            this.lbUserNumber.Size = new System.Drawing.Size(140, 20);
            this.lbUserNumber.TabIndex = 4;
            this.lbUserNumber.Text = "Текущее число:";
            // 
            // lbStepsNumber
            // 
            this.lbStepsNumber.AutoSize = true;
            this.lbStepsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStepsNumber.Location = new System.Drawing.Point(12, 246);
            this.lbStepsNumber.Name = "lbStepsNumber";
            this.lbStepsNumber.Size = new System.Drawing.Size(170, 20);
            this.lbStepsNumber.TabIndex = 5;
            this.lbStepsNumber.Text = "Количество ходов:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMenuItem
            // 
            this.MainMenuItem.AutoSize = false;
            this.MainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPlayItem});
            this.MainMenuItem.Name = "MainMenuItem";
            this.MainMenuItem.Size = new System.Drawing.Size(53, 20);
            this.MainMenuItem.Text = "Меню";
            // 
            // MenuPlayItem
            // 
            this.MenuPlayItem.CheckOnClick = true;
            this.MenuPlayItem.Name = "MenuPlayItem";
            this.MenuPlayItem.Size = new System.Drawing.Size(112, 22);
            this.MenuPlayItem.Text = "Играть";
            this.MenuPlayItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuPlayItem.Click += new System.EventHandler(this.MenuPlayItem_Click);
            // 
            // btnMoveBack
            // 
            this.btnMoveBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMoveBack.Location = new System.Drawing.Point(244, 229);
            this.btnMoveBack.Name = "btnMoveBack";
            this.btnMoveBack.Size = new System.Drawing.Size(111, 57);
            this.btnMoveBack.TabIndex = 7;
            this.btnMoveBack.Text = "Отменить ход";
            this.btnMoveBack.UseVisualStyleBackColor = true;
            this.btnMoveBack.Click += new System.EventHandler(this.btnMoveBack_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.btnMoveBack);
            this.Controls.Add(this.lbStepsNumber);
            this.Controls.Add(this.lbUserNumber);
            this.Controls.Add(this.lbComputerNumber);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Label lbComputerNumber;
        private System.Windows.Forms.Label lbUserNumber;
        private System.Windows.Forms.Label lbStepsNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MenuPlayItem;
        private System.Windows.Forms.Button btnMoveBack;
    }
}
