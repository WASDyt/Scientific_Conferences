﻿using Scientific_Conferences.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Scientific_Conferences.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageCountry.xaml
    /// </summary>
    public partial class PageCountry : Page
    {
        public PageCountry()
        {
            InitializeComponent();
            dtgConference.ItemsSource = Scientific_conferencesEntities.GetContext().Conference.ToList();
        }

        public void frmMain_ContentRendered(object sender, EventArgs e)
        {

        }
    }
}
