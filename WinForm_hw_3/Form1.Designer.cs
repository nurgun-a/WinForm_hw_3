
namespace WinForm_hw_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_anketa = new System.Windows.Forms.Button();
            this.button_tovar = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_anketa
            // 
            this.button_anketa.Location = new System.Drawing.Point(12, 12);
            this.button_anketa.Name = "button_anketa";
            this.button_anketa.Size = new System.Drawing.Size(75, 75);
            this.button_anketa.TabIndex = 0;
            this.button_anketa.Text = "Анкета";
            this.button_anketa.UseVisualStyleBackColor = true;
            this.button_anketa.Click += new System.EventHandler(this.button_anketa_Click);
            this.button_anketa.MouseEnter += new System.EventHandler(this.button_anketa_MouseEnter);
            this.button_anketa.MouseLeave += new System.EventHandler(this.button_anketa_MouseLeave);
            // 
            // button_tovar
            // 
            this.button_tovar.Location = new System.Drawing.Point(93, 12);
            this.button_tovar.Name = "button_tovar";
            this.button_tovar.Size = new System.Drawing.Size(75, 75);
            this.button_tovar.TabIndex = 0;
            this.button_tovar.Text = "Каталог товаров";
            this.button_tovar.UseVisualStyleBackColor = true;
            this.button_tovar.Click += new System.EventHandler(this.button_tovar_Click);
            this.button_tovar.MouseEnter += new System.EventHandler(this.button_tovar_MouseEnter);
            this.button_tovar.MouseLeave += new System.EventHandler(this.button_anketa_MouseLeave);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(174, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 75);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Выход";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            this.button_close.MouseEnter += new System.EventHandler(this.button_close_MouseEnter);
            this.button_close.MouseLeave += new System.EventHandler(this.button_anketa_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(265, 103);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_tovar);
            this.Controls.Add(this.button_anketa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Д/3 № 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_anketa;
        private System.Windows.Forms.Button button_tovar;
        private System.Windows.Forms.Button button_close;
    }
}

