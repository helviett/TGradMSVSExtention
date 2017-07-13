﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Data;

namespace TGradMSVSExtention
{
  
    public partial class SettingsView : Window
    {
        public SettingsView()
        {
            InitializeComponent();
        }

        private void GeneralTemplatesTVISelected(object sender, RoutedEventArgs e)
        {
            SettingsPanel.Children.Clear();
            GeneralTemplatePanel gtp = new GeneralTemplatePanel() { };
            SettingsPanel.Children.Add(gtp);
            var OKBtnClick = OKBtn.Tag as RoutedEventHandler;
            if (OKBtnClick != null)
                OKBtn.Click -= OKBtnClick;
            OKBtn.Click += new RoutedEventHandler((sndr, rea) =>
            {
                gtp.AcceptBtnClick(sndr, rea);
                this.Close();
            });
        }

        private void CancelBtnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}