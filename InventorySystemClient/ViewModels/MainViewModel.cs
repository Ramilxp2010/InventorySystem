﻿using InventorySystemClient.Commands;
using InventorySystemClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace InventorySystemClient.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private Frame _mainFrame;
        public Frame MainFrame 
        {
            get => _mainFrame;
            set 
            {
                _mainFrame = value;
                OnPropertyChanged("MainFrame");
            }
        }

        public MainViewModel(Frame frame) 
        {
            _mainFrame = frame;
        }

        private RelayCommand _goToWarehouseCommand;
        public RelayCommand GoToWarehouseCommand 
        {
            get 
            {
                return _goToWarehouseCommand ??
                    (_goToWarehouseCommand = new RelayCommand(obj =>
                    {
                        MainFrame.Navigate(new WarehouseView(_mainFrame));
                    }));
            }
        }
    }
}