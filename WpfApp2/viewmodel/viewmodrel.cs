using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp2.model;

namespace WpfApp2.viewmodel
{
    public class Viewmodrel : INotifyPropertyChanged
    {
        private Class1 Class1 = new Class1();
        public Viewmodrel()
        {
            
            edc = new edcIcommend(a =>
            {
                Name = "嗨嗨";
                
            });
            close=new edcIcommend(a =>
            {
                
                (a as Window)?.Close();
                
            });
            nashuju=new edcIcommend(a =>
            {
                Name = Class1.sd();
            });


        }
        private string? name { get; set; } 

        public string Name
        {
            get { return name; }
            set
            {
                name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }
        
        public ICommand edc { get; set; }
        public ICommand close { get; set; }
        public ICommand nashuju { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
