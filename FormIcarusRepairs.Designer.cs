namespace IcarusRepairs
{
    partial class FormIcarusRepairs
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
            this.ButtonAddNewItem = new System.Windows.Forms.Button();
            this.GroupBoxServicePriority = new System.Windows.Forms.GroupBox();
            this.RadioButtonRegular = new System.Windows.Forms.RadioButton();
            this.RadioButtonExpress = new System.Windows.Forms.RadioButton();
            this.NumericUpDownServiceTag = new System.Windows.Forms.NumericUpDown();
            this.LabelServiceTag = new System.Windows.Forms.Label();
            this.TextBoxServiceProblem = new System.Windows.Forms.TextBox();
            this.LabelServiceProblem = new System.Windows.Forms.Label();
            this.LabelClientName = new System.Windows.Forms.Label();
            this.TextBoxClientName = new System.Windows.Forms.TextBox();
            this.LabelServiceCost = new System.Windows.Forms.Label();
            this.LabelDroneModel = new System.Windows.Forms.Label();
            this.TextBoxServiceCost = new System.Windows.Forms.TextBox();
            this.TextBoxDroneModel = new System.Windows.Forms.TextBox();
            this.LabelRegularListView = new System.Windows.Forms.Label();
            this.ListViewRegular = new System.Windows.Forms.ListView();
            this.LabelExpressListView = new System.Windows.Forms.Label();
            this.ListViewExpress = new System.Windows.Forms.ListView();
            this.LabelFinishedItems = new System.Windows.Forms.Label();
            this.ListBoxFinishedItems = new System.Windows.Forms.ListBox();
            this.column_RegularName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_RegularModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_RegularProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_RegularCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_RegularTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ExpressName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ExpressModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ExpressProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ExpressCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ExpressTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.GroupBoxServicePriority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownServiceTag)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAddNewItem
            // 
            this.ButtonAddNewItem.Location = new System.Drawing.Point(12, 11);
            this.ButtonAddNewItem.Name = "ButtonAddNewItem";
            this.ButtonAddNewItem.Size = new System.Drawing.Size(85, 23);
            this.ButtonAddNewItem.TabIndex = 0;
            this.ButtonAddNewItem.Text = "AddNewItem";
            this.ButtonAddNewItem.UseVisualStyleBackColor = true;
            // 
            // GroupBoxServicePriority
            // 
            this.GroupBoxServicePriority.Controls.Add(this.RadioButtonExpress);
            this.GroupBoxServicePriority.Controls.Add(this.RadioButtonRegular);
            this.GroupBoxServicePriority.Location = new System.Drawing.Point(195, 117);
            this.GroupBoxServicePriority.Name = "GroupBoxServicePriority";
            this.GroupBoxServicePriority.Size = new System.Drawing.Size(100, 79);
            this.GroupBoxServicePriority.TabIndex = 1;
            this.GroupBoxServicePriority.TabStop = false;
            this.GroupBoxServicePriority.Text = "Service Priority";
            // 
            // RadioButtonRegular
            // 
            this.RadioButtonRegular.AutoSize = true;
            this.RadioButtonRegular.Location = new System.Drawing.Point(7, 20);
            this.RadioButtonRegular.Name = "RadioButtonRegular";
            this.RadioButtonRegular.Size = new System.Drawing.Size(62, 17);
            this.RadioButtonRegular.TabIndex = 0;
            this.RadioButtonRegular.TabStop = true;
            this.RadioButtonRegular.Text = "Regular";
            this.RadioButtonRegular.UseVisualStyleBackColor = true;
            // 
            // RadioButtonExpress
            // 
            this.RadioButtonExpress.AutoSize = true;
            this.RadioButtonExpress.Location = new System.Drawing.Point(7, 56);
            this.RadioButtonExpress.Name = "RadioButtonExpress";
            this.RadioButtonExpress.Size = new System.Drawing.Size(62, 17);
            this.RadioButtonExpress.TabIndex = 1;
            this.RadioButtonExpress.TabStop = true;
            this.RadioButtonExpress.Text = "Express";
            this.RadioButtonExpress.UseVisualStyleBackColor = true;
            // 
            // NumericUpDownServiceTag
            // 
            this.NumericUpDownServiceTag.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDownServiceTag.Location = new System.Drawing.Point(15, 176);
            this.NumericUpDownServiceTag.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.NumericUpDownServiceTag.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericUpDownServiceTag.Name = "NumericUpDownServiceTag";
            this.NumericUpDownServiceTag.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownServiceTag.TabIndex = 2;
            this.NumericUpDownServiceTag.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // LabelServiceTag
            // 
            this.LabelServiceTag.AutoSize = true;
            this.LabelServiceTag.Location = new System.Drawing.Point(12, 152);
            this.LabelServiceTag.Name = "LabelServiceTag";
            this.LabelServiceTag.Size = new System.Drawing.Size(68, 13);
            this.LabelServiceTag.TabIndex = 3;
            this.LabelServiceTag.Text = "Service Tag:";
            // 
            // TextBoxServiceProblem
            // 
            this.TextBoxServiceProblem.Location = new System.Drawing.Point(12, 236);
            this.TextBoxServiceProblem.Multiline = true;
            this.TextBoxServiceProblem.Name = "TextBoxServiceProblem";
            this.TextBoxServiceProblem.Size = new System.Drawing.Size(283, 149);
            this.TextBoxServiceProblem.TabIndex = 4;
            // 
            // LabelServiceProblem
            // 
            this.LabelServiceProblem.AutoSize = true;
            this.LabelServiceProblem.Location = new System.Drawing.Point(12, 217);
            this.LabelServiceProblem.Name = "LabelServiceProblem";
            this.LabelServiceProblem.Size = new System.Drawing.Size(87, 13);
            this.LabelServiceProblem.TabIndex = 5;
            this.LabelServiceProblem.Text = "Service Problem:";
            // 
            // LabelClientName
            // 
            this.LabelClientName.AutoSize = true;
            this.LabelClientName.Location = new System.Drawing.Point(15, 50);
            this.LabelClientName.Name = "LabelClientName";
            this.LabelClientName.Size = new System.Drawing.Size(67, 13);
            this.LabelClientName.TabIndex = 6;
            this.LabelClientName.Text = "Client Name:";
            // 
            // TextBoxClientName
            // 
            this.TextBoxClientName.Location = new System.Drawing.Point(15, 72);
            this.TextBoxClientName.Name = "TextBoxClientName";
            this.TextBoxClientName.Size = new System.Drawing.Size(154, 20);
            this.TextBoxClientName.TabIndex = 7;
            // 
            // LabelServiceCost
            // 
            this.LabelServiceCost.AutoSize = true;
            this.LabelServiceCost.Location = new System.Drawing.Point(195, 50);
            this.LabelServiceCost.Name = "LabelServiceCost";
            this.LabelServiceCost.Size = new System.Drawing.Size(70, 13);
            this.LabelServiceCost.TabIndex = 8;
            this.LabelServiceCost.Text = "Service Cost:";
            // 
            // LabelDroneModel
            // 
            this.LabelDroneModel.AutoSize = true;
            this.LabelDroneModel.Location = new System.Drawing.Point(15, 101);
            this.LabelDroneModel.Name = "LabelDroneModel";
            this.LabelDroneModel.Size = new System.Drawing.Size(71, 13);
            this.LabelDroneModel.TabIndex = 9;
            this.LabelDroneModel.Text = "Drone Model:";
            // 
            // TextBoxServiceCost
            // 
            this.TextBoxServiceCost.Location = new System.Drawing.Point(195, 72);
            this.TextBoxServiceCost.Name = "TextBoxServiceCost";
            this.TextBoxServiceCost.Size = new System.Drawing.Size(100, 20);
            this.TextBoxServiceCost.TabIndex = 10;
            // 
            // TextBoxDroneModel
            // 
            this.TextBoxDroneModel.Location = new System.Drawing.Point(15, 123);
            this.TextBoxDroneModel.Name = "TextBoxDroneModel";
            this.TextBoxDroneModel.Size = new System.Drawing.Size(154, 20);
            this.TextBoxDroneModel.TabIndex = 11;
            // 
            // LabelRegularListView
            // 
            this.LabelRegularListView.AutoSize = true;
            this.LabelRegularListView.Location = new System.Drawing.Point(332, 9);
            this.LabelRegularListView.Name = "LabelRegularListView";
            this.LabelRegularListView.Size = new System.Drawing.Size(86, 13);
            this.LabelRegularListView.TabIndex = 12;
            this.LabelRegularListView.Text = "Regular Service:";
            // 
            // ListViewRegular
            // 
            this.ListViewRegular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_RegularName,
            this.column_RegularModel,
            this.column_RegularProblem,
            this.column_RegularCost,
            this.column_RegularTag});
            this.ListViewRegular.HideSelection = false;
            this.ListViewRegular.Location = new System.Drawing.Point(335, 36);
            this.ListViewRegular.Name = "ListViewRegular";
            this.ListViewRegular.Size = new System.Drawing.Size(453, 97);
            this.ListViewRegular.TabIndex = 13;
            this.ListViewRegular.UseCompatibleStateImageBehavior = false;
            this.ListViewRegular.View = System.Windows.Forms.View.Details;
            // 
            // LabelExpressListView
            // 
            this.LabelExpressListView.AutoSize = true;
            this.LabelExpressListView.Location = new System.Drawing.Point(335, 147);
            this.LabelExpressListView.Name = "LabelExpressListView";
            this.LabelExpressListView.Size = new System.Drawing.Size(86, 13);
            this.LabelExpressListView.TabIndex = 14;
            this.LabelExpressListView.Text = "Express Service:";
            // 
            // ListViewExpress
            // 
            this.ListViewExpress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_ExpressName,
            this.column_ExpressModel,
            this.column_ExpressProblem,
            this.column_ExpressCost,
            this.column_ExpressTag});
            this.ListViewExpress.HideSelection = false;
            this.ListViewExpress.Location = new System.Drawing.Point(335, 174);
            this.ListViewExpress.Name = "ListViewExpress";
            this.ListViewExpress.Size = new System.Drawing.Size(453, 97);
            this.ListViewExpress.TabIndex = 15;
            this.ListViewExpress.UseCompatibleStateImageBehavior = false;
            this.ListViewExpress.View = System.Windows.Forms.View.Details;
            // 
            // LabelFinishedItems
            // 
            this.LabelFinishedItems.AutoSize = true;
            this.LabelFinishedItems.Location = new System.Drawing.Point(335, 293);
            this.LabelFinishedItems.Name = "LabelFinishedItems";
            this.LabelFinishedItems.Size = new System.Drawing.Size(93, 13);
            this.LabelFinishedItems.TabIndex = 16;
            this.LabelFinishedItems.Text = "Service Complete:";
            // 
            // ListBoxFinishedItems
            // 
            this.ListBoxFinishedItems.FormattingEnabled = true;
            this.ListBoxFinishedItems.Location = new System.Drawing.Point(335, 320);
            this.ListBoxFinishedItems.Name = "ListBoxFinishedItems";
            this.ListBoxFinishedItems.Size = new System.Drawing.Size(453, 95);
            this.ListBoxFinishedItems.TabIndex = 17;
            // 
            // column_RegularName
            // 
            this.column_RegularName.Text = "Name:";
            this.column_RegularName.Width = 97;
            // 
            // column_RegularModel
            // 
            this.column_RegularModel.Text = "Model:";
            this.column_RegularModel.Width = 83;
            // 
            // column_RegularProblem
            // 
            this.column_RegularProblem.Text = "Problem:";
            this.column_RegularProblem.Width = 142;
            // 
            // column_RegularCost
            // 
            this.column_RegularCost.Text = "Cost:";
            this.column_RegularCost.Width = 63;
            // 
            // column_RegularTag
            // 
            this.column_RegularTag.Text = "Tag:";
            this.column_RegularTag.Width = 63;
            // 
            // column_ExpressName
            // 
            this.column_ExpressName.Text = "Name:";
            this.column_ExpressName.Width = 97;
            // 
            // column_ExpressModel
            // 
            this.column_ExpressModel.Text = "Model:";
            this.column_ExpressModel.Width = 83;
            // 
            // column_ExpressProblem
            // 
            this.column_ExpressProblem.Text = "Problem:";
            this.column_ExpressProblem.Width = 142;
            // 
            // column_ExpressCost
            // 
            this.column_ExpressCost.Text = "Cost:";
            this.column_ExpressCost.Width = 63;
            // 
            // column_ExpressTag
            // 
            this.column_ExpressTag.Text = "Tag:";
            this.column_ExpressTag.Width = 63;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Regular Complete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Express Complete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(117, 11);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 20;
            this.ButtonEdit.Text = "EditItem";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(220, 11);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 21;
            this.ButtonDelete.Text = "DeleteItem";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // FormIcarusRepairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListBoxFinishedItems);
            this.Controls.Add(this.LabelFinishedItems);
            this.Controls.Add(this.ListViewExpress);
            this.Controls.Add(this.LabelExpressListView);
            this.Controls.Add(this.ListViewRegular);
            this.Controls.Add(this.LabelRegularListView);
            this.Controls.Add(this.TextBoxDroneModel);
            this.Controls.Add(this.TextBoxServiceCost);
            this.Controls.Add(this.LabelDroneModel);
            this.Controls.Add(this.LabelServiceCost);
            this.Controls.Add(this.TextBoxClientName);
            this.Controls.Add(this.LabelClientName);
            this.Controls.Add(this.LabelServiceProblem);
            this.Controls.Add(this.TextBoxServiceProblem);
            this.Controls.Add(this.LabelServiceTag);
            this.Controls.Add(this.NumericUpDownServiceTag);
            this.Controls.Add(this.GroupBoxServicePriority);
            this.Controls.Add(this.ButtonAddNewItem);
            this.Name = "FormIcarusRepairs";
            this.Text = "Icarus Repairs";
            this.GroupBoxServicePriority.ResumeLayout(false);
            this.GroupBoxServicePriority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownServiceTag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddNewItem;
        private System.Windows.Forms.GroupBox GroupBoxServicePriority;
        private System.Windows.Forms.RadioButton RadioButtonExpress;
        private System.Windows.Forms.RadioButton RadioButtonRegular;
        private System.Windows.Forms.NumericUpDown NumericUpDownServiceTag;
        private System.Windows.Forms.Label LabelServiceTag;
        private System.Windows.Forms.TextBox TextBoxServiceProblem;
        private System.Windows.Forms.Label LabelServiceProblem;
        private System.Windows.Forms.Label LabelClientName;
        private System.Windows.Forms.TextBox TextBoxClientName;
        private System.Windows.Forms.Label LabelServiceCost;
        private System.Windows.Forms.Label LabelDroneModel;
        private System.Windows.Forms.TextBox TextBoxServiceCost;
        private System.Windows.Forms.TextBox TextBoxDroneModel;
        private System.Windows.Forms.Label LabelRegularListView;
        private System.Windows.Forms.ListView ListViewRegular;
        private System.Windows.Forms.Label LabelExpressListView;
        private System.Windows.Forms.ListView ListViewExpress;
        private System.Windows.Forms.Label LabelFinishedItems;
        private System.Windows.Forms.ListBox ListBoxFinishedItems;
        private System.Windows.Forms.ColumnHeader column_RegularName;
        private System.Windows.Forms.ColumnHeader column_RegularModel;
        private System.Windows.Forms.ColumnHeader column_RegularProblem;
        private System.Windows.Forms.ColumnHeader column_RegularCost;
        private System.Windows.Forms.ColumnHeader column_RegularTag;
        private System.Windows.Forms.ColumnHeader column_ExpressName;
        private System.Windows.Forms.ColumnHeader column_ExpressModel;
        private System.Windows.Forms.ColumnHeader column_ExpressProblem;
        private System.Windows.Forms.ColumnHeader column_ExpressCost;
        private System.Windows.Forms.ColumnHeader column_ExpressTag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDelete;
    }
}

