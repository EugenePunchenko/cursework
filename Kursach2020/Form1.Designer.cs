namespace Kursach2020
{
    partial class Form1
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
            this.listBoxTerms = new System.Windows.Forms.ListBox();
            this.findButton = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.textBoxTerm = new System.Windows.Forms.TextBox();
            this.textBoxDef = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.folderPathToTrie = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // listBoxTerms
            // 
            this.listBoxTerms.FormattingEnabled = true;
            this.listBoxTerms.Location = new System.Drawing.Point(12, 311);
            this.listBoxTerms.Name = "listBoxTerms";
            this.listBoxTerms.Size = new System.Drawing.Size(776, 212);
            this.listBoxTerms.TabIndex = 0;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(713, 27);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(90, 30);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(327, 20);
            this.textBoxFind.TabIndex = 2;
            // 
            // textBoxTerm
            // 
            this.textBoxTerm.Location = new System.Drawing.Point(90, 96);
            this.textBoxTerm.Name = "textBoxTerm";
            this.textBoxTerm.Size = new System.Drawing.Size(327, 20);
            this.textBoxTerm.TabIndex = 3;
            // 
            // textBoxDef
            // 
            this.textBoxDef.Location = new System.Drawing.Point(90, 166);
            this.textBoxDef.Name = "textBoxDef";
            this.textBoxDef.Size = new System.Drawing.Size(327, 20);
            this.textBoxDef.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Найти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Термин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Определение";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(713, 96);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить слово";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Создать дерево";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCreateTrie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDef);
            this.Controls.Add(this.textBoxTerm);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.listBoxTerms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTerms;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.TextBox textBoxTerm;
        private System.Windows.Forms.TextBox textBoxDef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderPathToTrie;
    }
}

