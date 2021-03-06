﻿using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Animations;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;

namespace SCVMobil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupView : PopupPage
    {
        public PopupView()
        {
            InitializeComponent();           

        }

    

        private void btnCancelar_Clicked(object sender, EventArgs e) //Cerrar PopUp//
        {
            this.IsVisible = false;
        }

        private async void entrar_Clicked(object sender, EventArgs e)//Acceder al appSettings//
        {
            if (entPassword.Text == "1")
            {
                entPassword.Text = string.Empty;
                Navigation.PushAsync(new AppSettingsPage());
                this.IsVisible = false;
            }
            else
            {
                await PopupNavigation.PushAsync(new PopUpClaveIncorrecta()); //Popup para el mensaje de error para clave incorrecta//
            }
        }
    }
}