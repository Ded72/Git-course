namespace FileManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьСкрытыеФайлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBar = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDisckInfo = new System.Windows.Forms.ToolStripButton();
            this.comboBoxDisck = new System.Windows.Forms.ComboBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonSearchFile = new System.Windows.Forms.Button();
            this.comboBoxHistory = new System.Windows.Forms.ComboBox();
            this.imageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.listViewManager = new System.Windows.Forms.ListView();
            this.ColumnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateCreate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderExtension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBarLoad = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.папкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстовыйДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FeaturestoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSpace = new System.Windows.Forms.Label();
            this.labelCountFile = new System.Windows.Forms.Label();
            this.скрытьТулбарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStripBar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.функцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1222, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьСкрытыеФайлыToolStripMenuItem,
            this.скрытьТулбарToolStripMenuItem});
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.функцииToolStripMenuItem.Text = "Функции";
            // 
            // показатьСкрытыеФайлыToolStripMenuItem
            // 
            this.показатьСкрытыеФайлыToolStripMenuItem.Name = "показатьСкрытыеФайлыToolStripMenuItem";
            this.показатьСкрытыеФайлыToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.показатьСкрытыеФайлыToolStripMenuItem.Text = "Показать скрытые файлы";
            this.показатьСкрытыеФайлыToolStripMenuItem.Click += new System.EventHandler(this.показатьСкрытыеФайлыToolStripMenuItem_Click);
            // 
            // toolStripBar
            // 
            this.toolStripBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack,
            this.toolStripButtonRefresh,
            this.toolStripButtonCopy,
            this.toolStripButtonPaste,
            this.toolStripButtonCut,
            this.toolStripButtonDelete,
            this.toolStripButtonDisckInfo});
            this.toolStripBar.Location = new System.Drawing.Point(0, 28);
            this.toolStripBar.Name = "toolStripBar";
            this.toolStripBar.Size = new System.Drawing.Size(1222, 27);
            this.toolStripBar.TabIndex = 2;
            this.toolStripBar.Text = "toolStrip1";
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBack.Enabled = false;
            this.toolStripButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBack.Image")));
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonBack.Text = "Назад";
            this.toolStripButtonBack.Click += new System.EventHandler(this.toolStripButtonBack_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonRefresh.Text = "Обновить";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopy.Image")));
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonCopy.Text = "Копировать";
            this.toolStripButtonCopy.Click += new System.EventHandler(this.toolStripButtonCopy_Click);
            // 
            // toolStripButtonPaste
            // 
            this.toolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPaste.Image")));
            this.toolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPaste.Name = "toolStripButtonPaste";
            this.toolStripButtonPaste.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonPaste.Text = "Вставить";
            this.toolStripButtonPaste.Click += new System.EventHandler(this.toolStripButtonPaste_Click);
            // 
            // toolStripButtonCut
            // 
            this.toolStripButtonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCut.Image")));
            this.toolStripButtonCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCut.Name = "toolStripButtonCut";
            this.toolStripButtonCut.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonCut.Text = "Вырезать";
            this.toolStripButtonCut.Click += new System.EventHandler(this.toolStripButtonCut_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonDelete.Text = "Удалить";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonDisckInfo
            // 
            this.toolStripButtonDisckInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDisckInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDisckInfo.Image")));
            this.toolStripButtonDisckInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDisckInfo.Name = "toolStripButtonDisckInfo";
            this.toolStripButtonDisckInfo.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonDisckInfo.Text = "Информация о диске";
            this.toolStripButtonDisckInfo.Click += new System.EventHandler(this.toolStripButtonDisckInfo_Click);
            // 
            // comboBoxDisck
            // 
            this.comboBoxDisck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.comboBoxDisck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDisck.ForeColor = System.Drawing.Color.White;
            this.comboBoxDisck.FormattingEnabled = true;
            this.comboBoxDisck.Location = new System.Drawing.Point(11, 174);
            this.comboBoxDisck.Name = "comboBoxDisck";
            this.comboBoxDisck.Size = new System.Drawing.Size(191, 26);
            this.comboBoxDisck.TabIndex = 3;
            this.comboBoxDisck.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisck_SelectedIndexChanged);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPath.ForeColor = System.Drawing.Color.White;
            this.textBoxPath.Location = new System.Drawing.Point(12, 97);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(1198, 24);
            this.textBoxPath.TabIndex = 11;
            // 
            // buttonSearchFile
            // 
            this.buttonSearchFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.buttonSearchFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchFile.ForeColor = System.Drawing.Color.White;
            this.buttonSearchFile.Location = new System.Drawing.Point(1110, 125);
            this.buttonSearchFile.Name = "buttonSearchFile";
            this.buttonSearchFile.Size = new System.Drawing.Size(99, 31);
            this.buttonSearchFile.TabIndex = 13;
            this.buttonSearchFile.Text = "Поиск";
            this.buttonSearchFile.UseVisualStyleBackColor = false;
            this.buttonSearchFile.Click += new System.EventHandler(this.buttonSearchFile_Click);
            // 
            // comboBoxHistory
            // 
            this.comboBoxHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.comboBoxHistory.DropDownHeight = 60;
            this.comboBoxHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxHistory.ForeColor = System.Drawing.Color.White;
            this.comboBoxHistory.FormattingEnabled = true;
            this.comboBoxHistory.IntegralHeight = false;
            this.comboBoxHistory.Location = new System.Drawing.Point(621, 174);
            this.comboBoxHistory.Name = "comboBoxHistory";
            this.comboBoxHistory.Size = new System.Drawing.Size(588, 26);
            this.comboBoxHistory.TabIndex = 17;
            this.comboBoxHistory.SelectedIndexChanged += new System.EventHandler(this.comboBoxHistory_SelectedIndexChanged);
            // 
            // imageListIcon
            // 
            this.imageListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcon.ImageStream")));
            this.imageListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcon.Images.SetKeyName(0, "file.bmp");
            // 
            // listViewManager
            // 
            this.listViewManager.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.listViewManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderName,
            this.columnHeaderDateCreate,
            this.columnHeaderExtension});
            this.listViewManager.ForeColor = System.Drawing.Color.White;
            this.listViewManager.HideSelection = false;
            this.listViewManager.Location = new System.Drawing.Point(12, 204);
            this.listViewManager.Name = "listViewManager";
            this.listViewManager.Size = new System.Drawing.Size(1198, 425);
            this.listViewManager.SmallImageList = this.imageListIcon;
            this.listViewManager.TabIndex = 18;
            this.listViewManager.UseCompatibleStateImageBehavior = false;
            this.listViewManager.View = System.Windows.Forms.View.Details;
            this.listViewManager.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewManager_ColumnClick);
            this.listViewManager.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewManager_MouseDoubleClick);
            // 
            // ColumnHeaderName
            // 
            this.ColumnHeaderName.Text = "Имя файла";
            this.ColumnHeaderName.Width = 260;
            // 
            // columnHeaderDateCreate
            // 
            this.columnHeaderDateCreate.Text = "Дата создания";
            this.columnHeaderDateCreate.Width = 300;
            // 
            // columnHeaderExtension
            // 
            this.columnHeaderExtension.Text = "Расширение";
            this.columnHeaderExtension.Width = 108;
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.progressBarLoad.Location = new System.Drawing.Point(13, 68);
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(1197, 23);
            this.progressBarLoad.TabIndex = 20;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.cutToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.createToolStripMenuItem1,
            this.FeaturestoolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 172);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.reloadToolStripMenuItem.Text = "Обновить";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.copyToolStripMenuItem1.Text = "Копировать";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.pasteToolStripMenuItem1.Text = "Вставить";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.cutToolStripMenuItem1.Text = "Вырезать";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.cutToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.deleteToolStripMenuItem1.Text = "Удалить";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.папкуToolStripMenuItem,
            this.документWordToolStripMenuItem,
            this.текстовыйДокументToolStripMenuItem});
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.createToolStripMenuItem1.Text = "Создать";
            // 
            // папкуToolStripMenuItem
            // 
            this.папкуToolStripMenuItem.Name = "папкуToolStripMenuItem";
            this.папкуToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.папкуToolStripMenuItem.Text = "Папку";
            this.папкуToolStripMenuItem.Click += new System.EventHandler(this.папкуToolStripMenuItem_Click);
            // 
            // документWordToolStripMenuItem
            // 
            this.документWordToolStripMenuItem.Name = "документWordToolStripMenuItem";
            this.документWordToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.документWordToolStripMenuItem.Text = "Документ Word";
            this.документWordToolStripMenuItem.Click += new System.EventHandler(this.документWordToolStripMenuItem_Click);
            // 
            // текстовыйДокументToolStripMenuItem
            // 
            this.текстовыйДокументToolStripMenuItem.Name = "текстовыйДокументToolStripMenuItem";
            this.текстовыйДокументToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.текстовыйДокументToolStripMenuItem.Text = "Текстовый документ";
            this.текстовыйДокументToolStripMenuItem.Click += new System.EventHandler(this.текстовыйДокументToolStripMenuItem_Click);
            // 
            // FeaturestoolStripMenuItem1
            // 
            this.FeaturestoolStripMenuItem1.Name = "FeaturestoolStripMenuItem1";
            this.FeaturestoolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.FeaturestoolStripMenuItem1.Text = "Свойства";
            this.FeaturestoolStripMenuItem1.Click += new System.EventHandler(this.FeaturestoolStripMenuItem1_Click);
            // 
            // labelSpace
            // 
            this.labelSpace.AutoSize = true;
            this.labelSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpace.ForeColor = System.Drawing.Color.White;
            this.labelSpace.Location = new System.Drawing.Point(278, 182);
            this.labelSpace.Name = "labelSpace";
            this.labelSpace.Size = new System.Drawing.Size(210, 20);
            this.labelSpace.TabIndex = 21;
            this.labelSpace.Text = "Пространство на диске";
            // 
            // labelCountFile
            // 
            this.labelCountFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCountFile.AutoSize = true;
            this.labelCountFile.ForeColor = System.Drawing.Color.White;
            this.labelCountFile.Location = new System.Drawing.Point(12, 648);
            this.labelCountFile.Name = "labelCountFile";
            this.labelCountFile.Size = new System.Drawing.Size(139, 16);
            this.labelCountFile.TabIndex = 22;
            this.labelCountFile.Text = "Количество файлов";
            // 
            // скрытьТулбарToolStripMenuItem
            // 
            this.скрытьТулбарToolStripMenuItem.Name = "скрытьТулбарToolStripMenuItem";
            this.скрытьТулбарToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.скрытьТулбарToolStripMenuItem.Text = "Скрыть тулбар";
            this.скрытьТулбарToolStripMenuItem.Click += new System.EventHandler(this.скрытьТулбарToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1222, 673);
            this.Controls.Add(this.labelCountFile);
            this.Controls.Add(this.labelSpace);
            this.Controls.Add(this.progressBarLoad);
            this.Controls.Add(this.listViewManager);
            this.Controls.Add(this.comboBoxHistory);
            this.Controls.Add(this.buttonSearchFile);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.comboBoxDisck);
            this.Controls.Add(this.toolStripBar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Файловый Менеджер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripBar.ResumeLayout(false);
            this.toolStripBar.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        protected System.Windows.Forms.ToolStrip toolStripBar;
        protected System.Windows.Forms.ComboBox comboBoxDisck;
        public System.Windows.Forms.TextBox textBoxPath;
        protected System.Windows.Forms.Button buttonSearchFile;
        protected System.Windows.Forms.ComboBox comboBoxHistory;
        public System.Windows.Forms.ImageList imageListIcon;
        public System.Windows.Forms.ListView listViewManager;
        protected System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        protected System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        protected System.Windows.Forms.ToolStripButton toolStripButtonPaste;
        protected System.Windows.Forms.ToolStripButton toolStripButtonCut;
        protected System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        public System.Windows.Forms.ProgressBar progressBarLoad;
        protected System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        protected System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        protected System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        protected System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        protected System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        protected System.Windows.Forms.Label labelSpace;
        public System.Windows.Forms.ToolStripButton toolStripButtonBack;
        public System.Windows.Forms.Label labelCountFile;
        protected System.Windows.Forms.ToolStripButton toolStripButtonDisckInfo;
        protected System.Windows.Forms.ToolStripMenuItem FeaturestoolStripMenuItem1;
        protected System.Windows.Forms.ToolStripMenuItem показатьСкрытыеФайлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem папкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстовыйДокументToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader ColumnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDateCreate;
        private System.Windows.Forms.ColumnHeader columnHeaderExtension;
        private System.Windows.Forms.ToolStripMenuItem скрытьТулбарToolStripMenuItem;
    }
}

