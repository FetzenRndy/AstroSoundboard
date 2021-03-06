﻿// ****************************** Module Header ****************************** //
//
//
// Last Modified: 08:05:2017 / 18:26
// Creation: 08:05:2017
// Project: AstroSoundBoard
//
//
// <copyright file="AboutView.xaml.cs" company="Patrick Hollweck" GitHub="https://github.com/FetzenRndy">//</copyright>
// *************************************************************************** //

using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace AstroSoundBoard.WPF.Pages.About
{
    public partial class AboutView : UserControl
    {
        public AboutView()
        {
            InitializeComponent();
        }

        private void OpenGitHub(object sender, RoutedEventArgs e) => Process.Start(Properties.Resources.Project_Github);

        private void ShowDiscordInfo(object sender, RoutedEventArgs e) => MessageBox.Show("Add me on discord : Fetzen.NET#9296");

        private void OpenMail(object sender, RoutedEventArgs e) => Process.Start("mailto:patrick-hollweck@gmx.de");
    }
}