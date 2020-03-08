using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Lottie.Forms;
using Reactive.Bindings;

namespace LottieSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public ReactiveProperty<bool> ButtonAnimIsPlaying { get; } = new ReactiveProperty<bool>();
        public ReactiveProperty<bool> ButtonIsVisible { get; } = new ReactiveProperty<bool>();
        public ReactiveProperty<bool> ParticleIsPlaying { get; } = new ReactiveProperty<bool>();

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            ButtonStartCommand = new DelegateCommand(ButtonStart);
            ButtonAnimFinishCommand = new DelegateCommand(ButtonAnimFinish);

            //lottie init
            var animationView = new AnimationView()
            {

            };

            ButtonIsVisible.Value = true;
            ButtonAnimIsPlaying.Value = false;
        }


        public DelegateCommand ButtonStartCommand { get; set; }
        private void ButtonStart()
        {

            ButtonAnimIsPlaying.Value = true;
        }

        public DelegateCommand ButtonAnimFinishCommand { get; set; }
        private void ButtonAnimFinish()
        {
            ButtonIsVisible.Value = false;
            ParticleIsPlaying.Value = true;

        }
    }
}
