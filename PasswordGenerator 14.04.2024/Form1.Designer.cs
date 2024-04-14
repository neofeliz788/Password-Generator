namespace PasswordGenerator_14._04._2024
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.checkSimilarity = new System.Windows.Forms.CheckBox();
            this.checkNonLetter = new System.Windows.Forms.CheckBox();
            this.comboLength = new System.Windows.Forms.ComboBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonChoose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.AutoSize = true;
            this.buttonGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGenerate.BackColor = System.Drawing.Color.Transparent;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("Alef", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.ForeColor = System.Drawing.Color.Black;
            this.buttonGenerate.Location = new System.Drawing.Point(300, 390);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(149, 36);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Сгенерировать";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkSimilarity
            // 
            this.checkSimilarity.AutoSize = true;
            this.checkSimilarity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkSimilarity.BackgroundImage")));
            this.checkSimilarity.Font = new System.Drawing.Font("Alef", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSimilarity.Location = new System.Drawing.Point(49, 287);
            this.checkSimilarity.Name = "checkSimilarity";
            this.checkSimilarity.Size = new System.Drawing.Size(222, 22);
            this.checkSimilarity.TabIndex = 1;
            this.checkSimilarity.Text = "Исключить похожие символы";
            this.checkSimilarity.UseVisualStyleBackColor = true;
            this.checkSimilarity.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkNonLetter
            // 
            this.checkNonLetter.AutoSize = true;
            this.checkNonLetter.BackColor = System.Drawing.Color.CadetBlue;
            this.checkNonLetter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkNonLetter.BackgroundImage")));
            this.checkNonLetter.Font = new System.Drawing.Font("Alef", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNonLetter.ForeColor = System.Drawing.Color.Black;
            this.checkNonLetter.Location = new System.Drawing.Point(49, 334);
            this.checkNonLetter.Name = "checkNonLetter";
            this.checkNonLetter.Size = new System.Drawing.Size(255, 22);
            this.checkNonLetter.TabIndex = 2;
            this.checkNonLetter.Text = "Исключить небуквенные символы";
            this.checkNonLetter.UseVisualStyleBackColor = false;
            this.checkNonLetter.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboLength
            // 
            this.comboLength.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLength.FormattingEnabled = true;
            this.comboLength.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboLength.Location = new System.Drawing.Point(49, 372);
            this.comboLength.Name = "comboLength";
            this.comboLength.Size = new System.Drawing.Size(143, 27);
            this.comboLength.TabIndex = 3;
            this.comboLength.Text = "Длина пароля";
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.White;
            this.textPassword.ForeColor = System.Drawing.Color.Black;
            this.textPassword.Location = new System.Drawing.Point(317, 287);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(300, 22);
            this.textPassword.TabIndex = 4;
            this.textPassword.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonChoose
            // 
            this.buttonChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChoose.AutoSize = true;
            this.buttonChoose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonChoose.BackColor = System.Drawing.Color.Transparent;
            this.buttonChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoose.Font = new System.Drawing.Font("Alef", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoose.ForeColor = System.Drawing.Color.Black;
            this.buttonChoose.Location = new System.Drawing.Point(508, 390);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(158, 36);
            this.buttonChoose.TabIndex = 5;
            this.buttonChoose.Text = "Выбрать пароль";
            this.buttonChoose.UseVisualStyleBackColor = false;
            this.buttonChoose.Click += new System.EventHandler(this.button2_CLick);
            this.buttonChoose.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(779, 518);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.comboLength);
            this.Controls.Add(this.checkNonLetter);
            this.Controls.Add(this.checkSimilarity);
            this.Controls.Add(this.buttonGenerate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.CheckBox checkSimilarity;
        private System.Windows.Forms.CheckBox checkNonLetter;
        private System.Windows.Forms.ComboBox comboLength;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonChoose;
    }
}

