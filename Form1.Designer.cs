using System.Drawing;

namespace Filtering_images
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оброботатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборФидьтраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.северToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.северовостокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.востокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.юговостокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.югToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.югозападToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.западToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.северозападToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarForImage = new System.Windows.Forms.ProgressBar();
            this.labelMouseMovePos = new System.Windows.Forms.Label();
            this.labelLeftMouseDownPosX = new System.Windows.Forms.Label();
            this.labelLeftMouseDownPosY = new System.Windows.Forms.Label();
            this.pictureBoxForDrawing = new System.Windows.Forms.PictureBox();
            this.label_filter = new System.Windows.Forms.Label();
            this.скользящееСреднееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гаусовскийФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.весоваяФункцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.выборФидьтраToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.оброботатьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // оброботатьToolStripMenuItem
            // 
            this.оброботатьToolStripMenuItem.Name = "оброботатьToolStripMenuItem";
            this.оброботатьToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.оброботатьToolStripMenuItem.Text = "Оброботать";
            this.оброботатьToolStripMenuItem.Click += new System.EventHandler(this.оброботатьToolStripMenuItem_Click);
            // 
            // выборФидьтраToolStripMenuItem
            // 
            this.выборФидьтраToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.северToolStripMenuItem,
            this.северовостокToolStripMenuItem,
            this.востокToolStripMenuItem,
            this.юговостокToolStripMenuItem,
            this.югToolStripMenuItem,
            this.югозападToolStripMenuItem,
            this.западToolStripMenuItem,
            this.северозападToolStripMenuItem,
            this.скользящееСреднееToolStripMenuItem,
            this.гаусовскийФильтрToolStripMenuItem,
            this.весоваяФункцияToolStripMenuItem});
            this.выборФидьтраToolStripMenuItem.Name = "выборФидьтраToolStripMenuItem";
            this.выборФидьтраToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.выборФидьтраToolStripMenuItem.Text = "Выбор фильтра";
            // 
            // северToolStripMenuItem
            // 
            this.северToolStripMenuItem.Name = "северToolStripMenuItem";
            this.северToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.северToolStripMenuItem.Text = "север";
            this.северToolStripMenuItem.Click += new System.EventHandler(this.северToolStripMenuItem_Click);
            // 
            // северовостокToolStripMenuItem
            // 
            this.северовостокToolStripMenuItem.Name = "северовостокToolStripMenuItem";
            this.северовостокToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.северовостокToolStripMenuItem.Text = "северо-восток";
            this.северовостокToolStripMenuItem.Click += new System.EventHandler(this.северовостокToolStripMenuItem_Click);
            // 
            // востокToolStripMenuItem
            // 
            this.востокToolStripMenuItem.Name = "востокToolStripMenuItem";
            this.востокToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.востокToolStripMenuItem.Text = "восток";
            this.востокToolStripMenuItem.Click += new System.EventHandler(this.востокToolStripMenuItem_Click);
            // 
            // юговостокToolStripMenuItem
            // 
            this.юговостокToolStripMenuItem.Name = "юговостокToolStripMenuItem";
            this.юговостокToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.юговостокToolStripMenuItem.Text = "юго-восток";
            this.юговостокToolStripMenuItem.Click += new System.EventHandler(this.юговостокToolStripMenuItem_Click);
            // 
            // югToolStripMenuItem
            // 
            this.югToolStripMenuItem.Name = "югToolStripMenuItem";
            this.югToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.югToolStripMenuItem.Text = "юг";
            this.югToolStripMenuItem.Click += new System.EventHandler(this.югToolStripMenuItem_Click);
            // 
            // югозападToolStripMenuItem
            // 
            this.югозападToolStripMenuItem.Name = "югозападToolStripMenuItem";
            this.югозападToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.югозападToolStripMenuItem.Text = "юго-запад";
            this.югозападToolStripMenuItem.Click += new System.EventHandler(this.югозападToolStripMenuItem_Click);
            // 
            // западToolStripMenuItem
            // 
            this.западToolStripMenuItem.Name = "западToolStripMenuItem";
            this.западToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.западToolStripMenuItem.Text = "запад";
            this.западToolStripMenuItem.Click += new System.EventHandler(this.западToolStripMenuItem_Click);
            // 
            // северозападToolStripMenuItem
            // 
            this.северозападToolStripMenuItem.Name = "северозападToolStripMenuItem";
            this.северозападToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.северозападToolStripMenuItem.Text = "северо-запад";
            this.северозападToolStripMenuItem.Click += new System.EventHandler(this.северозападToolStripMenuItem_Click);
            // 
            // progressBarForImage
            // 
            this.progressBarForImage.Location = new System.Drawing.Point(672, 6);
            this.progressBarForImage.Name = "progressBarForImage";
            this.progressBarForImage.Size = new System.Drawing.Size(100, 24);
            this.progressBarForImage.TabIndex = 1;
            this.progressBarForImage.Visible = false;
            // 
            // labelMouseMovePos
            // 
            this.labelMouseMovePos.AutoSize = true;
            this.labelMouseMovePos.BackColor = System.Drawing.SystemColors.Menu;
            this.labelMouseMovePos.Location = new System.Drawing.Point(510, 6);
            this.labelMouseMovePos.Name = "labelMouseMovePos";
            this.labelMouseMovePos.Size = new System.Drawing.Size(0, 13);
            this.labelMouseMovePos.TabIndex = 5;
            // 
            // labelLeftMouseDownPosX
            // 
            this.labelLeftMouseDownPosX.AutoSize = true;
            this.labelLeftMouseDownPosX.BackColor = System.Drawing.SystemColors.Menu;
            this.labelLeftMouseDownPosX.Location = new System.Drawing.Point(664, 6);
            this.labelLeftMouseDownPosX.Name = "labelLeftMouseDownPosX";
            this.labelLeftMouseDownPosX.Size = new System.Drawing.Size(0, 13);
            this.labelLeftMouseDownPosX.TabIndex = 6;
            // 
            // labelLeftMouseDownPosY
            // 
            this.labelLeftMouseDownPosY.AutoSize = true;
            this.labelLeftMouseDownPosY.BackColor = System.Drawing.SystemColors.Menu;
            this.labelLeftMouseDownPosY.Location = new System.Drawing.Point(722, 6);
            this.labelLeftMouseDownPosY.Name = "labelLeftMouseDownPosY";
            this.labelLeftMouseDownPosY.Size = new System.Drawing.Size(0, 13);
            this.labelLeftMouseDownPosY.TabIndex = 7;
            // 
            // pictureBoxForDrawing
            // 
            this.pictureBoxForDrawing.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxForDrawing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxForDrawing.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxForDrawing.Location = new System.Drawing.Point(12, 40);
            this.pictureBoxForDrawing.Name = "pictureBoxForDrawing";
            this.pictureBoxForDrawing.Size = new System.Drawing.Size(760, 510);
            this.pictureBoxForDrawing.TabIndex = 8;
            this.pictureBoxForDrawing.TabStop = false;
            this.pictureBoxForDrawing.MouseLeave += new System.EventHandler(this.pictureBoxForDrawing_MouseLeave);
            this.pictureBoxForDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxForDrawing_MouseMove);
            // 
            // label_filter
            // 
            this.label_filter.AutoSize = true;
            this.label_filter.BackColor = System.Drawing.SystemColors.Menu;
            this.label_filter.ForeColor = System.Drawing.Color.Red;
            this.label_filter.Location = new System.Drawing.Point(163, 6);
            this.label_filter.Name = "label_filter";
            this.label_filter.Size = new System.Drawing.Size(75, 13);
            this.label_filter.TabIndex = 9;
            this.label_filter.Text = "Нет фильтра!";
            // 
            // скользящееСреднееToolStripMenuItem
            // 
            this.скользящееСреднееToolStripMenuItem.Name = "скользящееСреднееToolStripMenuItem";
            this.скользящееСреднееToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.скользящееСреднееToolStripMenuItem.Text = "скользящее среднее";
            this.скользящееСреднееToolStripMenuItem.Click += new System.EventHandler(this.скользящееСреднееToolStripMenuItem_Click);
            // 
            // гаусовскийФильтрToolStripMenuItem
            // 
            this.гаусовскийФильтрToolStripMenuItem.Name = "гаусовскийФильтрToolStripMenuItem";
            this.гаусовскийФильтрToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.гаусовскийФильтрToolStripMenuItem.Text = "Гауссовский фильтр";
            this.гаусовскийФильтрToolStripMenuItem.Click += new System.EventHandler(this.гаусовскийФильтрToolStripMenuItem_Click);
            // 
            // весоваяФункцияToolStripMenuItem
            // 
            this.весоваяФункцияToolStripMenuItem.Name = "весоваяФункцияToolStripMenuItem";
            this.весоваяФункцияToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.весоваяФункцияToolStripMenuItem.Text = "весовая функция";
            this.весоваяФункцияToolStripMenuItem.Click += new System.EventHandler(this.весоваяФункцияToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label_filter);
            this.Controls.Add(this.pictureBoxForDrawing);
            this.Controls.Add(this.labelLeftMouseDownPosY);
            this.Controls.Add(this.labelLeftMouseDownPosX);
            this.Controls.Add(this.labelMouseMovePos);
            this.Controls.Add(this.progressBarForImage);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Программа для линейной фильтрации изображений";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForDrawing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оброботатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборФидьтраToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarForImage;
        private System.Windows.Forms.Label labelMouseMovePos;
        private System.Windows.Forms.Label labelLeftMouseDownPosX;
        private System.Windows.Forms.Label labelLeftMouseDownPosY;
        private System.Windows.Forms.PictureBox pictureBoxForDrawing;
        private System.Windows.Forms.ToolStripMenuItem северToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem северовостокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem востокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem юговостокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem югToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem югозападToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem западToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem северозападToolStripMenuItem;
        private System.Windows.Forms.Label label_filter;
        private System.Windows.Forms.ToolStripMenuItem скользящееСреднееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гаусовскийФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весоваяФункцияToolStripMenuItem;
    }
}

