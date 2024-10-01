namespace TaskReminderApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.DateTimePicker dateTimePickerReminder;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Timer timerReminder;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBoxTasks = new ListBox();
            textBoxTask = new TextBox();
            dateTimePickerReminder = new DateTimePicker();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            timerReminder = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(9, 82);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(360, 154);
            listBoxTasks.TabIndex = 0;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(12, 53);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(200, 23);
            textBoxTask.TabIndex = 1;
            // 
            // dateTimePickerReminder
            // 
            dateTimePickerReminder.CustomFormat = "dd/MM/yyyy HH:mm tt";
            dateTimePickerReminder.Format = DateTimePickerFormat.Custom;
            dateTimePickerReminder.Location = new Point(227, 53);
            dateTimePickerReminder.Name = "dateTimePickerReminder";
            dateTimePickerReminder.Size = new Size(142, 23);
            dateTimePickerReminder.TabIndex = 2;
            dateTimePickerReminder.ValueChanged += dateTimePickerReminder_ValueChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Создать";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(143, 12);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(100, 23);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Редактировать задачу";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(294, 12);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Удалить задачу";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // timerReminder
            // 
            timerReminder.Interval = 60000;
            timerReminder.Tick += timerReminder_Tick;
            // 
            // Form1
            // 
            ClientSize = new Size(389, 259);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dateTimePickerReminder);
            Controls.Add(textBoxTask);
            Controls.Add(listBoxTasks);
            Name = "Form1";
            Text = "Напоминалкоинатор 3000";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
