namespace WindowsFormLabirintGenCol
{
    partial class Map
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
            this.dataGridViewLabirint = new System.Windows.Forms.DataGridView();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelKeys = new System.Windows.Forms.Label();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabirint)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLabirint
            // 
            this.dataGridViewLabirint.AllowUserToAddRows = false;
            this.dataGridViewLabirint.AllowUserToDeleteRows = false;
            this.dataGridViewLabirint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLabirint.ColumnHeadersVisible = false;
            this.dataGridViewLabirint.Location = new System.Drawing.Point(102, 34);
            this.dataGridViewLabirint.Name = "dataGridViewLabirint";
            this.dataGridViewLabirint.ReadOnly = true;
            this.dataGridViewLabirint.RowHeadersVisible = false;
            this.dataGridViewLabirint.Size = new System.Drawing.Size(461, 385);
            this.dataGridViewLabirint.TabIndex = 0;
            this.dataGridViewLabirint.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLabirint_CellContentClick);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(462, 445);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(101, 27);
            this.buttonNewGame.TabIndex = 1;
            this.buttonNewGame.Text = "Новая игра";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(42, 13);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Счёт: 0";
            // 
            // labelKeys
            // 
            this.labelKeys.AutoSize = true;
            this.labelKeys.Location = new System.Drawing.Point(12, 43);
            this.labelKeys.Name = "labelKeys";
            this.labelKeys.Size = new System.Drawing.Size(51, 13);
            this.labelKeys.TabIndex = 3;
            this.labelKeys.Text = "Ключи: 0";
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.Location = new System.Drawing.Point(663, 34);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(137, 238);
            this.listBoxMessages.TabIndex = 4;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 484);
            this.Controls.Add(this.listBoxMessages);
            this.Controls.Add(this.labelKeys);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.dataGridViewLabirint);
            this.KeyPreview = true;
            this.Name = "Map";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Map_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Map_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabirint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLabirint;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelKeys;
        private System.Windows.Forms.ListBox listBoxMessages;
    }
}

