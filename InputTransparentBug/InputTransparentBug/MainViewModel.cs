namespace InputTransparentBug
{
  using System;
  using System.Collections.ObjectModel;
  using System.Linq;

  using Xamarin.Forms;

  public class MainViewModel : BindableObject
  {
    
    public MainViewModel()
    {
      TheCommand = new Command(
        () =>
          {
            Application.Current.MainPage.DisplayAlert("Some Dialog", "Button was clicked", "OK", "Cancel");
          });
    }


    private bool shouldBeTransparent;

    public bool ShouldBeTransparent
    {
      get => this.shouldBeTransparent;
      set
      {
        if (this.shouldBeTransparent != value)
        {
          this.shouldBeTransparent = value;
          this.OnPropertyChanged();
        }

      }
    }

    /**/



    public Command TheCommand { get; set; }
  }
}