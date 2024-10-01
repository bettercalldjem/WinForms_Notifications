using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskReminderApp
{
    public partial class Form1 : Form
    {
        private List<TaskItem> tasks = new List<TaskItem>();

        public Form1()
        {
            InitializeComponent();
            timerReminder.Start();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string taskDescription = textBoxTask.Text;
            DateTime reminderTime = dateTimePickerReminder.Value;

            if (!string.IsNullOrEmpty(taskDescription))
            {
                TaskItem newTask = new TaskItem(taskDescription, reminderTime);
                tasks.Add(newTask);
                UpdateTaskList();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                TaskItem selectedTask = tasks[listBoxTasks.SelectedIndex];
                selectedTask.Description = textBoxTask.Text;
                selectedTask.ReminderTime = dateTimePickerReminder.Value;
                UpdateTaskList();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                tasks.RemoveAt(listBoxTasks.SelectedIndex);
                UpdateTaskList();
            }
        }

        private void UpdateTaskList()
        {
            listBoxTasks.Items.Clear();
            foreach (TaskItem task in tasks)
            {
                listBoxTasks.Items.Add($"{task.Description} - {task.ReminderTime:dd/MM/yyyy HH:mm tt}");
            }
        }

        private void timerReminder_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            foreach (TaskItem task in tasks)
            {
                if (task.ReminderTime <= now && !task.Reminded)
                {
                    MessageBox.Show($"Напоминание: {task.Description}", "Напоминание о задаче", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    task.Reminded = true;
                }
            }
        }

        private void dateTimePickerReminder_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    public class TaskItem
    {
        public string Description { get; set; }
        public DateTime ReminderTime { get; set; }
        public bool Reminded { get; set; }

        public TaskItem(string description, DateTime reminderTime)
        {
            Description = description;
            ReminderTime = reminderTime;
            Reminded = false;
        }
    }
}
