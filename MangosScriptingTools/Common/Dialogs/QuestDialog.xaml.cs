﻿using System.Windows;

namespace EventIAConstructor.Common.Dialogs
{
    /// <summary>
    /// Логика взаимодействия для QuestDialog.xaml
    /// </summary>
    public partial class QuestDialog : Window, IDialog
    {
        public QuestDialog()
        {
            InitializeComponent();
        }

        int IDialog.Id { get; set; }
    }
}